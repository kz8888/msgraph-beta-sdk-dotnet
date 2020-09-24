// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph.TermStore
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IRelationRequestBuilder.
    /// </summary>
    public partial interface IRelationRequestBuilder : Microsoft.Graph.IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IRelationRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IRelationRequest Request(IEnumerable<Microsoft.Graph.Option> options);
    
        /// <summary>
        /// Gets the request builder for FromTerm.
        /// </summary>
        /// <returns>The <see cref="ITermWithReferenceRequestBuilder"/>.</returns>
        ITermWithReferenceRequestBuilder FromTerm { get; }

        /// <summary>
        /// Gets the request builder for Set.
        /// </summary>
        /// <returns>The <see cref="ISetWithReferenceRequestBuilder"/>.</returns>
        ISetWithReferenceRequestBuilder Set { get; }

        /// <summary>
        /// Gets the request builder for ToTerm.
        /// </summary>
        /// <returns>The <see cref="ITermWithReferenceRequestBuilder"/>.</returns>
        ITermWithReferenceRequestBuilder ToTerm { get; }
    
    }
}