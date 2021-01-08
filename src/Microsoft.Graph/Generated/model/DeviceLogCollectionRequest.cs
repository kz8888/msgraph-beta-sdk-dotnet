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
    /// The type DeviceLogCollectionRequest.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class DeviceLogCollectionRequestObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceLogCollectionRequestObject"/> class.
        /// </summary>
        public DeviceLogCollectionRequestObject()
        {
            this.ODataType = "microsoft.graph.deviceLogCollectionRequest";
        }

        /// <summary>
        /// Gets or sets id.
        /// The unique identifier
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id", Required = Newtonsoft.Json.Required.Default)]
        public string Id { get; set; }
    
        /// <summary>
        /// Gets or sets templateType.
        /// The template type that is sent with the collection request. Possible values are: predefined.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "templateType", Required = Newtonsoft.Json.Required.Default)]
        public DeviceLogCollectionTemplateType? TemplateType { get; set; }
    
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
