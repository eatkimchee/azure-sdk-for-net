// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class GremlinGraphPropertiesConfig : IUtf8JsonSerializable, IJsonModel<GremlinGraphPropertiesConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GremlinGraphPropertiesConfig>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GremlinGraphPropertiesConfig>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GremlinGraphPropertiesConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GremlinGraphPropertiesConfig)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Throughput.HasValue)
            {
                writer.WritePropertyName("throughput"u8);
                writer.WriteNumberValue(Throughput.Value);
            }
            if (AutoscaleSettings != null)
            {
                writer.WritePropertyName("autoscaleSettings"u8);
                writer.WriteObjectValue(AutoscaleSettings);
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

        GremlinGraphPropertiesConfig IJsonModel<GremlinGraphPropertiesConfig>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GremlinGraphPropertiesConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GremlinGraphPropertiesConfig)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGremlinGraphPropertiesConfig(document.RootElement, options);
        }

        internal static GremlinGraphPropertiesConfig DeserializeGremlinGraphPropertiesConfig(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? throughput = default;
            AutoscaleSettings autoscaleSettings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("throughput"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    throughput = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("autoscaleSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoscaleSettings = AutoscaleSettings.DeserializeAutoscaleSettings(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GremlinGraphPropertiesConfig(throughput, autoscaleSettings, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<GremlinGraphPropertiesConfig>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GremlinGraphPropertiesConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GremlinGraphPropertiesConfig)} does not support '{options.Format}' format.");
            }
        }

        GremlinGraphPropertiesConfig IPersistableModel<GremlinGraphPropertiesConfig>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GremlinGraphPropertiesConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGremlinGraphPropertiesConfig(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GremlinGraphPropertiesConfig)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GremlinGraphPropertiesConfig>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
