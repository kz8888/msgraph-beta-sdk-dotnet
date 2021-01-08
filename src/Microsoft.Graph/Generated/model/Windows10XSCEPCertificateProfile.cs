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
    /// The type Windows10XSCEPCertificate Profile.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Windows10XSCEPCertificateProfile : Windows10XCertificateProfile
    {
    
		///<summary>
		/// The Windows10XSCEPCertificateProfile constructor
		///</summary>
        public Windows10XSCEPCertificateProfile()
        {
            this.ODataType = "microsoft.graph.windows10XSCEPCertificateProfile";
        }
	
        /// <summary>
        /// Gets or sets certificate store.
        /// Target store certificate. Possible values are: user, machine.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "certificateStore", Required = Newtonsoft.Json.Required.Default)]
        public CertificateStore? CertificateStore { get; set; }
    
        /// <summary>
        /// Gets or sets certificate validity period scale.
        /// Scale for the Certificate Validity Period. Possible values are: days, months, years.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "certificateValidityPeriodScale", Required = Newtonsoft.Json.Required.Default)]
        public CertificateValidityPeriodScale? CertificateValidityPeriodScale { get; set; }
    
        /// <summary>
        /// Gets or sets certificate validity period value.
        /// Value for the Certificate Validity Period
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "certificateValidityPeriodValue", Required = Newtonsoft.Json.Required.Default)]
        public Int32? CertificateValidityPeriodValue { get; set; }
    
        /// <summary>
        /// Gets or sets extended key usages.
        /// Extended Key Usage (EKU) settings.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "extendedKeyUsages", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<ExtendedKeyUsage> ExtendedKeyUsages { get; set; }
    
        /// <summary>
        /// Gets or sets hash algorithm.
        /// SCEP Hash Algorithm.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "hashAlgorithm", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<HashAlgorithms> HashAlgorithm { get; set; }
    
        /// <summary>
        /// Gets or sets key size.
        /// SCEP Key Size. Possible values are: size1024, size2048, size4096.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "keySize", Required = Newtonsoft.Json.Required.Default)]
        public KeySize? KeySize { get; set; }
    
        /// <summary>
        /// Gets or sets key storage provider.
        /// Key Storage Provider (KSP). Possible values are: useTpmKspOtherwiseUseSoftwareKsp, useTpmKspOtherwiseFail, usePassportForWorkKspOtherwiseFail, useSoftwareKsp.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "keyStorageProvider", Required = Newtonsoft.Json.Required.Default)]
        public KeyStorageProviderOption? KeyStorageProvider { get; set; }
    
        /// <summary>
        /// Gets or sets key usage.
        /// SCEP Key Usage. Possible values are: keyEncipherment, digitalSignature.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "keyUsage", Required = Newtonsoft.Json.Required.Default)]
        public KeyUsages? KeyUsage { get; set; }
    
        /// <summary>
        /// Gets or sets renewal threshold percentage.
        /// Certificate renewal threshold percentage
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "renewalThresholdPercentage", Required = Newtonsoft.Json.Required.Default)]
        public Int32? RenewalThresholdPercentage { get; set; }
    
        /// <summary>
        /// Gets or sets root certificate id.
        /// Trusted Root Certificate ID
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "rootCertificateId", Required = Newtonsoft.Json.Required.Default)]
        public Guid? RootCertificateId { get; set; }
    
        /// <summary>
        /// Gets or sets scep server urls.
        /// SCEP Server Url(s).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "scepServerUrls", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> ScepServerUrls { get; set; }
    
        /// <summary>
        /// Gets or sets subject alternative name formats.
        /// Custom AAD Attributes.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subjectAlternativeNameFormats", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<Windows10XCustomSubjectAlternativeName> SubjectAlternativeNameFormats { get; set; }
    
        /// <summary>
        /// Gets or sets subject name format string.
        /// Custom format to use with SubjectNameFormat = Custom. Example: CN={{EmailAddress}},E={{EmailAddress}},OU=Enterprise Users,O=Contoso Corporation,L=Redmond,ST=WA,C=US
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subjectNameFormatString", Required = Newtonsoft.Json.Required.Default)]
        public string SubjectNameFormatString { get; set; }
    
    }
}

