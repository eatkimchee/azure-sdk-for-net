// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    public partial class HostPoolRegistrationInfo : IUtf8JsonSerializable, IJsonModel<HostPoolRegistrationInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HostPoolRegistrationInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HostPoolRegistrationInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HostPoolRegistrationInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HostPoolRegistrationInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ExpireOn.HasValue)
            {
                writer.WritePropertyName("expirationTime"u8);
                writer.WriteStringValue(ExpireOn.Value, "O");
            }
            if (Token != null)
            {
                writer.WritePropertyName("token"u8);
                writer.WriteStringValue(Token);
            }
            if (RegistrationTokenOperation.HasValue)
            {
                writer.WritePropertyName("registrationTokenOperation"u8);
                writer.WriteStringValue(RegistrationTokenOperation.Value.ToString());
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

        HostPoolRegistrationInfo IJsonModel<HostPoolRegistrationInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HostPoolRegistrationInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HostPoolRegistrationInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHostPoolRegistrationInfo(document.RootElement, options);
        }

        internal static HostPoolRegistrationInfo DeserializeHostPoolRegistrationInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? expirationTime = default;
            string token = default;
            HostPoolRegistrationTokenOperation? registrationTokenOperation = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("expirationTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expirationTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("token"u8))
                {
                    token = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("registrationTokenOperation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    registrationTokenOperation = new HostPoolRegistrationTokenOperation(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HostPoolRegistrationInfo(expirationTime, token, registrationTokenOperation, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HostPoolRegistrationInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HostPoolRegistrationInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HostPoolRegistrationInfo)} does not support '{options.Format}' format.");
            }
        }

        HostPoolRegistrationInfo IPersistableModel<HostPoolRegistrationInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HostPoolRegistrationInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHostPoolRegistrationInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HostPoolRegistrationInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HostPoolRegistrationInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
