// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    internal partial class UnknownAzureOperatorNexusNetworkFunctionApplication : IUtf8JsonSerializable, IJsonModel<AzureOperatorNexusNetworkFunctionApplication>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureOperatorNexusNetworkFunctionApplication>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AzureOperatorNexusNetworkFunctionApplication>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureOperatorNexusNetworkFunctionApplication>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureOperatorNexusNetworkFunctionApplication)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("artifactType"u8);
            writer.WriteStringValue(ArtifactType.ToString());
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (DependsOnProfile != null)
            {
                writer.WritePropertyName("dependsOnProfile"u8);
                writer.WriteObjectValue(DependsOnProfile);
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

        AzureOperatorNexusNetworkFunctionApplication IJsonModel<AzureOperatorNexusNetworkFunctionApplication>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureOperatorNexusNetworkFunctionApplication>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureOperatorNexusNetworkFunctionApplication)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureOperatorNexusNetworkFunctionApplication(document.RootElement, options);
        }

        internal static UnknownAzureOperatorNexusNetworkFunctionApplication DeserializeUnknownAzureOperatorNexusNetworkFunctionApplication(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AzureOperatorNexusArtifactType artifactType = "AutoRest.CSharp.Output.Models.Types.EnumTypeValue";
            string name = default;
            DependsOnProfile dependsOnProfile = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("artifactType"u8))
                {
                    artifactType = new AzureOperatorNexusArtifactType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dependsOnProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dependsOnProfile = DependsOnProfile.DeserializeDependsOnProfile(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UnknownAzureOperatorNexusNetworkFunctionApplication(name, dependsOnProfile, serializedAdditionalRawData, artifactType);
        }

        BinaryData IPersistableModel<AzureOperatorNexusNetworkFunctionApplication>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureOperatorNexusNetworkFunctionApplication>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzureOperatorNexusNetworkFunctionApplication)} does not support '{options.Format}' format.");
            }
        }

        AzureOperatorNexusNetworkFunctionApplication IPersistableModel<AzureOperatorNexusNetworkFunctionApplication>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureOperatorNexusNetworkFunctionApplication>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureOperatorNexusNetworkFunctionApplication(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureOperatorNexusNetworkFunctionApplication)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureOperatorNexusNetworkFunctionApplication>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
