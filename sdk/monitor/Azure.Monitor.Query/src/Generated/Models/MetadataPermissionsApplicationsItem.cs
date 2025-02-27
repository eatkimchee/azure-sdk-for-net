// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Monitor.Query.Models
{
    /// <summary> The MetadataPermissionsApplicationsItem. </summary>
    internal partial class MetadataPermissionsApplicationsItem
    {
        /// <summary> Initializes a new instance of <see cref="MetadataPermissionsApplicationsItem"/>. </summary>
        /// <param name="resourceId"> The resource ID on the permission indication. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceId"/> is null. </exception>
        internal MetadataPermissionsApplicationsItem(string resourceId)
        {
            if (resourceId == null)
            {
                throw new ArgumentNullException(nameof(resourceId));
            }

            ResourceId = resourceId;
        }

        /// <summary> The resource ID on the permission indication. </summary>
        public string ResourceId { get; }
    }
}
