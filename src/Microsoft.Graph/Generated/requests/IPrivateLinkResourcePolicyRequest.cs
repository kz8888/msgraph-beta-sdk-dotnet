// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IPrivateLinkResourcePolicyRequest.
    /// </summary>
    public partial interface IPrivateLinkResourcePolicyRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified PrivateLinkResourcePolicy using POST.
        /// </summary>
        /// <param name="privateLinkResourcePolicyToCreate">The PrivateLinkResourcePolicy to create.</param>
        /// <returns>The created PrivateLinkResourcePolicy.</returns>
        System.Threading.Tasks.Task<PrivateLinkResourcePolicy> CreateAsync(PrivateLinkResourcePolicy privateLinkResourcePolicyToCreate);        /// <summary>
        /// Creates the specified PrivateLinkResourcePolicy using POST.
        /// </summary>
        /// <param name="privateLinkResourcePolicyToCreate">The PrivateLinkResourcePolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PrivateLinkResourcePolicy.</returns>
        System.Threading.Tasks.Task<PrivateLinkResourcePolicy> CreateAsync(PrivateLinkResourcePolicy privateLinkResourcePolicyToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified PrivateLinkResourcePolicy.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified PrivateLinkResourcePolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified PrivateLinkResourcePolicy.
        /// </summary>
        /// <returns>The PrivateLinkResourcePolicy.</returns>
        System.Threading.Tasks.Task<PrivateLinkResourcePolicy> GetAsync();

        /// <summary>
        /// Gets the specified PrivateLinkResourcePolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PrivateLinkResourcePolicy.</returns>
        System.Threading.Tasks.Task<PrivateLinkResourcePolicy> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified PrivateLinkResourcePolicy using PATCH.
        /// </summary>
        /// <param name="privateLinkResourcePolicyToUpdate">The PrivateLinkResourcePolicy to update.</param>
        /// <returns>The updated PrivateLinkResourcePolicy.</returns>
        System.Threading.Tasks.Task<PrivateLinkResourcePolicy> UpdateAsync(PrivateLinkResourcePolicy privateLinkResourcePolicyToUpdate);

        /// <summary>
        /// Updates the specified PrivateLinkResourcePolicy using PATCH.
        /// </summary>
        /// <param name="privateLinkResourcePolicyToUpdate">The PrivateLinkResourcePolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated PrivateLinkResourcePolicy.</returns>
        System.Threading.Tasks.Task<PrivateLinkResourcePolicy> UpdateAsync(PrivateLinkResourcePolicy privateLinkResourcePolicyToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IPrivateLinkResourcePolicyRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IPrivateLinkResourcePolicyRequest Expand(Expression<Func<PrivateLinkResourcePolicy, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IPrivateLinkResourcePolicyRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IPrivateLinkResourcePolicyRequest Select(Expression<Func<PrivateLinkResourcePolicy, object>> selectExpression);

    }
}