// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    internal partial class PolicyStatesQueryResults : IUtf8JsonSerializable, IJsonModel<PolicyStatesQueryResults>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PolicyStatesQueryResults>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PolicyStatesQueryResults>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyStatesQueryResults>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PolicyStatesQueryResults)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ODataContext != null)
            {
                writer.WritePropertyName("@odata.context"u8);
                writer.WriteStringValue(ODataContext);
            }
            if (ODataCount.HasValue)
            {
                writer.WritePropertyName("@odata.count"u8);
                writer.WriteNumberValue(ODataCount.Value);
            }
            if (ODataNextLink != null)
            {
                writer.WritePropertyName("@odata.nextLink"u8);
                writer.WriteStringValue(ODataNextLink);
            }
            if (!(Value is ChangeTrackingList<PolicyState> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
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

        PolicyStatesQueryResults IJsonModel<PolicyStatesQueryResults>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyStatesQueryResults>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PolicyStatesQueryResults)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePolicyStatesQueryResults(document.RootElement, options);
        }

        internal static PolicyStatesQueryResults DeserializePolicyStatesQueryResults(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string odataContext = default;
            int? odataCount = default;
            string odataNextLink = default;
            IReadOnlyList<PolicyState> value = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@odata.context"u8))
                {
                    odataContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@odata.count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    odataCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("@odata.nextLink"u8))
                {
                    odataNextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PolicyState> array = new List<PolicyState>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PolicyState.DeserializePolicyState(item, options));
                    }
                    value = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PolicyStatesQueryResults(odataContext, odataCount, odataNextLink, value ?? new ChangeTrackingList<PolicyState>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PolicyStatesQueryResults>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyStatesQueryResults>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PolicyStatesQueryResults)} does not support '{options.Format}' format.");
            }
        }

        PolicyStatesQueryResults IPersistableModel<PolicyStatesQueryResults>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyStatesQueryResults>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePolicyStatesQueryResults(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PolicyStatesQueryResults)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PolicyStatesQueryResults>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
