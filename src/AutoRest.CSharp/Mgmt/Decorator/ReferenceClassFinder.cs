﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using AutoRest.CSharp.Mgmt.AutoRest;
using AutoRest.CSharp.Output.Models.Responses;
using AutoRest.CSharp.Output.Models.Types;
using AutoRest.CSharp.Utilities;
using Azure;
using Azure.ResourceManager;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace AutoRest.CSharp.Mgmt.Decorator
{
    public class ReferenceClassFinder
    {
        internal const string InitializationCtorAttribute = "InitializationConstructor";
        internal const string SerializationCtorAttribute = "SerializationConstructor";
        internal const string ReferenceTypeAttribute = "ReferenceType";

        internal const string InitializationCtorAttributeName = "InitializationConstructorAttribute";
        internal const string SerializationCtorAttributeName = "SerializationConstructorAttribute";
        internal const string ReferenceTypeAttributeName = "ReferenceTypeAttribute";

        public record PropertyMetadata(string SerializedName, bool Required)
        {
            public PropertyMetadata(string serializedName) : this(serializedName, false)
            {
            }
        }

        private static readonly Dictionary<Type, Dictionary<string, PropertyMetadata>> _referenceTypesPropertyMetadata = new()
        {
            [typeof(ResourceData)] = new()
            {
                ["Id"] = new PropertyMetadata("id", true),
                ["Name"] = new PropertyMetadata("name", true),
                ["ResourceType"] = new PropertyMetadata("type", true),
                ["SystemData"] = new PropertyMetadata("systemData", false),
            },
            [typeof(TrackedResourceData)] = new()
            {
                ["Location"] = new PropertyMetadata("location", true),
                ["Tags"] = new PropertyMetadata("tags"),
            },
            [typeof(ManagedServiceIdentity)] = new()
            {
                ["PrincipalId"] = new PropertyMetadata("principalId"),
                ["TenantId"] = new PropertyMetadata("tenantId"),
                ["ManagedServiceIdentityType"] = new PropertyMetadata("type", true),
                ["UserAssignedIdentities"] = new PropertyMetadata("userAssignedIdentities"),
            },
            [typeof(SystemAssignedServiceIdentity)] = new()
            {
                ["PrincipalId"] = new PropertyMetadata("principalId"),
                ["TenantId"] = new PropertyMetadata("tenantId"),
                ["SystemAssignedServiceIdentityType"] = new PropertyMetadata("type", true),
            },
        };

        public static Dictionary<string, PropertyMetadata> GetPropertyMetadata(Type systemObjectType)
        {
            if (_referenceTypesPropertyMetadata.TryGetValue(systemObjectType, out var dict))
                return dict;
            dict = ConstructPropertyMetadata(systemObjectType);
            _referenceTypesPropertyMetadata.Add(systemObjectType, dict);
            return dict;
        }

        private static Dictionary<string, PropertyMetadata> ConstructPropertyMetadata(Type type)
        {
            var dict = new Dictionary<string, PropertyMetadata>();
            var publicCtor = type.GetConstructors().Where(c => c.IsPublic).OrderBy(c => c.GetParameters().Count()).FirstOrDefault();
            if (publicCtor == null)
                throw new InvalidOperationException($"Property metadata information for type {type} cannot be constructed automatically because it does not have a public constructor");
            foreach (var property in type.GetProperties().Where(p => p.DeclaringType == type))
            {
                var metadata = new PropertyMetadata(property.Name.ToVariableName(), GetRequired(publicCtor, property));
                dict.Add(property.Name, metadata);
            }
            return dict;
        }

        private static bool GetRequired(ConstructorInfo publicCtor, PropertyInfo property)
            => publicCtor.GetParameters().Any(param => param.Name?.Equals(property.Name, StringComparison.OrdinalIgnoreCase) == true && param.GetType() == property.GetType());

        private static IList<Type>? _externalTypes;
        private static IList<Type>? _referenceTypes;

        internal class Node
        {
            public Type Type { get; }
            public List<Node> Children { get; }

            public Node(Type type)
            {
                Type = type;
                Children = new List<Node>();
            }
        }

        /// <summary>
        /// All external types, right now they are all defined in <c>ResourceManager</c>
        /// See: https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/resourcemanager/Azure.ResourceManager/src
        /// </summary>
        internal static IList<Type> ExternalTypes => _externalTypes ??= GetExternalTypes();
        internal static IList<Type> GetReferenceClassCollection() => _referenceTypes ??= GetOrderedList(GetReferenceClassCollectionInternal());

        private static IList<Type> GetExternalTypes()
        {
            var assembly = Assembly.GetAssembly(typeof(ArmClient));
            List<Type> types = new List<Type>();
            if (assembly != null)
                types.AddRange(assembly.GetTypes());

            assembly = Assembly.GetAssembly(typeof(Operation));
            if (assembly != null)
                types.AddRange(assembly.GetTypes());

            return types;
        }

        private static IList<Type> GetReferenceClassCollectionInternal()
        {
            return ExternalTypes.Where(t =>
                !t.Name.Equals("Resource") && //temp while we have both Resource and ResourceData
                !t.Name.Equals("TrackedResource") && //temp while we have both TrackedResource and TrackedResourceData
                t.GetCustomAttributes(false).Where(a => a.GetType().Name == ReferenceTypeAttributeName).Count() > 0).ToList();
        }

        internal static List<Type> GetOrderedList(IList<Type> referenceTypes)
        {
            var rootNodes = GetRootNodes(referenceTypes);
            rootNodes.Sort((a, b) => a.Type.GetProperties(BindingFlags.Instance | BindingFlags.Public).Length.CompareTo(b.Type.GetProperties(BindingFlags.Instance | BindingFlags.Public).Length) * -1);
            var output = new List<Type>();
            foreach (var root in rootNodes)
            {
                var treeNodes = new List<Type>();
                Queue<Node> queue = new Queue<Node>();
                queue.Enqueue(root);
                while (queue.Count != 0)
                {
                    Node tempNode = queue.Dequeue();
                    treeNodes.Add(tempNode.Type);
                    List<Node> tempChilren = tempNode.Children;
                    if (tempChilren != null)
                    {
                        int childNum = tempChilren.Count;
                        while (childNum > 0)
                        {
                            queue.Enqueue(tempChilren[childNum - 1]);
                            childNum--;
                        }
                    }
                }
                treeNodes.Reverse();
                output.AddRange(PromoteGenericType(treeNodes));
            }
            return output;
        }

        private static List<Type> PromoteGenericType(List<Type> output)
        {
            bool swapped = false;
            for (int i = 0; i < output.Count; i++)
            {
                if (output[i].IsGenericType)
                {
                    // since we need to ensure the base generic type is before
                    // any other inheritors we just need to search behind
                    for (int j = i - 1; j > -1; j--)
                    {
                        if (output[j].IsGenericType == false
                            && output[j].BaseType == output[i])
                        {

                            System.Type temp = output[j];
                            output[j] = output[i];
                            output[i] = temp;
                            swapped = true;
                        }
                    }
                }
            }
            if (swapped)
                return PromoteGenericType(output);

            return output;
        }

        internal static List<Node> GetRootNodes(IList<Type> referenceClassCollection)
        {
            List<Node> rootNodes = new List<Node>();
            var added = new Dictionary<Type, Node>();
            var rootHash = new Dictionary<Type, List<Node>>();
            foreach (System.Type reference in referenceClassCollection)
            {
                if (!added.ContainsKey(reference))
                {
                    Node node = new Node(reference);
                    System.Type baseType = reference.BaseType ?? typeof(object);
                    if (baseType != typeof(object) && added.ContainsKey(baseType))
                    {
                        added[baseType].Children.Add(node);
                    }
                    else
                    {
                        if (rootHash.ContainsKey(node.Type))
                        {
                            foreach (var child in rootHash[node.Type])
                            {
                                node.Children.Add(child);
                                rootNodes.Remove(child);
                            }
                            rootHash.Remove(baseType);
                        }
                        else
                        {
                            if (baseType != typeof(object))
                            {
                                List<Node>? list;
                                if (!rootHash.TryGetValue(baseType, out list))
                                {
                                    list = new List<Node>();
                                    rootHash.Add(baseType, list);
                                }
                                list.Add(node);
                            }
                        }
                        rootNodes.Add(node);
                    }
                    added.Add(reference, node);
                }
            }
            return rootNodes;
        }
    }
}
