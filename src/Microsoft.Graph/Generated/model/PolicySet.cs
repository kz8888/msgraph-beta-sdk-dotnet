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
    /// The type Policy Set.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class PolicySet : Entity
    {
    
		///<summary>
		/// The PolicySet constructor
		///</summary>
        public PolicySet()
        {
            this.ODataType = "microsoft.graph.policySet";
        }
	
        /// <summary>
        /// Gets or sets created date time.
        /// Creation time of the PolicySet.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// Description of the PolicySet.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description", Required = Newtonsoft.Json.Required.Default)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// DisplayName of the PolicySet.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets error code.
        /// Error code if any occured. Possible values are: noError, unauthorized, notFound, deleted.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "errorCode", Required = Newtonsoft.Json.Required.Default)]
        public ErrorCode? ErrorCode { get; set; }
    
        /// <summary>
        /// Gets or sets guided deployment tags.
        /// Tags of the guided deployment
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "guidedDeploymentTags", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> GuidedDeploymentTags { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// Last modified time of the PolicySet.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastModifiedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets role scope tags.
        /// RoleScopeTags of the PolicySet
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "roleScopeTags", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> RoleScopeTags { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// Validation/assignment status of the PolicySet. Possible values are: unknown, validating, partialSuccess, success, error, notAssigned.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "status", Required = Newtonsoft.Json.Required.Default)]
        public PolicySetStatus? Status { get; set; }
    
        /// <summary>
        /// Gets or sets assignments.
        /// Assignments of the PolicySet.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assignments", Required = Newtonsoft.Json.Required.Default)]
        public IPolicySetAssignmentsCollectionPage Assignments { get; set; }
    
        /// <summary>
        /// Gets or sets items.
        /// Items of the PolicySet with maximum count 100.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "items", Required = Newtonsoft.Json.Required.Default)]
        public IPolicySetItemsCollectionPage Items { get; set; }
    
    }
}

