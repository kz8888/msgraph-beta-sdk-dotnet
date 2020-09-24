// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type CalendarSharingMessageAction.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class CalendarSharingMessageAction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CalendarSharingMessageAction"/> class.
        /// </summary>
        public CalendarSharingMessageAction()
        {
            this.ODataType = "microsoft.graph.calendarSharingMessageAction";
        }

        /// <summary>
        /// Gets or sets action.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "action", Required = Newtonsoft.Json.Required.Default)]
        public CalendarSharingAction? Action { get; set; }
    
        /// <summary>
        /// Gets or sets actionType.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "actionType", Required = Newtonsoft.Json.Required.Default)]
        public CalendarSharingActionType? ActionType { get; set; }
    
        /// <summary>
        /// Gets or sets importance.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "importance", Required = Newtonsoft.Json.Required.Default)]
        public CalendarSharingActionImportance? Importance { get; set; }
    
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