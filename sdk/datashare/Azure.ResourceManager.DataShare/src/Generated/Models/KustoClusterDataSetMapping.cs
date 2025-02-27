// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataShare;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataShare.Models
{
    /// <summary> A Kusto cluster data set mapping. </summary>
    public partial class KustoClusterDataSetMapping : ShareDataSetMappingData
    {
        /// <summary> Initializes a new instance of <see cref="KustoClusterDataSetMapping"/>. </summary>
        /// <param name="dataSetId"> The id of the source data set. </param>
        /// <param name="kustoClusterResourceId"> Resource id of the sink kusto cluster. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="kustoClusterResourceId"/> is null. </exception>
        public KustoClusterDataSetMapping(Guid dataSetId, ResourceIdentifier kustoClusterResourceId)
        {
            if (kustoClusterResourceId == null)
            {
                throw new ArgumentNullException(nameof(kustoClusterResourceId));
            }

            DataSetId = dataSetId;
            KustoClusterResourceId = kustoClusterResourceId;
            Kind = DataSetMappingKind.KustoCluster;
        }

        /// <summary> Initializes a new instance of <see cref="KustoClusterDataSetMapping"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of data set mapping. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="dataSetId"> The id of the source data set. </param>
        /// <param name="dataSetMappingStatus"> Gets the status of the data set mapping. </param>
        /// <param name="kustoClusterResourceId"> Resource id of the sink kusto cluster. </param>
        /// <param name="location"> Location of the sink kusto cluster. </param>
        /// <param name="provisioningState"> Provisioning state of the data set mapping. </param>
        internal KustoClusterDataSetMapping(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DataSetMappingKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData, Guid dataSetId, DataSetMappingStatus? dataSetMappingStatus, ResourceIdentifier kustoClusterResourceId, AzureLocation? location, DataShareProvisioningState? provisioningState) : base(id, name, resourceType, systemData, kind, serializedAdditionalRawData)
        {
            DataSetId = dataSetId;
            DataSetMappingStatus = dataSetMappingStatus;
            KustoClusterResourceId = kustoClusterResourceId;
            Location = location;
            ProvisioningState = provisioningState;
            Kind = kind;
        }

        /// <summary> Initializes a new instance of <see cref="KustoClusterDataSetMapping"/> for deserialization. </summary>
        internal KustoClusterDataSetMapping()
        {
        }

        /// <summary> The id of the source data set. </summary>
        public Guid DataSetId { get; set; }
        /// <summary> Gets the status of the data set mapping. </summary>
        public DataSetMappingStatus? DataSetMappingStatus { get; }
        /// <summary> Resource id of the sink kusto cluster. </summary>
        public ResourceIdentifier KustoClusterResourceId { get; set; }
        /// <summary> Location of the sink kusto cluster. </summary>
        public AzureLocation? Location { get; }
        /// <summary> Provisioning state of the data set mapping. </summary>
        public DataShareProvisioningState? ProvisioningState { get; }
    }
}
