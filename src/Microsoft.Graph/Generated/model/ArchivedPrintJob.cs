// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type ArchivedPrintJob.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class ArchivedPrintJob
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArchivedPrintJob"/> class.
        /// </summary>
        public ArchivedPrintJob()
        {
            this.ODataType = "microsoft.graph.archivedPrintJob";
        }

        /// <summary>
        /// Gets or sets acquiredByPrinter.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "acquiredByPrinter", Required = Newtonsoft.Json.Required.Default)]
        public bool? AcquiredByPrinter { get; set; }
    
        /// <summary>
        /// Gets or sets acquiredDateTime.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "acquiredDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? AcquiredDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets blackAndWhitePageCount.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "blackAndWhitePageCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? BlackAndWhitePageCount { get; set; }
    
        /// <summary>
        /// Gets or sets colorPageCount.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "colorPageCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? ColorPageCount { get; set; }
    
        /// <summary>
        /// Gets or sets completionDateTime.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "completionDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CompletionDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets copiesPrinted.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "copiesPrinted", Required = Newtonsoft.Json.Required.Default)]
        public Int32? CopiesPrinted { get; set; }
    
        /// <summary>
        /// Gets or sets createdBy.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdBy", Required = Newtonsoft.Json.Required.Default)]
        public UserIdentity CreatedBy { get; set; }
    
        /// <summary>
        /// Gets or sets createdDateTime.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets duplexPageCount.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "duplexPageCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? DuplexPageCount { get; set; }
    
        /// <summary>
        /// Gets or sets id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id", Required = Newtonsoft.Json.Required.Default)]
        public string Id { get; set; }
    
        /// <summary>
        /// Gets or sets pageCount.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pageCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PageCount { get; set; }
    
        /// <summary>
        /// Gets or sets printerId.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "printerId", Required = Newtonsoft.Json.Required.Default)]
        public string PrinterId { get; set; }
    
        /// <summary>
        /// Gets or sets processingState.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "processingState", Required = Newtonsoft.Json.Required.Default)]
        public PrintJobProcessingState? ProcessingState { get; set; }
    
        /// <summary>
        /// Gets or sets simplexPageCount.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "simplexPageCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? SimplexPageCount { get; set; }
    
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