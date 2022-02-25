// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace MgmtListMethods.Models
{
    /// <summary> Quota update parameters. </summary>
    public partial class QuotaUpdateContent
    {
        /// <summary> Initializes a new instance of QuotaUpdateContent. </summary>
        public QuotaUpdateContent()
        {
            Value = new ChangeTrackingList<QuotaBaseProperties>();
        }

        /// <summary> The list for update quota. </summary>
        public IList<QuotaBaseProperties> Value { get; }
        /// <summary> Region of workspace quota to be updated. </summary>
        public string Location { get; set; }
    }
}