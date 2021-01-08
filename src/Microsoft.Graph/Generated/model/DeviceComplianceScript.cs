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
    /// The type Device Compliance Script.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeviceComplianceScript : Entity
    {
    
		///<summary>
		/// The DeviceComplianceScript constructor
		///</summary>
        public DeviceComplianceScript()
        {
            this.ODataType = "microsoft.graph.deviceComplianceScript";
        }
	
        /// <summary>
        /// Gets or sets created date time.
        /// The timestamp of when the device compliance script was created. This property is read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// Description of the device compliance script
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description", Required = Newtonsoft.Json.Required.Default)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets detection script content.
        /// The entire content of the detection powershell script
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "detectionScriptContent", Required = Newtonsoft.Json.Required.Default)]
        public byte[] DetectionScriptContent { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Name of the device compliance script
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets enforce signature check.
        /// Indicate whether the script signature needs be checked
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enforceSignatureCheck", Required = Newtonsoft.Json.Required.Default)]
        public bool? EnforceSignatureCheck { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// The timestamp of when the device compliance script was modified. This property is read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastModifiedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets publisher.
        /// Name of the device compliance script publisher
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "publisher", Required = Newtonsoft.Json.Required.Default)]
        public string Publisher { get; set; }
    
        /// <summary>
        /// Gets or sets role scope tag ids.
        /// List of Scope Tag IDs for the device compliance script
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "roleScopeTagIds", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> RoleScopeTagIds { get; set; }
    
        /// <summary>
        /// Gets or sets run as32bit.
        /// Indicate whether PowerShell script(s) should run as 32-bit
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "runAs32Bit", Required = Newtonsoft.Json.Required.Default)]
        public bool? RunAs32Bit { get; set; }
    
        /// <summary>
        /// Gets or sets run as account.
        /// Indicates the type of execution context. Possible values are: system, user.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "runAsAccount", Required = Newtonsoft.Json.Required.Default)]
        public RunAsAccountType? RunAsAccount { get; set; }
    
        /// <summary>
        /// Gets or sets version.
        /// Version of the device compliance script
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "version", Required = Newtonsoft.Json.Required.Default)]
        public string Version { get; set; }
    
        /// <summary>
        /// Gets or sets assignments.
        /// The list of group assignments for the device compliance script
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assignments", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceComplianceScriptAssignmentsCollectionPage Assignments { get; set; }
    
        /// <summary>
        /// Gets or sets device run states.
        /// List of run states for the device compliance script across all devices
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceRunStates", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceComplianceScriptDeviceRunStatesCollectionPage DeviceRunStates { get; set; }
    
        /// <summary>
        /// Gets or sets run summary.
        /// High level run summary for device compliance script.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "runSummary", Required = Newtonsoft.Json.Required.Default)]
        public DeviceComplianceScriptRunSummary RunSummary { get; set; }
    
    }
}

