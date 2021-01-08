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
    /// The type EvaluateDynamicMembershipResult.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class EvaluateDynamicMembershipResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluateDynamicMembershipResult"/> class.
        /// </summary>
        public EvaluateDynamicMembershipResult()
        {
            this.ODataType = "microsoft.graph.evaluateDynamicMembershipResult";
        }

        /// <summary>
        /// Gets or sets membershipRule.
        /// If a group ID is provided, the value is the membership rule for the group. If a group ID is not provided, the value is the membership rule that was provided as a parameter. For more information, see Dynamic membership rules for groups in Azure Active Directory.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "membershipRule", Required = Newtonsoft.Json.Required.Default)]
        public string MembershipRule { get; set; }
    
        /// <summary>
        /// Gets or sets membershipRuleEvaluationDetails.
        /// Provides a detailed anaylsis of the membership evaluation result.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "membershipRuleEvaluationDetails", Required = Newtonsoft.Json.Required.Default)]
        public ExpressionEvaluationDetails MembershipRuleEvaluationDetails { get; set; }
    
        /// <summary>
        /// Gets or sets membershipRuleEvaluationResult.
        /// The value is true if the user or device is a member of the group. The value can also be true if a membership rule was provided and the user or device passes the rule evaluation; otherwise false.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "membershipRuleEvaluationResult", Required = Newtonsoft.Json.Required.Default)]
        public bool? MembershipRuleEvaluationResult { get; set; }
    
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
