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
    /// The type B2c Identity User Flow.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class B2cIdentityUserFlow : IdentityUserFlow
    {
    
		///<summary>
		/// The B2cIdentityUserFlow constructor
		///</summary>
        public B2cIdentityUserFlow()
        {
            this.ODataType = "microsoft.graph.b2cIdentityUserFlow";
        }
	
        /// <summary>
        /// Gets or sets api connector configuration.
        /// Configuration for enabling an API connector for use as part of the user flow. You can only obtain the value of this object using Get userFlowApiConnectorConfiguration.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "apiConnectorConfiguration", Required = Newtonsoft.Json.Required.Default)]
        public UserFlowApiConnectorConfiguration ApiConnectorConfiguration { get; set; }
    
        /// <summary>
        /// Gets or sets default language tag.
        /// Indicates the default language of the b2cIdentityUserFlow that is used when no ui_locale tag is specified in the request. This field is RFC 5646 compliant.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "defaultLanguageTag", Required = Newtonsoft.Json.Required.Default)]
        public string DefaultLanguageTag { get; set; }
    
        /// <summary>
        /// Gets or sets is language customization enabled.
        /// The property that determines whether language customization is enabled within the B2C user flow. Language customization is not enabled by default for B2C user flows.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isLanguageCustomizationEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsLanguageCustomizationEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets identity providers.
        /// The identity providers included in the user flow.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "identityProviders", Required = Newtonsoft.Json.Required.Default)]
        public IB2cIdentityUserFlowIdentityProvidersCollectionWithReferencesPage IdentityProviders { get; set; }
    
        /// <summary>
        /// Gets or sets languages.
        /// The languages supported for customization within the user flow. Language customization is not enabled by default in B2C user flows.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "languages", Required = Newtonsoft.Json.Required.Default)]
        public IB2cIdentityUserFlowLanguagesCollectionPage Languages { get; set; }
    
        /// <summary>
        /// Gets or sets user attribute assignments.
        /// The user attribute assignments included in the user flow.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userAttributeAssignments", Required = Newtonsoft.Json.Required.Default)]
        public IB2cIdentityUserFlowUserAttributeAssignmentsCollectionPage UserAttributeAssignments { get; set; }
    
    }
}

