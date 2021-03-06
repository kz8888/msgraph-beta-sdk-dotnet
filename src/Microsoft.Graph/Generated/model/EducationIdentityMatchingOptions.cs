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
    /// The type EducationIdentityMatchingOptions.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class EducationIdentityMatchingOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EducationIdentityMatchingOptions"/> class.
        /// </summary>
        public EducationIdentityMatchingOptions()
        {
            this.ODataType = "microsoft.graph.educationIdentityMatchingOptions";
        }

        /// <summary>
        /// Gets or sets appliesTo.
        /// The user role type to assign to the license. Possible values are: student, teacher, faculty.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appliesTo", Required = Newtonsoft.Json.Required.Default)]
        public EducationUserRole? AppliesTo { get; set; }
    
        /// <summary>
        /// Gets or sets sourcePropertyName.
        /// The name of the source property, which should be a field name in the source data. This property is case-sensitive.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sourcePropertyName", Required = Newtonsoft.Json.Required.Default)]
        public string SourcePropertyName { get; set; }
    
        /// <summary>
        /// Gets or sets targetDomain.
        /// The domain to suffix with the source property to match on the target. If provided as null, the source property will be used to match with the target property.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "targetDomain", Required = Newtonsoft.Json.Required.Default)]
        public string TargetDomain { get; set; }
    
        /// <summary>
        /// Gets or sets targetPropertyName.
        /// The name of the target property, which should be a valid property in Azure AD. This property is case-sensitive.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "targetPropertyName", Required = Newtonsoft.Json.Required.Default)]
        public string TargetPropertyName { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
