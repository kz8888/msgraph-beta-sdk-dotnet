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
    /// The interface IWorkbookChartRequest.
    /// </summary>
    public partial interface IWorkbookChartRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WorkbookChart using POST.
        /// </summary>
        /// <param name="workbookChartToCreate">The WorkbookChart to create.</param>
        /// <returns>The created WorkbookChart.</returns>
        System.Threading.Tasks.Task<WorkbookChart> CreateAsync(WorkbookChart workbookChartToCreate);        /// <summary>
        /// Creates the specified WorkbookChart using POST.
        /// </summary>
        /// <param name="workbookChartToCreate">The WorkbookChart to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookChart.</returns>
        System.Threading.Tasks.Task<WorkbookChart> CreateAsync(WorkbookChart workbookChartToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WorkbookChart.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified WorkbookChart.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WorkbookChart.
        /// </summary>
        /// <returns>The WorkbookChart.</returns>
        System.Threading.Tasks.Task<WorkbookChart> GetAsync();

        /// <summary>
        /// Gets the specified WorkbookChart.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookChart.</returns>
        System.Threading.Tasks.Task<WorkbookChart> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WorkbookChart using PATCH.
        /// </summary>
        /// <param name="workbookChartToUpdate">The WorkbookChart to update.</param>
        /// <returns>The updated WorkbookChart.</returns>
        System.Threading.Tasks.Task<WorkbookChart> UpdateAsync(WorkbookChart workbookChartToUpdate);

        /// <summary>
        /// Updates the specified WorkbookChart using PATCH.
        /// </summary>
        /// <param name="workbookChartToUpdate">The WorkbookChart to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WorkbookChart.</returns>
        System.Threading.Tasks.Task<WorkbookChart> UpdateAsync(WorkbookChart workbookChartToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartRequest Expand(Expression<Func<WorkbookChart, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartRequest Select(Expression<Func<WorkbookChart, object>> selectExpression);

    }
}
