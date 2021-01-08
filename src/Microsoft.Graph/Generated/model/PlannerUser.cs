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
    /// The type Planner User.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class PlannerUser : PlannerDelta
    {
    
		///<summary>
		/// The PlannerUser constructor
		///</summary>
        public PlannerUser()
        {
            this.ODataType = "microsoft.graph.plannerUser";
        }
	
        /// <summary>
        /// Gets or sets favorite plan references.
        /// A collection containing the references to the plans that the user has marked as favorites.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "favoritePlanReferences", Required = Newtonsoft.Json.Required.Default)]
        public PlannerFavoritePlanReferenceCollection FavoritePlanReferences { get; set; }
    
        /// <summary>
        /// Gets or sets recent plan references.
        /// A collection containing references to the plans that were viewed recently by the user in apps that support recent plans.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "recentPlanReferences", Required = Newtonsoft.Json.Required.Default)]
        public PlannerRecentPlanReferenceCollection RecentPlanReferences { get; set; }
    
        /// <summary>
        /// Gets or sets all.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "all", Required = Newtonsoft.Json.Required.Default)]
        public IPlannerUserAllCollectionPage All { get; set; }
    
        /// <summary>
        /// Gets or sets favorite plans.
        /// Read-only. Nullable. Returns the plannerPlans that the user marked as favorites.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "favoritePlans", Required = Newtonsoft.Json.Required.Default)]
        public IPlannerUserFavoritePlansCollectionWithReferencesPage FavoritePlans { get; set; }
    
        /// <summary>
        /// Gets or sets plans.
        /// Read-only. Nullable. Returns the plannerTasks assigned to the user.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "plans", Required = Newtonsoft.Json.Required.Default)]
        public IPlannerUserPlansCollectionPage Plans { get; set; }
    
        /// <summary>
        /// Gets or sets recent plans.
        /// Read-only. Nullable. Returns the plannerPlans that have been recently viewed by the user in apps that support recent plans.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "recentPlans", Required = Newtonsoft.Json.Required.Default)]
        public IPlannerUserRecentPlansCollectionWithReferencesPage RecentPlans { get; set; }
    
        /// <summary>
        /// Gets or sets tasks.
        /// Read-only. Nullable. Returns the plannerTasks assigned to the user.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tasks", Required = Newtonsoft.Json.Required.Default)]
        public IPlannerUserTasksCollectionPage Tasks { get; set; }
    
    }
}

