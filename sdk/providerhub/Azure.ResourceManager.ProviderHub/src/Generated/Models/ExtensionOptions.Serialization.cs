// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class ExtensionOptions : IUtf8JsonSerializable, IJsonModel<ExtensionOptions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExtensionOptions>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ExtensionOptions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtensionOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExtensionOptions)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Request is ChangeTrackingList<ExtensionOptionType> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("request"u8);
                writer.WriteStartArray();
                foreach (var item in Request)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (!(Response is ChangeTrackingList<ExtensionOptionType> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("response"u8);
                writer.WriteStartArray();
                foreach (var item in Response)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
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

        ExtensionOptions IJsonModel<ExtensionOptions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtensionOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExtensionOptions)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExtensionOptions(document.RootElement, options);
        }

        internal static ExtensionOptions DeserializeExtensionOptions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<ExtensionOptionType> request = default;
            IList<ExtensionOptionType> response = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("request"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ExtensionOptionType> array = new List<ExtensionOptionType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new ExtensionOptionType(item.GetString()));
                    }
                    request = array;
                    continue;
                }
                if (property.NameEquals("response"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ExtensionOptionType> array = new List<ExtensionOptionType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new ExtensionOptionType(item.GetString()));
                    }
                    response = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ExtensionOptions(request ?? new ChangeTrackingList<ExtensionOptionType>(), response ?? new ChangeTrackingList<ExtensionOptionType>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ExtensionOptions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtensionOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ExtensionOptions)} does not support '{options.Format}' format.");
            }
        }

        ExtensionOptions IPersistableModel<ExtensionOptions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtensionOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeExtensionOptions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExtensionOptions)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExtensionOptions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
