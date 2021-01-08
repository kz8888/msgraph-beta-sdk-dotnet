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
    /// The type Continuous Access Evaluation Policy.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ContinuousAccessEvaluationPolicy : Entity
    {
    
		///<summary>
		/// The ContinuousAccessEvaluationPolicy constructor
		///</summary>
        public ContinuousAccessEvaluationPolicy()
        {
            this.ODataType = "microsoft.graph.continuousAccessEvaluationPolicy";
        }
	
        /// <summary>
        /// Gets or sets description.
        /// Continuous access evaluation automatically blocks access to resources and applications in near real time when a user's access is removed or a client IP address changes. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description", Required = Newtonsoft.Json.Required.Default)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The value is always 'Continuous Access Evaluation'. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets groups.
        /// The collection of group identifiers in scope for evaluation. All groups are in scope when the collection is empty.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "groups", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> Groups { get; set; }
    
        /// <summary>
        /// Gets or sets is enabled.
        /// true to indicate whether continuous access evaluation should be performed; otherwise false.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets users.
        /// The collection of user identifiers in scope for evaluation. All users are in scope when the collection is empty.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "users", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> Users { get; set; }
    
    }
}

