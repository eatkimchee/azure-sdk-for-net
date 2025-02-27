// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    internal partial class ConfigurationServiceGitProperty : IUtf8JsonSerializable, IJsonModel<ConfigurationServiceGitProperty>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConfigurationServiceGitProperty>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ConfigurationServiceGitProperty>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigurationServiceGitProperty>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConfigurationServiceGitProperty)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(ConfigurationServiceGitRepositories is ChangeTrackingList<AppPlatformConfigurationServiceGitRepository> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("repositories"u8);
                writer.WriteStartArray();
                foreach (var item in ConfigurationServiceGitRepositories)
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

        ConfigurationServiceGitProperty IJsonModel<ConfigurationServiceGitProperty>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigurationServiceGitProperty>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConfigurationServiceGitProperty)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConfigurationServiceGitProperty(document.RootElement, options);
        }

        internal static ConfigurationServiceGitProperty DeserializeConfigurationServiceGitProperty(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<AppPlatformConfigurationServiceGitRepository> repositories = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("repositories"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AppPlatformConfigurationServiceGitRepository> array = new List<AppPlatformConfigurationServiceGitRepository>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AppPlatformConfigurationServiceGitRepository.DeserializeAppPlatformConfigurationServiceGitRepository(item, options));
                    }
                    repositories = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ConfigurationServiceGitProperty(repositories ?? new ChangeTrackingList<AppPlatformConfigurationServiceGitRepository>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConfigurationServiceGitProperty>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigurationServiceGitProperty>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConfigurationServiceGitProperty)} does not support '{options.Format}' format.");
            }
        }

        ConfigurationServiceGitProperty IPersistableModel<ConfigurationServiceGitProperty>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigurationServiceGitProperty>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConfigurationServiceGitProperty(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConfigurationServiceGitProperty)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConfigurationServiceGitProperty>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
