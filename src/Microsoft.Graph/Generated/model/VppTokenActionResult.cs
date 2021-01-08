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
    /// The type VppTokenActionResult.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class VppTokenActionResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VppTokenActionResult"/> class.
        /// </summary>
        public VppTokenActionResult()
        {
            this.ODataType = "microsoft.graph.vppTokenActionResult";
        }

        /// <summary>
        /// Gets or sets actionName.
        /// Action name
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "actionName", Required = Newtonsoft.Json.Required.Default)]
        public string ActionName { get; set; }
    
        /// <summary>
        /// Gets or sets actionState.
        /// State of the action. Possible values are: none, pending, canceled, active, done, failed, notSupported.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "actionState", Required = Newtonsoft.Json.Required.Default)]
        public ActionState? ActionState { get; set; }
    
        /// <summary>
        /// Gets or sets lastUpdatedDateTime.
        /// Time the action state was last updated
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastUpdatedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastUpdatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets startDateTime.
        /// Time the action was initiated
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "startDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? StartDateTime { get; set; }
    
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
