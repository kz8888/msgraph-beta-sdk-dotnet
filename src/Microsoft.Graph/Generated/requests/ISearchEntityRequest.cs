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
    /// The interface ISearchEntityRequest.
    /// </summary>
    public partial interface ISearchEntityRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified SearchEntity using POST.
        /// </summary>
        /// <param name="searchEntityToCreate">The SearchEntity to create.</param>
        /// <returns>The created SearchEntity.</returns>
        System.Threading.Tasks.Task<SearchEntity> CreateAsync(SearchEntity searchEntityToCreate);        /// <summary>
        /// Creates the specified SearchEntity using POST.
        /// </summary>
        /// <param name="searchEntityToCreate">The SearchEntity to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SearchEntity.</returns>
        System.Threading.Tasks.Task<SearchEntity> CreateAsync(SearchEntity searchEntityToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified SearchEntity.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified SearchEntity.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified SearchEntity.
        /// </summary>
        /// <returns>The SearchEntity.</returns>
        System.Threading.Tasks.Task<SearchEntity> GetAsync();

        /// <summary>
        /// Gets the specified SearchEntity.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SearchEntity.</returns>
        System.Threading.Tasks.Task<SearchEntity> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified SearchEntity using PATCH.
        /// </summary>
        /// <param name="searchEntityToUpdate">The SearchEntity to update.</param>
        /// <returns>The updated SearchEntity.</returns>
        System.Threading.Tasks.Task<SearchEntity> UpdateAsync(SearchEntity searchEntityToUpdate);

        /// <summary>
        /// Updates the specified SearchEntity using PATCH.
        /// </summary>
        /// <param name="searchEntityToUpdate">The SearchEntity to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SearchEntity.</returns>
        System.Threading.Tasks.Task<SearchEntity> UpdateAsync(SearchEntity searchEntityToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISearchEntityRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISearchEntityRequest Expand(Expression<Func<SearchEntity, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISearchEntityRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISearchEntityRequest Select(Expression<Func<SearchEntity, object>> selectExpression);

    }
}
