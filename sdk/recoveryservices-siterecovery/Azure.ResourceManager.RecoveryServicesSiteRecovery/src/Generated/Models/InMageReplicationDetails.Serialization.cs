// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class InMageReplicationDetails : IUtf8JsonSerializable, IJsonModel<InMageReplicationDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InMageReplicationDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<InMageReplicationDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageReplicationDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InMageReplicationDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ActiveSiteType != null)
            {
                writer.WritePropertyName("activeSiteType"u8);
                writer.WriteStringValue(ActiveSiteType);
            }
            if (SourceVmCpuCount.HasValue)
            {
                writer.WritePropertyName("sourceVmCpuCount"u8);
                writer.WriteNumberValue(SourceVmCpuCount.Value);
            }
            if (SourceVmRamSizeInMB.HasValue)
            {
                writer.WritePropertyName("sourceVmRamSizeInMB"u8);
                writer.WriteNumberValue(SourceVmRamSizeInMB.Value);
            }
            if (OSDetails != null)
            {
                writer.WritePropertyName("osDetails"u8);
                writer.WriteObjectValue(OSDetails);
            }
            if (ProtectionStage != null)
            {
                writer.WritePropertyName("protectionStage"u8);
                writer.WriteStringValue(ProtectionStage);
            }
            if (VmId != null)
            {
                writer.WritePropertyName("vmId"u8);
                writer.WriteStringValue(VmId);
            }
            if (VmProtectionState != null)
            {
                writer.WritePropertyName("vmProtectionState"u8);
                writer.WriteStringValue(VmProtectionState);
            }
            if (VmProtectionStateDescription != null)
            {
                writer.WritePropertyName("vmProtectionStateDescription"u8);
                writer.WriteStringValue(VmProtectionStateDescription);
            }
            if (ResyncDetails != null)
            {
                writer.WritePropertyName("resyncDetails"u8);
                writer.WriteObjectValue(ResyncDetails);
            }
            if (RetentionWindowStartOn.HasValue)
            {
                writer.WritePropertyName("retentionWindowStart"u8);
                writer.WriteStringValue(RetentionWindowStartOn.Value, "O");
            }
            if (RetentionWindowEndOn.HasValue)
            {
                writer.WritePropertyName("retentionWindowEnd"u8);
                writer.WriteStringValue(RetentionWindowEndOn.Value, "O");
            }
            if (CompressedDataRateInMB.HasValue)
            {
                writer.WritePropertyName("compressedDataRateInMB"u8);
                writer.WriteNumberValue(CompressedDataRateInMB.Value);
            }
            if (UncompressedDataRateInMB.HasValue)
            {
                writer.WritePropertyName("uncompressedDataRateInMB"u8);
                writer.WriteNumberValue(UncompressedDataRateInMB.Value);
            }
            if (RpoInSeconds.HasValue)
            {
                writer.WritePropertyName("rpoInSeconds"u8);
                writer.WriteNumberValue(RpoInSeconds.Value);
            }
            if (!(ProtectedDisks is ChangeTrackingList<InMageProtectedDiskDetails> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("protectedDisks"u8);
                writer.WriteStartArray();
                foreach (var item in ProtectedDisks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (IPAddress != null)
            {
                writer.WritePropertyName("ipAddress"u8);
                writer.WriteStringValue(IPAddress.ToString());
            }
            if (LastHeartbeatReceivedOn.HasValue)
            {
                writer.WritePropertyName("lastHeartbeat"u8);
                writer.WriteStringValue(LastHeartbeatReceivedOn.Value, "O");
            }
            if (ProcessServerId.HasValue)
            {
                writer.WritePropertyName("processServerId"u8);
                writer.WriteStringValue(ProcessServerId.Value);
            }
            if (MasterTargetId != null)
            {
                writer.WritePropertyName("masterTargetId"u8);
                writer.WriteStringValue(MasterTargetId);
            }
            if (!(ConsistencyPoints is ChangeTrackingDictionary<string, DateTimeOffset> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("consistencyPoints"u8);
                writer.WriteStartObject();
                foreach (var item in ConsistencyPoints)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value, "O");
                }
                writer.WriteEndObject();
            }
            if (DiskResized != null)
            {
                writer.WritePropertyName("diskResized"u8);
                writer.WriteStringValue(DiskResized);
            }
            if (RebootAfterUpdateStatus != null)
            {
                writer.WritePropertyName("rebootAfterUpdateStatus"u8);
                writer.WriteStringValue(RebootAfterUpdateStatus);
            }
            if (MultiVmGroupId != null)
            {
                writer.WritePropertyName("multiVmGroupId"u8);
                writer.WriteStringValue(MultiVmGroupId);
            }
            if (MultiVmGroupName != null)
            {
                writer.WritePropertyName("multiVmGroupName"u8);
                writer.WriteStringValue(MultiVmGroupName);
            }
            if (MultiVmSyncStatus != null)
            {
                writer.WritePropertyName("multiVmSyncStatus"u8);
                writer.WriteStringValue(MultiVmSyncStatus);
            }
            if (AgentDetails != null)
            {
                writer.WritePropertyName("agentDetails"u8);
                writer.WriteObjectValue(AgentDetails);
            }
            if (VCenterInfrastructureId != null)
            {
                writer.WritePropertyName("vCenterInfrastructureId"u8);
                writer.WriteStringValue(VCenterInfrastructureId);
            }
            if (InfrastructureVmId != null)
            {
                writer.WritePropertyName("infrastructureVmId"u8);
                writer.WriteStringValue(InfrastructureVmId);
            }
            if (!(VmNics is ChangeTrackingList<VmNicDetails> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("vmNics"u8);
                writer.WriteStartArray();
                foreach (var item in VmNics)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (DiscoveryType != null)
            {
                writer.WritePropertyName("discoveryType"u8);
                writer.WriteStringValue(DiscoveryType);
            }
            if (AzureStorageAccountId != null)
            {
                writer.WritePropertyName("azureStorageAccountId"u8);
                writer.WriteStringValue(AzureStorageAccountId);
            }
            if (!(Datastores is ChangeTrackingList<string> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("datastores"u8);
                writer.WriteStartArray();
                foreach (var item in Datastores)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(ValidationErrors is ChangeTrackingList<SiteRecoveryHealthError> collection3 && collection3.IsUndefined))
            {
                writer.WritePropertyName("validationErrors"u8);
                writer.WriteStartArray();
                foreach (var item in ValidationErrors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (LastRpoCalculatedOn.HasValue)
            {
                writer.WritePropertyName("lastRpoCalculatedTime"u8);
                writer.WriteStringValue(LastRpoCalculatedOn.Value, "O");
            }
            if (LastUpdateReceivedOn.HasValue)
            {
                writer.WritePropertyName("lastUpdateReceivedTime"u8);
                writer.WriteStringValue(LastUpdateReceivedOn.Value, "O");
            }
            if (ReplicaId != null)
            {
                writer.WritePropertyName("replicaId"u8);
                writer.WriteStringValue(ReplicaId);
            }
            if (OSVersion != null)
            {
                writer.WritePropertyName("osVersion"u8);
                writer.WriteStringValue(OSVersion);
            }
            if (IsAdditionalStatsAvailable.HasValue)
            {
                writer.WritePropertyName("isAdditionalStatsAvailable"u8);
                writer.WriteBooleanValue(IsAdditionalStatsAvailable.Value);
            }
            if (TotalDataTransferred.HasValue)
            {
                writer.WritePropertyName("totalDataTransferred"u8);
                writer.WriteNumberValue(TotalDataTransferred.Value);
            }
            if (TotalProgressHealth != null)
            {
                writer.WritePropertyName("totalProgressHealth"u8);
                writer.WriteStringValue(TotalProgressHealth);
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        InMageReplicationDetails IJsonModel<InMageReplicationDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageReplicationDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InMageReplicationDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInMageReplicationDetails(document.RootElement, options);
        }

        internal static InMageReplicationDetails DeserializeInMageReplicationDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string activeSiteType = default;
            int? sourceVmCpuCount = default;
            int? sourceVmRamSizeInMB = default;
            SiteRecoveryOSDiskDetails osDetails = default;
            string protectionStage = default;
            string vmId = default;
            string vmProtectionState = default;
            string vmProtectionStateDescription = default;
            InitialReplicationDetails resyncDetails = default;
            DateTimeOffset? retentionWindowStart = default;
            DateTimeOffset? retentionWindowEnd = default;
            double? compressedDataRateInMB = default;
            double? uncompressedDataRateInMB = default;
            long? rpoInSeconds = default;
            IReadOnlyList<InMageProtectedDiskDetails> protectedDisks = default;
            IPAddress ipAddress = default;
            DateTimeOffset? lastHeartbeat = default;
            Guid? processServerId = default;
            string masterTargetId = default;
            IReadOnlyDictionary<string, DateTimeOffset> consistencyPoints = default;
            string diskResized = default;
            string rebootAfterUpdateStatus = default;
            string multiVmGroupId = default;
            string multiVmGroupName = default;
            string multiVmSyncStatus = default;
            InMageAgentDetails agentDetails = default;
            string vCenterInfrastructureId = default;
            string infrastructureVmId = default;
            IReadOnlyList<VmNicDetails> vmNics = default;
            string discoveryType = default;
            ResourceIdentifier azureStorageAccountId = default;
            IReadOnlyList<string> datastores = default;
            IReadOnlyList<SiteRecoveryHealthError> validationErrors = default;
            DateTimeOffset? lastRpoCalculatedTime = default;
            DateTimeOffset? lastUpdateReceivedTime = default;
            string replicaId = default;
            string osVersion = default;
            bool? isAdditionalStatsAvailable = default;
            long? totalDataTransferred = default;
            string totalProgressHealth = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("activeSiteType"u8))
                {
                    activeSiteType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceVmCpuCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceVmCpuCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("sourceVmRamSizeInMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceVmRamSizeInMB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("osDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osDetails = SiteRecoveryOSDiskDetails.DeserializeSiteRecoveryOSDiskDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("protectionStage"u8))
                {
                    protectionStage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vmId"u8))
                {
                    vmId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vmProtectionState"u8))
                {
                    vmProtectionState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vmProtectionStateDescription"u8))
                {
                    vmProtectionStateDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resyncDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resyncDetails = InitialReplicationDetails.DeserializeInitialReplicationDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("retentionWindowStart"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    retentionWindowStart = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("retentionWindowEnd"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    retentionWindowEnd = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("compressedDataRateInMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    compressedDataRateInMB = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("uncompressedDataRateInMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    uncompressedDataRateInMB = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("rpoInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rpoInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("protectedDisks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<InMageProtectedDiskDetails> array = new List<InMageProtectedDiskDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InMageProtectedDiskDetails.DeserializeInMageProtectedDiskDetails(item, options));
                    }
                    protectedDisks = array;
                    continue;
                }
                if (property.NameEquals("ipAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lastHeartbeat"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastHeartbeat = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("processServerId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    processServerId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("masterTargetId"u8))
                {
                    masterTargetId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("consistencyPoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, DateTimeOffset> dictionary = new Dictionary<string, DateTimeOffset>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetDateTimeOffset("O"));
                    }
                    consistencyPoints = dictionary;
                    continue;
                }
                if (property.NameEquals("diskResized"u8))
                {
                    diskResized = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rebootAfterUpdateStatus"u8))
                {
                    rebootAfterUpdateStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("multiVmGroupId"u8))
                {
                    multiVmGroupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("multiVmGroupName"u8))
                {
                    multiVmGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("multiVmSyncStatus"u8))
                {
                    multiVmSyncStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("agentDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    agentDetails = InMageAgentDetails.DeserializeInMageAgentDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("vCenterInfrastructureId"u8))
                {
                    vCenterInfrastructureId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("infrastructureVmId"u8))
                {
                    infrastructureVmId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vmNics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VmNicDetails> array = new List<VmNicDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VmNicDetails.DeserializeVmNicDetails(item, options));
                    }
                    vmNics = array;
                    continue;
                }
                if (property.NameEquals("discoveryType"u8))
                {
                    discoveryType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("azureStorageAccountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureStorageAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("datastores"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    datastores = array;
                    continue;
                }
                if (property.NameEquals("validationErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SiteRecoveryHealthError> array = new List<SiteRecoveryHealthError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteRecoveryHealthError.DeserializeSiteRecoveryHealthError(item, options));
                    }
                    validationErrors = array;
                    continue;
                }
                if (property.NameEquals("lastRpoCalculatedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastRpoCalculatedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastUpdateReceivedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastUpdateReceivedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("replicaId"u8))
                {
                    replicaId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osVersion"u8))
                {
                    osVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isAdditionalStatsAvailable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAdditionalStatsAvailable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("totalDataTransferred"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalDataTransferred = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("totalProgressHealth"u8))
                {
                    totalProgressHealth = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new InMageReplicationDetails(
                instanceType,
                serializedAdditionalRawData,
                activeSiteType,
                sourceVmCpuCount,
                sourceVmRamSizeInMB,
                osDetails,
                protectionStage,
                vmId,
                vmProtectionState,
                vmProtectionStateDescription,
                resyncDetails,
                retentionWindowStart,
                retentionWindowEnd,
                compressedDataRateInMB,
                uncompressedDataRateInMB,
                rpoInSeconds,
                protectedDisks ?? new ChangeTrackingList<InMageProtectedDiskDetails>(),
                ipAddress,
                lastHeartbeat,
                processServerId,
                masterTargetId,
                consistencyPoints ?? new ChangeTrackingDictionary<string, DateTimeOffset>(),
                diskResized,
                rebootAfterUpdateStatus,
                multiVmGroupId,
                multiVmGroupName,
                multiVmSyncStatus,
                agentDetails,
                vCenterInfrastructureId,
                infrastructureVmId,
                vmNics ?? new ChangeTrackingList<VmNicDetails>(),
                discoveryType,
                azureStorageAccountId,
                datastores ?? new ChangeTrackingList<string>(),
                validationErrors ?? new ChangeTrackingList<SiteRecoveryHealthError>(),
                lastRpoCalculatedTime,
                lastUpdateReceivedTime,
                replicaId,
                osVersion,
                isAdditionalStatsAvailable,
                totalDataTransferred,
                totalProgressHealth);
        }

        BinaryData IPersistableModel<InMageReplicationDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageReplicationDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InMageReplicationDetails)} does not support '{options.Format}' format.");
            }
        }

        InMageReplicationDetails IPersistableModel<InMageReplicationDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageReplicationDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInMageReplicationDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InMageReplicationDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<InMageReplicationDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
