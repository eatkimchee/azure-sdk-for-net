// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ManagedInstanceDtcTransactionManagerCommunicationSettings : IUtf8JsonSerializable, IJsonModel<ManagedInstanceDtcTransactionManagerCommunicationSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedInstanceDtcTransactionManagerCommunicationSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagedInstanceDtcTransactionManagerCommunicationSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedInstanceDtcTransactionManagerCommunicationSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedInstanceDtcTransactionManagerCommunicationSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (AllowInboundEnabled.HasValue)
            {
                writer.WritePropertyName("allowInboundEnabled"u8);
                writer.WriteBooleanValue(AllowInboundEnabled.Value);
            }
            if (AllowOutboundEnabled.HasValue)
            {
                writer.WritePropertyName("allowOutboundEnabled"u8);
                writer.WriteBooleanValue(AllowOutboundEnabled.Value);
            }
            if (Authentication != null)
            {
                writer.WritePropertyName("authentication"u8);
                writer.WriteStringValue(Authentication);
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

        ManagedInstanceDtcTransactionManagerCommunicationSettings IJsonModel<ManagedInstanceDtcTransactionManagerCommunicationSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedInstanceDtcTransactionManagerCommunicationSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedInstanceDtcTransactionManagerCommunicationSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedInstanceDtcTransactionManagerCommunicationSettings(document.RootElement, options);
        }

        internal static ManagedInstanceDtcTransactionManagerCommunicationSettings DeserializeManagedInstanceDtcTransactionManagerCommunicationSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? allowInboundEnabled = default;
            bool? allowOutboundEnabled = default;
            string authentication = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allowInboundEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowInboundEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("allowOutboundEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowOutboundEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("authentication"u8))
                {
                    authentication = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagedInstanceDtcTransactionManagerCommunicationSettings(allowInboundEnabled, allowOutboundEnabled, authentication, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedInstanceDtcTransactionManagerCommunicationSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedInstanceDtcTransactionManagerCommunicationSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedInstanceDtcTransactionManagerCommunicationSettings)} does not support '{options.Format}' format.");
            }
        }

        ManagedInstanceDtcTransactionManagerCommunicationSettings IPersistableModel<ManagedInstanceDtcTransactionManagerCommunicationSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedInstanceDtcTransactionManagerCommunicationSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedInstanceDtcTransactionManagerCommunicationSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedInstanceDtcTransactionManagerCommunicationSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedInstanceDtcTransactionManagerCommunicationSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
