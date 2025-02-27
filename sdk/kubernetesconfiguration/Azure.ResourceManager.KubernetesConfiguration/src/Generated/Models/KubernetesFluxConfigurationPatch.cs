// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    /// <summary> The Flux Configuration Patch Request object. </summary>
    public partial class KubernetesFluxConfigurationPatch
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

        /// <summary> Initializes a new instance of <see cref="KubernetesFluxConfigurationPatch"/>. </summary>
        public KubernetesFluxConfigurationPatch()
        {
            Kustomizations = new ChangeTrackingDictionary<string, KustomizationUpdateContent>();
            ConfigurationProtectedSettings = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="KubernetesFluxConfigurationPatch"/>. </summary>
        /// <param name="sourceKind"> Source Kind to pull the configuration data from. </param>
        /// <param name="suspend"> Whether this configuration should suspend its reconciliation of its kustomizations and sources. </param>
        /// <param name="gitRepository"> Parameters to reconcile to the GitRepository source kind type. </param>
        /// <param name="bucket"> Parameters to reconcile to the Bucket source kind type. </param>
        /// <param name="azureBlob"> Parameters to reconcile to the AzureBlob source kind type. </param>
        /// <param name="kustomizations"> Array of kustomizations used to reconcile the artifact pulled by the source type on the cluster. </param>
        /// <param name="configurationProtectedSettings"> Key-value pairs of protected configuration settings for the configuration. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal KubernetesFluxConfigurationPatch(KubernetesConfigurationSourceKind? sourceKind, bool? suspend, KubernetesGitRepositoryUpdateContent gitRepository, KubernetesBucketUpdateContent bucket, KubernetesAzureBlobUpdateContent azureBlob, IDictionary<string, KustomizationUpdateContent> kustomizations, IDictionary<string, string> configurationProtectedSettings, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SourceKind = sourceKind;
            Suspend = suspend;
            GitRepository = gitRepository;
            Bucket = bucket;
            AzureBlob = azureBlob;
            Kustomizations = kustomizations;
            ConfigurationProtectedSettings = configurationProtectedSettings;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Source Kind to pull the configuration data from. </summary>
        public KubernetesConfigurationSourceKind? SourceKind { get; set; }
        /// <summary> Whether this configuration should suspend its reconciliation of its kustomizations and sources. </summary>
        public bool? Suspend { get; set; }
        /// <summary> Parameters to reconcile to the GitRepository source kind type. </summary>
        public KubernetesGitRepositoryUpdateContent GitRepository { get; set; }
        /// <summary> Parameters to reconcile to the Bucket source kind type. </summary>
        public KubernetesBucketUpdateContent Bucket { get; set; }
        /// <summary> Parameters to reconcile to the AzureBlob source kind type. </summary>
        public KubernetesAzureBlobUpdateContent AzureBlob { get; set; }
        /// <summary> Array of kustomizations used to reconcile the artifact pulled by the source type on the cluster. </summary>
        public IDictionary<string, KustomizationUpdateContent> Kustomizations { get; set; }
        /// <summary> Key-value pairs of protected configuration settings for the configuration. </summary>
        public IDictionary<string, string> ConfigurationProtectedSettings { get; set; }
    }
}
