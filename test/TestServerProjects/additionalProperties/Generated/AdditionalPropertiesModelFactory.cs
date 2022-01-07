// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace AdditionalProperties.Models
{
    /// <summary> Model factory for read-only models. </summary>
    public static partial class AdditionalPropertiesModelFactory
    {
        /// <summary> Initializes a new instance of PetAPTrue. </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="status"></param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <returns> A new <see cref="Models.PetAPTrue"/> instance for mocking. </returns>
        public static PetAPTrue PetAPTrue(int id = default, string name = null, bool? status = null, IDictionary<string, object> additionalProperties = null)
        {
            additionalProperties ??= new Dictionary<string, object>();

            return new PetAPTrue(id, name, status, additionalProperties);
        }

        /// <summary> Initializes a new instance of PetAPObject. </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="status"></param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <returns> A new <see cref="Models.PetAPObject"/> instance for mocking. </returns>
        public static PetAPObject PetAPObject(int id = default, string name = null, bool? status = null, IDictionary<string, object> additionalProperties = null)
        {
            additionalProperties ??= new Dictionary<string, object>();

            return new PetAPObject(id, name, status, additionalProperties);
        }

        /// <summary> Initializes a new instance of PetAPString. </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="status"></param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <returns> A new <see cref="Models.PetAPString"/> instance for mocking. </returns>
        public static PetAPString PetAPString(int id = default, string name = null, bool? status = null, IDictionary<string, string> additionalProperties = null)
        {
            additionalProperties ??= new Dictionary<string, string>();

            return new PetAPString(id, name, status, additionalProperties);
        }

        /// <summary> Initializes a new instance of PetAPInProperties. </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="status"></param>
        /// <param name="additionalProperties"> Dictionary of &lt;number&gt;. </param>
        /// <returns> A new <see cref="Models.PetAPInProperties"/> instance for mocking. </returns>
        public static PetAPInProperties PetAPInProperties(int id = default, string name = null, bool? status = null, IDictionary<string, float> additionalProperties = null)
        {
            additionalProperties ??= new Dictionary<string, float>();

            return new PetAPInProperties(id, name, status, additionalProperties);
        }
    }
}
