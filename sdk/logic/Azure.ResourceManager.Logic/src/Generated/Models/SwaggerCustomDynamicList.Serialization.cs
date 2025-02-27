// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class SwaggerCustomDynamicList : IUtf8JsonSerializable, IJsonModel<SwaggerCustomDynamicList>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SwaggerCustomDynamicList>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SwaggerCustomDynamicList>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SwaggerCustomDynamicList>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SwaggerCustomDynamicList)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (OperationId != null)
            {
                writer.WritePropertyName("operationId"u8);
                writer.WriteStringValue(OperationId);
            }
            if (BuiltInOperation != null)
            {
                writer.WritePropertyName("builtInOperation"u8);
                writer.WriteStringValue(BuiltInOperation);
            }
            if (ItemsPath != null)
            {
                writer.WritePropertyName("itemsPath"u8);
                writer.WriteStringValue(ItemsPath);
            }
            if (ItemValuePath != null)
            {
                writer.WritePropertyName("itemValuePath"u8);
                writer.WriteStringValue(ItemValuePath);
            }
            if (ItemTitlePath != null)
            {
                writer.WritePropertyName("itemTitlePath"u8);
                writer.WriteStringValue(ItemTitlePath);
            }
            if (!(Parameters is ChangeTrackingDictionary<string, SwaggerCustomDynamicProperties> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
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

        SwaggerCustomDynamicList IJsonModel<SwaggerCustomDynamicList>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SwaggerCustomDynamicList>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SwaggerCustomDynamicList)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSwaggerCustomDynamicList(document.RootElement, options);
        }

        internal static SwaggerCustomDynamicList DeserializeSwaggerCustomDynamicList(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string operationId = default;
            string builtInOperation = default;
            string itemsPath = default;
            string itemValuePath = default;
            string itemTitlePath = default;
            IDictionary<string, SwaggerCustomDynamicProperties> parameters = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operationId"u8))
                {
                    operationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("builtInOperation"u8))
                {
                    builtInOperation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("itemsPath"u8))
                {
                    itemsPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("itemValuePath"u8))
                {
                    itemValuePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("itemTitlePath"u8))
                {
                    itemTitlePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, SwaggerCustomDynamicProperties> dictionary = new Dictionary<string, SwaggerCustomDynamicProperties>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, SwaggerCustomDynamicProperties.DeserializeSwaggerCustomDynamicProperties(property0.Value, options));
                    }
                    parameters = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SwaggerCustomDynamicList(
                operationId,
                builtInOperation,
                itemsPath,
                itemValuePath,
                itemTitlePath,
                parameters ?? new ChangeTrackingDictionary<string, SwaggerCustomDynamicProperties>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SwaggerCustomDynamicList>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SwaggerCustomDynamicList>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SwaggerCustomDynamicList)} does not support '{options.Format}' format.");
            }
        }

        SwaggerCustomDynamicList IPersistableModel<SwaggerCustomDynamicList>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SwaggerCustomDynamicList>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSwaggerCustomDynamicList(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SwaggerCustomDynamicList)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SwaggerCustomDynamicList>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
