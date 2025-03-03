// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    /// <summary> Query results. </summary>
    internal partial class PolicyStatesQueryResults
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

        /// <summary> Initializes a new instance of <see cref="PolicyStatesQueryResults"/>. </summary>
        internal PolicyStatesQueryResults()
        {
            Value = new ChangeTrackingList<PolicyState>();
        }

        /// <summary> Initializes a new instance of <see cref="PolicyStatesQueryResults"/>. </summary>
        /// <param name="odataContext"> OData context string; used by OData clients to resolve type information based on metadata. </param>
        /// <param name="odataCount"> OData entity count; represents the number of policy state records returned. </param>
        /// <param name="odataNextLink"> Odata next link; URL to get the next set of results. </param>
        /// <param name="value"> Query results. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PolicyStatesQueryResults(string odataContext, int? odataCount, string odataNextLink, IReadOnlyList<PolicyState> value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ODataContext = odataContext;
            ODataCount = odataCount;
            ODataNextLink = odataNextLink;
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> OData context string; used by OData clients to resolve type information based on metadata. </summary>
        public string ODataContext { get; }
        /// <summary> OData entity count; represents the number of policy state records returned. </summary>
        public int? ODataCount { get; }
        /// <summary> Odata next link; URL to get the next set of results. </summary>
        public string ODataNextLink { get; }
        /// <summary> Query results. </summary>
        public IReadOnlyList<PolicyState> Value { get; }
    }
}
