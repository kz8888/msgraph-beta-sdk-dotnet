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
    /// The interface IIdentityUserFlowAttributeAssignmentRequest.
    /// </summary>
    public partial interface IIdentityUserFlowAttributeAssignmentRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified IdentityUserFlowAttributeAssignment using POST.
        /// </summary>
        /// <param name="identityUserFlowAttributeAssignmentToCreate">The IdentityUserFlowAttributeAssignment to create.</param>
        /// <returns>The created IdentityUserFlowAttributeAssignment.</returns>
        System.Threading.Tasks.Task<IdentityUserFlowAttributeAssignment> CreateAsync(IdentityUserFlowAttributeAssignment identityUserFlowAttributeAssignmentToCreate);        /// <summary>
        /// Creates the specified IdentityUserFlowAttributeAssignment using POST.
        /// </summary>
        /// <param name="identityUserFlowAttributeAssignmentToCreate">The IdentityUserFlowAttributeAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IdentityUserFlowAttributeAssignment.</returns>
        System.Threading.Tasks.Task<IdentityUserFlowAttributeAssignment> CreateAsync(IdentityUserFlowAttributeAssignment identityUserFlowAttributeAssignmentToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified IdentityUserFlowAttributeAssignment.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified IdentityUserFlowAttributeAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified IdentityUserFlowAttributeAssignment.
        /// </summary>
        /// <returns>The IdentityUserFlowAttributeAssignment.</returns>
        System.Threading.Tasks.Task<IdentityUserFlowAttributeAssignment> GetAsync();

        /// <summary>
        /// Gets the specified IdentityUserFlowAttributeAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IdentityUserFlowAttributeAssignment.</returns>
        System.Threading.Tasks.Task<IdentityUserFlowAttributeAssignment> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified IdentityUserFlowAttributeAssignment using PATCH.
        /// </summary>
        /// <param name="identityUserFlowAttributeAssignmentToUpdate">The IdentityUserFlowAttributeAssignment to update.</param>
        /// <returns>The updated IdentityUserFlowAttributeAssignment.</returns>
        System.Threading.Tasks.Task<IdentityUserFlowAttributeAssignment> UpdateAsync(IdentityUserFlowAttributeAssignment identityUserFlowAttributeAssignmentToUpdate);

        /// <summary>
        /// Updates the specified IdentityUserFlowAttributeAssignment using PATCH.
        /// </summary>
        /// <param name="identityUserFlowAttributeAssignmentToUpdate">The IdentityUserFlowAttributeAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated IdentityUserFlowAttributeAssignment.</returns>
        System.Threading.Tasks.Task<IdentityUserFlowAttributeAssignment> UpdateAsync(IdentityUserFlowAttributeAssignment identityUserFlowAttributeAssignmentToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IIdentityUserFlowAttributeAssignmentRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IIdentityUserFlowAttributeAssignmentRequest Expand(Expression<Func<IdentityUserFlowAttributeAssignment, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IIdentityUserFlowAttributeAssignmentRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IIdentityUserFlowAttributeAssignmentRequest Select(Expression<Func<IdentityUserFlowAttributeAssignment, object>> selectExpression);

    }
}
