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

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class EdgeIotAddon : IUtf8JsonSerializable, IJsonModel<EdgeIotAddon>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EdgeIotAddon>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EdgeIotAddon>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeIotAddon>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdgeIotAddon)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
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
            writer.WritePropertyName("ioTDeviceDetails"u8);
            writer.WriteObjectValue(IotDeviceDetails);
            writer.WritePropertyName("ioTEdgeDeviceDetails"u8);
            writer.WriteObjectValue(IotEdgeDeviceDetails);
            if (options.Format != "W" && Version != null)
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
            }
            if (options.Format != "W" && HostPlatform.HasValue)
            {
                writer.WritePropertyName("hostPlatform"u8);
                writer.WriteStringValue(HostPlatform.Value.ToString());
            }
            if (options.Format != "W" && HostPlatformType.HasValue)
            {
                writer.WritePropertyName("hostPlatformType"u8);
                writer.WriteStringValue(HostPlatformType.Value.ToString());
            }
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
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

        EdgeIotAddon IJsonModel<EdgeIotAddon>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeIotAddon>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdgeIotAddon)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEdgeIotAddon(document.RootElement, options);
        }

        internal static EdgeIotAddon DeserializeEdgeIotAddon(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AddonType kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            EdgeIotDeviceInfo iotDeviceDetails = default;
            EdgeIotDeviceInfo iotEdgeDeviceDetails = default;
            string version = default;
            DataBoxEdgeOSPlatformType? hostPlatform = default;
            HostPlatformType? hostPlatformType = default;
            DataBoxEdgeRoleAddonProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new AddonType(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("ioTDeviceDetails"u8))
                        {
                            iotDeviceDetails = EdgeIotDeviceInfo.DeserializeEdgeIotDeviceInfo(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("ioTEdgeDeviceDetails"u8))
                        {
                            iotEdgeDeviceDetails = EdgeIotDeviceInfo.DeserializeEdgeIotDeviceInfo(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("version"u8))
                        {
                            version = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hostPlatform"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hostPlatform = new DataBoxEdgeOSPlatformType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("hostPlatformType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hostPlatformType = new HostPlatformType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new DataBoxEdgeRoleAddonProvisioningState(property0.Value.GetString());
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
            return new EdgeIotAddon(
                id,
                name,
                type,
                systemData,
                kind,
                serializedAdditionalRawData,
                iotDeviceDetails,
                iotEdgeDeviceDetails,
                version,
                hostPlatform,
                hostPlatformType,
                provisioningState);
        }

        BinaryData IPersistableModel<EdgeIotAddon>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeIotAddon>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EdgeIotAddon)} does not support '{options.Format}' format.");
            }
        }

        EdgeIotAddon IPersistableModel<EdgeIotAddon>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeIotAddon>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEdgeIotAddon(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EdgeIotAddon)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<EdgeIotAddon>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
