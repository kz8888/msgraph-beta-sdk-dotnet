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
    /// The type Eas Email Profile Configuration Base.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class EasEmailProfileConfigurationBase : DeviceConfiguration
    {
    
		///<summary>
		/// The internal EasEmailProfileConfigurationBase constructor
		///</summary>
        protected internal EasEmailProfileConfigurationBase()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets custom domain name.
        /// Custom domain name value used while generating an email profile before installing on the device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "customDomainName", Required = Newtonsoft.Json.Required.Default)]
        public string CustomDomainName { get; set; }
    
        /// <summary>
        /// Gets or sets user domain name source.
        /// UserDomainname attribute that is picked from AAD and injected into this profile before installing on the device. Possible values are: fullDomainName, netBiosDomainName.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userDomainNameSource", Required = Newtonsoft.Json.Required.Default)]
        public DomainNameSource? UserDomainNameSource { get; set; }
    
        /// <summary>
        /// Gets or sets username aadsource.
        /// Name of the AAD field, that will be used to retrieve UserName for email profile. Possible values are: userPrincipalName, primarySmtpAddress, samAccountName.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "usernameAADSource", Required = Newtonsoft.Json.Required.Default)]
        public UsernameSource? UsernameAADSource { get; set; }
    
        /// <summary>
        /// Gets or sets username source.
        /// Username attribute that is picked from AAD and injected into this profile before installing on the device. Possible values are: userPrincipalName, primarySmtpAddress.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "usernameSource", Required = Newtonsoft.Json.Required.Default)]
        public UserEmailSource? UsernameSource { get; set; }
    
    }
}

