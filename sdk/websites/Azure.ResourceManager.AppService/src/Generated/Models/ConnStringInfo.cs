// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Database connection string information. </summary>
    public partial class ConnStringInfo
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

        /// <summary> Initializes a new instance of <see cref="ConnStringInfo"/>. </summary>
        public ConnStringInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ConnStringInfo"/>. </summary>
        /// <param name="name"> Name of connection string. </param>
        /// <param name="connectionString"> Connection string value. </param>
        /// <param name="connectionStringType"> Type of database. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConnStringInfo(string name, string connectionString, ConnectionStringType? connectionStringType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            ConnectionString = connectionString;
            ConnectionStringType = connectionStringType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Name of connection string. </summary>
        public string Name { get; set; }
        /// <summary> Connection string value. </summary>
        public string ConnectionString { get; set; }
        /// <summary> Type of database. </summary>
        public ConnectionStringType? ConnectionStringType { get; set; }
    }
}
