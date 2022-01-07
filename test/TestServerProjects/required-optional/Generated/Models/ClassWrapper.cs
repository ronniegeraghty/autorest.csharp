// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Required_Optional.Models
{
    /// <summary> The ClassWrapper. </summary>
    public partial class ClassWrapper
    {
        /// <summary> Initializes a new instance of ClassWrapper. </summary>
        /// <param name="value"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ClassWrapper(Product value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value;
        }

        /// <summary> Gets the value. </summary>
        public Product Value { get; }
    }
}
