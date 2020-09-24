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
    /// The enum MailboxRecipientType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum MailboxRecipientType
    {
    
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 0,
	
        /// <summary>
        /// User
        /// </summary>
        User = 1,
	
        /// <summary>
        /// Linked
        /// </summary>
        Linked = 2,
	
        /// <summary>
        /// Shared
        /// </summary>
        Shared = 3,
	
        /// <summary>
        /// Room
        /// </summary>
        Room = 4,
	
        /// <summary>
        /// Equipment
        /// </summary>
        Equipment = 5,
	
        /// <summary>
        /// Others
        /// </summary>
        Others = 6,
	
    }
}