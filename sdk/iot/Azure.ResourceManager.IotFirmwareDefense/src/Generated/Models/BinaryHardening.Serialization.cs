// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotFirmwareDefense.Models
{
    public partial class BinaryHardening : IUtf8JsonSerializable, IJsonModel<BinaryHardening>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BinaryHardening>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BinaryHardening>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BinaryHardening>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BinaryHardening)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (BinaryHardeningId != null)
            {
                if (BinaryHardeningId != null)
                {
                    writer.WritePropertyName("binaryHardeningId"u8);
                    writer.WriteStringValue(BinaryHardeningId);
                }
                else
                {
                    writer.WriteNull("binaryHardeningId");
                }
            }
            if (Architecture != null)
            {
                if (Architecture != null)
                {
                    writer.WritePropertyName("architecture"u8);
                    writer.WriteStringValue(Architecture);
                }
                else
                {
                    writer.WriteNull("architecture");
                }
            }
            if (Path != null)
            {
                if (Path != null)
                {
                    writer.WritePropertyName("path"u8);
                    writer.WriteStringValue(Path);
                }
                else
                {
                    writer.WriteNull("path");
                }
            }
            if (Class != null)
            {
                if (Class != null)
                {
                    writer.WritePropertyName("class"u8);
                    writer.WriteStringValue(Class);
                }
                else
                {
                    writer.WriteNull("class");
                }
            }
            if (Runpath != null)
            {
                if (Runpath != null)
                {
                    writer.WritePropertyName("runpath"u8);
                    writer.WriteStringValue(Runpath);
                }
                else
                {
                    writer.WriteNull("runpath");
                }
            }
            if (Rpath != null)
            {
                if (Rpath != null)
                {
                    writer.WritePropertyName("rpath"u8);
                    writer.WriteStringValue(Rpath);
                }
                else
                {
                    writer.WriteNull("rpath");
                }
            }
            writer.WritePropertyName("features"u8);
            writer.WriteStartObject();
            if (Nx.HasValue)
            {
                writer.WritePropertyName("nx"u8);
                writer.WriteStringValue(Nx.Value.ToString());
            }
            if (Pie.HasValue)
            {
                writer.WritePropertyName("pie"u8);
                writer.WriteStringValue(Pie.Value.ToString());
            }
            if (Relro.HasValue)
            {
                writer.WritePropertyName("relro"u8);
                writer.WriteStringValue(Relro.Value.ToString());
            }
            if (Canary.HasValue)
            {
                writer.WritePropertyName("canary"u8);
                writer.WriteStringValue(Canary.Value.ToString());
            }
            if (Stripped.HasValue)
            {
                writer.WritePropertyName("stripped"u8);
                writer.WriteStringValue(Stripped.Value.ToString());
            }
            writer.WriteEndObject();
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

        BinaryHardening IJsonModel<BinaryHardening>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BinaryHardening>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BinaryHardening)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBinaryHardening(document.RootElement, options);
        }

        internal static BinaryHardening DeserializeBinaryHardening(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string binaryHardeningId = default;
            string architecture = default;
            string path = default;
            string @class = default;
            string runpath = default;
            string rpath = default;
            NxFlag? nx = default;
            PieFlag? pie = default;
            RelroFlag? relro = default;
            CanaryFlag? canary = default;
            StrippedFlag? stripped = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("binaryHardeningId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        binaryHardeningId = null;
                        continue;
                    }
                    binaryHardeningId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("architecture"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        architecture = null;
                        continue;
                    }
                    architecture = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("path"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        path = null;
                        continue;
                    }
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("class"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        @class = null;
                        continue;
                    }
                    @class = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runpath"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        runpath = null;
                        continue;
                    }
                    runpath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rpath"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        rpath = null;
                        continue;
                    }
                    rpath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("features"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("nx"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nx = new NxFlag(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("pie"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            pie = new PieFlag(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("relro"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            relro = new RelroFlag(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("canary"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            canary = new CanaryFlag(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("stripped"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            stripped = new StrippedFlag(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BinaryHardening(
                binaryHardeningId,
                architecture,
                path,
                @class,
                runpath,
                rpath,
                nx,
                pie,
                relro,
                canary,
                stripped,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BinaryHardening>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BinaryHardening>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BinaryHardening)} does not support '{options.Format}' format.");
            }
        }

        BinaryHardening IPersistableModel<BinaryHardening>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BinaryHardening>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBinaryHardening(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BinaryHardening)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BinaryHardening>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
