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
    /// The interface ITimeOffReasonRequest.
    /// </summary>
    public partial interface ITimeOffReasonRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified TimeOffReason using PUT.
        /// </summary>
        /// <param name="timeOffReasonToCreate">The TimeOffReason to create.</param>
        /// <returns>The created TimeOffReason.</returns>
        System.Threading.Tasks.Task<TimeOffReason> CreateAsync(TimeOffReason timeOffReasonToCreate);        /// <summary>
        /// Creates the specified TimeOffReason using PUT.
        /// </summary>
        /// <param name="timeOffReasonToCreate">The TimeOffReason to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TimeOffReason.</returns>
        System.Threading.Tasks.Task<TimeOffReason> CreateAsync(TimeOffReason timeOffReasonToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified TimeOffReason.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified TimeOffReason.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified TimeOffReason.
        /// </summary>
        /// <returns>The TimeOffReason.</returns>
        System.Threading.Tasks.Task<TimeOffReason> GetAsync();

        /// <summary>
        /// Gets the specified TimeOffReason.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TimeOffReason.</returns>
        System.Threading.Tasks.Task<TimeOffReason> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified TimeOffReason using PATCH.
        /// </summary>
        /// <param name="timeOffReasonToUpdate">The TimeOffReason to update.</param>
        /// <returns>The updated TimeOffReason.</returns>
        System.Threading.Tasks.Task<TimeOffReason> UpdateAsync(TimeOffReason timeOffReasonToUpdate);

        /// <summary>
        /// Updates the specified TimeOffReason using PATCH.
        /// </summary>
        /// <param name="timeOffReasonToUpdate">The TimeOffReason to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated TimeOffReason.</returns>
        System.Threading.Tasks.Task<TimeOffReason> UpdateAsync(TimeOffReason timeOffReasonToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ITimeOffReasonRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ITimeOffReasonRequest Expand(Expression<Func<TimeOffReason, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ITimeOffReasonRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ITimeOffReasonRequest Select(Expression<Func<TimeOffReason, object>> selectExpression);

    }
}