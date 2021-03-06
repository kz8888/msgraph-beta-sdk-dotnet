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
    /// The type Windows10XCustomSubjectAlternativeName.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class Windows10XCustomSubjectAlternativeName
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Windows10XCustomSubjectAlternativeName"/> class.
        /// </summary>
        public Windows10XCustomSubjectAlternativeName()
        {
            this.ODataType = "microsoft.graph.windows10XCustomSubjectAlternativeName";
        }

        /// <summary>
        /// Gets or sets name.
        /// Custom SAN Name
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "name", Required = Newtonsoft.Json.Required.Default)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets sanType.
        /// Custom SAN Type. Possible values are: none, emailAddress, userPrincipalName, customAzureADAttribute, domainNameService, universalResourceIdentifier.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sanType", Required = Newtonsoft.Json.Required.Default)]
        public SubjectAlternativeNameType? SanType { get; set; }
    
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
