// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Mobile App Assignment.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class MobileAppAssignment : Entity
    {
    
		///<summary>
		/// The MobileAppAssignment constructor
		///</summary>
        public MobileAppAssignment()
        {
            this.ODataType = "microsoft.graph.mobileAppAssignment";
        }
	
        /// <summary>
        /// Gets or sets intent.
        /// The install intent defined by the admin. Possible values are: available, required, uninstall, availableWithoutEnrollment.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "intent", Required = Newtonsoft.Json.Required.Default)]
        public InstallIntent? Intent { get; set; }
    
        /// <summary>
        /// Gets or sets settings.
        /// The settings for target assignment defined by the admin.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "settings", Required = Newtonsoft.Json.Required.Default)]
        public MobileAppAssignmentSettings Settings { get; set; }
    
        /// <summary>
        /// Gets or sets source.
        /// The resource type which is the source for the assignment. Possible values are: direct, policySets.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "source", Required = Newtonsoft.Json.Required.Default)]
        public DeviceAndAppManagementAssignmentSource? Source { get; set; }
    
        /// <summary>
        /// Gets or sets source id.
        /// The identifier of the source of the assignment.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sourceId", Required = Newtonsoft.Json.Required.Default)]
        public string SourceId { get; set; }
    
        /// <summary>
        /// Gets or sets target.
        /// The target group assignment defined by the admin.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "target", Required = Newtonsoft.Json.Required.Default)]
        public DeviceAndAppManagementAssignmentTarget Target { get; set; }
    
    }
}

