// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.ContainerServiceFleet.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ContainerServiceFleet
{
    public partial class ContainerServiceFleetUpdateRunData : IUtf8JsonSerializable, IJsonModel<ContainerServiceFleetUpdateRunData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerServiceFleetUpdateRunData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerServiceFleetUpdateRunData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceFleetUpdateRunData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerServiceFleetUpdateRunData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && ETag.HasValue)
            {
                writer.WritePropertyName("eTag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
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
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (UpdateStrategyId != null)
            {
                writer.WritePropertyName("updateStrategyId"u8);
                writer.WriteStringValue(UpdateStrategyId);
            }
            if (Strategy != null)
            {
                writer.WritePropertyName("strategy"u8);
                writer.WriteObjectValue(Strategy);
            }
            if (ManagedClusterUpdate != null)
            {
                writer.WritePropertyName("managedClusterUpdate"u8);
                writer.WriteObjectValue(ManagedClusterUpdate);
            }
            if (options.Format != "W" && Status != null)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteObjectValue(Status);
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

        ContainerServiceFleetUpdateRunData IJsonModel<ContainerServiceFleetUpdateRunData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceFleetUpdateRunData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerServiceFleetUpdateRunData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerServiceFleetUpdateRunData(document.RootElement, options);
        }

        internal static ContainerServiceFleetUpdateRunData DeserializeContainerServiceFleetUpdateRunData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ETag? eTag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            ContainerServiceFleetUpdateRunProvisioningState? provisioningState = default;
            ResourceIdentifier updateStrategyId = default;
            ContainerServiceFleetUpdateRunStrategy strategy = default;
            ContainerServiceFleetManagedClusterUpdate managedClusterUpdate = default;
            ContainerServiceFleetUpdateRunStatus status = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eTag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eTag = new ETag(property.Value.GetString());
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ContainerServiceFleetUpdateRunProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("updateStrategyId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            updateStrategyId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("strategy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            strategy = ContainerServiceFleetUpdateRunStrategy.DeserializeContainerServiceFleetUpdateRunStrategy(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("managedClusterUpdate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            managedClusterUpdate = ContainerServiceFleetManagedClusterUpdate.DeserializeContainerServiceFleetManagedClusterUpdate(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = ContainerServiceFleetUpdateRunStatus.DeserializeContainerServiceFleetUpdateRunStatus(property0.Value, options);
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
            return new ContainerServiceFleetUpdateRunData(
                id,
                name,
                type,
                systemData,
                eTag,
                provisioningState,
                updateStrategyId,
                strategy,
                managedClusterUpdate,
                status,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerServiceFleetUpdateRunData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceFleetUpdateRunData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerServiceFleetUpdateRunData)} does not support '{options.Format}' format.");
            }
        }

        ContainerServiceFleetUpdateRunData IPersistableModel<ContainerServiceFleetUpdateRunData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceFleetUpdateRunData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerServiceFleetUpdateRunData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerServiceFleetUpdateRunData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerServiceFleetUpdateRunData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
