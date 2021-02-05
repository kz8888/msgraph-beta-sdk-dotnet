// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// The enum AndroidDeviceOwnerEnrollmentMode.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum AndroidDeviceOwnerEnrollmentMode
    {
    
        /// <summary>
        /// Corporate Owned Dedicated Device
        /// </summary>
        CorporateOwnedDedicatedDevice = 0,
	
        /// <summary>
        /// Corporate Owned Fully Managed
        /// </summary>
        CorporateOwnedFullyManaged = 1,
	
        /// <summary>
        /// Corporate Owned Work Profile
        /// </summary>
        CorporateOwnedWorkProfile = 2,
	
    }
}
