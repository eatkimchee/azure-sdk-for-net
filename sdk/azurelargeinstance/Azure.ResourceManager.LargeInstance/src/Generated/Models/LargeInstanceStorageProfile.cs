// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.LargeInstance.Models
{
    /// <summary> Specifies the storage settings for the Azure Large Instance disks. </summary>
    public partial class LargeInstanceStorageProfile
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

        /// <summary> Initializes a new instance of <see cref="LargeInstanceStorageProfile"/>. </summary>
        internal LargeInstanceStorageProfile()
        {
            OSDisks = new ChangeTrackingList<LargeInstanceDisk>();
        }

        /// <summary> Initializes a new instance of <see cref="LargeInstanceStorageProfile"/>. </summary>
        /// <param name="nfsIPAddress"> IP Address to connect to storage. </param>
        /// <param name="osDisks">
        /// Specifies information about the operating system disk used by Azure Large
        /// Instance.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LargeInstanceStorageProfile(string nfsIPAddress, IReadOnlyList<LargeInstanceDisk> osDisks, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NfsIPAddress = nfsIPAddress;
            OSDisks = osDisks;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> IP Address to connect to storage. </summary>
        public string NfsIPAddress { get; }
        /// <summary>
        /// Specifies information about the operating system disk used by Azure Large
        /// Instance.
        /// </summary>
        public IReadOnlyList<LargeInstanceDisk> OSDisks { get; }
    }
}
