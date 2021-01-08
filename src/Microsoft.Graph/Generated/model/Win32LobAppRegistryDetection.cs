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
    /// The type Win32LobAppRegistryDetection.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Win32LobAppRegistryDetection : Win32LobAppDetection
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Win32LobAppRegistryDetection"/> class.
        /// </summary>
        public Win32LobAppRegistryDetection()
        {
            this.ODataType = "microsoft.graph.win32LobAppRegistryDetection";
        }

        /// <summary>
        /// Gets or sets check32BitOn64System.
        /// A value indicating whether this registry path is for checking 32-bit app on 64-bit system
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "check32BitOn64System", Required = Newtonsoft.Json.Required.Default)]
        public bool? Check32BitOn64System { get; set; }
    
        /// <summary>
        /// Gets or sets detectionType.
        /// The registry data detection type. Possible values are: notConfigured, exists, doesNotExist, string, integer, version.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "detectionType", Required = Newtonsoft.Json.Required.Default)]
        public Win32LobAppRegistryDetectionType? DetectionType { get; set; }
    
        /// <summary>
        /// Gets or sets detectionValue.
        /// The registry detection value
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "detectionValue", Required = Newtonsoft.Json.Required.Default)]
        public string DetectionValue { get; set; }
    
        /// <summary>
        /// Gets or sets keyPath.
        /// The registry key path to detect Win32 Line of Business (LoB) app
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "keyPath", Required = Newtonsoft.Json.Required.Default)]
        public string KeyPath { get; set; }
    
        /// <summary>
        /// Gets or sets operator.
        /// The operator for registry data detection. Possible values are: notConfigured, equal, notEqual, greaterThan, greaterThanOrEqual, lessThan, lessThanOrEqual.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "operator", Required = Newtonsoft.Json.Required.Default)]
        public Win32LobAppDetectionOperator? Operator { get; set; }
    
        /// <summary>
        /// Gets or sets valueName.
        /// The registry value name
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "valueName", Required = Newtonsoft.Json.Required.Default)]
        public string ValueName { get; set; }
    
    }
}
