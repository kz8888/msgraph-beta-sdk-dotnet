// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type GovernanceSchedule.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class GovernanceSchedule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GovernanceSchedule"/> class.
        /// </summary>
        public GovernanceSchedule()
        {
            this.ODataType = "microsoft.graph.governanceSchedule";
        }

        /// <summary>
        /// Gets or sets duration.
        /// The duration of a role assignment. It is in format of a TimeSpan.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "duration", Required = Newtonsoft.Json.Required.Default)]
        public Duration Duration { get; set; }
    
        /// <summary>
        /// Gets or sets endDateTime.
        /// The end time of the role assignment. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Note: if the value is null, it indicates a permanent assignment.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "endDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? EndDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets startDateTime.
        /// The start time of the role assignment. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "startDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? StartDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets type.
        /// The role assignment schedule type. Only Once is supported for now.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "type", Required = Newtonsoft.Json.Required.Default)]
        public string Type { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
