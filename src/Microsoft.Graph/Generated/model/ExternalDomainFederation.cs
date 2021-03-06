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
    /// The type ExternalDomainFederation.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ExternalDomainFederation : IdentitySource
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalDomainFederation"/> class.
        /// </summary>
        public ExternalDomainFederation()
        {
            this.ODataType = "microsoft.graph.externalDomainFederation";
        }

        /// <summary>
        /// Gets or sets displayName.
        /// The name of the identity source, typically also the domain name. Read only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets domainName.
        /// The domain name. Read only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "domainName", Required = Newtonsoft.Json.Required.Default)]
        public string DomainName { get; set; }
    
        /// <summary>
        /// Gets or sets issuerUri.
        /// The issuerURI of the incoming federation. Read only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "issuerUri", Required = Newtonsoft.Json.Required.Default)]
        public string IssuerUri { get; set; }
    
    }
}
