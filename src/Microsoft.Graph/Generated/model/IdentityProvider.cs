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
    /// The type Identity Provider.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class IdentityProvider : Entity
    {
    
		///<summary>
		/// The IdentityProvider constructor
		///</summary>
        public IdentityProvider()
        {
            this.ODataType = "microsoft.graph.identityProvider";
        }
	
        /// <summary>
        /// Gets or sets client id.
        /// The client ID for the application obtained when registering the application with the identity provider. This is a required field.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "clientId", Required = Newtonsoft.Json.Required.Default)]
        public string ClientId { get; set; }
    
        /// <summary>
        /// Gets or sets client secret.
        /// The client secret for the application obtained when registering the application with the identity provider. This is write-only. A read operation will return '****'. This is a required field.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "clientSecret", Required = Newtonsoft.Json.Required.Default)]
        public string ClientSecret { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// The display name of the identity provider.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "name", Required = Newtonsoft.Json.Required.Default)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets type.
        /// The identity provider type is a required field.For B2B scenario:GoogleFacebookFor B2C scenario:MicrosoftGoogleAmazonLinkedInFacebookGitHubTwitterWeiboQQWeChatOpenIDConnect
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "type", Required = Newtonsoft.Json.Required.Default)]
        public string Type { get; set; }
    
    }
}

