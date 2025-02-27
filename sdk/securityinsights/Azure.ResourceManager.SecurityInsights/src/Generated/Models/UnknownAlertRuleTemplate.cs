// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityInsights;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The UnknownAlertRuleTemplate. </summary>
    internal partial class UnknownAlertRuleTemplate : SecurityInsightsAlertRuleTemplateData
    {
        /// <summary> Initializes a new instance of <see cref="UnknownAlertRuleTemplate"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> The alert rule kind. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownAlertRuleTemplate(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AlertRuleKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, kind, serializedAdditionalRawData)
        {
            Kind = kind;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownAlertRuleTemplate"/> for deserialization. </summary>
        internal UnknownAlertRuleTemplate()
        {
        }
    }
}
