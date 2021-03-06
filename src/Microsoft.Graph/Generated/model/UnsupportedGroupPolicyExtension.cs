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
    /// The type Unsupported Group Policy Extension.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class UnsupportedGroupPolicyExtension : Entity
    {
    
		///<summary>
		/// The UnsupportedGroupPolicyExtension constructor
		///</summary>
        public UnsupportedGroupPolicyExtension()
        {
            this.ODataType = "microsoft.graph.unsupportedGroupPolicyExtension";
        }
	
        /// <summary>
        /// Gets or sets extension type.
        /// ExtensionType of the unsupported extension.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "extensionType", Required = Newtonsoft.Json.Required.Default)]
        public string ExtensionType { get; set; }
    
        /// <summary>
        /// Gets or sets namespace url.
        /// Namespace Url of the unsupported extension.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "namespaceUrl", Required = Newtonsoft.Json.Required.Default)]
        public string NamespaceUrl { get; set; }
    
        /// <summary>
        /// Gets or sets node name.
        /// Node name of the unsupported extension.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "nodeName", Required = Newtonsoft.Json.Required.Default)]
        public string NodeName { get; set; }
    
        /// <summary>
        /// Gets or sets setting scope.
        /// Setting Scope of the unsupported extension. Possible values are: unknown, device, user.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "settingScope", Required = Newtonsoft.Json.Required.Default)]
        public GroupPolicySettingScope? SettingScope { get; set; }
    
    }
}

