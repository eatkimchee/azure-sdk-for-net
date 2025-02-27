// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Authorization
{
    /// <summary>
    /// A class representing a collection of <see cref="AuthorizationRoleDefinitionResource"/> and their operations.
    /// Each <see cref="AuthorizationRoleDefinitionResource"/> in the collection will belong to the same instance of <see cref="ArmResource"/>.
    /// To get an <see cref="AuthorizationRoleDefinitionCollection"/> instance call the GetAuthorizationRoleDefinitions method from an instance of <see cref="ArmResource"/>.
    /// </summary>
    public partial class AuthorizationRoleDefinitionCollection : ArmCollection, IEnumerable<AuthorizationRoleDefinitionResource>, IAsyncEnumerable<AuthorizationRoleDefinitionResource>
    {
        private readonly ClientDiagnostics _authorizationRoleDefinitionRoleDefinitionsClientDiagnostics;
        private readonly RoleDefinitionsRestOperations _authorizationRoleDefinitionRoleDefinitionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="AuthorizationRoleDefinitionCollection"/> class for mocking. </summary>
        protected AuthorizationRoleDefinitionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AuthorizationRoleDefinitionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AuthorizationRoleDefinitionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _authorizationRoleDefinitionRoleDefinitionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Authorization", AuthorizationRoleDefinitionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AuthorizationRoleDefinitionResource.ResourceType, out string authorizationRoleDefinitionRoleDefinitionsApiVersion);
            _authorizationRoleDefinitionRoleDefinitionsRestClient = new RoleDefinitionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, authorizationRoleDefinitionRoleDefinitionsApiVersion);
        }

        /// <summary>
        /// Creates or updates a role definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleDefinitions/{roleDefinitionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleDefinitions_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AuthorizationRoleDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="roleDefinitionId"> The ID of the role definition. </param>
        /// <param name="data"> The values for the role definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleDefinitionId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AuthorizationRoleDefinitionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, ResourceIdentifier roleDefinitionId, AuthorizationRoleDefinitionData data, CancellationToken cancellationToken = default)
        {
            if (roleDefinitionId == null)
            {
                throw new ArgumentNullException(nameof(roleDefinitionId));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _authorizationRoleDefinitionRoleDefinitionsClientDiagnostics.CreateScope("AuthorizationRoleDefinitionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _authorizationRoleDefinitionRoleDefinitionsRestClient.CreateOrUpdateAsync(Id, roleDefinitionId, data, cancellationToken).ConfigureAwait(false);
                var operation = new AuthorizationArmOperation<AuthorizationRoleDefinitionResource>(Response.FromValue(new AuthorizationRoleDefinitionResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates a role definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleDefinitions/{roleDefinitionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleDefinitions_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AuthorizationRoleDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="roleDefinitionId"> The ID of the role definition. </param>
        /// <param name="data"> The values for the role definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleDefinitionId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AuthorizationRoleDefinitionResource> CreateOrUpdate(WaitUntil waitUntil, ResourceIdentifier roleDefinitionId, AuthorizationRoleDefinitionData data, CancellationToken cancellationToken = default)
        {
            if (roleDefinitionId == null)
            {
                throw new ArgumentNullException(nameof(roleDefinitionId));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _authorizationRoleDefinitionRoleDefinitionsClientDiagnostics.CreateScope("AuthorizationRoleDefinitionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _authorizationRoleDefinitionRoleDefinitionsRestClient.CreateOrUpdate(Id, roleDefinitionId, data, cancellationToken);
                var operation = new AuthorizationArmOperation<AuthorizationRoleDefinitionResource>(Response.FromValue(new AuthorizationRoleDefinitionResource(Client, response), response.GetRawResponse()));
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
        /// Get role definition by name (GUID).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleDefinitions/{roleDefinitionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleDefinitions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AuthorizationRoleDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleDefinitionId"> The ID of the role definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleDefinitionId"/> is null. </exception>
        public virtual async Task<Response<AuthorizationRoleDefinitionResource>> GetAsync(ResourceIdentifier roleDefinitionId, CancellationToken cancellationToken = default)
        {
            if (roleDefinitionId == null)
            {
                throw new ArgumentNullException(nameof(roleDefinitionId));
            }

            using var scope = _authorizationRoleDefinitionRoleDefinitionsClientDiagnostics.CreateScope("AuthorizationRoleDefinitionCollection.Get");
            scope.Start();
            try
            {
                var response = await _authorizationRoleDefinitionRoleDefinitionsRestClient.GetAsync(Id, roleDefinitionId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AuthorizationRoleDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get role definition by name (GUID).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleDefinitions/{roleDefinitionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleDefinitions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AuthorizationRoleDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleDefinitionId"> The ID of the role definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleDefinitionId"/> is null. </exception>
        public virtual Response<AuthorizationRoleDefinitionResource> Get(ResourceIdentifier roleDefinitionId, CancellationToken cancellationToken = default)
        {
            if (roleDefinitionId == null)
            {
                throw new ArgumentNullException(nameof(roleDefinitionId));
            }

            using var scope = _authorizationRoleDefinitionRoleDefinitionsClientDiagnostics.CreateScope("AuthorizationRoleDefinitionCollection.Get");
            scope.Start();
            try
            {
                var response = _authorizationRoleDefinitionRoleDefinitionsRestClient.Get(Id, roleDefinitionId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AuthorizationRoleDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get all role definitions that are applicable at scope and above.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleDefinitions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleDefinitions_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AuthorizationRoleDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. Use atScopeAndBelow filter to search below the given scope as well. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AuthorizationRoleDefinitionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AuthorizationRoleDefinitionResource> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _authorizationRoleDefinitionRoleDefinitionsRestClient.CreateListRequest(Id, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _authorizationRoleDefinitionRoleDefinitionsRestClient.CreateListNextPageRequest(nextLink, Id, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new AuthorizationRoleDefinitionResource(Client, AuthorizationRoleDefinitionData.DeserializeAuthorizationRoleDefinitionData(e)), _authorizationRoleDefinitionRoleDefinitionsClientDiagnostics, Pipeline, "AuthorizationRoleDefinitionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get all role definitions that are applicable at scope and above.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleDefinitions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleDefinitions_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AuthorizationRoleDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. Use atScopeAndBelow filter to search below the given scope as well. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AuthorizationRoleDefinitionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AuthorizationRoleDefinitionResource> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _authorizationRoleDefinitionRoleDefinitionsRestClient.CreateListRequest(Id, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _authorizationRoleDefinitionRoleDefinitionsRestClient.CreateListNextPageRequest(nextLink, Id, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new AuthorizationRoleDefinitionResource(Client, AuthorizationRoleDefinitionData.DeserializeAuthorizationRoleDefinitionData(e)), _authorizationRoleDefinitionRoleDefinitionsClientDiagnostics, Pipeline, "AuthorizationRoleDefinitionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleDefinitions/{roleDefinitionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleDefinitions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AuthorizationRoleDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleDefinitionId"> The ID of the role definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleDefinitionId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(ResourceIdentifier roleDefinitionId, CancellationToken cancellationToken = default)
        {
            if (roleDefinitionId == null)
            {
                throw new ArgumentNullException(nameof(roleDefinitionId));
            }

            using var scope = _authorizationRoleDefinitionRoleDefinitionsClientDiagnostics.CreateScope("AuthorizationRoleDefinitionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _authorizationRoleDefinitionRoleDefinitionsRestClient.GetAsync(Id, roleDefinitionId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/{scope}/providers/Microsoft.Authorization/roleDefinitions/{roleDefinitionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleDefinitions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AuthorizationRoleDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleDefinitionId"> The ID of the role definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleDefinitionId"/> is null. </exception>
        public virtual Response<bool> Exists(ResourceIdentifier roleDefinitionId, CancellationToken cancellationToken = default)
        {
            if (roleDefinitionId == null)
            {
                throw new ArgumentNullException(nameof(roleDefinitionId));
            }

            using var scope = _authorizationRoleDefinitionRoleDefinitionsClientDiagnostics.CreateScope("AuthorizationRoleDefinitionCollection.Exists");
            scope.Start();
            try
            {
                var response = _authorizationRoleDefinitionRoleDefinitionsRestClient.Get(Id, roleDefinitionId, cancellationToken: cancellationToken);
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
        /// <description>/{scope}/providers/Microsoft.Authorization/roleDefinitions/{roleDefinitionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleDefinitions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AuthorizationRoleDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleDefinitionId"> The ID of the role definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleDefinitionId"/> is null. </exception>
        public virtual async Task<NullableResponse<AuthorizationRoleDefinitionResource>> GetIfExistsAsync(ResourceIdentifier roleDefinitionId, CancellationToken cancellationToken = default)
        {
            if (roleDefinitionId == null)
            {
                throw new ArgumentNullException(nameof(roleDefinitionId));
            }

            using var scope = _authorizationRoleDefinitionRoleDefinitionsClientDiagnostics.CreateScope("AuthorizationRoleDefinitionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _authorizationRoleDefinitionRoleDefinitionsRestClient.GetAsync(Id, roleDefinitionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<AuthorizationRoleDefinitionResource>(response.GetRawResponse());
                return Response.FromValue(new AuthorizationRoleDefinitionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/{scope}/providers/Microsoft.Authorization/roleDefinitions/{roleDefinitionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleDefinitions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AuthorizationRoleDefinitionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleDefinitionId"> The ID of the role definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleDefinitionId"/> is null. </exception>
        public virtual NullableResponse<AuthorizationRoleDefinitionResource> GetIfExists(ResourceIdentifier roleDefinitionId, CancellationToken cancellationToken = default)
        {
            if (roleDefinitionId == null)
            {
                throw new ArgumentNullException(nameof(roleDefinitionId));
            }

            using var scope = _authorizationRoleDefinitionRoleDefinitionsClientDiagnostics.CreateScope("AuthorizationRoleDefinitionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _authorizationRoleDefinitionRoleDefinitionsRestClient.Get(Id, roleDefinitionId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<AuthorizationRoleDefinitionResource>(response.GetRawResponse());
                return Response.FromValue(new AuthorizationRoleDefinitionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AuthorizationRoleDefinitionResource> IEnumerable<AuthorizationRoleDefinitionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AuthorizationRoleDefinitionResource> IAsyncEnumerable<AuthorizationRoleDefinitionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
