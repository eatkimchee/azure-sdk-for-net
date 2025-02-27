// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.BillingBenefits.Models
{
    public partial class SavingsPlanValidateResult : IUtf8JsonSerializable, IJsonModel<SavingsPlanValidateResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SavingsPlanValidateResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SavingsPlanValidateResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SavingsPlanValidateResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SavingsPlanValidateResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (IsValid.HasValue)
            {
                writer.WritePropertyName("valid"u8);
                writer.WriteBooleanValue(IsValid.Value);
            }
            if (ReasonCode != null)
            {
                writer.WritePropertyName("reasonCode"u8);
                writer.WriteStringValue(ReasonCode);
            }
            if (Reason != null)
            {
                writer.WritePropertyName("reason"u8);
                writer.WriteStringValue(Reason);
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

        SavingsPlanValidateResult IJsonModel<SavingsPlanValidateResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SavingsPlanValidateResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SavingsPlanValidateResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSavingsPlanValidateResult(document.RootElement, options);
        }

        internal static SavingsPlanValidateResult DeserializeSavingsPlanValidateResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? valid = default;
            string reasonCode = default;
            string reason = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("valid"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valid = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("reasonCode"u8))
                {
                    reasonCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("reason"u8))
                {
                    reason = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SavingsPlanValidateResult(valid, reasonCode, reason, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SavingsPlanValidateResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SavingsPlanValidateResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SavingsPlanValidateResult)} does not support '{options.Format}' format.");
            }
        }

        SavingsPlanValidateResult IPersistableModel<SavingsPlanValidateResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SavingsPlanValidateResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSavingsPlanValidateResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SavingsPlanValidateResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SavingsPlanValidateResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
