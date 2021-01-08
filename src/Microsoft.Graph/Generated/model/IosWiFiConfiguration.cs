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
    /// The type Ios Wi Fi Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class IosWiFiConfiguration : DeviceConfiguration
    {
    
		///<summary>
		/// The IosWiFiConfiguration constructor
		///</summary>
        public IosWiFiConfiguration()
        {
            this.ODataType = "microsoft.graph.iosWiFiConfiguration";
        }
	
        /// <summary>
        /// Gets or sets connect automatically.
        /// Connect automatically when this network is in range. Setting this to true will skip the user prompt and automatically connect the device to Wi-Fi network.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "connectAutomatically", Required = Newtonsoft.Json.Required.Default)]
        public bool? ConnectAutomatically { get; set; }
    
        /// <summary>
        /// Gets or sets connect when network name is hidden.
        /// Connect when the network is not broadcasting its name (SSID). When set to true, this profile forces the device to connect to a network that doesn't broadcast its SSID to all devices.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "connectWhenNetworkNameIsHidden", Required = Newtonsoft.Json.Required.Default)]
        public bool? ConnectWhenNetworkNameIsHidden { get; set; }
    
        /// <summary>
        /// Gets or sets disable mac address randomization.
        /// If set to true, forces devices connecting using this Wi-Fi profile to present their actual Wi-Fi MAC address instead of a random MAC address. Applies to iOS 14 and later.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "disableMacAddressRandomization", Required = Newtonsoft.Json.Required.Default)]
        public bool? DisableMacAddressRandomization { get; set; }
    
        /// <summary>
        /// Gets or sets network name.
        /// Network Name
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "networkName", Required = Newtonsoft.Json.Required.Default)]
        public string NetworkName { get; set; }
    
        /// <summary>
        /// Gets or sets pre shared key.
        /// This is the pre-shared key for WPA Personal Wi-Fi network.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "preSharedKey", Required = Newtonsoft.Json.Required.Default)]
        public string PreSharedKey { get; set; }
    
        /// <summary>
        /// Gets or sets proxy automatic configuration url.
        /// URL of the proxy server automatic configuration script when automatic configuration is selected. This URL is typically the location of PAC (Proxy Auto Configuration) file.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "proxyAutomaticConfigurationUrl", Required = Newtonsoft.Json.Required.Default)]
        public string ProxyAutomaticConfigurationUrl { get; set; }
    
        /// <summary>
        /// Gets or sets proxy manual address.
        /// IP Address or DNS hostname of the proxy server when manual configuration is selected.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "proxyManualAddress", Required = Newtonsoft.Json.Required.Default)]
        public string ProxyManualAddress { get; set; }
    
        /// <summary>
        /// Gets or sets proxy manual port.
        /// Port of the proxy server when manual configuration is selected.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "proxyManualPort", Required = Newtonsoft.Json.Required.Default)]
        public Int32? ProxyManualPort { get; set; }
    
        /// <summary>
        /// Gets or sets proxy settings.
        /// Proxy Type for this Wi-Fi connection. Possible values are: none, manual, automatic.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "proxySettings", Required = Newtonsoft.Json.Required.Default)]
        public WiFiProxySetting? ProxySettings { get; set; }
    
        /// <summary>
        /// Gets or sets ssid.
        /// This is the name of the Wi-Fi network that is broadcast to all devices.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ssid", Required = Newtonsoft.Json.Required.Default)]
        public string Ssid { get; set; }
    
        /// <summary>
        /// Gets or sets wi fi security type.
        /// Indicates whether Wi-Fi endpoint uses an EAP based security type. Possible values are: open, wpaPersonal, wpaEnterprise, wep, wpa2Personal, wpa2Enterprise.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "wiFiSecurityType", Required = Newtonsoft.Json.Required.Default)]
        public WiFiSecurityType? WiFiSecurityType { get; set; }
    
    }
}

