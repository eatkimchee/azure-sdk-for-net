// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    public partial class SecurityContactData : IUtf8JsonSerializable, IJsonModel<SecurityContactData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityContactData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecurityContactData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityContactData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityContactData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Emails != null)
            {
                writer.WritePropertyName("emails"u8);
                writer.WriteStringValue(Emails);
            }
            if (Phone != null)
            {
                writer.WritePropertyName("phone"u8);
                writer.WriteStringValue(Phone);
            }
            if (AlertNotifications != null)
            {
                writer.WritePropertyName("alertNotifications"u8);
                writer.WriteObjectValue(AlertNotifications);
            }
            if (NotificationsByRole != null)
            {
                writer.WritePropertyName("notificationsByRole"u8);
                writer.WriteObjectValue(NotificationsByRole);
            }
            writer.WriteEndObject();
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

        SecurityContactData IJsonModel<SecurityContactData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityContactData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityContactData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityContactData(document.RootElement, options);
        }

        internal static SecurityContactData DeserializeSecurityContactData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string emails = default;
            string phone = default;
            SecurityContactPropertiesAlertNotifications alertNotifications = default;
            SecurityContactPropertiesNotificationsByRole notificationsByRole = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("emails"u8))
                        {
                            emails = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("phone"u8))
                        {
                            phone = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("alertNotifications"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            alertNotifications = SecurityContactPropertiesAlertNotifications.DeserializeSecurityContactPropertiesAlertNotifications(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("notificationsByRole"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            notificationsByRole = SecurityContactPropertiesNotificationsByRole.DeserializeSecurityContactPropertiesNotificationsByRole(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SecurityContactData(
                id,
                name,
                type,
                systemData,
                emails,
                phone,
                alertNotifications,
                notificationsByRole,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SecurityContactData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityContactData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SecurityContactData)} does not support '{options.Format}' format.");
            }
        }

        SecurityContactData IPersistableModel<SecurityContactData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityContactData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityContactData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityContactData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityContactData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
