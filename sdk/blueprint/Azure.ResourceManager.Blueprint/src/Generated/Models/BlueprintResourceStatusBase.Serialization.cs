// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Blueprint.Models
{
    public partial class BlueprintResourceStatusBase : IUtf8JsonSerializable, IJsonModel<BlueprintResourceStatusBase>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BlueprintResourceStatusBase>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BlueprintResourceStatusBase>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BlueprintResourceStatusBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BlueprintResourceStatusBase)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && TimeCreated.HasValue)
            {
                writer.WritePropertyName("timeCreated"u8);
                writer.WriteStringValue(TimeCreated.Value, "O");
            }
            if (options.Format != "W" && LastModified.HasValue)
            {
                writer.WritePropertyName("lastModified"u8);
                writer.WriteStringValue(LastModified.Value, "O");
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        BlueprintResourceStatusBase IJsonModel<BlueprintResourceStatusBase>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BlueprintResourceStatusBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BlueprintResourceStatusBase)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBlueprintResourceStatusBase(document.RootElement, options);
        }

        internal static BlueprintResourceStatusBase DeserializeBlueprintResourceStatusBase(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? timeCreated = default;
            DateTimeOffset? lastModified = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timeCreated"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeCreated = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastModified"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastModified = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BlueprintResourceStatusBase(timeCreated, lastModified, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BlueprintResourceStatusBase>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BlueprintResourceStatusBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BlueprintResourceStatusBase)} does not support '{options.Format}' format.");
            }
        }

        BlueprintResourceStatusBase IPersistableModel<BlueprintResourceStatusBase>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BlueprintResourceStatusBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBlueprintResourceStatusBase(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BlueprintResourceStatusBase)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BlueprintResourceStatusBase>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
