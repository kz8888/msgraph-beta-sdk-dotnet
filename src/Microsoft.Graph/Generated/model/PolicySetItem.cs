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
    /// The type Policy Set Item.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class PolicySetItem : Entity
    {
    
		///<summary>
		/// The internal PolicySetItem constructor
		///</summary>
        protected internal PolicySetItem()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets created date time.
        /// Creation time of the PolicySetItem.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// DisplayName of the PolicySetItem.
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
        /// Gets or sets item type.
        /// policySetType of the PolicySetItem.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "itemType", Required = Newtonsoft.Json.Required.Default)]
        public string ItemType { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// Last modified time of the PolicySetItem.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastModifiedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets payload id.
        /// PayloadId of the PolicySetItem.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payloadId", Required = Newtonsoft.Json.Required.Default)]
        public string PayloadId { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// Status of the PolicySetItem. Possible values are: unknown, validating, partialSuccess, success, error, notAssigned.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "status", Required = Newtonsoft.Json.Required.Default)]
        public PolicySetStatus? Status { get; set; }
    
    }
}

