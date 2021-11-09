// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace NoTypeReplacement.Models
{
    /// <summary> The MiddleResourceModel. </summary>
    public partial class MiddleResourceModel
    {
        /// <summary> Initializes a new instance of MiddleResourceModel. </summary>
        public MiddleResourceModel()
        {
        }

        /// <summary> Initializes a new instance of MiddleResourceModel. </summary>
        /// <param name="foo"></param>
        internal MiddleResourceModel(NoSubResourceModel2 foo)
        {
            Foo = foo;
        }

        /// <summary> Gets or sets the foo. </summary>
        public NoSubResourceModel2 Foo { get; set; }
    }
}