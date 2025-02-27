// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Rendering
{
    internal partial class MapAttribution
    {
        internal static MapAttribution DeserializeMapAttribution(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<string> copyrights = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("copyrights"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    copyrights = array;
                    continue;
                }
            }
            return new MapAttribution(copyrights ?? new ChangeTrackingList<string>());
        }
    }
}
