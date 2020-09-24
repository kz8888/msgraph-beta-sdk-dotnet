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
    /// The type Device Management Template Setting Category.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeviceManagementTemplateSettingCategory : DeviceManagementSettingCategory
    {
    
		///<summary>
		/// The DeviceManagementTemplateSettingCategory constructor
		///</summary>
        public DeviceManagementTemplateSettingCategory()
        {
            this.ODataType = "microsoft.graph.deviceManagementTemplateSettingCategory";
        }
	
        /// <summary>
        /// Gets or sets recommended settings.
        /// The settings this category contains
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "recommendedSettings", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementTemplateSettingCategoryRecommendedSettingsCollectionPage RecommendedSettings { get; set; }
    
    }
}
