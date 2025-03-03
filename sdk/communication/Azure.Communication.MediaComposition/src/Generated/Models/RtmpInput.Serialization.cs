// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Communication.MediaComposition.Models;
using Azure.Core;

namespace Azure.Communication.MediaComposition
{
    public partial class RtmpInput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("streamKey"u8);
            writer.WriteStringValue(StreamKey);
            writer.WritePropertyName("resolution"u8);
            writer.WriteObjectValue(Resolution);
            writer.WritePropertyName("streamUrl"u8);
            writer.WriteStringValue(StreamUrl);
            if (Mode.HasValue)
            {
                writer.WritePropertyName("mode"u8);
                writer.WriteStringValue(Mode.Value.ToString());
            }
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (PlaceholderImageUri != null)
            {
                writer.WritePropertyName("placeholderImageUri"u8);
                writer.WriteStringValue(PlaceholderImageUri);
            }
            writer.WriteEndObject();
        }

        internal static RtmpInput DeserializeRtmpInput(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string streamKey = default;
            LayoutResolution resolution = default;
            string streamUrl = default;
            RtmpMode? mode = default;
            MediaInputType kind = default;
            string placeholderImageUri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("streamKey"u8))
                {
                    streamKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resolution"u8))
                {
                    resolution = LayoutResolution.DeserializeLayoutResolution(property.Value);
                    continue;
                }
                if (property.NameEquals("streamUrl"u8))
                {
                    streamUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mode = new RtmpMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new MediaInputType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("placeholderImageUri"u8))
                {
                    placeholderImageUri = property.Value.GetString();
                    continue;
                }
            }
            return new RtmpInput(
                kind,
                placeholderImageUri,
                streamKey,
                resolution,
                streamUrl,
                mode);
        }
    }
}
