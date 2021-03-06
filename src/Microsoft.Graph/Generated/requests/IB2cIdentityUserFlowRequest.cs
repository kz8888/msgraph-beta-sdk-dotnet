// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IB2cIdentityUserFlowRequest.
    /// </summary>
    public partial interface IB2cIdentityUserFlowRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified B2cIdentityUserFlow using POST.
        /// </summary>
        /// <param name="b2cIdentityUserFlowToCreate">The B2cIdentityUserFlow to create.</param>
        /// <returns>The created B2cIdentityUserFlow.</returns>
        System.Threading.Tasks.Task<B2cIdentityUserFlow> CreateAsync(B2cIdentityUserFlow b2cIdentityUserFlowToCreate);        /// <summary>
        /// Creates the specified B2cIdentityUserFlow using POST.
        /// </summary>
        /// <param name="b2cIdentityUserFlowToCreate">The B2cIdentityUserFlow to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created B2cIdentityUserFlow.</returns>
        System.Threading.Tasks.Task<B2cIdentityUserFlow> CreateAsync(B2cIdentityUserFlow b2cIdentityUserFlowToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified B2cIdentityUserFlow.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified B2cIdentityUserFlow.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified B2cIdentityUserFlow.
        /// </summary>
        /// <returns>The B2cIdentityUserFlow.</returns>
        System.Threading.Tasks.Task<B2cIdentityUserFlow> GetAsync();

        /// <summary>
        /// Gets the specified B2cIdentityUserFlow.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The B2cIdentityUserFlow.</returns>
        System.Threading.Tasks.Task<B2cIdentityUserFlow> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified B2cIdentityUserFlow using PATCH.
        /// </summary>
        /// <param name="b2cIdentityUserFlowToUpdate">The B2cIdentityUserFlow to update.</param>
        /// <returns>The updated B2cIdentityUserFlow.</returns>
        System.Threading.Tasks.Task<B2cIdentityUserFlow> UpdateAsync(B2cIdentityUserFlow b2cIdentityUserFlowToUpdate);

        /// <summary>
        /// Updates the specified B2cIdentityUserFlow using PATCH.
        /// </summary>
        /// <param name="b2cIdentityUserFlowToUpdate">The B2cIdentityUserFlow to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated B2cIdentityUserFlow.</returns>
        System.Threading.Tasks.Task<B2cIdentityUserFlow> UpdateAsync(B2cIdentityUserFlow b2cIdentityUserFlowToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IB2cIdentityUserFlowRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IB2cIdentityUserFlowRequest Expand(Expression<Func<B2cIdentityUserFlow, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IB2cIdentityUserFlowRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IB2cIdentityUserFlowRequest Select(Expression<Func<B2cIdentityUserFlow, object>> selectExpression);

    }
}
