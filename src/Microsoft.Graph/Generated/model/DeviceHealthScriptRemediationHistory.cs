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
    /// The type DeviceHealthScriptRemediationHistory.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class DeviceHealthScriptRemediationHistory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceHealthScriptRemediationHistory"/> class.
        /// </summary>
        public DeviceHealthScriptRemediationHistory()
        {
            this.ODataType = "microsoft.graph.deviceHealthScriptRemediationHistory";
        }

        /// <summary>
        /// Gets or sets historyData.
        /// The number of devices remediated by the device health script on the given date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "historyData", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<DeviceHealthScriptRemediationHistoryData> HistoryData { get; set; }
    
        /// <summary>
        /// Gets or sets lastModifiedDateTime.
        /// The date on which the results history is calculated for the healthscript.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastModifiedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
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
