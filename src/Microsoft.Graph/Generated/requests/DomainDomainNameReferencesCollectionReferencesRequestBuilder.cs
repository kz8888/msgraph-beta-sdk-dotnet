// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type DomainDomainNameReferencesCollectionReferencesRequestBuilder.
    /// </summary>
    public partial class DomainDomainNameReferencesCollectionReferencesRequestBuilder : BaseRequestBuilder, IDomainDomainNameReferencesCollectionReferencesRequestBuilder
    {

        /// <summary>
        /// Constructs a new DomainDomainNameReferencesCollectionReferencesRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DomainDomainNameReferencesCollectionReferencesRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDomainDomainNameReferencesCollectionReferencesRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDomainDomainNameReferencesCollectionReferencesRequest Request(IEnumerable<Option> options)
        {
            return new DomainDomainNameReferencesCollectionReferencesRequest(this.RequestUrl, this.Client, options);
        }
    }
}
