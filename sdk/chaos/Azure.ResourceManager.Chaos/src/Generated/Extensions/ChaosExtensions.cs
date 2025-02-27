// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Chaos.Mocking;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Chaos
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.Chaos. </summary>
    public static partial class ChaosExtensions
    {
        private static MockableChaosArmClient GetMockableChaosArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableChaosArmClient(client0));
        }

        private static MockableChaosResourceGroupResource GetMockableChaosResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableChaosResourceGroupResource(client, resource.Id));
        }

        private static MockableChaosSubscriptionResource GetMockableChaosSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableChaosSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="ChaosCapabilityResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ChaosCapabilityResource.CreateResourceIdentifier" /> to create a <see cref="ChaosCapabilityResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableChaosArmClient.GetChaosCapabilityResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="ChaosCapabilityResource"/> object. </returns>
        public static ChaosCapabilityResource GetChaosCapabilityResource(this ArmClient client, ResourceIdentifier id)
        {
            if (client == null)
            {
                throw new ArgumentNullException(nameof(client));
            }

            return GetMockableChaosArmClient(client).GetChaosCapabilityResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ChaosCapabilityTypeResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ChaosCapabilityTypeResource.CreateResourceIdentifier" /> to create a <see cref="ChaosCapabilityTypeResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableChaosArmClient.GetChaosCapabilityTypeResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="ChaosCapabilityTypeResource"/> object. </returns>
        public static ChaosCapabilityTypeResource GetChaosCapabilityTypeResource(this ArmClient client, ResourceIdentifier id)
        {
            if (client == null)
            {
                throw new ArgumentNullException(nameof(client));
            }

            return GetMockableChaosArmClient(client).GetChaosCapabilityTypeResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ChaosExperimentResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ChaosExperimentResource.CreateResourceIdentifier" /> to create a <see cref="ChaosExperimentResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableChaosArmClient.GetChaosExperimentResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="ChaosExperimentResource"/> object. </returns>
        public static ChaosExperimentResource GetChaosExperimentResource(this ArmClient client, ResourceIdentifier id)
        {
            if (client == null)
            {
                throw new ArgumentNullException(nameof(client));
            }

            return GetMockableChaosArmClient(client).GetChaosExperimentResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ChaosExperimentExecutionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ChaosExperimentExecutionResource.CreateResourceIdentifier" /> to create a <see cref="ChaosExperimentExecutionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableChaosArmClient.GetChaosExperimentExecutionResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="ChaosExperimentExecutionResource"/> object. </returns>
        public static ChaosExperimentExecutionResource GetChaosExperimentExecutionResource(this ArmClient client, ResourceIdentifier id)
        {
            if (client == null)
            {
                throw new ArgumentNullException(nameof(client));
            }

            return GetMockableChaosArmClient(client).GetChaosExperimentExecutionResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ChaosTargetTypeResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ChaosTargetTypeResource.CreateResourceIdentifier" /> to create a <see cref="ChaosTargetTypeResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableChaosArmClient.GetChaosTargetTypeResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="ChaosTargetTypeResource"/> object. </returns>
        public static ChaosTargetTypeResource GetChaosTargetTypeResource(this ArmClient client, ResourceIdentifier id)
        {
            if (client == null)
            {
                throw new ArgumentNullException(nameof(client));
            }

            return GetMockableChaosArmClient(client).GetChaosTargetTypeResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ChaosTargetResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ChaosTargetResource.CreateResourceIdentifier" /> to create a <see cref="ChaosTargetResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableChaosArmClient.GetChaosTargetResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="ChaosTargetResource"/> object. </returns>
        public static ChaosTargetResource GetChaosTargetResource(this ArmClient client, ResourceIdentifier id)
        {
            if (client == null)
            {
                throw new ArgumentNullException(nameof(client));
            }

            return GetMockableChaosArmClient(client).GetChaosTargetResource(id);
        }

        /// <summary>
        /// Gets a collection of ChaosExperimentResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableChaosResourceGroupResource.GetChaosExperiments()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of ChaosExperimentResources and their operations over a ChaosExperimentResource. </returns>
        public static ChaosExperimentCollection GetChaosExperiments(this ResourceGroupResource resourceGroupResource)
        {
            if (resourceGroupResource == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupResource));
            }

            return GetMockableChaosResourceGroupResource(resourceGroupResource).GetChaosExperiments();
        }

        /// <summary>
        /// Get a Experiment resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Chaos/experiments/{experimentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Experiments_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ChaosExperimentResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableChaosResourceGroupResource.GetChaosExperimentAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="experimentName"> String that represents a Experiment resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="experimentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="experimentName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<ChaosExperimentResource>> GetChaosExperimentAsync(this ResourceGroupResource resourceGroupResource, string experimentName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupResource == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupResource));
            }

            return await GetMockableChaosResourceGroupResource(resourceGroupResource).GetChaosExperimentAsync(experimentName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a Experiment resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Chaos/experiments/{experimentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Experiments_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ChaosExperimentResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableChaosResourceGroupResource.GetChaosExperiment(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="experimentName"> String that represents a Experiment resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="experimentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="experimentName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<ChaosExperimentResource> GetChaosExperiment(this ResourceGroupResource resourceGroupResource, string experimentName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupResource == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupResource));
            }

            return GetMockableChaosResourceGroupResource(resourceGroupResource).GetChaosExperiment(experimentName, cancellationToken);
        }

        /// <summary>
        /// Gets a collection of ChaosTargetResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableChaosResourceGroupResource.GetChaosTargets(string,string,string)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="parentProviderNamespace"> String that represents a resource provider namespace. </param>
        /// <param name="parentResourceType"> String that represents a resource type. </param>
        /// <param name="parentResourceName"> String that represents a resource name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/>, <paramref name="parentProviderNamespace"/>, <paramref name="parentResourceType"/> or <paramref name="parentResourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="parentProviderNamespace"/>, <paramref name="parentResourceType"/> or <paramref name="parentResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <returns> An object representing collection of ChaosTargetResources and their operations over a ChaosTargetResource. </returns>
        public static ChaosTargetCollection GetChaosTargets(this ResourceGroupResource resourceGroupResource, string parentProviderNamespace, string parentResourceType, string parentResourceName)
        {
            if (resourceGroupResource == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupResource));
            }

            return GetMockableChaosResourceGroupResource(resourceGroupResource).GetChaosTargets(parentProviderNamespace, parentResourceType, parentResourceName);
        }

        /// <summary>
        /// Get a Target resource that extends a tracked regional resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{parentProviderNamespace}/{parentResourceType}/{parentResourceName}/providers/Microsoft.Chaos/targets/{targetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Targets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ChaosTargetResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableChaosResourceGroupResource.GetChaosTargetAsync(string,string,string,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="parentProviderNamespace"> String that represents a resource provider namespace. </param>
        /// <param name="parentResourceType"> String that represents a resource type. </param>
        /// <param name="parentResourceName"> String that represents a resource name. </param>
        /// <param name="targetName"> String that represents a Target resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/>, <paramref name="parentProviderNamespace"/>, <paramref name="parentResourceType"/>, <paramref name="parentResourceName"/> or <paramref name="targetName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="parentProviderNamespace"/>, <paramref name="parentResourceType"/>, <paramref name="parentResourceName"/> or <paramref name="targetName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<ChaosTargetResource>> GetChaosTargetAsync(this ResourceGroupResource resourceGroupResource, string parentProviderNamespace, string parentResourceType, string parentResourceName, string targetName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupResource == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupResource));
            }

            return await GetMockableChaosResourceGroupResource(resourceGroupResource).GetChaosTargetAsync(parentProviderNamespace, parentResourceType, parentResourceName, targetName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a Target resource that extends a tracked regional resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{parentProviderNamespace}/{parentResourceType}/{parentResourceName}/providers/Microsoft.Chaos/targets/{targetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Targets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ChaosTargetResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableChaosResourceGroupResource.GetChaosTarget(string,string,string,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="parentProviderNamespace"> String that represents a resource provider namespace. </param>
        /// <param name="parentResourceType"> String that represents a resource type. </param>
        /// <param name="parentResourceName"> String that represents a resource name. </param>
        /// <param name="targetName"> String that represents a Target resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/>, <paramref name="parentProviderNamespace"/>, <paramref name="parentResourceType"/>, <paramref name="parentResourceName"/> or <paramref name="targetName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="parentProviderNamespace"/>, <paramref name="parentResourceType"/>, <paramref name="parentResourceName"/> or <paramref name="targetName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<ChaosTargetResource> GetChaosTarget(this ResourceGroupResource resourceGroupResource, string parentProviderNamespace, string parentResourceType, string parentResourceName, string targetName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupResource == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupResource));
            }

            return GetMockableChaosResourceGroupResource(resourceGroupResource).GetChaosTarget(parentProviderNamespace, parentResourceType, parentResourceName, targetName, cancellationToken);
        }

        /// <summary>
        /// Gets a collection of ChaosTargetTypeResources in the SubscriptionResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableChaosSubscriptionResource.GetChaosTargetTypes(string)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationName"> String that represents a Location resource name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="locationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <returns> An object representing collection of ChaosTargetTypeResources and their operations over a ChaosTargetTypeResource. </returns>
        public static ChaosTargetTypeCollection GetChaosTargetTypes(this SubscriptionResource subscriptionResource, string locationName)
        {
            if (subscriptionResource == null)
            {
                throw new ArgumentNullException(nameof(subscriptionResource));
            }

            return GetMockableChaosSubscriptionResource(subscriptionResource).GetChaosTargetTypes(locationName);
        }

        /// <summary>
        /// Get a Target Type resources for given location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Chaos/locations/{locationName}/targetTypes/{targetTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TargetTypes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ChaosTargetTypeResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableChaosSubscriptionResource.GetChaosTargetTypeAsync(string,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationName"> String that represents a Location resource name. </param>
        /// <param name="targetTypeName"> String that represents a Target Type resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/>, <paramref name="locationName"/> or <paramref name="targetTypeName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> or <paramref name="targetTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<ChaosTargetTypeResource>> GetChaosTargetTypeAsync(this SubscriptionResource subscriptionResource, string locationName, string targetTypeName, CancellationToken cancellationToken = default)
        {
            if (subscriptionResource == null)
            {
                throw new ArgumentNullException(nameof(subscriptionResource));
            }

            return await GetMockableChaosSubscriptionResource(subscriptionResource).GetChaosTargetTypeAsync(locationName, targetTypeName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a Target Type resources for given location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Chaos/locations/{locationName}/targetTypes/{targetTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TargetTypes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ChaosTargetTypeResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableChaosSubscriptionResource.GetChaosTargetType(string,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationName"> String that represents a Location resource name. </param>
        /// <param name="targetTypeName"> String that represents a Target Type resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/>, <paramref name="locationName"/> or <paramref name="targetTypeName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> or <paramref name="targetTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<ChaosTargetTypeResource> GetChaosTargetType(this SubscriptionResource subscriptionResource, string locationName, string targetTypeName, CancellationToken cancellationToken = default)
        {
            if (subscriptionResource == null)
            {
                throw new ArgumentNullException(nameof(subscriptionResource));
            }

            return GetMockableChaosSubscriptionResource(subscriptionResource).GetChaosTargetType(locationName, targetTypeName, cancellationToken);
        }

        /// <summary>
        /// Get a list of Experiment resources in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Chaos/experiments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Experiments_ListAll</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ChaosExperimentResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableChaosSubscriptionResource.GetChaosExperiments(bool?,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="running"> Optional value that indicates whether to filter results based on if the Experiment is currently running. If null, then the results will not be filtered. </param>
        /// <param name="continuationToken"> String that sets the continuation token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="ChaosExperimentResource"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ChaosExperimentResource> GetChaosExperimentsAsync(this SubscriptionResource subscriptionResource, bool? running = null, string continuationToken = null, CancellationToken cancellationToken = default)
        {
            if (subscriptionResource == null)
            {
                throw new ArgumentNullException(nameof(subscriptionResource));
            }

            return GetMockableChaosSubscriptionResource(subscriptionResource).GetChaosExperimentsAsync(running, continuationToken, cancellationToken);
        }

        /// <summary>
        /// Get a list of Experiment resources in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Chaos/experiments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Experiments_ListAll</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ChaosExperimentResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableChaosSubscriptionResource.GetChaosExperiments(bool?,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="running"> Optional value that indicates whether to filter results based on if the Experiment is currently running. If null, then the results will not be filtered. </param>
        /// <param name="continuationToken"> String that sets the continuation token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="ChaosExperimentResource"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ChaosExperimentResource> GetChaosExperiments(this SubscriptionResource subscriptionResource, bool? running = null, string continuationToken = null, CancellationToken cancellationToken = default)
        {
            if (subscriptionResource == null)
            {
                throw new ArgumentNullException(nameof(subscriptionResource));
            }

            return GetMockableChaosSubscriptionResource(subscriptionResource).GetChaosExperiments(running, continuationToken, cancellationToken);
        }
    }
}
