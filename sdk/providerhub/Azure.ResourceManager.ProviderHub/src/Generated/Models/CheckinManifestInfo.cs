// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The CheckinManifestInfo. </summary>
    public partial class CheckinManifestInfo
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CheckinManifestInfo"/>. </summary>
        /// <param name="isCheckedIn"></param>
        /// <param name="statusMessage"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="statusMessage"/> is null. </exception>
        internal CheckinManifestInfo(bool isCheckedIn, string statusMessage)
        {
            if (statusMessage == null)
            {
                throw new ArgumentNullException(nameof(statusMessage));
            }

            IsCheckedIn = isCheckedIn;
            StatusMessage = statusMessage;
        }

        /// <summary> Initializes a new instance of <see cref="CheckinManifestInfo"/>. </summary>
        /// <param name="isCheckedIn"></param>
        /// <param name="statusMessage"></param>
        /// <param name="pullRequest"></param>
        /// <param name="commitId"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CheckinManifestInfo(bool isCheckedIn, string statusMessage, string pullRequest, string commitId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsCheckedIn = isCheckedIn;
            StatusMessage = statusMessage;
            PullRequest = pullRequest;
            CommitId = commitId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CheckinManifestInfo"/> for deserialization. </summary>
        internal CheckinManifestInfo()
        {
        }

        /// <summary> Gets the is checked in. </summary>
        public bool IsCheckedIn { get; }
        /// <summary> Gets the status message. </summary>
        public string StatusMessage { get; }
        /// <summary> Gets the pull request. </summary>
        public string PullRequest { get; }
        /// <summary> Gets the commit id. </summary>
        public string CommitId { get; }
    }
}
