// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Policy Set Assignment.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class PolicySetAssignment : Entity
    {
    
		///<summary>
		/// The PolicySetAssignment constructor
		///</summary>
        public PolicySetAssignment()
        {
            this.ODataType = "microsoft.graph.policySetAssignment";
        }
	
        /// <summary>
        /// Gets or sets last modified date time.
        /// Last modified time of the PolicySetAssignment.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastModifiedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets target.
        /// The target group of PolicySetAssignment
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "target", Required = Newtonsoft.Json.Required.Default)]
        public DeviceAndAppManagementAssignmentTarget Target { get; set; }
    
    }
}
