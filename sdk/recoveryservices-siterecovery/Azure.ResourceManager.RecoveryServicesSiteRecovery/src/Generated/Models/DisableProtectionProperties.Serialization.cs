// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class DisableProtectionProperties : IUtf8JsonSerializable, IJsonModel<DisableProtectionProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DisableProtectionProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DisableProtectionProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DisableProtectionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DisableProtectionProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (DisableProtectionReason.HasValue)
            {
                writer.WritePropertyName("disableProtectionReason"u8);
                writer.WriteStringValue(DisableProtectionReason.Value.ToString());
            }
            if (ReplicationProviderContent != null)
            {
                writer.WritePropertyName("replicationProviderInput"u8);
                writer.WriteObjectValue(ReplicationProviderContent);
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

        DisableProtectionProperties IJsonModel<DisableProtectionProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DisableProtectionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DisableProtectionProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDisableProtectionProperties(document.RootElement, options);
        }

        internal static DisableProtectionProperties DeserializeDisableProtectionProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DisableProtectionReason? disableProtectionReason = default;
            DisableProtectionProviderSpecificContent replicationProviderContent = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("disableProtectionReason"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disableProtectionReason = new DisableProtectionReason(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("replicationProviderInput"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    replicationProviderContent = DisableProtectionProviderSpecificContent.DeserializeDisableProtectionProviderSpecificContent(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DisableProtectionProperties(disableProtectionReason, replicationProviderContent, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DisableProtectionProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DisableProtectionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DisableProtectionProperties)} does not support '{options.Format}' format.");
            }
        }

        DisableProtectionProperties IPersistableModel<DisableProtectionProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DisableProtectionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDisableProtectionProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DisableProtectionProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DisableProtectionProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
