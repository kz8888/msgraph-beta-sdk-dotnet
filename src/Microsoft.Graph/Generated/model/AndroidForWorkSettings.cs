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
    /// The type Android For Work Settings.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AndroidForWorkSettings : Entity
    {
    
		///<summary>
		/// The AndroidForWorkSettings constructor
		///</summary>
        public AndroidForWorkSettings()
        {
            this.ODataType = "microsoft.graph.androidForWorkSettings";
        }
	
        /// <summary>
        /// Gets or sets bind status.
        /// Bind status of the tenant with the Google EMM API. Possible values are: notBound, bound, boundAndValidated, unbinding.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bindStatus", Required = Newtonsoft.Json.Required.Default)]
        public AndroidForWorkBindStatus? BindStatus { get; set; }
    
        /// <summary>
        /// Gets or sets device owner management enabled.
        /// Indicates if this account is flighting for Android Device Owner Management with CloudDPC.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceOwnerManagementEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? DeviceOwnerManagementEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets enrollment target.
        /// Indicates which users can enroll devices in Android for Work device management. Possible values are: none, all, targeted, targetedAsEnrollmentRestrictions.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enrollmentTarget", Required = Newtonsoft.Json.Required.Default)]
        public AndroidForWorkEnrollmentTarget? EnrollmentTarget { get; set; }
    
        /// <summary>
        /// Gets or sets last app sync date time.
        /// Last completion time for app sync
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastAppSyncDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastAppSyncDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets last app sync status.
        /// Last application sync result. Possible values are: success, credentialsNotValid, androidForWorkApiError, managementServiceError, unknownError, none.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastAppSyncStatus", Required = Newtonsoft.Json.Required.Default)]
        public AndroidForWorkSyncStatus? LastAppSyncStatus { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// Last modification time for Android for Work settings
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastModifiedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets owner organization name.
        /// Organization name used when onboarding Android for Work
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ownerOrganizationName", Required = Newtonsoft.Json.Required.Default)]
        public string OwnerOrganizationName { get; set; }
    
        /// <summary>
        /// Gets or sets owner user principal name.
        /// Owner UPN that created the enterprise
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ownerUserPrincipalName", Required = Newtonsoft.Json.Required.Default)]
        public string OwnerUserPrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets target group ids.
        /// Specifies which AAD groups can enroll devices in Android for Work device management if enrollmentTarget is set to 'Targeted'
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "targetGroupIds", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> TargetGroupIds { get; set; }
    
    }
}

