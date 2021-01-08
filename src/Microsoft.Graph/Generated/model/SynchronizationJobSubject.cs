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
    /// The type SynchronizationJobSubject.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class SynchronizationJobSubject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SynchronizationJobSubject"/> class.
        /// </summary>
        public SynchronizationJobSubject()
        {
            this.ODataType = "microsoft.graph.synchronizationJobSubject";
        }

        /// <summary>
        /// Gets or sets objectId.
        /// The identifier of an object to which a synchronizationJob  is to be applied.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "objectId", Required = Newtonsoft.Json.Required.Default)]
        public string ObjectId { get; set; }
    
        /// <summary>
        /// Gets or sets objectTypeName.
        /// The type of the object to which a synchronizationJob  is to be applied.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "objectTypeName", Required = Newtonsoft.Json.Required.Default)]
        public string ObjectTypeName { get; set; }
    
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
