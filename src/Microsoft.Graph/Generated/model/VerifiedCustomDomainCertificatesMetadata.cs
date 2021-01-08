// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type VerifiedCustomDomainCertificatesMetadata.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class VerifiedCustomDomainCertificatesMetadata
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VerifiedCustomDomainCertificatesMetadata"/> class.
        /// </summary>
        public VerifiedCustomDomainCertificatesMetadata()
        {
            this.ODataType = "microsoft.graph.verifiedCustomDomainCertificatesMetadata";
        }

        /// <summary>
        /// Gets or sets expiryDate.
        /// The expiry date of the custom domain certificate. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "expiryDate", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? ExpiryDate { get; set; }
    
        /// <summary>
        /// Gets or sets issueDate.
        /// The issue date of the custom domain. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "issueDate", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? IssueDate { get; set; }
    
        /// <summary>
        /// Gets or sets issuerName.
        /// The issuer name of the custom domain certificate.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "issuerName", Required = Newtonsoft.Json.Required.Default)]
        public string IssuerName { get; set; }
    
        /// <summary>
        /// Gets or sets subjectName.
        /// The subject name of the custom domain certificate.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subjectName", Required = Newtonsoft.Json.Required.Default)]
        public string SubjectName { get; set; }
    
        /// <summary>
        /// Gets or sets thumbprint.
        /// The thumbprint associated with the custom domain certificate.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "thumbprint", Required = Newtonsoft.Json.Required.Default)]
        public string Thumbprint { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
