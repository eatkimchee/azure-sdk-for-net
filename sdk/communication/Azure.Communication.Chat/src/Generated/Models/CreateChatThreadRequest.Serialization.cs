// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.Chat
{
    internal partial class CreateChatThreadRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("topic"u8);
            writer.WriteStringValue(Topic);
            if (!(Participants is ChangeTrackingList<ChatParticipantInternal> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("participants"u8);
                writer.WriteStartArray();
                foreach (var item in Participants)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
    }
}
