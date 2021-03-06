// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type PolicySetRequestBuilder.
    /// </summary>
    public partial class PolicySetRequestBuilder : EntityRequestBuilder, IPolicySetRequestBuilder
    {

        /// <summary>
        /// Constructs a new PolicySetRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public PolicySetRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IPolicySetRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IPolicySetRequest Request(IEnumerable<Option> options)
        {
            return new PolicySetRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Assignments.
        /// </summary>
        /// <returns>The <see cref="IPolicySetAssignmentsCollectionRequestBuilder"/>.</returns>
        public IPolicySetAssignmentsCollectionRequestBuilder Assignments
        {
            get
            {
                return new PolicySetAssignmentsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("assignments"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Items.
        /// </summary>
        /// <returns>The <see cref="IPolicySetItemsCollectionRequestBuilder"/>.</returns>
        public IPolicySetItemsCollectionRequestBuilder Items
        {
            get
            {
                return new PolicySetItemsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("items"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for PolicySetUpdate.
        /// </summary>
        /// <returns>The <see cref="IPolicySetUpdateRequestBuilder"/>.</returns>
        public IPolicySetUpdateRequestBuilder Update(
            IEnumerable<PolicySetItem> addedPolicySetItems = null,
            IEnumerable<PolicySetItem> updatedPolicySetItems = null,
            IEnumerable<string> deletedPolicySetItems = null,
            IEnumerable<PolicySetAssignment> assignments = null)
        {
            return new PolicySetUpdateRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.update"),
                this.Client,
                addedPolicySetItems,
                updatedPolicySetItems,
                deletedPolicySetItems,
                assignments);
        }
    
    }
}
