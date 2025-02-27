// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class RestSource : IUtf8JsonSerializable, IJsonModel<RestSource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RestSource>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RestSource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RestSource)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (RequestMethod != null)
            {
                writer.WritePropertyName("requestMethod"u8);
                JsonSerializer.Serialize(writer, RequestMethod);
            }
            if (RequestBody != null)
            {
                writer.WritePropertyName("requestBody"u8);
                JsonSerializer.Serialize(writer, RequestBody);
            }
            if (AdditionalHeaders != null)
            {
                writer.WritePropertyName("additionalHeaders"u8);
                JsonSerializer.Serialize(writer, AdditionalHeaders);
            }
            if (PaginationRules != null)
            {
                writer.WritePropertyName("paginationRules"u8);
                JsonSerializer.Serialize(writer, PaginationRules);
            }
            if (HttpRequestTimeout != null)
            {
                writer.WritePropertyName("httpRequestTimeout"u8);
                JsonSerializer.Serialize(writer, HttpRequestTimeout);
            }
            if (RequestInterval != null)
            {
                writer.WritePropertyName("requestInterval"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(RequestInterval);
#else
                using (JsonDocument document = JsonDocument.Parse(RequestInterval))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (AdditionalColumns != null)
            {
                writer.WritePropertyName("additionalColumns"u8);
                JsonSerializer.Serialize(writer, AdditionalColumns);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(CopySourceType);
            if (SourceRetryCount != null)
            {
                writer.WritePropertyName("sourceRetryCount"u8);
                JsonSerializer.Serialize(writer, SourceRetryCount);
            }
            if (SourceRetryWait != null)
            {
                writer.WritePropertyName("sourceRetryWait"u8);
                JsonSerializer.Serialize(writer, SourceRetryWait);
            }
            if (MaxConcurrentConnections != null)
            {
                writer.WritePropertyName("maxConcurrentConnections"u8);
                JsonSerializer.Serialize(writer, MaxConcurrentConnections);
            }
            if (DisableMetricsCollection != null)
            {
                writer.WritePropertyName("disableMetricsCollection"u8);
                JsonSerializer.Serialize(writer, DisableMetricsCollection);
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

        RestSource IJsonModel<RestSource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RestSource)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRestSource(document.RootElement, options);
        }

        internal static RestSource DeserializeRestSource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataFactoryElement<string> requestMethod = default;
            DataFactoryElement<string> requestBody = default;
            DataFactoryElement<string> additionalHeaders = default;
            DataFactoryElement<string> paginationRules = default;
            DataFactoryElement<string> httpRequestTimeout = default;
            BinaryData requestInterval = default;
            DataFactoryElement<IDictionary<string, string>> additionalColumns = default;
            string type = default;
            DataFactoryElement<int> sourceRetryCount = default;
            DataFactoryElement<string> sourceRetryWait = default;
            DataFactoryElement<int> maxConcurrentConnections = default;
            DataFactoryElement<bool> disableMetricsCollection = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("requestMethod"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requestMethod = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("requestBody"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requestBody = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("additionalHeaders"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    additionalHeaders = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("paginationRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    paginationRules = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("httpRequestTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    httpRequestTimeout = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("requestInterval"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requestInterval = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("additionalColumns"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    additionalColumns = JsonSerializer.Deserialize<DataFactoryElement<IDictionary<string, string>>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceRetryCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceRetryCount = JsonSerializer.Deserialize<DataFactoryElement<int>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("sourceRetryWait"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceRetryWait = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("maxConcurrentConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrentConnections = JsonSerializer.Deserialize<DataFactoryElement<int>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("disableMetricsCollection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disableMetricsCollection = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property.Value.GetRawText());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new RestSource(
                type,
                sourceRetryCount,
                sourceRetryWait,
                maxConcurrentConnections,
                disableMetricsCollection,
                additionalProperties,
                requestMethod,
                requestBody,
                additionalHeaders,
                paginationRules,
                httpRequestTimeout,
                requestInterval,
                additionalColumns);
        }

        BinaryData IPersistableModel<RestSource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RestSource)} does not support '{options.Format}' format.");
            }
        }

        RestSource IPersistableModel<RestSource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRestSource(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RestSource)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RestSource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
