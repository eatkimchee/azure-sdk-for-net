// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class IntegrationRuntimeComputeProperties : IUtf8JsonSerializable, IJsonModel<IntegrationRuntimeComputeProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IntegrationRuntimeComputeProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<IntegrationRuntimeComputeProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationRuntimeComputeProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IntegrationRuntimeComputeProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Location.HasValue)
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (NodeSize != null)
            {
                writer.WritePropertyName("nodeSize"u8);
                writer.WriteStringValue(NodeSize);
            }
            if (NumberOfNodes.HasValue)
            {
                writer.WritePropertyName("numberOfNodes"u8);
                writer.WriteNumberValue(NumberOfNodes.Value);
            }
            if (MaxParallelExecutionsPerNode.HasValue)
            {
                writer.WritePropertyName("maxParallelExecutionsPerNode"u8);
                writer.WriteNumberValue(MaxParallelExecutionsPerNode.Value);
            }
            if (DataFlowProperties != null)
            {
                writer.WritePropertyName("dataFlowProperties"u8);
                writer.WriteObjectValue(DataFlowProperties);
            }
            if (VnetProperties != null)
            {
                writer.WritePropertyName("vNetProperties"u8);
                writer.WriteObjectValue(VnetProperties);
            }
            if (CopyComputeScaleProperties != null)
            {
                writer.WritePropertyName("copyComputeScaleProperties"u8);
                writer.WriteObjectValue(CopyComputeScaleProperties);
            }
            if (PipelineExternalComputeScaleProperties != null)
            {
                writer.WritePropertyName("pipelineExternalComputeScaleProperties"u8);
                writer.WriteObjectValue(PipelineExternalComputeScaleProperties);
            }
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        IntegrationRuntimeComputeProperties IJsonModel<IntegrationRuntimeComputeProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationRuntimeComputeProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IntegrationRuntimeComputeProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIntegrationRuntimeComputeProperties(document.RootElement, options);
        }

        internal static IntegrationRuntimeComputeProperties DeserializeIntegrationRuntimeComputeProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AzureLocation? location = default;
            string nodeSize = default;
            int? numberOfNodes = default;
            int? maxParallelExecutionsPerNode = default;
            IntegrationRuntimeDataFlowProperties dataFlowProperties = default;
            IntegrationRuntimeVnetProperties vnetProperties = default;
            CopyComputeScaleProperties copyComputeScaleProperties = default;
            PipelineExternalComputeScaleProperties pipelineExternalComputeScaleProperties = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("nodeSize"u8))
                {
                    nodeSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("numberOfNodes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    numberOfNodes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxParallelExecutionsPerNode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxParallelExecutionsPerNode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("dataFlowProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataFlowProperties = IntegrationRuntimeDataFlowProperties.DeserializeIntegrationRuntimeDataFlowProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("vNetProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vnetProperties = IntegrationRuntimeVnetProperties.DeserializeIntegrationRuntimeVnetProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("copyComputeScaleProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    copyComputeScaleProperties = CopyComputeScaleProperties.DeserializeCopyComputeScaleProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("pipelineExternalComputeScaleProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pipelineExternalComputeScaleProperties = PipelineExternalComputeScaleProperties.DeserializePipelineExternalComputeScaleProperties(property.Value, options);
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new IntegrationRuntimeComputeProperties(
                location,
                nodeSize,
                numberOfNodes,
                maxParallelExecutionsPerNode,
                dataFlowProperties,
                vnetProperties,
                copyComputeScaleProperties,
                pipelineExternalComputeScaleProperties,
                additionalProperties);
        }

        BinaryData IPersistableModel<IntegrationRuntimeComputeProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationRuntimeComputeProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IntegrationRuntimeComputeProperties)} does not support '{options.Format}' format.");
            }
        }

        IntegrationRuntimeComputeProperties IPersistableModel<IntegrationRuntimeComputeProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationRuntimeComputeProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIntegrationRuntimeComputeProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IntegrationRuntimeComputeProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<IntegrationRuntimeComputeProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
