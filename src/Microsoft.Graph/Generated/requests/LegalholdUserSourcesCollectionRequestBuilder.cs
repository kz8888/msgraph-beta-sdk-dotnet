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
    /// The type LegalholdUserSourcesCollectionRequestBuilder.
    /// </summary>
    public partial class LegalholdUserSourcesCollectionRequestBuilder : BaseRequestBuilder, ILegalholdUserSourcesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new LegalholdUserSourcesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public LegalholdUserSourcesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ILegalholdUserSourcesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ILegalholdUserSourcesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new LegalholdUserSourcesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IUserSourceRequestBuilder"/> for the specified LegalholdUserSource.
        /// </summary>
        /// <param name="id">The ID for the LegalholdUserSource.</param>
        /// <returns>The <see cref="IUserSourceRequestBuilder"/>.</returns>
        public IUserSourceRequestBuilder this[string id]
        {
            get
            {
                return new UserSourceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}