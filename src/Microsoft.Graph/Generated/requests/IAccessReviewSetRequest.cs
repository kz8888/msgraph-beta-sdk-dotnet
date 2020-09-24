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
    /// The interface IAccessReviewSetRequest.
    /// </summary>
    public partial interface IAccessReviewSetRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AccessReviewSet using POST.
        /// </summary>
        /// <param name="accessReviewSetToCreate">The AccessReviewSet to create.</param>
        /// <returns>The created AccessReviewSet.</returns>
        System.Threading.Tasks.Task<AccessReviewSet> CreateAsync(AccessReviewSet accessReviewSetToCreate);        /// <summary>
        /// Creates the specified AccessReviewSet using POST.
        /// </summary>
        /// <param name="accessReviewSetToCreate">The AccessReviewSet to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AccessReviewSet.</returns>
        System.Threading.Tasks.Task<AccessReviewSet> CreateAsync(AccessReviewSet accessReviewSetToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified AccessReviewSet.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified AccessReviewSet.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified AccessReviewSet.
        /// </summary>
        /// <returns>The AccessReviewSet.</returns>
        System.Threading.Tasks.Task<AccessReviewSet> GetAsync();

        /// <summary>
        /// Gets the specified AccessReviewSet.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AccessReviewSet.</returns>
        System.Threading.Tasks.Task<AccessReviewSet> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified AccessReviewSet using PATCH.
        /// </summary>
        /// <param name="accessReviewSetToUpdate">The AccessReviewSet to update.</param>
        /// <returns>The updated AccessReviewSet.</returns>
        System.Threading.Tasks.Task<AccessReviewSet> UpdateAsync(AccessReviewSet accessReviewSetToUpdate);

        /// <summary>
        /// Updates the specified AccessReviewSet using PATCH.
        /// </summary>
        /// <param name="accessReviewSetToUpdate">The AccessReviewSet to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AccessReviewSet.</returns>
        System.Threading.Tasks.Task<AccessReviewSet> UpdateAsync(AccessReviewSet accessReviewSetToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAccessReviewSetRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAccessReviewSetRequest Expand(Expression<Func<AccessReviewSet, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAccessReviewSetRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAccessReviewSetRequest Select(Expression<Func<AccessReviewSet, object>> selectExpression);

    }
}