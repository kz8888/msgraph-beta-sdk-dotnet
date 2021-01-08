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
    /// The type RubricQuality.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class RubricQuality
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RubricQuality"/> class.
        /// </summary>
        public RubricQuality()
        {
            this.ODataType = "microsoft.graph.rubricQuality";
        }

        /// <summary>
        /// Gets or sets criteria.
        /// The collection of criteria for this rubric quality.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "criteria", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<RubricCriterion> Criteria { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// The description of this rubric quality.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description", Required = Newtonsoft.Json.Required.Default)]
        public EducationItemBody Description { get; set; }
    
        /// <summary>
        /// Gets or sets displayName.
        /// The name of this rubric quality.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets qualityId.
        /// The ID of this resource.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "qualityId", Required = Newtonsoft.Json.Required.Default)]
        public string QualityId { get; set; }
    
        /// <summary>
        /// Gets or sets weight.
        /// If present, a numerical weight for this quality.  Weights must add up to 100.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "weight", Required = Newtonsoft.Json.Required.Default)]
        public Single? Weight { get; set; }
    
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
