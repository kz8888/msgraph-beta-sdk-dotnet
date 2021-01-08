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
    /// The type Imported Windows Autopilot Device Identity.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ImportedWindowsAutopilotDeviceIdentity : Entity
    {
    
		///<summary>
		/// The ImportedWindowsAutopilotDeviceIdentity constructor
		///</summary>
        public ImportedWindowsAutopilotDeviceIdentity()
        {
            this.ODataType = "microsoft.graph.importedWindowsAutopilotDeviceIdentity";
        }
	
        /// <summary>
        /// Gets or sets assigned user principal name.
        /// UPN of the user the device will be assigned
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assignedUserPrincipalName", Required = Newtonsoft.Json.Required.Default)]
        public string AssignedUserPrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets group tag.
        /// Group Tag of the Windows autopilot device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "groupTag", Required = Newtonsoft.Json.Required.Default)]
        public string GroupTag { get; set; }
    
        /// <summary>
        /// Gets or sets hardware identifier.
        /// Hardware Blob of the Windows autopilot device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "hardwareIdentifier", Required = Newtonsoft.Json.Required.Default)]
        public byte[] HardwareIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets import id.
        /// The Import Id of the Windows autopilot device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "importId", Required = Newtonsoft.Json.Required.Default)]
        public string ImportId { get; set; }
    
        /// <summary>
        /// Gets or sets order identifier.
        /// Order Id of the Windows autopilot device. - Deprecate
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "orderIdentifier", Required = Newtonsoft.Json.Required.Default)]
        public string OrderIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets product key.
        /// Product Key of the Windows autopilot device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "productKey", Required = Newtonsoft.Json.Required.Default)]
        public string ProductKey { get; set; }
    
        /// <summary>
        /// Gets or sets serial number.
        /// Serial number of the Windows autopilot device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "serialNumber", Required = Newtonsoft.Json.Required.Default)]
        public string SerialNumber { get; set; }
    
        /// <summary>
        /// Gets or sets state.
        /// Current state of the imported device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state", Required = Newtonsoft.Json.Required.Default)]
        public ImportedWindowsAutopilotDeviceIdentityState State { get; set; }
    
    }
}

