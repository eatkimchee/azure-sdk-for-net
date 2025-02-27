// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class SyncGroupLogProperties : IUtf8JsonSerializable, IJsonModel<SyncGroupLogProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SyncGroupLogProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SyncGroupLogProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SyncGroupLogProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SyncGroupLogProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Timestamp.HasValue)
            {
                writer.WritePropertyName("timestamp"u8);
                writer.WriteStringValue(Timestamp.Value, "O");
            }
            if (options.Format != "W" && LogType.HasValue)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(LogType.Value.ToString());
            }
            if (options.Format != "W" && Source != null)
            {
                writer.WritePropertyName("source"u8);
                writer.WriteStringValue(Source);
            }
            if (options.Format != "W" && Details != null)
            {
                writer.WritePropertyName("details"u8);
                writer.WriteStringValue(Details);
            }
            if (options.Format != "W" && TracingId.HasValue)
            {
                writer.WritePropertyName("tracingId"u8);
                writer.WriteStringValue(TracingId.Value);
            }
            if (options.Format != "W" && OperationStatus != null)
            {
                writer.WritePropertyName("operationStatus"u8);
                writer.WriteStringValue(OperationStatus);
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

        SyncGroupLogProperties IJsonModel<SyncGroupLogProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SyncGroupLogProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SyncGroupLogProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSyncGroupLogProperties(document.RootElement, options);
        }

        internal static SyncGroupLogProperties DeserializeSyncGroupLogProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? timestamp = default;
            SyncGroupLogType? type = default;
            string source = default;
            string details = default;
            Guid? tracingId = default;
            string operationStatus = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new SyncGroupLogType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("source"u8))
                {
                    source = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("details"u8))
                {
                    details = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tracingId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tracingId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("operationStatus"u8))
                {
                    operationStatus = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SyncGroupLogProperties(
                timestamp,
                type,
                source,
                details,
                tracingId,
                operationStatus,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SyncGroupLogProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SyncGroupLogProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SyncGroupLogProperties)} does not support '{options.Format}' format.");
            }
        }

        SyncGroupLogProperties IPersistableModel<SyncGroupLogProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SyncGroupLogProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSyncGroupLogProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SyncGroupLogProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SyncGroupLogProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
