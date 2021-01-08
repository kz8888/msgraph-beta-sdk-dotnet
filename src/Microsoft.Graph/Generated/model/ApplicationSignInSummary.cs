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
    /// The type Application Sign In Summary.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ApplicationSignInSummary : Entity
    {
    
		///<summary>
		/// The ApplicationSignInSummary constructor
		///</summary>
        public ApplicationSignInSummary()
        {
            this.ODataType = "microsoft.graph.applicationSignInSummary";
        }
	
        /// <summary>
        /// Gets or sets app display name.
        /// Name of the application that the user signed in to.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appDisplayName", Required = Newtonsoft.Json.Required.Default)]
        public string AppDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets failed sign in count.
        /// Count of failed sign-ins made by the application.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "failedSignInCount", Required = Newtonsoft.Json.Required.Default)]
        public Int64? FailedSignInCount { get; set; }
    
        /// <summary>
        /// Gets or sets successful sign in count.
        /// Count of successful sign-ins made by the application.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "successfulSignInCount", Required = Newtonsoft.Json.Required.Default)]
        public Int64? SuccessfulSignInCount { get; set; }
    
        /// <summary>
        /// Gets or sets success percentage.
        /// Percentage of successful sign-ins made by the application.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "successPercentage", Required = Newtonsoft.Json.Required.Default)]
        public double? SuccessPercentage { get; set; }
    
    }
}

