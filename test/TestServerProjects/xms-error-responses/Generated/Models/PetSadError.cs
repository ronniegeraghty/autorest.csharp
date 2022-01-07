// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Xms_Error_Responses.Models
{
    /// <summary> The PetSadError. </summary>
    public partial class PetSadError : PetActionError
    {
        /// <summary> Initializes a new instance of PetSadError. </summary>
        internal PetSadError()
        {
            ErrorType = "PetSadError";
        }

        /// <summary> Initializes a new instance of PetSadError. </summary>
        /// <param name="actionResponse"> action feedback. </param>
        /// <param name="errorType"></param>
        /// <param name="errorMessage"> the error message. </param>
        /// <param name="reason"> why is the pet sad. </param>
        internal PetSadError(string actionResponse, string errorType, string errorMessage, string reason) : base(actionResponse, errorType, errorMessage)
        {
            Reason = reason;
            ErrorType = errorType ?? "PetSadError";
        }

        /// <summary> why is the pet sad. </summary>
        public string Reason { get; }
    }
}
