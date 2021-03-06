// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type CaseReviewSetsCollectionRequestBuilder.
    /// </summary>
    public partial class CaseReviewSetsCollectionRequestBuilder : BaseRequestBuilder, ICaseReviewSetsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new CaseReviewSetsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public CaseReviewSetsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ICaseReviewSetsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ICaseReviewSetsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new CaseReviewSetsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IReviewSetRequestBuilder"/> for the specified CaseReviewSet.
        /// </summary>
        /// <param name="id">The ID for the CaseReviewSet.</param>
        /// <returns>The <see cref="IReviewSetRequestBuilder"/>.</returns>
        public IReviewSetRequestBuilder this[string id]
        {
            get
            {
                return new ReviewSetRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
