// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class DataFactoryPipelineRunInfo : IUtf8JsonSerializable, IJsonModel<DataFactoryPipelineRunInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataFactoryPipelineRunInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataFactoryPipelineRunInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryPipelineRunInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataFactoryPipelineRunInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && RunId.HasValue)
            {
                writer.WritePropertyName("runId"u8);
                writer.WriteStringValue(RunId.Value);
            }
            if (options.Format != "W" && RunGroupId != null)
            {
                writer.WritePropertyName("runGroupId"u8);
                writer.WriteStringValue(RunGroupId);
            }
            if (options.Format != "W" && IsLatest.HasValue)
            {
                writer.WritePropertyName("isLatest"u8);
                writer.WriteBooleanValue(IsLatest.Value);
            }
            if (options.Format != "W" && PipelineName != null)
            {
                writer.WritePropertyName("pipelineName"u8);
                writer.WriteStringValue(PipelineName);
            }
            if (options.Format != "W" && !(Parameters is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W" && !(RunDimensions is ChangeTrackingDictionary<string, string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("runDimensions"u8);
                writer.WriteStartObject();
                foreach (var item in RunDimensions)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W" && InvokedBy != null)
            {
                writer.WritePropertyName("invokedBy"u8);
                writer.WriteObjectValue(InvokedBy);
            }
            if (options.Format != "W" && LastUpdatedOn.HasValue)
            {
                writer.WritePropertyName("lastUpdated"u8);
                writer.WriteStringValue(LastUpdatedOn.Value, "O");
            }
            if (options.Format != "W" && RunStartOn.HasValue)
            {
                writer.WritePropertyName("runStart"u8);
                writer.WriteStringValue(RunStartOn.Value, "O");
            }
            if (options.Format != "W" && RunEndOn.HasValue)
            {
                writer.WritePropertyName("runEnd"u8);
                writer.WriteStringValue(RunEndOn.Value, "O");
            }
            if (options.Format != "W" && DurationInMs.HasValue)
            {
                writer.WritePropertyName("durationInMs"u8);
                writer.WriteNumberValue(DurationInMs.Value);
            }
            if (options.Format != "W" && Status != null)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (options.Format != "W" && Message != null)
            {
                writer.WritePropertyName("message"u8);
                writer.WriteStringValue(Message);
            }
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        DataFactoryPipelineRunInfo IJsonModel<DataFactoryPipelineRunInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryPipelineRunInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataFactoryPipelineRunInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataFactoryPipelineRunInfo(document.RootElement, options);
        }

        internal static DataFactoryPipelineRunInfo DeserializeDataFactoryPipelineRunInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid? runId = default;
            string runGroupId = default;
            bool? isLatest = default;
            string pipelineName = default;
            IReadOnlyDictionary<string, string> parameters = default;
            IReadOnlyDictionary<string, string> runDimensions = default;
            DataFactoryPipelineRunEntityInfo invokedBy = default;
            DateTimeOffset? lastUpdated = default;
            DateTimeOffset? runStart = default;
            DateTimeOffset? runEnd = default;
            int? durationInMs = default;
            string status = default;
            string message = default;
            IReadOnlyDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("runId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    runId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("runGroupId"u8))
                {
                    runGroupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isLatest"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isLatest = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("pipelineName"u8))
                {
                    pipelineName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("runDimensions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    runDimensions = dictionary;
                    continue;
                }
                if (property.NameEquals("invokedBy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    invokedBy = DataFactoryPipelineRunEntityInfo.DeserializeDataFactoryPipelineRunEntityInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("lastUpdated"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastUpdated = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("runStart"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    runStart = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("runEnd"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    runEnd = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("durationInMs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    durationInMs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new DataFactoryPipelineRunInfo(
                runId,
                runGroupId,
                isLatest,
                pipelineName,
                parameters ?? new ChangeTrackingDictionary<string, string>(),
                runDimensions ?? new ChangeTrackingDictionary<string, string>(),
                invokedBy,
                lastUpdated,
                runStart,
                runEnd,
                durationInMs,
                status,
                message,
                additionalProperties);
        }

        BinaryData IPersistableModel<DataFactoryPipelineRunInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryPipelineRunInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataFactoryPipelineRunInfo)} does not support '{options.Format}' format.");
            }
        }

        DataFactoryPipelineRunInfo IPersistableModel<DataFactoryPipelineRunInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryPipelineRunInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataFactoryPipelineRunInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataFactoryPipelineRunInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataFactoryPipelineRunInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
