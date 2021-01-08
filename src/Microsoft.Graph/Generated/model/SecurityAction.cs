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
    /// The type Security Action.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class SecurityAction : Entity
    {
    
		///<summary>
		/// The SecurityAction constructor
		///</summary>
        public SecurityAction()
        {
            this.ODataType = "microsoft.graph.securityAction";
        }
	
        /// <summary>
        /// Gets or sets action reason.
        /// Reason for invoking this action.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "actionReason", Required = Newtonsoft.Json.Required.Default)]
        public string ActionReason { get; set; }
    
        /// <summary>
        /// Gets or sets app id.
        /// The Application ID of the calling application that submitted (POST) the action. The appId should be extracted from the auth token and not entered manually by the calling application.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appId", Required = Newtonsoft.Json.Required.Default)]
        public string AppId { get; set; }
    
        /// <summary>
        /// Gets or sets azure tenant id.
        /// Azure tenant ID of the entity to determine which tenant the entity belongs to (multi-tenancy support). The azureTenantId should be extracted from the auth token and not entered manually by the calling application.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "azureTenantId", Required = Newtonsoft.Json.Required.Default)]
        public string AzureTenantId { get; set; }
    
        /// <summary>
        /// Gets or sets client context.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "clientContext", Required = Newtonsoft.Json.Required.Default)]
        public string ClientContext { get; set; }
    
        /// <summary>
        /// Gets or sets completed date time.
        /// Timestamp when the action was completed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "completedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CompletedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// Timestamp when the action is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets error info.
        /// Error info when the action fails.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "errorInfo", Required = Newtonsoft.Json.Required.Default)]
        public ResultInfo ErrorInfo { get; set; }
    
        /// <summary>
        /// Gets or sets last action date time.
        /// Timestamp when this action was last updated. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastActionDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastActionDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// Action name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "name", Required = Newtonsoft.Json.Required.Default)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets parameters.
        /// Collection of parameters (key-value pairs) necessary to invoke the action, e.g. URL or fileHash to block, etc.). Required
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "parameters", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<KeyValuePair> Parameters { get; set; }
    
        /// <summary>
        /// Gets or sets states.
        /// Collection of securityActionState to keep the history of an action.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "states", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<SecurityActionState> States { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// Status of the action. Possible values are: NotStarted, Running, Completed, Failed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "status", Required = Newtonsoft.Json.Required.Default)]
        public OperationStatus? Status { get; set; }
    
        /// <summary>
        /// Gets or sets user.
        /// The user principal name of the signed-in user that submitted  (POST) the action. The user should be extracted from the auth token and not entered manually by the calling application.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "user", Required = Newtonsoft.Json.Required.Default)]
        public string User { get; set; }
    
        /// <summary>
        /// Gets or sets vendor information.
        /// Complex Type containing details about the Security product/service vendor, provider, and sub-provider (e.g. vendor=Microsoft; provider=Windows Defender ATP; sub-provider=AppLocker).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "vendorInformation", Required = Newtonsoft.Json.Required.Default)]
        public SecurityVendorInformation VendorInformation { get; set; }
    
    }
}

