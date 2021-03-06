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
    /// The type RecommendLabelAction.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class RecommendLabelAction : InformationProtectionAction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecommendLabelAction"/> class.
        /// </summary>
        public RecommendLabelAction()
        {
            this.ODataType = "microsoft.graph.recommendLabelAction";
        }

        /// <summary>
        /// Gets or sets actions.
        /// Actions to take if the label is accepted by the user.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "actions", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<InformationProtectionAction> Actions { get; set; }
    
        /// <summary>
        /// Gets or sets actionSource.
        /// Possible values are: manual, automatic, recommended, default.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "actionSource", Required = Newtonsoft.Json.Required.Default)]
        public ActionSource? ActionSource { get; set; }
    
        /// <summary>
        /// Gets or sets label.
        /// The label that is being recommended.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "label", Required = Newtonsoft.Json.Required.Default)]
        public LabelDetails Label { get; set; }
    
        /// <summary>
        /// Gets or sets responsibleSensitiveTypeIds.
        /// The sensitive information type GUIDs that caused the recommendation to be given.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "responsibleSensitiveTypeIds", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<Guid> ResponsibleSensitiveTypeIds { get; set; }
    
    }
}
