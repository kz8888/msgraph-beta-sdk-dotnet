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
    /// The type Android Eas Email Profile Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AndroidEasEmailProfileConfiguration : DeviceConfiguration
    {
    
		///<summary>
		/// The AndroidEasEmailProfileConfiguration constructor
		///</summary>
        public AndroidEasEmailProfileConfiguration()
        {
            this.ODataType = "microsoft.graph.androidEasEmailProfileConfiguration";
        }
	
        /// <summary>
        /// Gets or sets account name.
        /// Exchange ActiveSync account name, displayed to users as name of EAS (this) profile.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "accountName", Required = Newtonsoft.Json.Required.Default)]
        public string AccountName { get; set; }
    
        /// <summary>
        /// Gets or sets authentication method.
        /// Authentication method for Exchange ActiveSync. Possible values are: usernameAndPassword, certificate, derivedCredential.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "authenticationMethod", Required = Newtonsoft.Json.Required.Default)]
        public EasAuthenticationMethod? AuthenticationMethod { get; set; }
    
        /// <summary>
        /// Gets or sets custom domain name.
        /// Custom domain name value used while generating an email profile before installing on the device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "customDomainName", Required = Newtonsoft.Json.Required.Default)]
        public string CustomDomainName { get; set; }
    
        /// <summary>
        /// Gets or sets duration of email to sync.
        /// Duration of time email should be synced to. Possible values are: userDefined, oneDay, threeDays, oneWeek, twoWeeks, oneMonth, unlimited.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "durationOfEmailToSync", Required = Newtonsoft.Json.Required.Default)]
        public EmailSyncDuration? DurationOfEmailToSync { get; set; }
    
        /// <summary>
        /// Gets or sets email address source.
        /// Email attribute that is picked from AAD and injected into this profile before installing on the device. Possible values are: userPrincipalName, primarySmtpAddress.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "emailAddressSource", Required = Newtonsoft.Json.Required.Default)]
        public UserEmailSource? EmailAddressSource { get; set; }
    
        /// <summary>
        /// Gets or sets email sync schedule.
        /// Email sync schedule. Possible values are: userDefined, asMessagesArrive, manual, fifteenMinutes, thirtyMinutes, sixtyMinutes, basedOnMyUsage.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "emailSyncSchedule", Required = Newtonsoft.Json.Required.Default)]
        public EmailSyncSchedule? EmailSyncSchedule { get; set; }
    
        /// <summary>
        /// Gets or sets host name.
        /// Exchange location (URL) that the native mail app connects to.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "hostName", Required = Newtonsoft.Json.Required.Default)]
        public string HostName { get; set; }
    
        /// <summary>
        /// Gets or sets require smime.
        /// Indicates whether or not to use S/MIME certificate.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "requireSmime", Required = Newtonsoft.Json.Required.Default)]
        public bool? RequireSmime { get; set; }
    
        /// <summary>
        /// Gets or sets require ssl.
        /// Indicates whether or not to use SSL.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "requireSsl", Required = Newtonsoft.Json.Required.Default)]
        public bool? RequireSsl { get; set; }
    
        /// <summary>
        /// Gets or sets sync calendar.
        /// Toggles syncing the calendar. If set to false calendar is turned off on the device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "syncCalendar", Required = Newtonsoft.Json.Required.Default)]
        public bool? SyncCalendar { get; set; }
    
        /// <summary>
        /// Gets or sets sync contacts.
        /// Toggles syncing contacts. If set to false contacts are turned off on the device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "syncContacts", Required = Newtonsoft.Json.Required.Default)]
        public bool? SyncContacts { get; set; }
    
        /// <summary>
        /// Gets or sets sync notes.
        /// Toggles syncing notes. If set to false notes are turned off on the device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "syncNotes", Required = Newtonsoft.Json.Required.Default)]
        public bool? SyncNotes { get; set; }
    
        /// <summary>
        /// Gets or sets sync tasks.
        /// Toggles syncing tasks. If set to false tasks are turned off on the device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "syncTasks", Required = Newtonsoft.Json.Required.Default)]
        public bool? SyncTasks { get; set; }
    
        /// <summary>
        /// Gets or sets user domain name source.
        /// UserDomainname attribute that is picked from AAD and injected into this profile before installing on the device. Possible values are: fullDomainName, netBiosDomainName.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userDomainNameSource", Required = Newtonsoft.Json.Required.Default)]
        public DomainNameSource? UserDomainNameSource { get; set; }
    
        /// <summary>
        /// Gets or sets username source.
        /// Username attribute that is picked from AAD and injected into this profile before installing on the device. Possible values are: username, userPrincipalName, samAccountName, primarySmtpAddress.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "usernameSource", Required = Newtonsoft.Json.Required.Default)]
        public AndroidUsernameSource? UsernameSource { get; set; }
    
        /// <summary>
        /// Gets or sets identity certificate.
        /// Identity certificate.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "identityCertificate", Required = Newtonsoft.Json.Required.Default)]
        public AndroidCertificateProfileBase IdentityCertificate { get; set; }
    
        /// <summary>
        /// Gets or sets smime signing certificate.
        /// S/MIME signing certificate.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "smimeSigningCertificate", Required = Newtonsoft.Json.Required.Default)]
        public AndroidCertificateProfileBase SmimeSigningCertificate { get; set; }
    
    }
}

