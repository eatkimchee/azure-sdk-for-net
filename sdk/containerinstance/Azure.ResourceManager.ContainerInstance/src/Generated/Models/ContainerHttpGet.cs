// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> The container Http Get settings, for liveness or readiness probe. </summary>
    public partial class ContainerHttpGet
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

        /// <summary> Initializes a new instance of <see cref="ContainerHttpGet"/>. </summary>
        /// <param name="port"> The port number to probe. </param>
        public ContainerHttpGet(int port)
        {
            Port = port;
            HttpHeaders = new ChangeTrackingList<ContainerHttpHeader>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerHttpGet"/>. </summary>
        /// <param name="path"> The path to probe. </param>
        /// <param name="port"> The port number to probe. </param>
        /// <param name="scheme"> The scheme. </param>
        /// <param name="httpHeaders"> The HTTP headers. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerHttpGet(string path, int port, ContainerHttpGetScheme? scheme, IList<ContainerHttpHeader> httpHeaders, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Path = path;
            Port = port;
            Scheme = scheme;
            HttpHeaders = httpHeaders;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerHttpGet"/> for deserialization. </summary>
        internal ContainerHttpGet()
        {
        }

        /// <summary> The path to probe. </summary>
        public string Path { get; set; }
        /// <summary> The port number to probe. </summary>
        public int Port { get; set; }
        /// <summary> The scheme. </summary>
        public ContainerHttpGetScheme? Scheme { get; set; }
        /// <summary> The HTTP headers. </summary>
        public IList<ContainerHttpHeader> HttpHeaders { get; }
    }
}
