// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A database operation. </summary>
    public partial class DatabaseOperationData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="DatabaseOperationData"/>. </summary>
        public DatabaseOperationData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DatabaseOperationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="databaseName"> The name of the database the operation is being performed on. </param>
        /// <param name="operation"> The name of operation. </param>
        /// <param name="operationFriendlyName"> The friendly name of operation. </param>
        /// <param name="percentComplete"> The percentage of the operation completed. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="startOn"> The operation start time. </param>
        /// <param name="state"> The operation state. </param>
        /// <param name="errorCode"> The operation error code. </param>
        /// <param name="errorDescription"> The operation error description. </param>
        /// <param name="errorSeverity"> The operation error severity. </param>
        /// <param name="isUserError"> Whether or not the error is a user error. </param>
        /// <param name="estimatedCompleteOn"> The estimated completion time of the operation. </param>
        /// <param name="description"> The operation description. </param>
        /// <param name="isCancellable"> Whether the operation can be cancelled. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DatabaseOperationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string databaseName, string operation, string operationFriendlyName, int? percentComplete, string serverName, DateTimeOffset? startOn, ManagementOperationState? state, int? errorCode, string errorDescription, int? errorSeverity, bool? isUserError, DateTimeOffset? estimatedCompleteOn, string description, bool? isCancellable, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            DatabaseName = databaseName;
            Operation = operation;
            OperationFriendlyName = operationFriendlyName;
            PercentComplete = percentComplete;
            ServerName = serverName;
            StartOn = startOn;
            State = state;
            ErrorCode = errorCode;
            ErrorDescription = errorDescription;
            ErrorSeverity = errorSeverity;
            IsUserError = isUserError;
            EstimatedCompleteOn = estimatedCompleteOn;
            Description = description;
            IsCancellable = isCancellable;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the database the operation is being performed on. </summary>
        public string DatabaseName { get; }
        /// <summary> The name of operation. </summary>
        public string Operation { get; }
        /// <summary> The friendly name of operation. </summary>
        public string OperationFriendlyName { get; }
        /// <summary> The percentage of the operation completed. </summary>
        public int? PercentComplete { get; }
        /// <summary> The name of the server. </summary>
        public string ServerName { get; }
        /// <summary> The operation start time. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> The operation state. </summary>
        public ManagementOperationState? State { get; }
        /// <summary> The operation error code. </summary>
        public int? ErrorCode { get; }
        /// <summary> The operation error description. </summary>
        public string ErrorDescription { get; }
        /// <summary> The operation error severity. </summary>
        public int? ErrorSeverity { get; }
        /// <summary> Whether or not the error is a user error. </summary>
        public bool? IsUserError { get; }
        /// <summary> The estimated completion time of the operation. </summary>
        public DateTimeOffset? EstimatedCompleteOn { get; }
        /// <summary> The operation description. </summary>
        public string Description { get; }
        /// <summary> Whether the operation can be cancelled. </summary>
        public bool? IsCancellable { get; }
    }
}
