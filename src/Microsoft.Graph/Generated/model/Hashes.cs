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
    /// The type Hashes.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class Hashes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Hashes"/> class.
        /// </summary>
        public Hashes()
        {
            this.ODataType = "microsoft.graph.hashes";
        }

        /// <summary>
        /// Gets or sets crc32Hash.
        /// The CRC32 value of the file (if available). Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "crc32Hash", Required = Newtonsoft.Json.Required.Default)]
        public string Crc32Hash { get; set; }
    
        /// <summary>
        /// Gets or sets quickXorHash.
        /// A proprietary hash of the file that can be used to determine if the contents of the file have changed (if available). Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "quickXorHash", Required = Newtonsoft.Json.Required.Default)]
        public string QuickXorHash { get; set; }
    
        /// <summary>
        /// Gets or sets sha1Hash.
        /// SHA1 hash for the contents of the file (if available). Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sha1Hash", Required = Newtonsoft.Json.Required.Default)]
        public string Sha1Hash { get; set; }
    
        /// <summary>
        /// Gets or sets sha256Hash.
        /// SHA256 hash for the contents of the file (if available). Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sha256Hash", Required = Newtonsoft.Json.Required.Default)]
        public string Sha256Hash { get; set; }
    
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
