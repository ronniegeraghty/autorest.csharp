// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources.Models;

namespace ExactMatchFlattenInheritance
{
    /// <summary> A class representing the AzureResourceFlattenModel2 data model. </summary>
    public partial class AzureResourceFlattenModel2Data : TrackedResource
    {
        /// <summary> Initializes a new instance of AzureResourceFlattenModel2Data. </summary>
        /// <param name="location"> The location. </param>
        public AzureResourceFlattenModel2Data(Location location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of AzureResourceFlattenModel2Data. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="location"> The location. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="foo"> New property. </param>
        internal AzureResourceFlattenModel2Data(ResourceIdentifier id, string name, ResourceType type, Location location, IDictionary<string, string> tags, int? foo) : base(id, name, type, location, tags)
        {
            Foo = foo;
        }

        /// <summary> New property. </summary>
        public int? Foo { get; set; }
    }
}
