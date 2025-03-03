// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> A inbound NAT pool that can be used to address specific ports on compute nodes in a Batch pool externally. </summary>
    public partial class BatchInboundNatPool
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

        /// <summary> Initializes a new instance of <see cref="BatchInboundNatPool"/>. </summary>
        /// <param name="name"> The name must be unique within a Batch pool, can contain letters, numbers, underscores, periods, and hyphens. Names must start with a letter or number, must end with a letter, number, or underscore, and cannot exceed 77 characters.  If any invalid values are provided the request fails with HTTP status code 400. </param>
        /// <param name="protocol"> The protocol of the endpoint. </param>
        /// <param name="backendPort"> This must be unique within a Batch pool. Acceptable values are between 1 and 65535 except for 22, 3389, 29876 and 29877 as these are reserved. If any reserved values are provided the request fails with HTTP status code 400. </param>
        /// <param name="frontendPortRangeStart"> Acceptable values range between 1 and 65534 except ports from 50000 to 55000 which are reserved. All ranges within a pool must be distinct and cannot overlap. If any reserved or overlapping values are provided the request fails with HTTP status code 400. </param>
        /// <param name="frontendPortRangeEnd"> Acceptable values range between 1 and 65534 except ports from 50000 to 55000 which are reserved by the Batch service. All ranges within a pool must be distinct and cannot overlap. If any reserved or overlapping values are provided the request fails with HTTP status code 400. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public BatchInboundNatPool(string name, BatchInboundEndpointProtocol protocol, int backendPort, int frontendPortRangeStart, int frontendPortRangeEnd)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
            Protocol = protocol;
            BackendPort = backendPort;
            FrontendPortRangeStart = frontendPortRangeStart;
            FrontendPortRangeEnd = frontendPortRangeEnd;
            NetworkSecurityGroupRules = new ChangeTrackingList<BatchNetworkSecurityGroupRule>();
        }

        /// <summary> Initializes a new instance of <see cref="BatchInboundNatPool"/>. </summary>
        /// <param name="name"> The name must be unique within a Batch pool, can contain letters, numbers, underscores, periods, and hyphens. Names must start with a letter or number, must end with a letter, number, or underscore, and cannot exceed 77 characters.  If any invalid values are provided the request fails with HTTP status code 400. </param>
        /// <param name="protocol"> The protocol of the endpoint. </param>
        /// <param name="backendPort"> This must be unique within a Batch pool. Acceptable values are between 1 and 65535 except for 22, 3389, 29876 and 29877 as these are reserved. If any reserved values are provided the request fails with HTTP status code 400. </param>
        /// <param name="frontendPortRangeStart"> Acceptable values range between 1 and 65534 except ports from 50000 to 55000 which are reserved. All ranges within a pool must be distinct and cannot overlap. If any reserved or overlapping values are provided the request fails with HTTP status code 400. </param>
        /// <param name="frontendPortRangeEnd"> Acceptable values range between 1 and 65534 except ports from 50000 to 55000 which are reserved by the Batch service. All ranges within a pool must be distinct and cannot overlap. If any reserved or overlapping values are provided the request fails with HTTP status code 400. </param>
        /// <param name="networkSecurityGroupRules"> The maximum number of rules that can be specified across all the endpoints on a Batch pool is 25. If no network security group rules are specified, a default rule will be created to allow inbound access to the specified backendPort. If the maximum number of network security group rules is exceeded the request fails with HTTP status code 400. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchInboundNatPool(string name, BatchInboundEndpointProtocol protocol, int backendPort, int frontendPortRangeStart, int frontendPortRangeEnd, IList<BatchNetworkSecurityGroupRule> networkSecurityGroupRules, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Protocol = protocol;
            BackendPort = backendPort;
            FrontendPortRangeStart = frontendPortRangeStart;
            FrontendPortRangeEnd = frontendPortRangeEnd;
            NetworkSecurityGroupRules = networkSecurityGroupRules;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BatchInboundNatPool"/> for deserialization. </summary>
        internal BatchInboundNatPool()
        {
        }

        /// <summary> The name must be unique within a Batch pool, can contain letters, numbers, underscores, periods, and hyphens. Names must start with a letter or number, must end with a letter, number, or underscore, and cannot exceed 77 characters.  If any invalid values are provided the request fails with HTTP status code 400. </summary>
        public string Name { get; set; }
        /// <summary> The protocol of the endpoint. </summary>
        public BatchInboundEndpointProtocol Protocol { get; set; }
        /// <summary> This must be unique within a Batch pool. Acceptable values are between 1 and 65535 except for 22, 3389, 29876 and 29877 as these are reserved. If any reserved values are provided the request fails with HTTP status code 400. </summary>
        public int BackendPort { get; set; }
        /// <summary> Acceptable values range between 1 and 65534 except ports from 50000 to 55000 which are reserved. All ranges within a pool must be distinct and cannot overlap. If any reserved or overlapping values are provided the request fails with HTTP status code 400. </summary>
        public int FrontendPortRangeStart { get; set; }
        /// <summary> Acceptable values range between 1 and 65534 except ports from 50000 to 55000 which are reserved by the Batch service. All ranges within a pool must be distinct and cannot overlap. If any reserved or overlapping values are provided the request fails with HTTP status code 400. </summary>
        public int FrontendPortRangeEnd { get; set; }
        /// <summary> The maximum number of rules that can be specified across all the endpoints on a Batch pool is 25. If no network security group rules are specified, a default rule will be created to allow inbound access to the specified backendPort. If the maximum number of network security group rules is exceeded the request fails with HTTP status code 400. </summary>
        public IList<BatchNetworkSecurityGroupRule> NetworkSecurityGroupRules { get; }
    }
}
