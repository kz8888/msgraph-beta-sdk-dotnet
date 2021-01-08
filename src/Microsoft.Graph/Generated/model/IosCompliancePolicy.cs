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
    /// The type Ios Compliance Policy.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class IosCompliancePolicy : DeviceCompliancePolicy
    {
    
		///<summary>
		/// The IosCompliancePolicy constructor
		///</summary>
        public IosCompliancePolicy()
        {
            this.ODataType = "microsoft.graph.iosCompliancePolicy";
        }
	
        /// <summary>
        /// Gets or sets advanced threat protection required security level.
        /// MDATP Require Mobile Threat Protection minimum risk level to report noncompliance. Possible values are: unavailable, secured, low, medium, high, notSet.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "advancedThreatProtectionRequiredSecurityLevel", Required = Newtonsoft.Json.Required.Default)]
        public DeviceThreatProtectionLevel? AdvancedThreatProtectionRequiredSecurityLevel { get; set; }
    
        /// <summary>
        /// Gets or sets device threat protection enabled.
        /// Require that devices have enabled device threat protection .
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceThreatProtectionEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? DeviceThreatProtectionEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets device threat protection required security level.
        /// Require Mobile Threat Protection minimum risk level to report noncompliance. Possible values are: unavailable, secured, low, medium, high, notSet.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceThreatProtectionRequiredSecurityLevel", Required = Newtonsoft.Json.Required.Default)]
        public DeviceThreatProtectionLevel? DeviceThreatProtectionRequiredSecurityLevel { get; set; }
    
        /// <summary>
        /// Gets or sets managed email profile required.
        /// Indicates whether or not to require a managed email profile.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managedEmailProfileRequired", Required = Newtonsoft.Json.Required.Default)]
        public bool? ManagedEmailProfileRequired { get; set; }
    
        /// <summary>
        /// Gets or sets os maximum build version.
        /// Maximum IOS build version.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "osMaximumBuildVersion", Required = Newtonsoft.Json.Required.Default)]
        public string OsMaximumBuildVersion { get; set; }
    
        /// <summary>
        /// Gets or sets os maximum version.
        /// Maximum IOS version.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "osMaximumVersion", Required = Newtonsoft.Json.Required.Default)]
        public string OsMaximumVersion { get; set; }
    
        /// <summary>
        /// Gets or sets os minimum build version.
        /// Minimum IOS build version.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "osMinimumBuildVersion", Required = Newtonsoft.Json.Required.Default)]
        public string OsMinimumBuildVersion { get; set; }
    
        /// <summary>
        /// Gets or sets os minimum version.
        /// Minimum IOS version.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "osMinimumVersion", Required = Newtonsoft.Json.Required.Default)]
        public string OsMinimumVersion { get; set; }
    
        /// <summary>
        /// Gets or sets passcode block simple.
        /// Indicates whether or not to block simple passcodes.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passcodeBlockSimple", Required = Newtonsoft.Json.Required.Default)]
        public bool? PasscodeBlockSimple { get; set; }
    
        /// <summary>
        /// Gets or sets passcode expiration days.
        /// Number of days before the passcode expires. Valid values 1 to 65535
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passcodeExpirationDays", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasscodeExpirationDays { get; set; }
    
        /// <summary>
        /// Gets or sets passcode minimum character set count.
        /// The number of character sets required in the password.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passcodeMinimumCharacterSetCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasscodeMinimumCharacterSetCount { get; set; }
    
        /// <summary>
        /// Gets or sets passcode minimum length.
        /// Minimum length of passcode. Valid values 4 to 14
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passcodeMinimumLength", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasscodeMinimumLength { get; set; }
    
        /// <summary>
        /// Gets or sets passcode minutes of inactivity before lock.
        /// Minutes of inactivity before a passcode is required.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passcodeMinutesOfInactivityBeforeLock", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasscodeMinutesOfInactivityBeforeLock { get; set; }
    
        /// <summary>
        /// Gets or sets passcode minutes of inactivity before screen timeout.
        /// Minutes of inactivity before the screen times out.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passcodeMinutesOfInactivityBeforeScreenTimeout", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasscodeMinutesOfInactivityBeforeScreenTimeout { get; set; }
    
        /// <summary>
        /// Gets or sets passcode previous passcode block count.
        /// Number of previous passcodes to block. Valid values 1 to 24
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passcodePreviousPasscodeBlockCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasscodePreviousPasscodeBlockCount { get; set; }
    
        /// <summary>
        /// Gets or sets passcode required.
        /// Indicates whether or not to require a passcode.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passcodeRequired", Required = Newtonsoft.Json.Required.Default)]
        public bool? PasscodeRequired { get; set; }
    
        /// <summary>
        /// Gets or sets passcode required type.
        /// The required passcode type. Possible values are: deviceDefault, alphanumeric, numeric.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passcodeRequiredType", Required = Newtonsoft.Json.Required.Default)]
        public RequiredPasswordType? PasscodeRequiredType { get; set; }
    
        /// <summary>
        /// Gets or sets restricted apps.
        /// Require the device to not have the specified apps installed. This collection can contain a maximum of 100 elements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "restrictedApps", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<AppListItem> RestrictedApps { get; set; }
    
        /// <summary>
        /// Gets or sets security block jailbroken devices.
        /// Devices must not be jailbroken or rooted.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "securityBlockJailbrokenDevices", Required = Newtonsoft.Json.Required.Default)]
        public bool? SecurityBlockJailbrokenDevices { get; set; }
    
    }
}

