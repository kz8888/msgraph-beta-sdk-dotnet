// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum GroupPolicySettingType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum GroupPolicySettingType
    {
    
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 0,
	
        /// <summary>
        /// Policy
        /// </summary>
        Policy = 1,
	
        /// <summary>
        /// Account
        /// </summary>
        Account = 2,
	
    }
}