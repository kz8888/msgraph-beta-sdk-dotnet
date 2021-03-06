// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph.TermStore
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type StoreRequestBuilder.
    /// </summary>
    public partial class StoreRequestBuilder : Microsoft.Graph.EntityRequestBuilder, IStoreRequestBuilder
    {

        /// <summary>
        /// Constructs a new StoreRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        public StoreRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IStoreRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IStoreRequest Request(IEnumerable<Microsoft.Graph.Option> options)
        {
            return new StoreRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Groups.
        /// </summary>
        /// <returns>The <see cref="IStoreGroupsCollectionRequestBuilder"/>.</returns>
        public IStoreGroupsCollectionRequestBuilder Groups
        {
            get
            {
                return new StoreGroupsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("groups"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Sets.
        /// </summary>
        /// <returns>The <see cref="IStoreSetsCollectionRequestBuilder"/>.</returns>
        public IStoreSetsCollectionRequestBuilder Sets
        {
            get
            {
                return new StoreSetsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("sets"), this.Client);
            }
        }
    
    }
}
