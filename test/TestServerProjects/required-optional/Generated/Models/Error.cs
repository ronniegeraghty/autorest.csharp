// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Required_Optional.Models
{
    /// <summary> The Error. </summary>
    internal partial class Error
    {
        /// <summary> Initializes a new instance of Error. </summary>
        internal Error()
        {
        }

        /// <summary> Initializes a new instance of Error. </summary>
        /// <param name="status"></param>
        /// <param name="message"></param>
        internal Error(int? status, string message)
        {
            Status = status;
            Message = message;
        }

        /// <summary> Gets the status. </summary>
        public int? Status { get; }
        /// <summary> Gets the message. </summary>
        public string Message { get; }
    }
}
