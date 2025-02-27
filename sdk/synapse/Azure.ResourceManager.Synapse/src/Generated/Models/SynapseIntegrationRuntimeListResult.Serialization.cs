// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    internal partial class SynapseIntegrationRuntimeListResult : IUtf8JsonSerializable, IJsonModel<SynapseIntegrationRuntimeListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseIntegrationRuntimeListResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SynapseIntegrationRuntimeListResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseIntegrationRuntimeListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseIntegrationRuntimeListResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("value"u8);
            writer.WriteStartArray();
            foreach (var item in Value)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (NextLink != null)
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
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

        SynapseIntegrationRuntimeListResult IJsonModel<SynapseIntegrationRuntimeListResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseIntegrationRuntimeListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseIntegrationRuntimeListResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseIntegrationRuntimeListResult(document.RootElement, options);
        }

        internal static SynapseIntegrationRuntimeListResult DeserializeSynapseIntegrationRuntimeListResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<SynapseIntegrationRuntimeData> value = default;
            string nextLink = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<SynapseIntegrationRuntimeData> array = new List<SynapseIntegrationRuntimeData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SynapseIntegrationRuntimeData.DeserializeSynapseIntegrationRuntimeData(item, options));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SynapseIntegrationRuntimeListResult(value, nextLink, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SynapseIntegrationRuntimeListResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseIntegrationRuntimeListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SynapseIntegrationRuntimeListResult)} does not support '{options.Format}' format.");
            }
        }

        SynapseIntegrationRuntimeListResult IPersistableModel<SynapseIntegrationRuntimeListResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseIntegrationRuntimeListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSynapseIntegrationRuntimeListResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SynapseIntegrationRuntimeListResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseIntegrationRuntimeListResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
