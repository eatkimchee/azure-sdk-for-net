// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class DataMapperMapping : IUtf8JsonSerializable, IJsonModel<DataMapperMapping>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataMapperMapping>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataMapperMapping>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataMapperMapping>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataMapperMapping)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (TargetEntityName != null)
            {
                writer.WritePropertyName("targetEntityName"u8);
                writer.WriteStringValue(TargetEntityName);
            }
            if (SourceEntityName != null)
            {
                writer.WritePropertyName("sourceEntityName"u8);
                writer.WriteStringValue(SourceEntityName);
            }
            if (SourceConnectionReference != null)
            {
                writer.WritePropertyName("sourceConnectionReference"u8);
                writer.WriteObjectValue(SourceConnectionReference);
            }
            if (AttributeMappingInfo != null)
            {
                writer.WritePropertyName("attributeMappingInfo"u8);
                writer.WriteObjectValue(AttributeMappingInfo);
            }
            if (SourceDenormalizeInfo != null)
            {
                writer.WritePropertyName("sourceDenormalizeInfo"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(SourceDenormalizeInfo);
#else
                using (JsonDocument document = JsonDocument.Parse(SourceDenormalizeInfo))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
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

        DataMapperMapping IJsonModel<DataMapperMapping>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataMapperMapping>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataMapperMapping)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataMapperMapping(document.RootElement, options);
        }

        internal static DataMapperMapping DeserializeDataMapperMapping(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string targetEntityName = default;
            string sourceEntityName = default;
            MapperConnectionReference sourceConnectionReference = default;
            MapperAttributeMappings attributeMappingInfo = default;
            BinaryData sourceDenormalizeInfo = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targetEntityName"u8))
                {
                    targetEntityName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceEntityName"u8))
                {
                    sourceEntityName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceConnectionReference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceConnectionReference = MapperConnectionReference.DeserializeMapperConnectionReference(property.Value, options);
                    continue;
                }
                if (property.NameEquals("attributeMappingInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    attributeMappingInfo = MapperAttributeMappings.DeserializeMapperAttributeMappings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("sourceDenormalizeInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceDenormalizeInfo = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataMapperMapping(
                targetEntityName,
                sourceEntityName,
                sourceConnectionReference,
                attributeMappingInfo,
                sourceDenormalizeInfo,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataMapperMapping>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataMapperMapping>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataMapperMapping)} does not support '{options.Format}' format.");
            }
        }

        DataMapperMapping IPersistableModel<DataMapperMapping>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataMapperMapping>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataMapperMapping(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataMapperMapping)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataMapperMapping>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
