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
    /// The type Managed App Registration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ManagedAppRegistration : Entity
    {
    
		///<summary>
		/// The internal ManagedAppRegistration constructor
		///</summary>
        protected internal ManagedAppRegistration()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets app identifier.
        /// The app package Identifier
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appIdentifier", Required = Newtonsoft.Json.Required.Default)]
        public MobileAppIdentifier AppIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets application version.
        /// App version
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "applicationVersion", Required = Newtonsoft.Json.Required.Default)]
        public string ApplicationVersion { get; set; }
    
        /// <summary>
        /// Gets or sets azure addevice id.
        /// The Azure Active Directory Device identifier of the host device. Value could be empty even when the host device is Azure Active Directory registered.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "azureADDeviceId", Required = Newtonsoft.Json.Required.Default)]
        public string AzureADDeviceId { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// Date and time of creation
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets device manufacturer.
        /// The device manufacturer for the current app registration
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceManufacturer", Required = Newtonsoft.Json.Required.Default)]
        public string DeviceManufacturer { get; set; }
    
        /// <summary>
        /// Gets or sets device model.
        /// The device model for the current app registration
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceModel", Required = Newtonsoft.Json.Required.Default)]
        public string DeviceModel { get; set; }
    
        /// <summary>
        /// Gets or sets device name.
        /// Host device name
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceName", Required = Newtonsoft.Json.Required.Default)]
        public string DeviceName { get; set; }
    
        /// <summary>
        /// Gets or sets device tag.
        /// App management SDK generated tag, which helps relate apps hosted on the same device. Not guaranteed to relate apps in all conditions.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceTag", Required = Newtonsoft.Json.Required.Default)]
        public string DeviceTag { get; set; }
    
        /// <summary>
        /// Gets or sets device type.
        /// Host device type
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceType", Required = Newtonsoft.Json.Required.Default)]
        public string DeviceType { get; set; }
    
        /// <summary>
        /// Gets or sets flagged reasons.
        /// Zero or more reasons an app registration is flagged. E.g. app running on rooted device
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "flaggedReasons", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<ManagedAppFlaggedReason> FlaggedReasons { get; set; }
    
        /// <summary>
        /// Gets or sets last sync date time.
        /// Date and time of last the app synced with management service.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastSyncDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastSyncDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets managed device id.
        /// The Managed Device identifier of the host device. Value could be empty even when the host device is managed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managedDeviceId", Required = Newtonsoft.Json.Required.Default)]
        public string ManagedDeviceId { get; set; }
    
        /// <summary>
        /// Gets or sets management sdk version.
        /// App management SDK version
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managementSdkVersion", Required = Newtonsoft.Json.Required.Default)]
        public string ManagementSdkVersion { get; set; }
    
        /// <summary>
        /// Gets or sets platform version.
        /// Operating System version
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "platformVersion", Required = Newtonsoft.Json.Required.Default)]
        public string PlatformVersion { get; set; }
    
        /// <summary>
        /// Gets or sets user id.
        /// The user Id to who this app registration belongs.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userId", Required = Newtonsoft.Json.Required.Default)]
        public string UserId { get; set; }
    
        /// <summary>
        /// Gets or sets version.
        /// Version of the entity.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "version", Required = Newtonsoft.Json.Required.Default)]
        public string Version { get; set; }
    
        /// <summary>
        /// Gets or sets applied policies.
        /// Zero or more policys already applied on the registered app when it last synchronized with managment service.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appliedPolicies", Required = Newtonsoft.Json.Required.Default)]
        public IManagedAppRegistrationAppliedPoliciesCollectionPage AppliedPolicies { get; set; }
    
        /// <summary>
        /// Gets or sets intended policies.
        /// Zero or more policies admin intended for the app as of now.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "intendedPolicies", Required = Newtonsoft.Json.Required.Default)]
        public IManagedAppRegistrationIntendedPoliciesCollectionPage IntendedPolicies { get; set; }
    
        /// <summary>
        /// Gets or sets operations.
        /// Zero or more long running operations triggered on the app registration.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "operations", Required = Newtonsoft.Json.Required.Default)]
        public IManagedAppRegistrationOperationsCollectionPage Operations { get; set; }
    
    }
}

