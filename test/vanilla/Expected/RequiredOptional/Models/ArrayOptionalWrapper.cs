// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Fixtures.RequiredOptional.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ArrayOptionalWrapper
    {
        /// <summary>
        /// Initializes a new instance of the ArrayOptionalWrapper class.
        /// </summary>
        public ArrayOptionalWrapper()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ArrayOptionalWrapper class.
        /// </summary>
        public ArrayOptionalWrapper(IList<string> value = default(IList<string>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<string> Value { get; set; }

    }
}