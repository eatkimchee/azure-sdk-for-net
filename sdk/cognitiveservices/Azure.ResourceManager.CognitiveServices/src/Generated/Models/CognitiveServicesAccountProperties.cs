// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CognitiveServices;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> Properties of Cognitive Services account. </summary>
    public partial class CognitiveServicesAccountProperties
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

        /// <summary> Initializes a new instance of <see cref="CognitiveServicesAccountProperties"/>. </summary>
        public CognitiveServicesAccountProperties()
        {
            Capabilities = new ChangeTrackingList<CognitiveServicesSkuCapability>();
            UserOwnedStorage = new ChangeTrackingList<ServiceAccountUserOwnedStorage>();
            PrivateEndpointConnections = new ChangeTrackingList<CognitiveServicesPrivateEndpointConnectionData>();
            AllowedFqdnList = new ChangeTrackingList<string>();
            Endpoints = new ChangeTrackingDictionary<string, string>();
            CommitmentPlanAssociations = new ChangeTrackingList<CommitmentPlanAssociation>();
        }

        /// <summary> Initializes a new instance of <see cref="CognitiveServicesAccountProperties"/>. </summary>
        /// <param name="provisioningState"> Gets the status of the cognitive services account at the time the operation was called. </param>
        /// <param name="endpoint"> Endpoint of the created account. </param>
        /// <param name="capabilities"> Gets the capabilities of the cognitive services account. Each item indicates the capability of a specific feature. The values are read-only and for reference only. </param>
        /// <param name="isMigrated"> If the resource is migrated from an existing key. </param>
        /// <param name="migrationToken"> Resource migration token. </param>
        /// <param name="skuChangeInfo"> Sku change info of account. </param>
        /// <param name="customSubDomainName"> Optional subdomain name used for token-based authentication. </param>
        /// <param name="networkAcls"> A collection of rules governing the accessibility from specific network locations. </param>
        /// <param name="encryption"> The encryption properties for this resource. </param>
        /// <param name="userOwnedStorage"> The storage accounts for this resource. </param>
        /// <param name="privateEndpointConnections"> The private endpoint connection associated with the Cognitive Services account. </param>
        /// <param name="publicNetworkAccess"> Whether or not public endpoint access is allowed for this account. </param>
        /// <param name="apiProperties"> The api properties for special APIs. </param>
        /// <param name="createdOn"> Gets the date of cognitive services account creation. </param>
        /// <param name="callRateLimit"> The call rate limit Cognitive Services account. </param>
        /// <param name="enableDynamicThrottling"> The flag to enable dynamic throttling. </param>
        /// <param name="quotaLimit"></param>
        /// <param name="restrictOutboundNetworkAccess"></param>
        /// <param name="allowedFqdnList"></param>
        /// <param name="disableLocalAuth"></param>
        /// <param name="endpoints"> Dictionary of &lt;string&gt;. </param>
        /// <param name="restore"></param>
        /// <param name="deletedOn"> The deletion date, only available for deleted account. </param>
        /// <param name="scheduledPurgeDate"> The scheduled purge date, only available for deleted account. </param>
        /// <param name="locations"> The multiregion settings of Cognitive Services account. </param>
        /// <param name="commitmentPlanAssociations"> The commitment plan associations of Cognitive Services account. </param>
        /// <param name="abusePenalty"> The abuse penalty. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CognitiveServicesAccountProperties(ServiceAccountProvisioningState? provisioningState, string endpoint, IReadOnlyList<CognitiveServicesSkuCapability> capabilities, bool? isMigrated, string migrationToken, CognitiveServicesSkuChangeInfo skuChangeInfo, string customSubDomainName, CognitiveServicesNetworkRuleSet networkAcls, ServiceAccountEncryptionProperties encryption, IList<ServiceAccountUserOwnedStorage> userOwnedStorage, IReadOnlyList<CognitiveServicesPrivateEndpointConnectionData> privateEndpointConnections, ServiceAccountPublicNetworkAccess? publicNetworkAccess, ServiceAccountApiProperties apiProperties, DateTimeOffset? createdOn, ServiceAccountCallRateLimit callRateLimit, bool? enableDynamicThrottling, ServiceAccountQuotaLimit quotaLimit, bool? restrictOutboundNetworkAccess, IList<string> allowedFqdnList, bool? disableLocalAuth, IReadOnlyDictionary<string, string> endpoints, bool? restore, DateTimeOffset? deletedOn, string scheduledPurgeDate, CognitiveServicesMultiRegionSettings locations, IReadOnlyList<CommitmentPlanAssociation> commitmentPlanAssociations, AbusePenalty abusePenalty, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProvisioningState = provisioningState;
            Endpoint = endpoint;
            Capabilities = capabilities;
            IsMigrated = isMigrated;
            MigrationToken = migrationToken;
            SkuChangeInfo = skuChangeInfo;
            CustomSubDomainName = customSubDomainName;
            NetworkAcls = networkAcls;
            Encryption = encryption;
            UserOwnedStorage = userOwnedStorage;
            PrivateEndpointConnections = privateEndpointConnections;
            PublicNetworkAccess = publicNetworkAccess;
            ApiProperties = apiProperties;
            CreatedOn = createdOn;
            CallRateLimit = callRateLimit;
            EnableDynamicThrottling = enableDynamicThrottling;
            QuotaLimit = quotaLimit;
            RestrictOutboundNetworkAccess = restrictOutboundNetworkAccess;
            AllowedFqdnList = allowedFqdnList;
            DisableLocalAuth = disableLocalAuth;
            Endpoints = endpoints;
            Restore = restore;
            DeletedOn = deletedOn;
            ScheduledPurgeDate = scheduledPurgeDate;
            Locations = locations;
            CommitmentPlanAssociations = commitmentPlanAssociations;
            AbusePenalty = abusePenalty;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the status of the cognitive services account at the time the operation was called. </summary>
        public ServiceAccountProvisioningState? ProvisioningState { get; }
        /// <summary> Endpoint of the created account. </summary>
        public string Endpoint { get; }
        /// <summary> Gets the capabilities of the cognitive services account. Each item indicates the capability of a specific feature. The values are read-only and for reference only. </summary>
        public IReadOnlyList<CognitiveServicesSkuCapability> Capabilities { get; }
        /// <summary> If the resource is migrated from an existing key. </summary>
        public bool? IsMigrated { get; }
        /// <summary> Resource migration token. </summary>
        public string MigrationToken { get; set; }
        /// <summary> Sku change info of account. </summary>
        public CognitiveServicesSkuChangeInfo SkuChangeInfo { get; }
        /// <summary> Optional subdomain name used for token-based authentication. </summary>
        public string CustomSubDomainName { get; set; }
        /// <summary> A collection of rules governing the accessibility from specific network locations. </summary>
        public CognitiveServicesNetworkRuleSet NetworkAcls { get; set; }
        /// <summary> The encryption properties for this resource. </summary>
        public ServiceAccountEncryptionProperties Encryption { get; set; }
        /// <summary> The storage accounts for this resource. </summary>
        public IList<ServiceAccountUserOwnedStorage> UserOwnedStorage { get; }
        /// <summary> The private endpoint connection associated with the Cognitive Services account. </summary>
        public IReadOnlyList<CognitiveServicesPrivateEndpointConnectionData> PrivateEndpointConnections { get; }
        /// <summary> Whether or not public endpoint access is allowed for this account. </summary>
        public ServiceAccountPublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> The api properties for special APIs. </summary>
        public ServiceAccountApiProperties ApiProperties { get; set; }
        /// <summary> Gets the date of cognitive services account creation. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The call rate limit Cognitive Services account. </summary>
        public ServiceAccountCallRateLimit CallRateLimit { get; }
        /// <summary> The flag to enable dynamic throttling. </summary>
        public bool? EnableDynamicThrottling { get; set; }
        /// <summary> Gets the quota limit. </summary>
        public ServiceAccountQuotaLimit QuotaLimit { get; }
        /// <summary> Gets or sets the restrict outbound network access. </summary>
        public bool? RestrictOutboundNetworkAccess { get; set; }
        /// <summary> Gets the allowed fqdn list. </summary>
        public IList<string> AllowedFqdnList { get; }
        /// <summary> Gets or sets the disable local auth. </summary>
        public bool? DisableLocalAuth { get; set; }
        /// <summary> Dictionary of &lt;string&gt;. </summary>
        public IReadOnlyDictionary<string, string> Endpoints { get; }
        /// <summary> Gets or sets the restore. </summary>
        public bool? Restore { get; set; }
        /// <summary> The deletion date, only available for deleted account. </summary>
        public DateTimeOffset? DeletedOn { get; }
        /// <summary> The scheduled purge date, only available for deleted account. </summary>
        public string ScheduledPurgeDate { get; }
        /// <summary> The multiregion settings of Cognitive Services account. </summary>
        public CognitiveServicesMultiRegionSettings Locations { get; set; }
        /// <summary> The commitment plan associations of Cognitive Services account. </summary>
        public IReadOnlyList<CommitmentPlanAssociation> CommitmentPlanAssociations { get; }
        /// <summary> The abuse penalty. </summary>
        public AbusePenalty AbusePenalty { get; }
    }
}
