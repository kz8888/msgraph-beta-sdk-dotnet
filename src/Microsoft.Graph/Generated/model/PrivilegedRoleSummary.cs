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
    /// The type Privileged Role Summary.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class PrivilegedRoleSummary : Entity
    {
    
		///<summary>
		/// The PrivilegedRoleSummary constructor
		///</summary>
        public PrivilegedRoleSummary()
        {
            this.ODataType = "microsoft.graph.privilegedRoleSummary";
        }
	
        /// <summary>
        /// Gets or sets elevated count.
        /// The number of users that have the role assigned and the role is activated.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "elevatedCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? ElevatedCount { get; set; }
    
        /// <summary>
        /// Gets or sets managed count.
        /// The number of users that have the role assigned but the role is deactivated.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managedCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? ManagedCount { get; set; }
    
        /// <summary>
        /// Gets or sets mfa enabled.
        /// true if the role activation requires MFA. false if the role activation doesn't require MFA.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mfaEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? MfaEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// Possible values are: ok, bad. The value depends on the ratio of (managedCount / usersCount). If the ratio is less than a predefined threshold, ok is returned. Otherwise, bad is returned.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "status", Required = Newtonsoft.Json.Required.Default)]
        public RoleSummaryStatus? Status { get; set; }
    
        /// <summary>
        /// Gets or sets users count.
        /// The number of users that are assigned with the role.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "usersCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? UsersCount { get; set; }
    
    }
}

