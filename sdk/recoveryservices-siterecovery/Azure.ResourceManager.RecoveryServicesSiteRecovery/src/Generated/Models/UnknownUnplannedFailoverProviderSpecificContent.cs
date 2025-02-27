// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> The UnknownUnplannedFailoverProviderSpecificContent. </summary>
    internal partial class UnknownUnplannedFailoverProviderSpecificContent : UnplannedFailoverProviderSpecificContent
    {
        /// <summary> Initializes a new instance of <see cref="UnknownUnplannedFailoverProviderSpecificContent"/>. </summary>
        /// <param name="instanceType"> The class type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownUnplannedFailoverProviderSpecificContent(string instanceType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(instanceType, serializedAdditionalRawData)
        {
            InstanceType = instanceType ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownUnplannedFailoverProviderSpecificContent"/> for deserialization. </summary>
        internal UnknownUnplannedFailoverProviderSpecificContent()
        {
        }
    }
}
