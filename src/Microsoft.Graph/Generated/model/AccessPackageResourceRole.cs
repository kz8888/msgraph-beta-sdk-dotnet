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
    /// The type Access Package Resource Role.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AccessPackageResourceRole : Entity
    {
    
		///<summary>
		/// The AccessPackageResourceRole constructor
		///</summary>
        public AccessPackageResourceRole()
        {
            this.ODataType = "microsoft.graph.accessPackageResourceRole";
        }
	
        /// <summary>
        /// Gets or sets description.
        /// A description for the resource role.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description", Required = Newtonsoft.Json.Required.Default)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The display name of the resource role such as the role defined by the application.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets origin id.
        /// The unique identifier of the resource role in the origin system.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "originId", Required = Newtonsoft.Json.Required.Default)]
        public string OriginId { get; set; }
    
        /// <summary>
        /// Gets or sets origin system.
        /// The type of the resource in the origin system, such as SharePointOnline, AadApplication or AadGroup.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "originSystem", Required = Newtonsoft.Json.Required.Default)]
        public string OriginSystem { get; set; }
    
        /// <summary>
        /// Gets or sets access package resource.
        /// Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "accessPackageResource", Required = Newtonsoft.Json.Required.Default)]
        public AccessPackageResource AccessPackageResource { get; set; }
    
    }
}

