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
    /// The type EducationIdentityMatchingConfiguration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class EducationIdentityMatchingConfiguration : EducationIdentitySynchronizationConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EducationIdentityMatchingConfiguration"/> class.
        /// </summary>
        public EducationIdentityMatchingConfiguration()
        {
            this.ODataType = "microsoft.graph.educationIdentityMatchingConfiguration";
        }

        /// <summary>
        /// Gets or sets matchingOptions.
        /// Mapping between the user account and the options to use to uniquely identify the user to update.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "matchingOptions", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<EducationIdentityMatchingOptions> MatchingOptions { get; set; }
    
    }
}
