// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    public partial class ReportProperties : IUtf8JsonSerializable, IJsonModel<ReportProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ReportProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ReportProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReportProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReportProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Id != null)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W" && Status.HasValue)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (options.Format != "W" && TenantId.HasValue)
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId.Value);
            }
            if (options.Format != "W" && ReportName != null)
            {
                writer.WritePropertyName("reportName"u8);
                writer.WriteStringValue(ReportName);
            }
            if (OfferGuid != null)
            {
                writer.WritePropertyName("offerGuid"u8);
                writer.WriteStringValue(OfferGuid);
            }
            writer.WritePropertyName("timeZone"u8);
            writer.WriteStringValue(TimeZone);
            writer.WritePropertyName("triggerTime"u8);
            writer.WriteStringValue(TriggerOn, "O");
            if (options.Format != "W" && NextTriggerOn.HasValue)
            {
                writer.WritePropertyName("nextTriggerTime"u8);
                writer.WriteStringValue(NextTriggerOn.Value, "O");
            }
            if (options.Format != "W" && LastTriggerOn.HasValue)
            {
                writer.WritePropertyName("lastTriggerTime"u8);
                writer.WriteStringValue(LastTriggerOn.Value, "O");
            }
            if (options.Format != "W" && !(Subscriptions is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("subscriptions"u8);
                writer.WriteStartArray();
                foreach (var item in Subscriptions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("resources"u8);
            writer.WriteStartArray();
            foreach (var item in Resources)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (options.Format != "W" && ComplianceStatus != null)
            {
                writer.WritePropertyName("complianceStatus"u8);
                writer.WriteObjectValue(ComplianceStatus);
            }
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
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

        ReportProperties IJsonModel<ReportProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReportProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReportProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeReportProperties(document.RootElement, options);
        }

        internal static ReportProperties DeserializeReportProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            ReportStatus? status = default;
            Guid? tenantId = default;
            string reportName = default;
            string offerGuid = default;
            string timeZone = default;
            DateTimeOffset triggerTime = default;
            DateTimeOffset? nextTriggerTime = default;
            DateTimeOffset? lastTriggerTime = default;
            IReadOnlyList<string> subscriptions = default;
            IList<ResourceMetadata> resources = default;
            ReportComplianceStatus complianceStatus = default;
            ProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new ReportStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("reportName"u8))
                {
                    reportName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("offerGuid"u8))
                {
                    offerGuid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timeZone"u8))
                {
                    timeZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("triggerTime"u8))
                {
                    triggerTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("nextTriggerTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nextTriggerTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastTriggerTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastTriggerTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("subscriptions"u8))
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
                    subscriptions = array;
                    continue;
                }
                if (property.NameEquals("resources"u8))
                {
                    List<ResourceMetadata> array = new List<ResourceMetadata>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceMetadata.DeserializeResourceMetadata(item, options));
                    }
                    resources = array;
                    continue;
                }
                if (property.NameEquals("complianceStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    complianceStatus = ReportComplianceStatus.DeserializeReportComplianceStatus(property.Value, options);
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ReportProperties(
                id,
                status,
                tenantId,
                reportName,
                offerGuid,
                timeZone,
                triggerTime,
                nextTriggerTime,
                lastTriggerTime,
                subscriptions ?? new ChangeTrackingList<string>(),
                resources,
                complianceStatus,
                provisioningState,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ReportProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReportProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ReportProperties)} does not support '{options.Format}' format.");
            }
        }

        ReportProperties IPersistableModel<ReportProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReportProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeReportProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ReportProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ReportProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
