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
    /// The type RequestorManager.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class RequestorManager : UserSet
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestorManager"/> class.
        /// </summary>
        public RequestorManager()
        {
            this.ODataType = "microsoft.graph.requestorManager";
        }

        /// <summary>
        /// Gets or sets managerLevel.
        /// The hierarchical level of the manager with respect to the requestor. For example, the direct manager of a requestor would have a managerLevel of 1, while the manager of the requestor's manager would have a managerLevel of 2. Default value for managerLevel is 1. Possible values for this property range from 1 to 2.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managerLevel", Required = Newtonsoft.Json.Required.Default)]
        public Int32? ManagerLevel { get; set; }
    
    }
}
