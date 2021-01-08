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
    /// The type Person Annotation.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class PersonAnnotation : ItemFacet
    {
    
		///<summary>
		/// The PersonAnnotation constructor
		///</summary>
        public PersonAnnotation()
        {
            this.ODataType = "microsoft.graph.personAnnotation";
        }
	
        /// <summary>
        /// Gets or sets detail.
        /// Contains the detail of the note itself.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "detail", Required = Newtonsoft.Json.Required.Default)]
        public ItemBody Detail { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Contains a friendly name for the note.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
    }
}

