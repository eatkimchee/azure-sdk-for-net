// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotCentral.Models
{
    public partial class IotCentralNetworkRuleSetIPRule : IUtf8JsonSerializable, IJsonModel<IotCentralNetworkRuleSetIPRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IotCentralNetworkRuleSetIPRule>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<IotCentralNetworkRuleSetIPRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotCentralNetworkRuleSetIPRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotCentralNetworkRuleSetIPRule)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (FilterName != null)
            {
                writer.WritePropertyName("filterName"u8);
                writer.WriteStringValue(FilterName);
            }
            if (IPMask != null)
            {
                writer.WritePropertyName("ipMask"u8);
                writer.WriteStringValue(IPMask);
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

        IotCentralNetworkRuleSetIPRule IJsonModel<IotCentralNetworkRuleSetIPRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotCentralNetworkRuleSetIPRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotCentralNetworkRuleSetIPRule)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIotCentralNetworkRuleSetIPRule(document.RootElement, options);
        }

        internal static IotCentralNetworkRuleSetIPRule DeserializeIotCentralNetworkRuleSetIPRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string filterName = default;
            string ipMask = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("filterName"u8))
                {
                    filterName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ipMask"u8))
                {
                    ipMask = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IotCentralNetworkRuleSetIPRule(filterName, ipMask, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IotCentralNetworkRuleSetIPRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotCentralNetworkRuleSetIPRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IotCentralNetworkRuleSetIPRule)} does not support '{options.Format}' format.");
            }
        }

        IotCentralNetworkRuleSetIPRule IPersistableModel<IotCentralNetworkRuleSetIPRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotCentralNetworkRuleSetIPRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIotCentralNetworkRuleSetIPRule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IotCentralNetworkRuleSetIPRule)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<IotCentralNetworkRuleSetIPRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
