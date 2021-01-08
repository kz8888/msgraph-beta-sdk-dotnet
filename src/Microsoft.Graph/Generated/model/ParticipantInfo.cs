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
    /// The type ParticipantInfo.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class ParticipantInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParticipantInfo"/> class.
        /// </summary>
        public ParticipantInfo()
        {
            this.ODataType = "microsoft.graph.participantInfo";
        }

        /// <summary>
        /// Gets or sets countryCode.
        /// The ISO 3166-1 Alpha-2 country code of the participant's best estimated physical location at the start of the call. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "countryCode", Required = Newtonsoft.Json.Required.Default)]
        public string CountryCode { get; set; }
    
        /// <summary>
        /// Gets or sets endpointType.
        /// The type of endpoint the participant is using. Possible values are: default, skypeForBusiness, or skypeForBusinessVoipPhone. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "endpointType", Required = Newtonsoft.Json.Required.Default)]
        public EndpointType? EndpointType { get; set; }
    
        /// <summary>
        /// Gets or sets identity.
        /// The identitySet associated with this participant. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "identity", Required = Newtonsoft.Json.Required.Default)]
        public IdentitySet Identity { get; set; }
    
        /// <summary>
        /// Gets or sets languageId.
        /// The language culture string. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "languageId", Required = Newtonsoft.Json.Required.Default)]
        public string LanguageId { get; set; }
    
        /// <summary>
        /// Gets or sets platformId.
        /// The client platform ID of the participant. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "platformId", Required = Newtonsoft.Json.Required.Default)]
        public string PlatformId { get; set; }
    
        /// <summary>
        /// Gets or sets region.
        /// The home region of the participant. This can be a country, a continent, or a larger geographic region. This does not change based on the participant's current physical location, unlike countryCode. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "region", Required = Newtonsoft.Json.Required.Default)]
        public string Region { get; set; }
    
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
