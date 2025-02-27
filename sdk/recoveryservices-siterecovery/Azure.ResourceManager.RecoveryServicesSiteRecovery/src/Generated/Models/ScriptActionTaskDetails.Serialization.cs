// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class ScriptActionTaskDetails : IUtf8JsonSerializable, IJsonModel<ScriptActionTaskDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ScriptActionTaskDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ScriptActionTaskDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScriptActionTaskDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScriptActionTaskDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Path != null)
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(Path);
            }
            if (Output != null)
            {
                writer.WritePropertyName("output"u8);
                writer.WriteStringValue(Output);
            }
            if (IsPrimarySideScript.HasValue)
            {
                writer.WritePropertyName("isPrimarySideScript"u8);
                writer.WriteBooleanValue(IsPrimarySideScript.Value);
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        ScriptActionTaskDetails IJsonModel<ScriptActionTaskDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScriptActionTaskDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScriptActionTaskDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeScriptActionTaskDetails(document.RootElement, options);
        }

        internal static ScriptActionTaskDetails DeserializeScriptActionTaskDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string path = default;
            string output = default;
            bool? isPrimarySideScript = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("path"u8))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("output"u8))
                {
                    output = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isPrimarySideScript"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isPrimarySideScript = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ScriptActionTaskDetails(
                instanceType,
                serializedAdditionalRawData,
                name,
                path,
                output,
                isPrimarySideScript);
        }

        BinaryData IPersistableModel<ScriptActionTaskDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScriptActionTaskDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ScriptActionTaskDetails)} does not support '{options.Format}' format.");
            }
        }

        ScriptActionTaskDetails IPersistableModel<ScriptActionTaskDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScriptActionTaskDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeScriptActionTaskDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ScriptActionTaskDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ScriptActionTaskDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
