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
    /// The interface IWindowsQualityUpdateProfileAssignmentRequest.
    /// </summary>
    public partial interface IWindowsQualityUpdateProfileAssignmentRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WindowsQualityUpdateProfileAssignment using POST.
        /// </summary>
        /// <param name="windowsQualityUpdateProfileAssignmentToCreate">The WindowsQualityUpdateProfileAssignment to create.</param>
        /// <returns>The created WindowsQualityUpdateProfileAssignment.</returns>
        System.Threading.Tasks.Task<WindowsQualityUpdateProfileAssignment> CreateAsync(WindowsQualityUpdateProfileAssignment windowsQualityUpdateProfileAssignmentToCreate);        /// <summary>
        /// Creates the specified WindowsQualityUpdateProfileAssignment using POST.
        /// </summary>
        /// <param name="windowsQualityUpdateProfileAssignmentToCreate">The WindowsQualityUpdateProfileAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsQualityUpdateProfileAssignment.</returns>
        System.Threading.Tasks.Task<WindowsQualityUpdateProfileAssignment> CreateAsync(WindowsQualityUpdateProfileAssignment windowsQualityUpdateProfileAssignmentToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WindowsQualityUpdateProfileAssignment.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified WindowsQualityUpdateProfileAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WindowsQualityUpdateProfileAssignment.
        /// </summary>
        /// <returns>The WindowsQualityUpdateProfileAssignment.</returns>
        System.Threading.Tasks.Task<WindowsQualityUpdateProfileAssignment> GetAsync();

        /// <summary>
        /// Gets the specified WindowsQualityUpdateProfileAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsQualityUpdateProfileAssignment.</returns>
        System.Threading.Tasks.Task<WindowsQualityUpdateProfileAssignment> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WindowsQualityUpdateProfileAssignment using PATCH.
        /// </summary>
        /// <param name="windowsQualityUpdateProfileAssignmentToUpdate">The WindowsQualityUpdateProfileAssignment to update.</param>
        /// <returns>The updated WindowsQualityUpdateProfileAssignment.</returns>
        System.Threading.Tasks.Task<WindowsQualityUpdateProfileAssignment> UpdateAsync(WindowsQualityUpdateProfileAssignment windowsQualityUpdateProfileAssignmentToUpdate);

        /// <summary>
        /// Updates the specified WindowsQualityUpdateProfileAssignment using PATCH.
        /// </summary>
        /// <param name="windowsQualityUpdateProfileAssignmentToUpdate">The WindowsQualityUpdateProfileAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WindowsQualityUpdateProfileAssignment.</returns>
        System.Threading.Tasks.Task<WindowsQualityUpdateProfileAssignment> UpdateAsync(WindowsQualityUpdateProfileAssignment windowsQualityUpdateProfileAssignmentToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsQualityUpdateProfileAssignmentRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsQualityUpdateProfileAssignmentRequest Expand(Expression<Func<WindowsQualityUpdateProfileAssignment, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsQualityUpdateProfileAssignmentRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsQualityUpdateProfileAssignmentRequest Select(Expression<Func<WindowsQualityUpdateProfileAssignment, object>> selectExpression);

    }
}
