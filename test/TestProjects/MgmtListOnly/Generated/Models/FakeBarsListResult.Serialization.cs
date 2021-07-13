// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace MgmtListOnly.Models
{
    internal partial class FakeBarsListResult
    {
        internal static FakeBarsListResult DeserializeFakeBarsListResult(JsonElement element)
        {
            IReadOnlyList<FakeBar> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<FakeBar> array = new List<FakeBar>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FakeBar.DeserializeFakeBar(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new FakeBarsListResult(value, nextLink.Value);
        }
    }
}