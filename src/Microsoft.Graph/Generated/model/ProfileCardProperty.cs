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
    /// The type Profile Card Property.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ProfileCardProperty : Entity
    {
    
		///<summary>
		/// The ProfileCardProperty constructor
		///</summary>
        public ProfileCardProperty()
        {
            this.ODataType = "microsoft.graph.profileCardProperty";
        }
	
        /// <summary>
        /// Gets or sets annotations.
        /// Allows an administrator to set a custom display label for the directory property and localize it for the users in their tenant.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "annotations", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<ProfileCardAnnotation> Annotations { get; set; }
    
        /// <summary>
        /// Gets or sets directory property name.
        /// Identifies a profileCardProperty resource in Get, Update, or Delete operations. Allows an administrator to surface hidden Azure Active Directory (Azure AD) properties on the Microsoft 365 profile card within their tenant. When present, the Azure AD field referenced in this field will be visible to all users in your tenant on the contact pane of the profile card. Allowed values for this field are: UserPrincipalName, Fax, StreetAddress, PostalCode, StateOrProvince, Alias, CustomAttribute1,  CustomAttribute2, CustomAttribute3, CustomAttribute4, CustomAttribute5, CustomAttribute6, CustomAttribute7, CustomAttribute8, CustomAttribute9, CustomAttribute10, CustomAttribute11, CustomAttribute12, CustomAttribute13, CustomAttribute14, CustomAttribute15.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "directoryPropertyName", Required = Newtonsoft.Json.Required.Default)]
        public string DirectoryPropertyName { get; set; }
    
    }
}

