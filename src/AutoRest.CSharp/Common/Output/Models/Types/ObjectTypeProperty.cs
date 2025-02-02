﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Diagnostics.CodeAnalysis;
using System.Linq;
using AutoRest.CSharp.Generation.Types;
using AutoRest.CSharp.Input;

namespace AutoRest.CSharp.Output.Models.Types
{
    internal class ObjectTypeProperty
    {
        public ObjectTypeProperty(MemberDeclarationOptions declaration, string description, bool isReadOnly, Property? schemaProperty, CSharpType? valueType = null, bool optionalViaNullability = false)
        {
            Description = description;
            IsReadOnly = isReadOnly;
            SchemaProperty = schemaProperty;
            OptionalViaNullability = optionalViaNullability;
            ValueType = valueType ?? declaration.Type;
            Declaration = declaration;
        }

        public MemberDeclarationOptions Declaration { get; }
        public string Description { get; }
        public Property? SchemaProperty { get; }

        /// <summary>
        /// Gets or sets the value indicating whether nullable type of this property represents optionality of the value.
        /// </summary>
        public bool OptionalViaNullability { get; }

        /// <summary>
        /// When property is not required we transform the type to be able to express "omitted" value.
        /// For example we turn int type into int?.
        /// ValueType property contains the original type the property had before the transformation was applied to it.
        /// </summary>
        public CSharpType ValueType { get; }
        public bool IsReadOnly { get; }

        private bool IsDiscriminator() => SchemaProperty?.IsDiscriminator is true;
        public bool IsSinglePropertyObject([MaybeNullWhen(false)] out ObjectTypeProperty innerProperty)
        {
            innerProperty = null;

            if (this.ValueType.IsFrameworkType)
                return false;

            if (this.ValueType.Implementation is not ObjectType objType)
                return false;

            var properties = objType.EnumerateHierarchy().SelectMany(obj => obj.Properties);
            bool isSingleProperty = properties.Count() == 1 && !properties.First().IsDiscriminator();

            if (isSingleProperty)
                innerProperty = properties.First();

            return isSingleProperty;
        }
    }
}
