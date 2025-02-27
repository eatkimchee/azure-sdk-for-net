// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageSync.Models
{
    public partial class CloudTieringDatePolicyStatus : IUtf8JsonSerializable, IJsonModel<CloudTieringDatePolicyStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CloudTieringDatePolicyStatus>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CloudTieringDatePolicyStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudTieringDatePolicyStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CloudTieringDatePolicyStatus)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && LastUpdatedOn.HasValue)
            {
                writer.WritePropertyName("lastUpdatedTimestamp"u8);
                writer.WriteStringValue(LastUpdatedOn.Value, "O");
            }
            if (options.Format != "W" && TieredFilesMostRecentAccessTimestamp.HasValue)
            {
                writer.WritePropertyName("tieredFilesMostRecentAccessTimestamp"u8);
                writer.WriteStringValue(TieredFilesMostRecentAccessTimestamp.Value, "O");
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

        CloudTieringDatePolicyStatus IJsonModel<CloudTieringDatePolicyStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudTieringDatePolicyStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CloudTieringDatePolicyStatus)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCloudTieringDatePolicyStatus(document.RootElement, options);
        }

        internal static CloudTieringDatePolicyStatus DeserializeCloudTieringDatePolicyStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? lastUpdatedTimestamp = default;
            DateTimeOffset? tieredFilesMostRecentAccessTimestamp = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lastUpdatedTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastUpdatedTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("tieredFilesMostRecentAccessTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tieredFilesMostRecentAccessTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CloudTieringDatePolicyStatus(lastUpdatedTimestamp, tieredFilesMostRecentAccessTimestamp, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CloudTieringDatePolicyStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudTieringDatePolicyStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CloudTieringDatePolicyStatus)} does not support '{options.Format}' format.");
            }
        }

        CloudTieringDatePolicyStatus IPersistableModel<CloudTieringDatePolicyStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudTieringDatePolicyStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCloudTieringDatePolicyStatus(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CloudTieringDatePolicyStatus)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CloudTieringDatePolicyStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
