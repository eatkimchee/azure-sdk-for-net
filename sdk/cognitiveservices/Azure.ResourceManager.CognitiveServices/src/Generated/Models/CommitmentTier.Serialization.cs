// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    public partial class CommitmentTier : IUtf8JsonSerializable, IJsonModel<CommitmentTier>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CommitmentTier>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CommitmentTier>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommitmentTier>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CommitmentTier)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Kind != null)
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            if (SkuName != null)
            {
                writer.WritePropertyName("skuName"u8);
                writer.WriteStringValue(SkuName);
            }
            if (HostingModel.HasValue)
            {
                writer.WritePropertyName("hostingModel"u8);
                writer.WriteStringValue(HostingModel.Value.ToString());
            }
            if (PlanType != null)
            {
                writer.WritePropertyName("planType"u8);
                writer.WriteStringValue(PlanType);
            }
            if (Tier != null)
            {
                writer.WritePropertyName("tier"u8);
                writer.WriteStringValue(Tier);
            }
            if (MaxCount.HasValue)
            {
                writer.WritePropertyName("maxCount"u8);
                writer.WriteNumberValue(MaxCount.Value);
            }
            if (Quota != null)
            {
                writer.WritePropertyName("quota"u8);
                writer.WriteObjectValue(Quota);
            }
            if (Cost != null)
            {
                writer.WritePropertyName("cost"u8);
                writer.WriteObjectValue(Cost);
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

        CommitmentTier IJsonModel<CommitmentTier>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommitmentTier>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CommitmentTier)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCommitmentTier(document.RootElement, options);
        }

        internal static CommitmentTier DeserializeCommitmentTier(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string kind = default;
            string skuName = default;
            ServiceAccountHostingModel? hostingModel = default;
            string planType = default;
            string tier = default;
            int? maxCount = default;
            CommitmentQuota quota = default;
            CommitmentCost cost = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("skuName"u8))
                {
                    skuName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hostingModel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hostingModel = new ServiceAccountHostingModel(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("planType"u8))
                {
                    planType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tier"u8))
                {
                    tier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("quota"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    quota = CommitmentQuota.DeserializeCommitmentQuota(property.Value, options);
                    continue;
                }
                if (property.NameEquals("cost"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cost = CommitmentCost.DeserializeCommitmentCost(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CommitmentTier(
                kind,
                skuName,
                hostingModel,
                planType,
                tier,
                maxCount,
                quota,
                cost,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CommitmentTier>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommitmentTier>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CommitmentTier)} does not support '{options.Format}' format.");
            }
        }

        CommitmentTier IPersistableModel<CommitmentTier>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommitmentTier>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCommitmentTier(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CommitmentTier)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CommitmentTier>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
