// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MigrateSqlServerSqlDBTaskOutputValidationResult : IUtf8JsonSerializable, IJsonModel<MigrateSqlServerSqlDBTaskOutputValidationResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MigrateSqlServerSqlDBTaskOutputValidationResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MigrateSqlServerSqlDBTaskOutputValidationResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlServerSqlDBTaskOutputValidationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateSqlServerSqlDBTaskOutputValidationResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && MigrationId != null)
            {
                writer.WritePropertyName("migrationId"u8);
                writer.WriteStringValue(MigrationId);
            }
            if (!(SummaryResults is ChangeTrackingDictionary<string, MigrationValidationDatabaseSummaryResult> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("summaryResults"u8);
                writer.WriteStartObject();
                foreach (var item in SummaryResults)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W" && Status.HasValue)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (options.Format != "W" && Id != null)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("resultType"u8);
            writer.WriteStringValue(ResultType);
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

        MigrateSqlServerSqlDBTaskOutputValidationResult IJsonModel<MigrateSqlServerSqlDBTaskOutputValidationResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlServerSqlDBTaskOutputValidationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateSqlServerSqlDBTaskOutputValidationResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrateSqlServerSqlDBTaskOutputValidationResult(document.RootElement, options);
        }

        internal static MigrateSqlServerSqlDBTaskOutputValidationResult DeserializeMigrateSqlServerSqlDBTaskOutputValidationResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string migrationId = default;
            IReadOnlyDictionary<string, MigrationValidationDatabaseSummaryResult> summaryResults = default;
            ValidationStatus? status = default;
            string id = default;
            string resultType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("migrationId"u8))
                {
                    migrationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("summaryResults"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, MigrationValidationDatabaseSummaryResult> dictionary = new Dictionary<string, MigrationValidationDatabaseSummaryResult>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, MigrationValidationDatabaseSummaryResult.DeserializeMigrationValidationDatabaseSummaryResult(property0.Value, options));
                    }
                    summaryResults = dictionary;
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new ValidationStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultType"u8))
                {
                    resultType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MigrateSqlServerSqlDBTaskOutputValidationResult(
                id,
                resultType,
                serializedAdditionalRawData,
                migrationId,
                summaryResults ?? new ChangeTrackingDictionary<string, MigrationValidationDatabaseSummaryResult>(),
                status);
        }

        BinaryData IPersistableModel<MigrateSqlServerSqlDBTaskOutputValidationResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlServerSqlDBTaskOutputValidationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MigrateSqlServerSqlDBTaskOutputValidationResult)} does not support '{options.Format}' format.");
            }
        }

        MigrateSqlServerSqlDBTaskOutputValidationResult IPersistableModel<MigrateSqlServerSqlDBTaskOutputValidationResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlServerSqlDBTaskOutputValidationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMigrateSqlServerSqlDBTaskOutputValidationResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MigrateSqlServerSqlDBTaskOutputValidationResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MigrateSqlServerSqlDBTaskOutputValidationResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
