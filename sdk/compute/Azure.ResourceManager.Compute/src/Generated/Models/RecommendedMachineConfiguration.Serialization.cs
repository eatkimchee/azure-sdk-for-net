// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class RecommendedMachineConfiguration : IUtf8JsonSerializable, IJsonModel<RecommendedMachineConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RecommendedMachineConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RecommendedMachineConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecommendedMachineConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecommendedMachineConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (VCpus != null)
            {
                writer.WritePropertyName("vCPUs"u8);
                writer.WriteObjectValue(VCpus);
            }
            if (Memory != null)
            {
                writer.WritePropertyName("memory"u8);
                writer.WriteObjectValue(Memory);
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

        RecommendedMachineConfiguration IJsonModel<RecommendedMachineConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecommendedMachineConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecommendedMachineConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRecommendedMachineConfiguration(document.RootElement, options);
        }

        internal static RecommendedMachineConfiguration DeserializeRecommendedMachineConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceRange vCpus = default;
            ResourceRange memory = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vCPUs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vCpus = ResourceRange.DeserializeResourceRange(property.Value, options);
                    continue;
                }
                if (property.NameEquals("memory"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    memory = ResourceRange.DeserializeResourceRange(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RecommendedMachineConfiguration(vCpus, memory, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RecommendedMachineConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecommendedMachineConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RecommendedMachineConfiguration)} does not support '{options.Format}' format.");
            }
        }

        RecommendedMachineConfiguration IPersistableModel<RecommendedMachineConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecommendedMachineConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRecommendedMachineConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RecommendedMachineConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RecommendedMachineConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
