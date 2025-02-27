// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    public partial class IotHubRegistryStatistics : IUtf8JsonSerializable, IJsonModel<IotHubRegistryStatistics>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IotHubRegistryStatistics>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<IotHubRegistryStatistics>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubRegistryStatistics>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotHubRegistryStatistics)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && TotalDeviceCount.HasValue)
            {
                writer.WritePropertyName("totalDeviceCount"u8);
                writer.WriteNumberValue(TotalDeviceCount.Value);
            }
            if (options.Format != "W" && EnabledDeviceCount.HasValue)
            {
                writer.WritePropertyName("enabledDeviceCount"u8);
                writer.WriteNumberValue(EnabledDeviceCount.Value);
            }
            if (options.Format != "W" && DisabledDeviceCount.HasValue)
            {
                writer.WritePropertyName("disabledDeviceCount"u8);
                writer.WriteNumberValue(DisabledDeviceCount.Value);
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

        IotHubRegistryStatistics IJsonModel<IotHubRegistryStatistics>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubRegistryStatistics>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotHubRegistryStatistics)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIotHubRegistryStatistics(document.RootElement, options);
        }

        internal static IotHubRegistryStatistics DeserializeIotHubRegistryStatistics(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            long? totalDeviceCount = default;
            long? enabledDeviceCount = default;
            long? disabledDeviceCount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("totalDeviceCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalDeviceCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("enabledDeviceCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabledDeviceCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("disabledDeviceCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disabledDeviceCount = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IotHubRegistryStatistics(totalDeviceCount, enabledDeviceCount, disabledDeviceCount, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IotHubRegistryStatistics>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubRegistryStatistics>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IotHubRegistryStatistics)} does not support '{options.Format}' format.");
            }
        }

        IotHubRegistryStatistics IPersistableModel<IotHubRegistryStatistics>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubRegistryStatistics>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIotHubRegistryStatistics(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IotHubRegistryStatistics)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<IotHubRegistryStatistics>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
