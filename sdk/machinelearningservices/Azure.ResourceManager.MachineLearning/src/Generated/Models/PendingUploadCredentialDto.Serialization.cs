// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    [PersistableModelProxy(typeof(UnknownPendingUploadCredentialDto))]
    public partial class PendingUploadCredentialDto : IUtf8JsonSerializable, IJsonModel<PendingUploadCredentialDto>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PendingUploadCredentialDto>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PendingUploadCredentialDto>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PendingUploadCredentialDto>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PendingUploadCredentialDto)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("credentialType"u8);
            writer.WriteStringValue(CredentialType.ToString());
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

        PendingUploadCredentialDto IJsonModel<PendingUploadCredentialDto>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PendingUploadCredentialDto>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PendingUploadCredentialDto)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePendingUploadCredentialDto(document.RootElement, options);
        }

        internal static PendingUploadCredentialDto DeserializePendingUploadCredentialDto(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("credentialType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "SAS": return SasCredentialDto.DeserializeSasCredentialDto(element, options);
                }
            }
            return UnknownPendingUploadCredentialDto.DeserializeUnknownPendingUploadCredentialDto(element, options);
        }

        BinaryData IPersistableModel<PendingUploadCredentialDto>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PendingUploadCredentialDto>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PendingUploadCredentialDto)} does not support '{options.Format}' format.");
            }
        }

        PendingUploadCredentialDto IPersistableModel<PendingUploadCredentialDto>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PendingUploadCredentialDto>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePendingUploadCredentialDto(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PendingUploadCredentialDto)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PendingUploadCredentialDto>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
