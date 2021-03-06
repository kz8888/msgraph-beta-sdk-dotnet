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
    /// The type LocateDeviceActionResult.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class LocateDeviceActionResult : DeviceActionResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocateDeviceActionResult"/> class.
        /// </summary>
        public LocateDeviceActionResult()
        {
            this.ODataType = "microsoft.graph.locateDeviceActionResult";
        }

        /// <summary>
        /// Gets or sets deviceLocation.
        /// device location
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceLocation", Required = Newtonsoft.Json.Required.Default)]
        public DeviceGeoLocation DeviceLocation { get; set; }
    
    }
}
