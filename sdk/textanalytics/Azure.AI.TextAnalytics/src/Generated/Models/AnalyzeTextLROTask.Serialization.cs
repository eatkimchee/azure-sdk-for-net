// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class AnalyzeTextLROTask : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (TaskName != null)
            {
                writer.WritePropertyName("taskName"u8);
                writer.WriteStringValue(TaskName);
            }
            writer.WriteEndObject();
        }

        internal static AnalyzeTextLROTask DeserializeAnalyzeTextLROTask(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AbstractiveSummarization": return AbstractiveSummarizationLROTask.DeserializeAbstractiveSummarizationLROTask(element);
                    case "CustomEntityRecognition": return CustomEntitiesLROTask.DeserializeCustomEntitiesLROTask(element);
                    case "CustomMultiLabelClassification": return CustomMultiLabelClassificationLROTask.DeserializeCustomMultiLabelClassificationLROTask(element);
                    case "CustomSingleLabelClassification": return CustomSingleLabelClassificationLROTask.DeserializeCustomSingleLabelClassificationLROTask(element);
                    case "EntityLinking": return EntityLinkingLROTask.DeserializeEntityLinkingLROTask(element);
                    case "EntityRecognition": return EntitiesLROTask.DeserializeEntitiesLROTask(element);
                    case "ExtractiveSummarization": return ExtractiveSummarizationLROTask.DeserializeExtractiveSummarizationLROTask(element);
                    case "Healthcare": return HealthcareLROTask.DeserializeHealthcareLROTask(element);
                    case "KeyPhraseExtraction": return KeyPhraseLROTask.DeserializeKeyPhraseLROTask(element);
                    case "PiiEntityRecognition": return PiiLROTask.DeserializePiiLROTask(element);
                    case "SentimentAnalysis": return SentimentAnalysisLROTask.DeserializeSentimentAnalysisLROTask(element);
                }
            }
            return UnknownAnalyzeTextLROTask.DeserializeUnknownAnalyzeTextLROTask(element);
        }
    }
}
