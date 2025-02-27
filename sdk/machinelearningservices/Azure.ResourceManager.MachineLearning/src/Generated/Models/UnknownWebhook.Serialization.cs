// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    internal partial class UnknownWebhook : IUtf8JsonSerializable, IJsonModel<MachineLearningWebhook>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningWebhook>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineLearningWebhook>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningWebhook>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningWebhook)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (EventType != null)
            {
                if (EventType != null)
                {
                    writer.WritePropertyName("eventType"u8);
                    writer.WriteStringValue(EventType);
                }
                else
                {
                    writer.WriteNull("eventType");
                }
            }
            writer.WritePropertyName("webhookType"u8);
            writer.WriteStringValue(WebhookType.ToString());
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

        MachineLearningWebhook IJsonModel<MachineLearningWebhook>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningWebhook>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningWebhook)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningWebhook(document.RootElement, options);
        }

        internal static UnknownWebhook DeserializeUnknownWebhook(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string eventType = default;
            MachineLearningWebhookType webhookType = "Unknown";
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eventType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        eventType = null;
                        continue;
                    }
                    eventType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("webhookType"u8))
                {
                    webhookType = new MachineLearningWebhookType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UnknownWebhook(eventType, webhookType, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MachineLearningWebhook>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningWebhook>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningWebhook)} does not support '{options.Format}' format.");
            }
        }

        MachineLearningWebhook IPersistableModel<MachineLearningWebhook>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningWebhook>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningWebhook(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningWebhook)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningWebhook>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
