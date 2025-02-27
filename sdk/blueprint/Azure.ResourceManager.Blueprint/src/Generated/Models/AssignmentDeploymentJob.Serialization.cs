// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Blueprint.Models
{
    public partial class AssignmentDeploymentJob : IUtf8JsonSerializable, IJsonModel<AssignmentDeploymentJob>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AssignmentDeploymentJob>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AssignmentDeploymentJob>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssignmentDeploymentJob>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AssignmentDeploymentJob)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Kind != null)
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            if (Action != null)
            {
                writer.WritePropertyName("action"u8);
                writer.WriteStringValue(Action);
            }
            if (JobId != null)
            {
                writer.WritePropertyName("jobId"u8);
                writer.WriteStringValue(JobId);
            }
            if (JobState != null)
            {
                writer.WritePropertyName("jobState"u8);
                writer.WriteStringValue(JobState);
            }
            if (Result != null)
            {
                writer.WritePropertyName("result"u8);
                writer.WriteObjectValue(Result);
            }
            if (!(History is ChangeTrackingList<AssignmentDeploymentJobResult> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("history"u8);
                writer.WriteStartArray();
                foreach (var item in History)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (RequestUri != null)
            {
                writer.WritePropertyName("requestUri"u8);
                writer.WriteStringValue(RequestUri.AbsoluteUri);
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

        AssignmentDeploymentJob IJsonModel<AssignmentDeploymentJob>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssignmentDeploymentJob>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AssignmentDeploymentJob)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAssignmentDeploymentJob(document.RootElement, options);
        }

        internal static AssignmentDeploymentJob DeserializeAssignmentDeploymentJob(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string kind = default;
            string action = default;
            string jobId = default;
            string jobState = default;
            AssignmentDeploymentJobResult result = default;
            IList<AssignmentDeploymentJobResult> history = default;
            Uri requestUri = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("action"u8))
                {
                    action = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobId"u8))
                {
                    jobId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobState"u8))
                {
                    jobState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("result"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result = AssignmentDeploymentJobResult.DeserializeAssignmentDeploymentJobResult(property.Value, options);
                    continue;
                }
                if (property.NameEquals("history"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AssignmentDeploymentJobResult> array = new List<AssignmentDeploymentJobResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AssignmentDeploymentJobResult.DeserializeAssignmentDeploymentJobResult(item, options));
                    }
                    history = array;
                    continue;
                }
                if (property.NameEquals("requestUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requestUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AssignmentDeploymentJob(
                kind,
                action,
                jobId,
                jobState,
                result,
                history ?? new ChangeTrackingList<AssignmentDeploymentJobResult>(),
                requestUri,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AssignmentDeploymentJob>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssignmentDeploymentJob>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AssignmentDeploymentJob)} does not support '{options.Format}' format.");
            }
        }

        AssignmentDeploymentJob IPersistableModel<AssignmentDeploymentJob>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssignmentDeploymentJob>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAssignmentDeploymentJob(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AssignmentDeploymentJob)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AssignmentDeploymentJob>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
