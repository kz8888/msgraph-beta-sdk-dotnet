// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Print Connector.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class PrintConnector : Entity
    {
    
		///<summary>
		/// The PrintConnector constructor
		///</summary>
        public PrintConnector()
        {
            this.ODataType = "microsoft.graph.printConnector";
        }
	
        /// <summary>
        /// Gets or sets app version.
        /// The connector's version.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appVersion", Required = Newtonsoft.Json.Required.Default)]
        public string AppVersion { get; set; }
    
        /// <summary>
        /// Gets or sets device health.
        /// The connector's device health.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceHealth", Required = Newtonsoft.Json.Required.Default)]
        public DeviceHealth DeviceHealth { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The name of the connector.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets fully qualified domain name.
        /// The connector machine's hostname.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fullyQualifiedDomainName", Required = Newtonsoft.Json.Required.Default)]
        public string FullyQualifiedDomainName { get; set; }
    
        /// <summary>
        /// Gets or sets location.
        /// The physical and/or organizational location of the connector.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "location", Required = Newtonsoft.Json.Required.Default)]
        public PrinterLocation Location { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "name", Required = Newtonsoft.Json.Required.Default)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets operating system.
        /// The connector machine's operating system version.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "operatingSystem", Required = Newtonsoft.Json.Required.Default)]
        public string OperatingSystem { get; set; }
    
        /// <summary>
        /// Gets or sets registered date time.
        /// The DateTimeOffset when the connector was registered.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "registeredDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? RegisteredDateTime { get; set; }
    
    }
}

