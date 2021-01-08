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
    /// The type Call Activity Statistics.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class CallActivityStatistics : ActivityStatistics
    {
    
		///<summary>
		/// The CallActivityStatistics constructor
		///</summary>
        public CallActivityStatistics()
        {
            this.ODataType = "microsoft.graph.callActivityStatistics";
        }
	
        /// <summary>
        /// Gets or sets after hours.
        /// Time spent on calls outside of working hours, which is based on the user's Outlook calendar setting for work hours. The value is represented in ISO 8601 format for durations.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "afterHours", Required = Newtonsoft.Json.Required.Default)]
        public Duration AfterHours { get; set; }
    
    }
}

