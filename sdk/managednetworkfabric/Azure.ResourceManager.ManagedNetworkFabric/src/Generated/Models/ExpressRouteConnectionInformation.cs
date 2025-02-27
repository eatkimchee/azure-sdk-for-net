// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> The ExpressRoute circuit ID and the Auth Key are required for you to successfully deploy NFC service. </summary>
    public partial class ExpressRouteConnectionInformation
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

        /// <summary> Initializes a new instance of <see cref="ExpressRouteConnectionInformation"/>. </summary>
        /// <param name="expressRouteCircuitId"> The express route circuit Azure resource ID, must be of type Microsoft.Network/expressRouteCircuits/circuitName. The ExpressRoute Circuit is a mandatory attribute. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="expressRouteCircuitId"/> is null. </exception>
        public ExpressRouteConnectionInformation(ResourceIdentifier expressRouteCircuitId)
        {
            if (expressRouteCircuitId == null)
            {
                throw new ArgumentNullException(nameof(expressRouteCircuitId));
            }

            ExpressRouteCircuitId = expressRouteCircuitId;
        }

        /// <summary> Initializes a new instance of <see cref="ExpressRouteConnectionInformation"/>. </summary>
        /// <param name="expressRouteCircuitId"> The express route circuit Azure resource ID, must be of type Microsoft.Network/expressRouteCircuits/circuitName. The ExpressRoute Circuit is a mandatory attribute. </param>
        /// <param name="expressRouteAuthorizationKey"> Authorization key for the circuit, must be of type Microsoft.Network/expressRouteCircuits/authorizations. The Auth Key is a mandatory attribute. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ExpressRouteConnectionInformation(ResourceIdentifier expressRouteCircuitId, string expressRouteAuthorizationKey, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ExpressRouteCircuitId = expressRouteCircuitId;
            ExpressRouteAuthorizationKey = expressRouteAuthorizationKey;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ExpressRouteConnectionInformation"/> for deserialization. </summary>
        internal ExpressRouteConnectionInformation()
        {
        }

        /// <summary> The express route circuit Azure resource ID, must be of type Microsoft.Network/expressRouteCircuits/circuitName. The ExpressRoute Circuit is a mandatory attribute. </summary>
        public ResourceIdentifier ExpressRouteCircuitId { get; set; }
        /// <summary> Authorization key for the circuit, must be of type Microsoft.Network/expressRouteCircuits/authorizations. The Auth Key is a mandatory attribute. </summary>
        public string ExpressRouteAuthorizationKey { get; set; }
    }
}
