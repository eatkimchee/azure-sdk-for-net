// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;

namespace Azure.ResourceManager.Orbital.Models
{
    /// <summary> Customer End point to store/retrieve data during a contact. </summary>
    public partial class OrbitalContactEndpoint
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

        /// <summary> Initializes a new instance of <see cref="OrbitalContactEndpoint"/>. </summary>
        /// <param name="ipAddress"> IP Address. </param>
        /// <param name="endPointName"> Name of an end point. </param>
        /// <param name="port"> TCP port to listen on to receive data. </param>
        /// <param name="protocol"> Protocol either UDP or TCP. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ipAddress"/>, <paramref name="endPointName"/> or <paramref name="port"/> is null. </exception>
        public OrbitalContactEndpoint(IPAddress ipAddress, string endPointName, string port, OrbitalContactProtocol protocol)
        {
            if (ipAddress == null)
            {
                throw new ArgumentNullException(nameof(ipAddress));
            }
            if (endPointName == null)
            {
                throw new ArgumentNullException(nameof(endPointName));
            }
            if (port == null)
            {
                throw new ArgumentNullException(nameof(port));
            }

            IPAddress = ipAddress;
            EndPointName = endPointName;
            Port = port;
            Protocol = protocol;
        }

        /// <summary> Initializes a new instance of <see cref="OrbitalContactEndpoint"/>. </summary>
        /// <param name="ipAddress"> IP Address. </param>
        /// <param name="endPointName"> Name of an end point. </param>
        /// <param name="port"> TCP port to listen on to receive data. </param>
        /// <param name="protocol"> Protocol either UDP or TCP. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal OrbitalContactEndpoint(IPAddress ipAddress, string endPointName, string port, OrbitalContactProtocol protocol, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IPAddress = ipAddress;
            EndPointName = endPointName;
            Port = port;
            Protocol = protocol;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="OrbitalContactEndpoint"/> for deserialization. </summary>
        internal OrbitalContactEndpoint()
        {
        }

        /// <summary> IP Address. </summary>
        public IPAddress IPAddress { get; set; }
        /// <summary> Name of an end point. </summary>
        public string EndPointName { get; set; }
        /// <summary> TCP port to listen on to receive data. </summary>
        public string Port { get; set; }
        /// <summary> Protocol either UDP or TCP. </summary>
        public OrbitalContactProtocol Protocol { get; set; }
    }
}
