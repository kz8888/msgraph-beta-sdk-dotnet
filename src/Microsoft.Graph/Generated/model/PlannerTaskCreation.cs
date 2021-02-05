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
    /// The type PlannerTaskCreation.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class PlannerTaskCreation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlannerTaskCreation"/> class.
        /// </summary>
        public PlannerTaskCreation()
        {
            this.ODataType = "microsoft.graph.plannerTaskCreation";
        }

        /// <summary>
        /// Gets or sets teamsPublicationInfo.
        /// Information about the publication process that created this task. null value indicates that the task was not created by a publication process.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "teamsPublicationInfo", Required = Newtonsoft.Json.Required.Default)]
        public PlannerTeamsPublicationInfo TeamsPublicationInfo { get; set; }
    
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
