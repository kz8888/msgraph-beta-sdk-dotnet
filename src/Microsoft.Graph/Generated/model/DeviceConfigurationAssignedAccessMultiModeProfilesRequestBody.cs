// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;

    /// <summary>
    /// The type DeviceConfigurationAssignedAccessMultiModeProfilesRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeviceConfigurationAssignedAccessMultiModeProfilesRequestBody
    {
    
        /// <summary>
        /// Gets or sets AssignedAccessMultiModeProfiles.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assignedAccessMultiModeProfiles", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<WindowsAssignedAccessProfile> AssignedAccessMultiModeProfiles { get; set; }
    
    }
}
