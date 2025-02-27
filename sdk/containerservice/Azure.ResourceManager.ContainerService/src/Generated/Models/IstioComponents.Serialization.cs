// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class IstioComponents : IUtf8JsonSerializable, IJsonModel<IstioComponents>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IstioComponents>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<IstioComponents>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IstioComponents>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IstioComponents)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(IngressGateways is ChangeTrackingList<IstioIngressGateway> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("ingressGateways"u8);
                writer.WriteStartArray();
                foreach (var item in IngressGateways)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(EgressGateways is ChangeTrackingList<IstioEgressGateway> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("egressGateways"u8);
                writer.WriteStartArray();
                foreach (var item in EgressGateways)
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

        IstioComponents IJsonModel<IstioComponents>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IstioComponents>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IstioComponents)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIstioComponents(document.RootElement, options);
        }

        internal static IstioComponents DeserializeIstioComponents(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<IstioIngressGateway> ingressGateways = default;
            IList<IstioEgressGateway> egressGateways = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ingressGateways"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IstioIngressGateway> array = new List<IstioIngressGateway>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IstioIngressGateway.DeserializeIstioIngressGateway(item, options));
                    }
                    ingressGateways = array;
                    continue;
                }
                if (property.NameEquals("egressGateways"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IstioEgressGateway> array = new List<IstioEgressGateway>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IstioEgressGateway.DeserializeIstioEgressGateway(item, options));
                    }
                    egressGateways = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IstioComponents(ingressGateways ?? new ChangeTrackingList<IstioIngressGateway>(), egressGateways ?? new ChangeTrackingList<IstioEgressGateway>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IstioComponents>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IstioComponents>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IstioComponents)} does not support '{options.Format}' format.");
            }
        }

        IstioComponents IPersistableModel<IstioComponents>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IstioComponents>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIstioComponents(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IstioComponents)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<IstioComponents>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
