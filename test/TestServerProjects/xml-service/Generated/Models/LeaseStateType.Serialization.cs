// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Xml_Service.Models
{
    internal static partial class LeaseStateTypeExtensions
    {
        public static string ToSerialString(this LeaseStateType value) => value switch
        {
            LeaseStateType.Available => "available",
            LeaseStateType.Leased => "leased",
            LeaseStateType.Expired => "expired",
            LeaseStateType.Breaking => "breaking",
            LeaseStateType.Broken => "broken",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown LeaseStateType value.")
        };

        public static LeaseStateType ToLeaseStateType(this string value)
        {
            if (string.Equals(value, "available", StringComparison.InvariantCultureIgnoreCase)) return LeaseStateType.Available;
            if (string.Equals(value, "leased", StringComparison.InvariantCultureIgnoreCase)) return LeaseStateType.Leased;
            if (string.Equals(value, "expired", StringComparison.InvariantCultureIgnoreCase)) return LeaseStateType.Expired;
            if (string.Equals(value, "breaking", StringComparison.InvariantCultureIgnoreCase)) return LeaseStateType.Breaking;
            if (string.Equals(value, "broken", StringComparison.InvariantCultureIgnoreCase)) return LeaseStateType.Broken;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown LeaseStateType value.");
        }
    }
}
