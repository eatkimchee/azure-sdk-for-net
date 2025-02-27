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
    public partial class InMageRcmFailbackProtectedDiskDetails : IUtf8JsonSerializable, IJsonModel<InMageRcmFailbackProtectedDiskDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InMageRcmFailbackProtectedDiskDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<InMageRcmFailbackProtectedDiskDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmFailbackProtectedDiskDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InMageRcmFailbackProtectedDiskDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && DiskId != null)
            {
                writer.WritePropertyName("diskId"u8);
                writer.WriteStringValue(DiskId);
            }
            if (options.Format != "W" && DiskName != null)
            {
                writer.WritePropertyName("diskName"u8);
                writer.WriteStringValue(DiskName);
            }
            if (options.Format != "W" && IsOSDisk != null)
            {
                writer.WritePropertyName("isOSDisk"u8);
                writer.WriteStringValue(IsOSDisk);
            }
            if (options.Format != "W" && CapacityInBytes.HasValue)
            {
                writer.WritePropertyName("capacityInBytes"u8);
                writer.WriteNumberValue(CapacityInBytes.Value);
            }
            if (options.Format != "W" && DiskUuid != null)
            {
                writer.WritePropertyName("diskUuid"u8);
                writer.WriteStringValue(DiskUuid);
            }
            if (options.Format != "W" && DataPendingInLogDataStoreInMB.HasValue)
            {
                writer.WritePropertyName("dataPendingInLogDataStoreInMB"u8);
                writer.WriteNumberValue(DataPendingInLogDataStoreInMB.Value);
            }
            if (options.Format != "W" && DataPendingAtSourceAgentInMB.HasValue)
            {
                writer.WritePropertyName("dataPendingAtSourceAgentInMB"u8);
                writer.WriteNumberValue(DataPendingAtSourceAgentInMB.Value);
            }
            if (options.Format != "W" && IsInitialReplicationComplete != null)
            {
                writer.WritePropertyName("isInitialReplicationComplete"u8);
                writer.WriteStringValue(IsInitialReplicationComplete);
            }
            if (IrDetails != null)
            {
                writer.WritePropertyName("irDetails"u8);
                writer.WriteObjectValue(IrDetails);
            }
            if (ResyncDetails != null)
            {
                writer.WritePropertyName("resyncDetails"u8);
                writer.WriteObjectValue(ResyncDetails);
            }
            if (options.Format != "W" && LastSyncedOn.HasValue)
            {
                writer.WritePropertyName("lastSyncTime"u8);
                writer.WriteStringValue(LastSyncedOn.Value, "O");
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

        InMageRcmFailbackProtectedDiskDetails IJsonModel<InMageRcmFailbackProtectedDiskDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmFailbackProtectedDiskDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InMageRcmFailbackProtectedDiskDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInMageRcmFailbackProtectedDiskDetails(document.RootElement, options);
        }

        internal static InMageRcmFailbackProtectedDiskDetails DeserializeInMageRcmFailbackProtectedDiskDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string diskId = default;
            string diskName = default;
            string isOSDisk = default;
            long? capacityInBytes = default;
            string diskUuid = default;
            double? dataPendingInLogDataStoreInMB = default;
            double? dataPendingAtSourceAgentInMB = default;
            string isInitialReplicationComplete = default;
            InMageRcmFailbackSyncDetails irDetails = default;
            InMageRcmFailbackSyncDetails resyncDetails = default;
            DateTimeOffset? lastSyncTime = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskId"u8))
                {
                    diskId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskName"u8))
                {
                    diskName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isOSDisk"u8))
                {
                    isOSDisk = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("capacityInBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capacityInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("diskUuid"u8))
                {
                    diskUuid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataPendingInLogDataStoreInMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataPendingInLogDataStoreInMB = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("dataPendingAtSourceAgentInMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataPendingAtSourceAgentInMB = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("isInitialReplicationComplete"u8))
                {
                    isInitialReplicationComplete = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("irDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    irDetails = InMageRcmFailbackSyncDetails.DeserializeInMageRcmFailbackSyncDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("resyncDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resyncDetails = InMageRcmFailbackSyncDetails.DeserializeInMageRcmFailbackSyncDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("lastSyncTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastSyncTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new InMageRcmFailbackProtectedDiskDetails(
                diskId,
                diskName,
                isOSDisk,
                capacityInBytes,
                diskUuid,
                dataPendingInLogDataStoreInMB,
                dataPendingAtSourceAgentInMB,
                isInitialReplicationComplete,
                irDetails,
                resyncDetails,
                lastSyncTime,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InMageRcmFailbackProtectedDiskDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmFailbackProtectedDiskDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InMageRcmFailbackProtectedDiskDetails)} does not support '{options.Format}' format.");
            }
        }

        InMageRcmFailbackProtectedDiskDetails IPersistableModel<InMageRcmFailbackProtectedDiskDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmFailbackProtectedDiskDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInMageRcmFailbackProtectedDiskDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InMageRcmFailbackProtectedDiskDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<InMageRcmFailbackProtectedDiskDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
