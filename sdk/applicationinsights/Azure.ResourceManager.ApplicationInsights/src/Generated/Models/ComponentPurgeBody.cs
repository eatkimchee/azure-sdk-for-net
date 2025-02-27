// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    /// <summary> Describes the body of a purge request for an App Insights component. </summary>
    public partial class ComponentPurgeBody
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

        /// <summary> Initializes a new instance of <see cref="ComponentPurgeBody"/>. </summary>
        /// <param name="table"> Table from which to purge data. </param>
        /// <param name="filters"> The set of columns and filters (queries) to run over them to purge the resulting data. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="table"/> or <paramref name="filters"/> is null. </exception>
        public ComponentPurgeBody(string table, IEnumerable<ComponentPurgeBodyFilters> filters)
        {
            if (table == null)
            {
                throw new ArgumentNullException(nameof(table));
            }
            if (filters == null)
            {
                throw new ArgumentNullException(nameof(filters));
            }

            Table = table;
            Filters = filters.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ComponentPurgeBody"/>. </summary>
        /// <param name="table"> Table from which to purge data. </param>
        /// <param name="filters"> The set of columns and filters (queries) to run over them to purge the resulting data. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ComponentPurgeBody(string table, IList<ComponentPurgeBodyFilters> filters, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Table = table;
            Filters = filters;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ComponentPurgeBody"/> for deserialization. </summary>
        internal ComponentPurgeBody()
        {
        }

        /// <summary> Table from which to purge data. </summary>
        public string Table { get; }
        /// <summary> The set of columns and filters (queries) to run over them to purge the resulting data. </summary>
        public IList<ComponentPurgeBodyFilters> Filters { get; }
    }
}
