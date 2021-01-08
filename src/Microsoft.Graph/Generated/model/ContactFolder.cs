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
    /// The type Contact Folder.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ContactFolder : Entity
    {
    
		///<summary>
		/// The ContactFolder constructor
		///</summary>
        public ContactFolder()
        {
            this.ODataType = "microsoft.graph.contactFolder";
        }
	
        /// <summary>
        /// Gets or sets display name.
        /// The folder's display name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets parent folder id.
        /// The ID of the folder's parent folder.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "parentFolderId", Required = Newtonsoft.Json.Required.Default)]
        public string ParentFolderId { get; set; }
    
        /// <summary>
        /// Gets or sets well known name.
        /// The name of the folder if the folder is a recognized folder. Currently contacts is the only recognized contacts folder.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "wellKnownName", Required = Newtonsoft.Json.Required.Default)]
        public string WellKnownName { get; set; }
    
        /// <summary>
        /// Gets or sets child folders.
        /// The collection of child folders in the folder. Navigation property. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "childFolders", Required = Newtonsoft.Json.Required.Default)]
        public IContactFolderChildFoldersCollectionPage ChildFolders { get; set; }
    
        /// <summary>
        /// Gets or sets contacts.
        /// The contacts in the folder. Navigation property. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contacts", Required = Newtonsoft.Json.Required.Default)]
        public IContactFolderContactsCollectionPage Contacts { get; set; }
    
        /// <summary>
        /// Gets or sets multi value extended properties.
        /// The collection of multi-value extended properties defined for the contactFolder. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "multiValueExtendedProperties", Required = Newtonsoft.Json.Required.Default)]
        public IContactFolderMultiValueExtendedPropertiesCollectionPage MultiValueExtendedProperties { get; set; }
    
        /// <summary>
        /// Gets or sets single value extended properties.
        /// The collection of single-value extended properties defined for the contactFolder. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "singleValueExtendedProperties", Required = Newtonsoft.Json.Required.Default)]
        public IContactFolderSingleValueExtendedPropertiesCollectionPage SingleValueExtendedProperties { get; set; }
    
    }
}

