// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StoragePool.Models
{
    public partial class OutboundEndpointDependency : IUtf8JsonSerializable, IJsonModel<OutboundEndpointDependency>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OutboundEndpointDependency>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<OutboundEndpointDependency>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OutboundEndpointDependency>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OutboundEndpointDependency)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (DomainName != null)
            {
                writer.WritePropertyName("domainName"u8);
                writer.WriteStringValue(DomainName);
            }
            if (!(EndpointDetails is ChangeTrackingList<OutboundEndpointDetail> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("endpointDetails"u8);
                writer.WriteStartArray();
                foreach (var item in EndpointDetails)
                {
                    writer.WriteObjectValue(item);
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

        OutboundEndpointDependency IJsonModel<OutboundEndpointDependency>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OutboundEndpointDependency>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OutboundEndpointDependency)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOutboundEndpointDependency(document.RootElement, options);
        }

        internal static OutboundEndpointDependency DeserializeOutboundEndpointDependency(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string domainName = default;
            IReadOnlyList<OutboundEndpointDetail> endpointDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("domainName"u8))
                {
                    domainName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpointDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<OutboundEndpointDetail> array = new List<OutboundEndpointDetail>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OutboundEndpointDetail.DeserializeOutboundEndpointDetail(item, options));
                    }
                    endpointDetails = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new OutboundEndpointDependency(domainName, endpointDetails ?? new ChangeTrackingList<OutboundEndpointDetail>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<OutboundEndpointDependency>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OutboundEndpointDependency>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(OutboundEndpointDependency)} does not support '{options.Format}' format.");
            }
        }

        OutboundEndpointDependency IPersistableModel<OutboundEndpointDependency>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OutboundEndpointDependency>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOutboundEndpointDependency(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OutboundEndpointDependency)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<OutboundEndpointDependency>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
