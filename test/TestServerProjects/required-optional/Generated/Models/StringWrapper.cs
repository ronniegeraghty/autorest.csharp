// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Required_Optional.Models
{
    /// <summary> The StringWrapper. </summary>
    public partial class StringWrapper
    {
        /// <summary> Initializes a new instance of StringWrapper. </summary>
        /// <param name="value"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public StringWrapper(string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value;
        }

        /// <summary> Gets the value. </summary>
        public string Value { get; }
    }
}
