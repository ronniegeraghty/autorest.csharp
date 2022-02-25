// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace MgmtSignalR.Models
{
    public partial class SignalRUsageName
    {
        internal static SignalRUsageName DeserializeSignalRUsageName(JsonElement element)
        {
            Optional<string> value = default;
            Optional<string> localizedValue = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("localizedValue"))
                {
                    localizedValue = property.Value.GetString();
                    continue;
                }
            }
            return new SignalRUsageName(value.Value, localizedValue.Value);
        }
    }
}