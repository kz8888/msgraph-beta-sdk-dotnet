// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Localized Notification Message.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class LocalizedNotificationMessage : Entity
    {
    
		///<summary>
		/// The LocalizedNotificationMessage constructor
		///</summary>
        public LocalizedNotificationMessage()
        {
            this.ODataType = "microsoft.graph.localizedNotificationMessage";
        }
	
        /// <summary>
        /// Gets or sets is default.
        /// Flag to indicate whether or not this is the default locale for language fallback. This flag can only be set. To unset, set this property to true on another Localized Notification Message.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isDefault", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsDefault { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// DateTime the object was last modified.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastModifiedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets locale.
        /// The Locale for which this message is destined.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "locale", Required = Newtonsoft.Json.Required.Default)]
        public string Locale { get; set; }
    
        /// <summary>
        /// Gets or sets message template.
        /// The Message Template content.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "messageTemplate", Required = Newtonsoft.Json.Required.Default)]
        public string MessageTemplate { get; set; }
    
        /// <summary>
        /// Gets or sets subject.
        /// The Message Template Subject.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subject", Required = Newtonsoft.Json.Required.Default)]
        public string Subject { get; set; }
    
    }
}
