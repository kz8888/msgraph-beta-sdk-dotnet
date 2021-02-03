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
    /// The type Device.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Device : DirectoryObject
    {
    
		///<summary>
		/// The Device constructor
		///</summary>
        public Device()
        {
            this.ODataType = "microsoft.graph.device";
        }
	
        /// <summary>
        /// Gets or sets account enabled.
        /// true if the account is enabled; otherwise, false. default is true.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "accountEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? AccountEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets alternative security ids.
        /// For internal use only. Not nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "alternativeSecurityIds", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<AlternativeSecurityId> AlternativeSecurityIds { get; set; }
    
        /// <summary>
        /// Gets or sets approximate last sign in date time.
        /// The timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "approximateLastSignInDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? ApproximateLastSignInDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets compliance expiration date time.
        /// The timestamp when the device is no longer deemed compliant. The timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "complianceExpirationDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? ComplianceExpirationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets device category.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceCategory", Required = Newtonsoft.Json.Required.Default)]
        public string DeviceCategory { get; set; }
    
        /// <summary>
        /// Gets or sets device id.
        /// Unique identifier set by Azure Device Registration Service at the time of registration.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceId", Required = Newtonsoft.Json.Required.Default)]
        public string DeviceId { get; set; }
    
        /// <summary>
        /// Gets or sets device metadata.
        /// For internal use only. Set to null.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceMetadata", Required = Newtonsoft.Json.Required.Default)]
        public string DeviceMetadata { get; set; }
    
        /// <summary>
        /// Gets or sets device ownership.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceOwnership", Required = Newtonsoft.Json.Required.Default)]
        public string DeviceOwnership { get; set; }
    
        /// <summary>
        /// Gets or sets device version.
        /// For internal use only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceVersion", Required = Newtonsoft.Json.Required.Default)]
        public Int32? DeviceVersion { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The display name for the device. Required.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets domain name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "domainName", Required = Newtonsoft.Json.Required.Default)]
        public string DomainName { get; set; }
    
        /// <summary>
        /// Gets or sets enrollment profile name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enrollmentProfileName", Required = Newtonsoft.Json.Required.Default)]
        public string EnrollmentProfileName { get; set; }
    
        /// <summary>
        /// Gets or sets enrollment type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enrollmentType", Required = Newtonsoft.Json.Required.Default)]
        public string EnrollmentType { get; set; }
    
        /// <summary>
        /// Gets or sets extension attributes.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "extensionAttributes", Required = Newtonsoft.Json.Required.Default)]
        public OnPremisesExtensionAttributes ExtensionAttributes { get; set; }
    
        /// <summary>
        /// Gets or sets hostnames.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "hostnames", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> Hostnames { get; set; }
    
        /// <summary>
        /// Gets or sets is compliant.
        /// true if the device complies with Mobile Device Management (MDM) policies; otherwise, false. Read-only. This can only be updated by Intune for any device OS type or by an approved MDM app for Windows OS devices.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isCompliant", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsCompliant { get; set; }
    
        /// <summary>
        /// Gets or sets is managed.
        /// true if the device is managed by a Mobile Device Management (MDM) app; otherwise, false. This can only be updated by Intune for any device OS type or by an approved MDM app for Windows OS devices.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isManaged", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsManaged { get; set; }
    
        /// <summary>
        /// Gets or sets is rooted.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isRooted", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsRooted { get; set; }
    
        /// <summary>
        /// Gets or sets management type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managementType", Required = Newtonsoft.Json.Required.Default)]
        public string ManagementType { get; set; }
    
        /// <summary>
        /// Gets or sets on premises last sync date time.
        /// The last time at which the object was synced with the on-premises directory. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z' Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "onPremisesLastSyncDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? OnPremisesLastSyncDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets on premises sync enabled.
        /// true if this object is synced from an on-premises directory; false if this object was originally synced from an on-premises directory but is no longer synced; null if this object has never been synced from an on-premises directory (default). Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "onPremisesSyncEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? OnPremisesSyncEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets operating system.
        /// The type of operating system on the device. Required.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "operatingSystem", Required = Newtonsoft.Json.Required.Default)]
        public string OperatingSystem { get; set; }
    
        /// <summary>
        /// Gets or sets operating system version.
        /// Operating system version of the device. Required.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "operatingSystemVersion", Required = Newtonsoft.Json.Required.Default)]
        public string OperatingSystemVersion { get; set; }
    
        /// <summary>
        /// Gets or sets physical ids.
        /// For internal use only. Not nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "physicalIds", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> PhysicalIds { get; set; }
    
        /// <summary>
        /// Gets or sets profile type.
        /// The profile type of the device. Possible values:RegisteredDevice (default)SecureVMPrinterSharedIoT
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "profileType", Required = Newtonsoft.Json.Required.Default)]
        public string ProfileType { get; set; }
    
        /// <summary>
        /// Gets or sets registration date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "registrationDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? RegistrationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets system labels.
        /// List of labels applied to the device by the system.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "systemLabels", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> SystemLabels { get; set; }
    
        /// <summary>
        /// Gets or sets trust type.
        /// Type of trust for the joined device. Read-only. Possible values: Workplace - indicates bring your own personal devicesAzureAd - Cloud only joined devicesServerAd - on-premises domain joined devices joined to Azure AD. For more details, see Introduction to device management in Azure Active Directory
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "trustType", Required = Newtonsoft.Json.Required.Default)]
        public string TrustType { get; set; }
    
        /// <summary>
        /// Gets or sets kind.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "kind", Required = Newtonsoft.Json.Required.Default)]
        public string Kind { get; set; }
    
        /// <summary>
        /// Gets or sets manufacturer.
        /// Manufacturer of the device. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "manufacturer", Required = Newtonsoft.Json.Required.Default)]
        public string Manufacturer { get; set; }
    
        /// <summary>
        /// Gets or sets model.
        /// Model of the device. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "model", Required = Newtonsoft.Json.Required.Default)]
        public string Model { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "name", Required = Newtonsoft.Json.Required.Default)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets platform.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "platform", Required = Newtonsoft.Json.Required.Default)]
        public string Platform { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "status", Required = Newtonsoft.Json.Required.Default)]
        public string Status { get; set; }
    
        /// <summary>
        /// Gets or sets usage rights.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "usageRights", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceUsageRightsCollectionPage UsageRights { get; set; }
    
        /// <summary>
        /// Gets or sets member of.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "memberOf", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceMemberOfCollectionWithReferencesPage MemberOf { get; set; }
    
        /// <summary>
        /// Gets or sets registered owners.
        /// The user that cloud joined the device or registered their personal device. The registered owner is set at the time of registration. Currently, there can be only one owner. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "registeredOwners", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceRegisteredOwnersCollectionWithReferencesPage RegisteredOwners { get; set; }
    
        /// <summary>
        /// Gets or sets registered users.
        /// Collection of registered users of the device. For cloud joined devices and registered personal devices, registered users are set to the same value as registered owners at the time of registration. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "registeredUsers", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceRegisteredUsersCollectionWithReferencesPage RegisteredUsers { get; set; }
    
        /// <summary>
        /// Gets or sets transitive member of.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "transitiveMemberOf", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceTransitiveMemberOfCollectionWithReferencesPage TransitiveMemberOf { get; set; }
    
        /// <summary>
        /// Gets or sets extensions.
        /// The collection of open extensions defined for the device. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "extensions", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceExtensionsCollectionPage Extensions { get; set; }
    
        /// <summary>
        /// Gets or sets commands.
        /// Set of commands sent to this device
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "commands", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceCommandsCollectionPage Commands { get; set; }
    
    }
}

