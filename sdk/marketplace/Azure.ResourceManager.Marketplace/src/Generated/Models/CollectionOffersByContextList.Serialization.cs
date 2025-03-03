// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    internal partial class CollectionOffersByContextList : IUtf8JsonSerializable, IJsonModel<CollectionOffersByContextList>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CollectionOffersByContextList>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CollectionOffersByContextList>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CollectionOffersByContextList>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CollectionOffersByContextList)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && !(Value is ChangeTrackingList<CollectionOffersByContext> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (NextLink != null)
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
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

        CollectionOffersByContextList IJsonModel<CollectionOffersByContextList>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CollectionOffersByContextList>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CollectionOffersByContextList)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCollectionOffersByContextList(document.RootElement, options);
        }

        internal static CollectionOffersByContextList DeserializeCollectionOffersByContextList(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<CollectionOffersByContext> value = default;
            string nextLink = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CollectionOffersByContext> array = new List<CollectionOffersByContext>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CollectionOffersByContext.DeserializeCollectionOffersByContext(item, options));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CollectionOffersByContextList(value ?? new ChangeTrackingList<CollectionOffersByContext>(), nextLink, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CollectionOffersByContextList>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CollectionOffersByContextList>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CollectionOffersByContextList)} does not support '{options.Format}' format.");
            }
        }

        CollectionOffersByContextList IPersistableModel<CollectionOffersByContextList>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CollectionOffersByContextList>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCollectionOffersByContextList(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CollectionOffersByContextList)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CollectionOffersByContextList>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
