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
using Azure.ResourceManager.PlaywrightTesting.Mocking;
using Azure.ResourceManager.PlaywrightTesting.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.PlaywrightTesting
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.PlaywrightTesting. </summary>
    public static partial class PlaywrightTestingExtensions
    {
        private static MockablePlaywrightTestingArmClient GetMockablePlaywrightTestingArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockablePlaywrightTestingArmClient(client0));
        }

        private static MockablePlaywrightTestingResourceGroupResource GetMockablePlaywrightTestingResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockablePlaywrightTestingResourceGroupResource(client, resource.Id));
        }

        private static MockablePlaywrightTestingSubscriptionResource GetMockablePlaywrightTestingSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockablePlaywrightTestingSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="PlaywrightTestingAccountResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PlaywrightTestingAccountResource.CreateResourceIdentifier" /> to create a <see cref="PlaywrightTestingAccountResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePlaywrightTestingArmClient.GetPlaywrightTestingAccountResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="PlaywrightTestingAccountResource"/> object. </returns>
        public static PlaywrightTestingAccountResource GetPlaywrightTestingAccountResource(this ArmClient client, ResourceIdentifier id)
        {
            if (client == null)
            {
                throw new ArgumentNullException(nameof(client));
            }

            return GetMockablePlaywrightTestingArmClient(client).GetPlaywrightTestingAccountResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PlaywrightTestingQuotaResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PlaywrightTestingQuotaResource.CreateResourceIdentifier" /> to create a <see cref="PlaywrightTestingQuotaResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePlaywrightTestingArmClient.GetPlaywrightTestingQuotaResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="PlaywrightTestingQuotaResource"/> object. </returns>
        public static PlaywrightTestingQuotaResource GetPlaywrightTestingQuotaResource(this ArmClient client, ResourceIdentifier id)
        {
            if (client == null)
            {
                throw new ArgumentNullException(nameof(client));
            }

            return GetMockablePlaywrightTestingArmClient(client).GetPlaywrightTestingQuotaResource(id);
        }

        /// <summary>
        /// Gets a collection of PlaywrightTestingAccountResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePlaywrightTestingResourceGroupResource.GetPlaywrightTestingAccounts()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of PlaywrightTestingAccountResources and their operations over a PlaywrightTestingAccountResource. </returns>
        public static PlaywrightTestingAccountCollection GetPlaywrightTestingAccounts(this ResourceGroupResource resourceGroupResource)
        {
            if (resourceGroupResource == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupResource));
            }

            return GetMockablePlaywrightTestingResourceGroupResource(resourceGroupResource).GetPlaywrightTestingAccounts();
        }

        /// <summary>
        /// Get a Account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzurePlaywrightService/accounts/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PlaywrightTestingAccountResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePlaywrightTestingResourceGroupResource.GetPlaywrightTestingAccountAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="name"> Name of account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="name"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<PlaywrightTestingAccountResource>> GetPlaywrightTestingAccountAsync(this ResourceGroupResource resourceGroupResource, string name, CancellationToken cancellationToken = default)
        {
            if (resourceGroupResource == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupResource));
            }

            return await GetMockablePlaywrightTestingResourceGroupResource(resourceGroupResource).GetPlaywrightTestingAccountAsync(name, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a Account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzurePlaywrightService/accounts/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PlaywrightTestingAccountResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePlaywrightTestingResourceGroupResource.GetPlaywrightTestingAccount(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="name"> Name of account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="name"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<PlaywrightTestingAccountResource> GetPlaywrightTestingAccount(this ResourceGroupResource resourceGroupResource, string name, CancellationToken cancellationToken = default)
        {
            if (resourceGroupResource == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupResource));
            }

            return GetMockablePlaywrightTestingResourceGroupResource(resourceGroupResource).GetPlaywrightTestingAccount(name, cancellationToken);
        }

        /// <summary>
        /// Gets a collection of PlaywrightTestingQuotaResources in the SubscriptionResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePlaywrightTestingSubscriptionResource.GetAllPlaywrightTestingQuota(AzureLocation)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of quota in ARM Normalized format like eastus, southeastasia etc. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An object representing collection of PlaywrightTestingQuotaResources and their operations over a PlaywrightTestingQuotaResource. </returns>
        public static PlaywrightTestingQuotaCollection GetAllPlaywrightTestingQuota(this SubscriptionResource subscriptionResource, AzureLocation location)
        {
            if (subscriptionResource == null)
            {
                throw new ArgumentNullException(nameof(subscriptionResource));
            }

            return GetMockablePlaywrightTestingSubscriptionResource(subscriptionResource).GetAllPlaywrightTestingQuota(location);
        }

        /// <summary>
        /// Get quota by name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AzurePlaywrightService/locations/{location}/quotas/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Quotas_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PlaywrightTestingQuotaResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePlaywrightTestingSubscriptionResource.GetPlaywrightTestingQuotaAsync(AzureLocation,PlaywrightTestingQuotaName,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of quota in ARM Normalized format like eastus, southeastasia etc. </param>
        /// <param name="name"> The quota name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<PlaywrightTestingQuotaResource>> GetPlaywrightTestingQuotaAsync(this SubscriptionResource subscriptionResource, AzureLocation location, PlaywrightTestingQuotaName name, CancellationToken cancellationToken = default)
        {
            if (subscriptionResource == null)
            {
                throw new ArgumentNullException(nameof(subscriptionResource));
            }

            return await GetMockablePlaywrightTestingSubscriptionResource(subscriptionResource).GetPlaywrightTestingQuotaAsync(location, name, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get quota by name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AzurePlaywrightService/locations/{location}/quotas/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Quotas_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PlaywrightTestingQuotaResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePlaywrightTestingSubscriptionResource.GetPlaywrightTestingQuota(AzureLocation,PlaywrightTestingQuotaName,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of quota in ARM Normalized format like eastus, southeastasia etc. </param>
        /// <param name="name"> The quota name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<PlaywrightTestingQuotaResource> GetPlaywrightTestingQuota(this SubscriptionResource subscriptionResource, AzureLocation location, PlaywrightTestingQuotaName name, CancellationToken cancellationToken = default)
        {
            if (subscriptionResource == null)
            {
                throw new ArgumentNullException(nameof(subscriptionResource));
            }

            return GetMockablePlaywrightTestingSubscriptionResource(subscriptionResource).GetPlaywrightTestingQuota(location, name, cancellationToken);
        }

        /// <summary>
        /// List Account resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AzurePlaywrightService/accounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PlaywrightTestingAccountResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePlaywrightTestingSubscriptionResource.GetPlaywrightTestingAccounts(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="PlaywrightTestingAccountResource"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<PlaywrightTestingAccountResource> GetPlaywrightTestingAccountsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            if (subscriptionResource == null)
            {
                throw new ArgumentNullException(nameof(subscriptionResource));
            }

            return GetMockablePlaywrightTestingSubscriptionResource(subscriptionResource).GetPlaywrightTestingAccountsAsync(cancellationToken);
        }

        /// <summary>
        /// List Account resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AzurePlaywrightService/accounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PlaywrightTestingAccountResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePlaywrightTestingSubscriptionResource.GetPlaywrightTestingAccounts(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="PlaywrightTestingAccountResource"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<PlaywrightTestingAccountResource> GetPlaywrightTestingAccounts(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            if (subscriptionResource == null)
            {
                throw new ArgumentNullException(nameof(subscriptionResource));
            }

            return GetMockablePlaywrightTestingSubscriptionResource(subscriptionResource).GetPlaywrightTestingAccounts(cancellationToken);
        }
    }
}
