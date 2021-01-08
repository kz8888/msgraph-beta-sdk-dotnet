// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type ConnectedOrganizationMembers.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ConnectedOrganizationMembers : UserSet
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectedOrganizationMembers"/> class.
        /// </summary>
        public ConnectedOrganizationMembers()
        {
            this.ODataType = "microsoft.graph.connectedOrganizationMembers";
        }

        /// <summary>
        /// Gets or sets description.
        /// The name of the connected organization. Read only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description", Required = Newtonsoft.Json.Required.Default)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets id.
        /// The ID of the connected organization in entitlement management.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id", Required = Newtonsoft.Json.Required.Default)]
        public string Id { get; set; }
    
    }
}
