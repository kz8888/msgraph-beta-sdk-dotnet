// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IPolicyRootPrivateLinkResourcePoliciesCollectionRequestBuilder.
    /// </summary>
    public partial interface IPolicyRootPrivateLinkResourcePoliciesCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IPolicyRootPrivateLinkResourcePoliciesCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IPolicyRootPrivateLinkResourcePoliciesCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IPrivateLinkResourceRequestBuilder"/> for the specified PrivateLinkResource.
        /// </summary>
        /// <param name="id">The ID for the PrivateLinkResource.</param>
        /// <returns>The <see cref="IPrivateLinkResourceRequestBuilder"/>.</returns>
        IPrivateLinkResourceRequestBuilder this[string id] { get; }

        
    }
}