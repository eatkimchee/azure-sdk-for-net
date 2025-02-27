// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Communication;

namespace Azure.Communication.Chat
{
    /// <summary> Chat thread. </summary>
    internal partial class ChatThreadPropertiesInternal
    {
        /// <summary> Initializes a new instance of <see cref="ChatThreadPropertiesInternal"/>. </summary>
        /// <param name="id"> Chat thread id. </param>
        /// <param name="topic"> Chat thread topic. </param>
        /// <param name="createdOn"> The timestamp when the chat thread was created. The timestamp is in RFC3339 format: `yyyy-MM-ddTHH:mm:ssZ`. </param>
        /// <param name="createdByCommunicationIdentifier"> Identifies a participant in Azure Communication services. A participant is, for example, a phone number or an Azure communication user. This model is polymorphic: Apart from kind and rawId, at most one further property may be set which must match the kind enum value. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="topic"/> or <paramref name="createdByCommunicationIdentifier"/> is null. </exception>
        internal ChatThreadPropertiesInternal(string id, string topic, DateTimeOffset createdOn, CommunicationIdentifierModel createdByCommunicationIdentifier)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (topic == null)
            {
                throw new ArgumentNullException(nameof(topic));
            }
            if (createdByCommunicationIdentifier == null)
            {
                throw new ArgumentNullException(nameof(createdByCommunicationIdentifier));
            }

            Id = id;
            Topic = topic;
            CreatedOn = createdOn;
            CreatedByCommunicationIdentifier = createdByCommunicationIdentifier;
        }

        /// <summary> Initializes a new instance of <see cref="ChatThreadPropertiesInternal"/>. </summary>
        /// <param name="id"> Chat thread id. </param>
        /// <param name="topic"> Chat thread topic. </param>
        /// <param name="createdOn"> The timestamp when the chat thread was created. The timestamp is in RFC3339 format: `yyyy-MM-ddTHH:mm:ssZ`. </param>
        /// <param name="createdByCommunicationIdentifier"> Identifies a participant in Azure Communication services. A participant is, for example, a phone number or an Azure communication user. This model is polymorphic: Apart from kind and rawId, at most one further property may be set which must match the kind enum value. </param>
        /// <param name="deletedOn"> The timestamp when the chat thread was deleted. The timestamp is in RFC3339 format: `yyyy-MM-ddTHH:mm:ssZ`. </param>
        internal ChatThreadPropertiesInternal(string id, string topic, DateTimeOffset createdOn, CommunicationIdentifierModel createdByCommunicationIdentifier, DateTimeOffset? deletedOn)
        {
            Id = id;
            Topic = topic;
            CreatedOn = createdOn;
            CreatedByCommunicationIdentifier = createdByCommunicationIdentifier;
            DeletedOn = deletedOn;
        }

        /// <summary> Chat thread id. </summary>
        public string Id { get; }
        /// <summary> Chat thread topic. </summary>
        public string Topic { get; }
        /// <summary> The timestamp when the chat thread was created. The timestamp is in RFC3339 format: `yyyy-MM-ddTHH:mm:ssZ`. </summary>
        public DateTimeOffset CreatedOn { get; }
        /// <summary> Identifies a participant in Azure Communication services. A participant is, for example, a phone number or an Azure communication user. This model is polymorphic: Apart from kind and rawId, at most one further property may be set which must match the kind enum value. </summary>
        public CommunicationIdentifierModel CreatedByCommunicationIdentifier { get; }
        /// <summary> The timestamp when the chat thread was deleted. The timestamp is in RFC3339 format: `yyyy-MM-ddTHH:mm:ssZ`. </summary>
        public DateTimeOffset? DeletedOn { get; }
    }
}
