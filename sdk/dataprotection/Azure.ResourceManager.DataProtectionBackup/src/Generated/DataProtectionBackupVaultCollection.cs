// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DataProtectionBackup
{
    /// <summary>
    /// A class representing a collection of <see cref="DataProtectionBackupVaultResource"/> and their operations.
    /// Each <see cref="DataProtectionBackupVaultResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="DataProtectionBackupVaultCollection"/> instance call the GetDataProtectionBackupVaults method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class DataProtectionBackupVaultCollection : ArmCollection, IEnumerable<DataProtectionBackupVaultResource>, IAsyncEnumerable<DataProtectionBackupVaultResource>
    {
        private readonly ClientDiagnostics _dataProtectionBackupVaultBackupVaultsClientDiagnostics;
        private readonly BackupVaultsRestOperations _dataProtectionBackupVaultBackupVaultsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataProtectionBackupVaultCollection"/> class for mocking. </summary>
        protected DataProtectionBackupVaultCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataProtectionBackupVaultCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DataProtectionBackupVaultCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataProtectionBackupVaultBackupVaultsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataProtectionBackup", DataProtectionBackupVaultResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DataProtectionBackupVaultResource.ResourceType, out string dataProtectionBackupVaultBackupVaultsApiVersion);
            _dataProtectionBackupVaultBackupVaultsRestClient = new BackupVaultsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataProtectionBackupVaultBackupVaultsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a BackupVault resource belonging to a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupVaults_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataProtectionBackupVaultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="vaultName"> The name of the backup vault. </param>
        /// <param name="data"> Request body for operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DataProtectionBackupVaultResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string vaultName, DataProtectionBackupVaultData data, CancellationToken cancellationToken = default)
        {
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (vaultName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(vaultName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _dataProtectionBackupVaultBackupVaultsClientDiagnostics.CreateScope("DataProtectionBackupVaultCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dataProtectionBackupVaultBackupVaultsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, vaultName, data, cancellationToken).ConfigureAwait(false);
                var operation = new DataProtectionBackupArmOperation<DataProtectionBackupVaultResource>(new DataProtectionBackupVaultOperationSource(Client), _dataProtectionBackupVaultBackupVaultsClientDiagnostics, Pipeline, _dataProtectionBackupVaultBackupVaultsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, vaultName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a BackupVault resource belonging to a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupVaults_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataProtectionBackupVaultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="vaultName"> The name of the backup vault. </param>
        /// <param name="data"> Request body for operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DataProtectionBackupVaultResource> CreateOrUpdate(WaitUntil waitUntil, string vaultName, DataProtectionBackupVaultData data, CancellationToken cancellationToken = default)
        {
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (vaultName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(vaultName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _dataProtectionBackupVaultBackupVaultsClientDiagnostics.CreateScope("DataProtectionBackupVaultCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dataProtectionBackupVaultBackupVaultsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, vaultName, data, cancellationToken);
                var operation = new DataProtectionBackupArmOperation<DataProtectionBackupVaultResource>(new DataProtectionBackupVaultOperationSource(Client), _dataProtectionBackupVaultBackupVaultsClientDiagnostics, Pipeline, _dataProtectionBackupVaultBackupVaultsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, vaultName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a resource belonging to a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupVaults_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataProtectionBackupVaultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vaultName"> The name of the backup vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> is null. </exception>
        public virtual async Task<Response<DataProtectionBackupVaultResource>> GetAsync(string vaultName, CancellationToken cancellationToken = default)
        {
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (vaultName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(vaultName));
            }

            using var scope = _dataProtectionBackupVaultBackupVaultsClientDiagnostics.CreateScope("DataProtectionBackupVaultCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataProtectionBackupVaultBackupVaultsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, vaultName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataProtectionBackupVaultResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a resource belonging to a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupVaults_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataProtectionBackupVaultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vaultName"> The name of the backup vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> is null. </exception>
        public virtual Response<DataProtectionBackupVaultResource> Get(string vaultName, CancellationToken cancellationToken = default)
        {
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (vaultName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(vaultName));
            }

            using var scope = _dataProtectionBackupVaultBackupVaultsClientDiagnostics.CreateScope("DataProtectionBackupVaultCollection.Get");
            scope.Start();
            try
            {
                var response = _dataProtectionBackupVaultBackupVaultsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, vaultName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataProtectionBackupVaultResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns resource collection belonging to a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupVaults_GetInResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataProtectionBackupVaultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataProtectionBackupVaultResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataProtectionBackupVaultResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataProtectionBackupVaultBackupVaultsRestClient.CreateGetInResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataProtectionBackupVaultBackupVaultsRestClient.CreateGetInResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DataProtectionBackupVaultResource(Client, DataProtectionBackupVaultData.DeserializeDataProtectionBackupVaultData(e)), _dataProtectionBackupVaultBackupVaultsClientDiagnostics, Pipeline, "DataProtectionBackupVaultCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns resource collection belonging to a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupVaults_GetInResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataProtectionBackupVaultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataProtectionBackupVaultResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataProtectionBackupVaultResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataProtectionBackupVaultBackupVaultsRestClient.CreateGetInResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataProtectionBackupVaultBackupVaultsRestClient.CreateGetInResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DataProtectionBackupVaultResource(Client, DataProtectionBackupVaultData.DeserializeDataProtectionBackupVaultData(e)), _dataProtectionBackupVaultBackupVaultsClientDiagnostics, Pipeline, "DataProtectionBackupVaultCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupVaults_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataProtectionBackupVaultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vaultName"> The name of the backup vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string vaultName, CancellationToken cancellationToken = default)
        {
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (vaultName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(vaultName));
            }

            using var scope = _dataProtectionBackupVaultBackupVaultsClientDiagnostics.CreateScope("DataProtectionBackupVaultCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dataProtectionBackupVaultBackupVaultsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, vaultName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupVaults_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataProtectionBackupVaultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vaultName"> The name of the backup vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> is null. </exception>
        public virtual Response<bool> Exists(string vaultName, CancellationToken cancellationToken = default)
        {
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (vaultName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(vaultName));
            }

            using var scope = _dataProtectionBackupVaultBackupVaultsClientDiagnostics.CreateScope("DataProtectionBackupVaultCollection.Exists");
            scope.Start();
            try
            {
                var response = _dataProtectionBackupVaultBackupVaultsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, vaultName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupVaults_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataProtectionBackupVaultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vaultName"> The name of the backup vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> is null. </exception>
        public virtual async Task<NullableResponse<DataProtectionBackupVaultResource>> GetIfExistsAsync(string vaultName, CancellationToken cancellationToken = default)
        {
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (vaultName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(vaultName));
            }

            using var scope = _dataProtectionBackupVaultBackupVaultsClientDiagnostics.CreateScope("DataProtectionBackupVaultCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _dataProtectionBackupVaultBackupVaultsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, vaultName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DataProtectionBackupVaultResource>(response.GetRawResponse());
                return Response.FromValue(new DataProtectionBackupVaultResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupVaults_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataProtectionBackupVaultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vaultName"> The name of the backup vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> is null. </exception>
        public virtual NullableResponse<DataProtectionBackupVaultResource> GetIfExists(string vaultName, CancellationToken cancellationToken = default)
        {
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (vaultName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(vaultName));
            }

            using var scope = _dataProtectionBackupVaultBackupVaultsClientDiagnostics.CreateScope("DataProtectionBackupVaultCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _dataProtectionBackupVaultBackupVaultsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, vaultName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DataProtectionBackupVaultResource>(response.GetRawResponse());
                return Response.FromValue(new DataProtectionBackupVaultResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DataProtectionBackupVaultResource> IEnumerable<DataProtectionBackupVaultResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DataProtectionBackupVaultResource> IAsyncEnumerable<DataProtectionBackupVaultResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
