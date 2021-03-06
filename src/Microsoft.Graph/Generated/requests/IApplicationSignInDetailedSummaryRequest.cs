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
    /// The interface IApplicationSignInDetailedSummaryRequest.
    /// </summary>
    public partial interface IApplicationSignInDetailedSummaryRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ApplicationSignInDetailedSummary using POST.
        /// </summary>
        /// <param name="applicationSignInDetailedSummaryToCreate">The ApplicationSignInDetailedSummary to create.</param>
        /// <returns>The created ApplicationSignInDetailedSummary.</returns>
        System.Threading.Tasks.Task<ApplicationSignInDetailedSummary> CreateAsync(ApplicationSignInDetailedSummary applicationSignInDetailedSummaryToCreate);        /// <summary>
        /// Creates the specified ApplicationSignInDetailedSummary using POST.
        /// </summary>
        /// <param name="applicationSignInDetailedSummaryToCreate">The ApplicationSignInDetailedSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ApplicationSignInDetailedSummary.</returns>
        System.Threading.Tasks.Task<ApplicationSignInDetailedSummary> CreateAsync(ApplicationSignInDetailedSummary applicationSignInDetailedSummaryToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified ApplicationSignInDetailedSummary.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified ApplicationSignInDetailedSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified ApplicationSignInDetailedSummary.
        /// </summary>
        /// <returns>The ApplicationSignInDetailedSummary.</returns>
        System.Threading.Tasks.Task<ApplicationSignInDetailedSummary> GetAsync();

        /// <summary>
        /// Gets the specified ApplicationSignInDetailedSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ApplicationSignInDetailedSummary.</returns>
        System.Threading.Tasks.Task<ApplicationSignInDetailedSummary> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified ApplicationSignInDetailedSummary using PATCH.
        /// </summary>
        /// <param name="applicationSignInDetailedSummaryToUpdate">The ApplicationSignInDetailedSummary to update.</param>
        /// <returns>The updated ApplicationSignInDetailedSummary.</returns>
        System.Threading.Tasks.Task<ApplicationSignInDetailedSummary> UpdateAsync(ApplicationSignInDetailedSummary applicationSignInDetailedSummaryToUpdate);

        /// <summary>
        /// Updates the specified ApplicationSignInDetailedSummary using PATCH.
        /// </summary>
        /// <param name="applicationSignInDetailedSummaryToUpdate">The ApplicationSignInDetailedSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ApplicationSignInDetailedSummary.</returns>
        System.Threading.Tasks.Task<ApplicationSignInDetailedSummary> UpdateAsync(ApplicationSignInDetailedSummary applicationSignInDetailedSummaryToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IApplicationSignInDetailedSummaryRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IApplicationSignInDetailedSummaryRequest Expand(Expression<Func<ApplicationSignInDetailedSummary, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IApplicationSignInDetailedSummaryRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IApplicationSignInDetailedSummaryRequest Select(Expression<Func<ApplicationSignInDetailedSummary, object>> selectExpression);

    }
}
