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
    /// The type InferenceData.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class InferenceData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InferenceData"/> class.
        /// </summary>
        public InferenceData()
        {
            this.ODataType = "microsoft.graph.inferenceData";
        }

        /// <summary>
        /// Gets or sets confidenceScore.
        /// Confidence score reflecting the accuracy of the data inferred about the user.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "confidenceScore", Required = Newtonsoft.Json.Required.Default)]
        public double? ConfidenceScore { get; set; }
    
        /// <summary>
        /// Gets or sets userHasVerifiedAccuracy.
        /// Records if the user has confirmed this inference as being True or False.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userHasVerifiedAccuracy", Required = Newtonsoft.Json.Required.Default)]
        public bool? UserHasVerifiedAccuracy { get; set; }
    
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
