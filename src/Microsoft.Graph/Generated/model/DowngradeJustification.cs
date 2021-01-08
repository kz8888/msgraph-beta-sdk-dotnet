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
    /// The type DowngradeJustification.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class DowngradeJustification
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DowngradeJustification"/> class.
        /// </summary>
        public DowngradeJustification()
        {
            this.ODataType = "microsoft.graph.downgradeJustification";
        }

        /// <summary>
        /// Gets or sets isDowngradeJustified.
        /// Indicates whether the downgrade is or is not justified.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isDowngradeJustified", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsDowngradeJustified { get; set; }
    
        /// <summary>
        /// Gets or sets justificationMessage.
        /// Message that indicates why a downgrade is justified. The message will appear in administrative logs.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "justificationMessage", Required = Newtonsoft.Json.Required.Default)]
        public string JustificationMessage { get; set; }
    
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
