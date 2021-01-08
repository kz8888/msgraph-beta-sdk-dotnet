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
    /// The type Ios Pkcs Certificate Profile.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class IosPkcsCertificateProfile : IosCertificateProfileBase
    {
    
		///<summary>
		/// The IosPkcsCertificateProfile constructor
		///</summary>
        public IosPkcsCertificateProfile()
        {
            this.ODataType = "microsoft.graph.iosPkcsCertificateProfile";
        }
	
        /// <summary>
        /// Gets or sets certificate store.
        /// Target store certificate. Possible values are: user, machine.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "certificateStore", Required = Newtonsoft.Json.Required.Default)]
        public CertificateStore? CertificateStore { get; set; }
    
        /// <summary>
        /// Gets or sets certificate template name.
        /// PKCS Certificate Template Name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "certificateTemplateName", Required = Newtonsoft.Json.Required.Default)]
        public string CertificateTemplateName { get; set; }
    
        /// <summary>
        /// Gets or sets certification authority.
        /// PKCS Certification Authority.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "certificationAuthority", Required = Newtonsoft.Json.Required.Default)]
        public string CertificationAuthority { get; set; }
    
        /// <summary>
        /// Gets or sets certification authority name.
        /// PKCS Certification Authority Name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "certificationAuthorityName", Required = Newtonsoft.Json.Required.Default)]
        public string CertificationAuthorityName { get; set; }
    
        /// <summary>
        /// Gets or sets custom subject alternative names.
        /// Custom Subject Alternative Name Settings. This collection can contain a maximum of 500 elements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "customSubjectAlternativeNames", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<CustomSubjectAlternativeName> CustomSubjectAlternativeNames { get; set; }
    
        /// <summary>
        /// Gets or sets subject alternative name format string.
        /// Custom String that defines the AAD Attribute.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subjectAlternativeNameFormatString", Required = Newtonsoft.Json.Required.Default)]
        public string SubjectAlternativeNameFormatString { get; set; }
    
        /// <summary>
        /// Gets or sets subject name format string.
        /// Custom format to use with SubjectNameFormat = Custom. Example: CN={{EmailAddress}},E={{EmailAddress}},OU=Enterprise Users,O=Contoso Corporation,L=Redmond,ST=WA,C=US
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subjectNameFormatString", Required = Newtonsoft.Json.Required.Default)]
        public string SubjectNameFormatString { get; set; }
    
        /// <summary>
        /// Gets or sets managed device certificate states.
        /// Certificate state for devices
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managedDeviceCertificateStates", Required = Newtonsoft.Json.Required.Default)]
        public IIosPkcsCertificateProfileManagedDeviceCertificateStatesCollectionPage ManagedDeviceCertificateStates { get; set; }
    
    }
}

