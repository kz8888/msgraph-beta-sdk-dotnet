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
    /// The type External Group.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ExternalGroup : Entity
    {
    
		///<summary>
		/// The ExternalGroup constructor
		///</summary>
        public ExternalGroup()
        {
            this.ODataType = "microsoft.graph.externalGroup";
        }
	
        /// <summary>
        /// Gets or sets description.
        /// The description of the external group. Optional.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description", Required = Newtonsoft.Json.Required.Default)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The friendly name of the external group. Optional.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets members.
        /// A member added to an externalGroup. You can add Azure Active Directory users, Azure Active Directory groups, or other externalGroups as members.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "members", Required = Newtonsoft.Json.Required.Default)]
        public IExternalGroupMembersCollectionPage Members { get; set; }
    
    }
}

