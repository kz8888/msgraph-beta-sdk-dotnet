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
    /// The type Device Management Configuration Setting Definition.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeviceManagementConfigurationSettingDefinition : Entity
    {
    
		///<summary>
		/// The DeviceManagementConfigurationSettingDefinition constructor
		///</summary>
        public DeviceManagementConfigurationSettingDefinition()
        {
            this.ODataType = "microsoft.graph.deviceManagementConfigurationSettingDefinition";
        }
	
        /// <summary>
        /// Gets or sets access types.
        /// Read/write access mode of the setting. Possible values are: none, add, copy, delete, get, replace, execute.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "accessTypes", Required = Newtonsoft.Json.Required.Default)]
        public DeviceManagementConfigurationSettingAccessTypes? AccessTypes { get; set; }
    
        /// <summary>
        /// Gets or sets applicability.
        /// Details which device setting is applicable on
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "applicability", Required = Newtonsoft.Json.Required.Default)]
        public DeviceManagementConfigurationSettingApplicability Applicability { get; set; }
    
        /// <summary>
        /// Gets or sets base uri.
        /// Base CSP Path
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "baseUri", Required = Newtonsoft.Json.Required.Default)]
        public string BaseUri { get; set; }
    
        /// <summary>
        /// Gets or sets category id.
        /// Specifies the area group under which the setting is configured in a specified configuration service provider (CSP)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "categoryId", Required = Newtonsoft.Json.Required.Default)]
        public string CategoryId { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// Description of the item
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description", Required = Newtonsoft.Json.Required.Default)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Display name of the item
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets help text.
        /// Help text of the item
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "helpText", Required = Newtonsoft.Json.Required.Default)]
        public string HelpText { get; set; }
    
        /// <summary>
        /// Gets or sets info urls.
        /// List of links more info for the setting can be found at
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "infoUrls", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> InfoUrls { get; set; }
    
        /// <summary>
        /// Gets or sets keywords.
        /// Tokens which to search settings on
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "keywords", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> Keywords { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// Name of the item
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "name", Required = Newtonsoft.Json.Required.Default)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets occurrence.
        /// Indicates whether the setting is required or not
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "occurrence", Required = Newtonsoft.Json.Required.Default)]
        public DeviceManagementConfigurationSettingOccurrence Occurrence { get; set; }
    
        /// <summary>
        /// Gets or sets offset uri.
        /// Offset CSP Path from Base
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "offsetUri", Required = Newtonsoft.Json.Required.Default)]
        public string OffsetUri { get; set; }
    
        /// <summary>
        /// Gets or sets root definition id.
        /// Root setting definition if the setting is a child setting.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "rootDefinitionId", Required = Newtonsoft.Json.Required.Default)]
        public string RootDefinitionId { get; set; }
    
        /// <summary>
        /// Gets or sets setting usage.
        /// Setting type, for example, configuration and compliance. Possible values are: none, configuration.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "settingUsage", Required = Newtonsoft.Json.Required.Default)]
        public DeviceManagementConfigurationSettingUsage? SettingUsage { get; set; }
    
        /// <summary>
        /// Gets or sets version.
        /// Item Version
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "version", Required = Newtonsoft.Json.Required.Default)]
        public string Version { get; set; }
    
    }
}

