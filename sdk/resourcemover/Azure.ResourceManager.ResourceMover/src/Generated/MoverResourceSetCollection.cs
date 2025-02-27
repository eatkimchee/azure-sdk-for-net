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

namespace Azure.ResourceManager.ResourceMover
{
    /// <summary>
    /// A class representing a collection of <see cref="MoverResourceSetResource"/> and their operations.
    /// Each <see cref="MoverResourceSetResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="MoverResourceSetCollection"/> instance call the GetMoverResourceSets method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class MoverResourceSetCollection : ArmCollection, IEnumerable<MoverResourceSetResource>, IAsyncEnumerable<MoverResourceSetResource>
    {
        private readonly ClientDiagnostics _moverResourceSetMoveCollectionsClientDiagnostics;
        private readonly MoveCollectionsRestOperations _moverResourceSetMoveCollectionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MoverResourceSetCollection"/> class for mocking. </summary>
        protected MoverResourceSetCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MoverResourceSetCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MoverResourceSetCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _moverResourceSetMoveCollectionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ResourceMover", MoverResourceSetResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MoverResourceSetResource.ResourceType, out string moverResourceSetMoveCollectionsApiVersion);
            _moverResourceSetMoveCollectionsRestClient = new MoveCollectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, moverResourceSetMoveCollectionsApiVersion);
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
        /// Creates or updates a move collection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/moveCollections/{moveCollectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MoveCollections_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MoverResourceSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="moverResourceSetName"> The Move Collection Name. </param>
        /// <param name="data"> The <see cref="MoverResourceSetData"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="moverResourceSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="moverResourceSetName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MoverResourceSetResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string moverResourceSetName, MoverResourceSetData data, CancellationToken cancellationToken = default)
        {
            if (moverResourceSetName == null)
            {
                throw new ArgumentNullException(nameof(moverResourceSetName));
            }
            if (moverResourceSetName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(moverResourceSetName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _moverResourceSetMoveCollectionsClientDiagnostics.CreateScope("MoverResourceSetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _moverResourceSetMoveCollectionsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, moverResourceSetName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ResourceMoverArmOperation<MoverResourceSetResource>(Response.FromValue(new MoverResourceSetResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates a move collection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/moveCollections/{moveCollectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MoveCollections_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MoverResourceSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="moverResourceSetName"> The Move Collection Name. </param>
        /// <param name="data"> The <see cref="MoverResourceSetData"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="moverResourceSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="moverResourceSetName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MoverResourceSetResource> CreateOrUpdate(WaitUntil waitUntil, string moverResourceSetName, MoverResourceSetData data, CancellationToken cancellationToken = default)
        {
            if (moverResourceSetName == null)
            {
                throw new ArgumentNullException(nameof(moverResourceSetName));
            }
            if (moverResourceSetName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(moverResourceSetName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _moverResourceSetMoveCollectionsClientDiagnostics.CreateScope("MoverResourceSetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _moverResourceSetMoveCollectionsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, moverResourceSetName, data, cancellationToken);
                var operation = new ResourceMoverArmOperation<MoverResourceSetResource>(Response.FromValue(new MoverResourceSetResource(Client, response), response.GetRawResponse()));
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
        /// Gets the move collection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/moveCollections/{moveCollectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MoveCollections_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MoverResourceSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="moverResourceSetName"> The Move Collection Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="moverResourceSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="moverResourceSetName"/> is null. </exception>
        public virtual async Task<Response<MoverResourceSetResource>> GetAsync(string moverResourceSetName, CancellationToken cancellationToken = default)
        {
            if (moverResourceSetName == null)
            {
                throw new ArgumentNullException(nameof(moverResourceSetName));
            }
            if (moverResourceSetName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(moverResourceSetName));
            }

            using var scope = _moverResourceSetMoveCollectionsClientDiagnostics.CreateScope("MoverResourceSetCollection.Get");
            scope.Start();
            try
            {
                var response = await _moverResourceSetMoveCollectionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, moverResourceSetName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MoverResourceSetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the move collection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/moveCollections/{moveCollectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MoveCollections_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MoverResourceSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="moverResourceSetName"> The Move Collection Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="moverResourceSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="moverResourceSetName"/> is null. </exception>
        public virtual Response<MoverResourceSetResource> Get(string moverResourceSetName, CancellationToken cancellationToken = default)
        {
            if (moverResourceSetName == null)
            {
                throw new ArgumentNullException(nameof(moverResourceSetName));
            }
            if (moverResourceSetName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(moverResourceSetName));
            }

            using var scope = _moverResourceSetMoveCollectionsClientDiagnostics.CreateScope("MoverResourceSetCollection.Get");
            scope.Start();
            try
            {
                var response = _moverResourceSetMoveCollectionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, moverResourceSetName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MoverResourceSetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get all the Move Collections in the resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/moveCollections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MoveCollections_ListMoveCollectionsByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MoverResourceSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MoverResourceSetResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MoverResourceSetResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _moverResourceSetMoveCollectionsRestClient.CreateListMoveCollectionsByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _moverResourceSetMoveCollectionsRestClient.CreateListMoveCollectionsByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new MoverResourceSetResource(Client, MoverResourceSetData.DeserializeMoverResourceSetData(e)), _moverResourceSetMoveCollectionsClientDiagnostics, Pipeline, "MoverResourceSetCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get all the Move Collections in the resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/moveCollections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MoveCollections_ListMoveCollectionsByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MoverResourceSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MoverResourceSetResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MoverResourceSetResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _moverResourceSetMoveCollectionsRestClient.CreateListMoveCollectionsByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _moverResourceSetMoveCollectionsRestClient.CreateListMoveCollectionsByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new MoverResourceSetResource(Client, MoverResourceSetData.DeserializeMoverResourceSetData(e)), _moverResourceSetMoveCollectionsClientDiagnostics, Pipeline, "MoverResourceSetCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/moveCollections/{moveCollectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MoveCollections_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MoverResourceSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="moverResourceSetName"> The Move Collection Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="moverResourceSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="moverResourceSetName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string moverResourceSetName, CancellationToken cancellationToken = default)
        {
            if (moverResourceSetName == null)
            {
                throw new ArgumentNullException(nameof(moverResourceSetName));
            }
            if (moverResourceSetName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(moverResourceSetName));
            }

            using var scope = _moverResourceSetMoveCollectionsClientDiagnostics.CreateScope("MoverResourceSetCollection.Exists");
            scope.Start();
            try
            {
                var response = await _moverResourceSetMoveCollectionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, moverResourceSetName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/moveCollections/{moveCollectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MoveCollections_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MoverResourceSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="moverResourceSetName"> The Move Collection Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="moverResourceSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="moverResourceSetName"/> is null. </exception>
        public virtual Response<bool> Exists(string moverResourceSetName, CancellationToken cancellationToken = default)
        {
            if (moverResourceSetName == null)
            {
                throw new ArgumentNullException(nameof(moverResourceSetName));
            }
            if (moverResourceSetName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(moverResourceSetName));
            }

            using var scope = _moverResourceSetMoveCollectionsClientDiagnostics.CreateScope("MoverResourceSetCollection.Exists");
            scope.Start();
            try
            {
                var response = _moverResourceSetMoveCollectionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, moverResourceSetName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/moveCollections/{moveCollectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MoveCollections_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MoverResourceSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="moverResourceSetName"> The Move Collection Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="moverResourceSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="moverResourceSetName"/> is null. </exception>
        public virtual async Task<NullableResponse<MoverResourceSetResource>> GetIfExistsAsync(string moverResourceSetName, CancellationToken cancellationToken = default)
        {
            if (moverResourceSetName == null)
            {
                throw new ArgumentNullException(nameof(moverResourceSetName));
            }
            if (moverResourceSetName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(moverResourceSetName));
            }

            using var scope = _moverResourceSetMoveCollectionsClientDiagnostics.CreateScope("MoverResourceSetCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _moverResourceSetMoveCollectionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, moverResourceSetName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<MoverResourceSetResource>(response.GetRawResponse());
                return Response.FromValue(new MoverResourceSetResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/moveCollections/{moveCollectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MoveCollections_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MoverResourceSetResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="moverResourceSetName"> The Move Collection Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="moverResourceSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="moverResourceSetName"/> is null. </exception>
        public virtual NullableResponse<MoverResourceSetResource> GetIfExists(string moverResourceSetName, CancellationToken cancellationToken = default)
        {
            if (moverResourceSetName == null)
            {
                throw new ArgumentNullException(nameof(moverResourceSetName));
            }
            if (moverResourceSetName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(moverResourceSetName));
            }

            using var scope = _moverResourceSetMoveCollectionsClientDiagnostics.CreateScope("MoverResourceSetCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _moverResourceSetMoveCollectionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, moverResourceSetName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<MoverResourceSetResource>(response.GetRawResponse());
                return Response.FromValue(new MoverResourceSetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MoverResourceSetResource> IEnumerable<MoverResourceSetResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MoverResourceSetResource> IAsyncEnumerable<MoverResourceSetResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
