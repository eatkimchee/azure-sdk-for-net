// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class AutoscaleProfile : IUtf8JsonSerializable, IJsonModel<AutoscaleProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AutoscaleProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AutoscaleProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoscaleProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutoscaleProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("capacity"u8);
            writer.WriteObjectValue(Capacity);
            writer.WritePropertyName("rules"u8);
            writer.WriteStartArray();
            foreach (var item in Rules)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (FixedDate != null)
            {
                writer.WritePropertyName("fixedDate"u8);
                writer.WriteObjectValue(FixedDate);
            }
            if (Recurrence != null)
            {
                writer.WritePropertyName("recurrence"u8);
                writer.WriteObjectValue(Recurrence);
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

        AutoscaleProfile IJsonModel<AutoscaleProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoscaleProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutoscaleProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAutoscaleProfile(document.RootElement, options);
        }

        internal static AutoscaleProfile DeserializeAutoscaleProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            MonitorScaleCapacity capacity = default;
            IList<AutoscaleRule> rules = default;
            MonitorTimeWindow fixedDate = default;
            MonitorRecurrence recurrence = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("capacity"u8))
                {
                    capacity = MonitorScaleCapacity.DeserializeMonitorScaleCapacity(property.Value, options);
                    continue;
                }
                if (property.NameEquals("rules"u8))
                {
                    List<AutoscaleRule> array = new List<AutoscaleRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AutoscaleRule.DeserializeAutoscaleRule(item, options));
                    }
                    rules = array;
                    continue;
                }
                if (property.NameEquals("fixedDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fixedDate = MonitorTimeWindow.DeserializeMonitorTimeWindow(property.Value, options);
                    continue;
                }
                if (property.NameEquals("recurrence"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recurrence = MonitorRecurrence.DeserializeMonitorRecurrence(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AutoscaleProfile(
                name,
                capacity,
                rules,
                fixedDate,
                recurrence,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AutoscaleProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoscaleProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AutoscaleProfile)} does not support '{options.Format}' format.");
            }
        }

        AutoscaleProfile IPersistableModel<AutoscaleProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoscaleProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAutoscaleProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AutoscaleProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AutoscaleProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
