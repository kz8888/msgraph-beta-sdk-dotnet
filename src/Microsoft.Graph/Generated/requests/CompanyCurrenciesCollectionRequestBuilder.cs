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
    /// The type CompanyCurrenciesCollectionRequestBuilder.
    /// </summary>
    public partial class CompanyCurrenciesCollectionRequestBuilder : BaseRequestBuilder, ICompanyCurrenciesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new CompanyCurrenciesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public CompanyCurrenciesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ICompanyCurrenciesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ICompanyCurrenciesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new CompanyCurrenciesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ICurrencyRequestBuilder"/> for the specified CompanyCurrency.
        /// </summary>
        /// <param name="id">The ID for the CompanyCurrency.</param>
        /// <returns>The <see cref="ICurrencyRequestBuilder"/>.</returns>
        public ICurrencyRequestBuilder this[string id]
        {
            get
            {
                return new CurrencyRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
