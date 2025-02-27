// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridCompute.Models
{
    public partial class AgentUpgrade : IUtf8JsonSerializable, IJsonModel<AgentUpgrade>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AgentUpgrade>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AgentUpgrade>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AgentUpgrade>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AgentUpgrade)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (DesiredVersion != null)
            {
                writer.WritePropertyName("desiredVersion"u8);
                writer.WriteStringValue(DesiredVersion);
            }
            if (CorrelationId.HasValue)
            {
                writer.WritePropertyName("correlationId"u8);
                writer.WriteStringValue(CorrelationId.Value);
            }
            if (IsAutomaticUpgradeEnabled.HasValue)
            {
                writer.WritePropertyName("enableAutomaticUpgrade"u8);
                writer.WriteBooleanValue(IsAutomaticUpgradeEnabled.Value);
            }
            if (options.Format != "W" && LastAttemptDesiredVersion != null)
            {
                writer.WritePropertyName("lastAttemptDesiredVersion"u8);
                writer.WriteStringValue(LastAttemptDesiredVersion);
            }
            if (options.Format != "W" && LastAttemptedOn.HasValue)
            {
                writer.WritePropertyName("lastAttemptTimestamp"u8);
                writer.WriteStringValue(LastAttemptedOn.Value, "O");
            }
            if (options.Format != "W" && LastAttemptStatus.HasValue)
            {
                writer.WritePropertyName("lastAttemptStatus"u8);
                writer.WriteStringValue(LastAttemptStatus.Value.ToString());
            }
            if (options.Format != "W" && LastAttemptMessage != null)
            {
                writer.WritePropertyName("lastAttemptMessage"u8);
                writer.WriteStringValue(LastAttemptMessage);
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

        AgentUpgrade IJsonModel<AgentUpgrade>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AgentUpgrade>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AgentUpgrade)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAgentUpgrade(document.RootElement, options);
        }

        internal static AgentUpgrade DeserializeAgentUpgrade(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string desiredVersion = default;
            Guid? correlationId = default;
            bool? enableAutomaticUpgrade = default;
            string lastAttemptDesiredVersion = default;
            DateTimeOffset? lastAttemptTimestamp = default;
            LastAttemptStatusEnum? lastAttemptStatus = default;
            string lastAttemptMessage = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("desiredVersion"u8))
                {
                    desiredVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("correlationId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    correlationId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("enableAutomaticUpgrade"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableAutomaticUpgrade = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("lastAttemptDesiredVersion"u8))
                {
                    lastAttemptDesiredVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastAttemptTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastAttemptTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastAttemptStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastAttemptStatus = new LastAttemptStatusEnum(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lastAttemptMessage"u8))
                {
                    lastAttemptMessage = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AgentUpgrade(
                desiredVersion,
                correlationId,
                enableAutomaticUpgrade,
                lastAttemptDesiredVersion,
                lastAttemptTimestamp,
                lastAttemptStatus,
                lastAttemptMessage,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AgentUpgrade>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AgentUpgrade>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AgentUpgrade)} does not support '{options.Format}' format.");
            }
        }

        AgentUpgrade IPersistableModel<AgentUpgrade>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AgentUpgrade>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAgentUpgrade(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AgentUpgrade)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AgentUpgrade>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
