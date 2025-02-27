// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.MixedReality.RemoteRendering
{
    public partial class AssetConversionOutput
    {
        internal static AssetConversionOutput DeserializeAssetConversionOutput(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string outputAssetUri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("outputAssetUri"u8))
                {
                    outputAssetUri = property.Value.GetString();
                    continue;
                }
            }
            return new AssetConversionOutput(outputAssetUri);
        }
    }
}
