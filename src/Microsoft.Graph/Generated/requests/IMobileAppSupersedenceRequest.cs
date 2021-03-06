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
    /// The interface IMobileAppSupersedenceRequest.
    /// </summary>
    public partial interface IMobileAppSupersedenceRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified MobileAppSupersedence using POST.
        /// </summary>
        /// <param name="mobileAppSupersedenceToCreate">The MobileAppSupersedence to create.</param>
        /// <returns>The created MobileAppSupersedence.</returns>
        System.Threading.Tasks.Task<MobileAppSupersedence> CreateAsync(MobileAppSupersedence mobileAppSupersedenceToCreate);        /// <summary>
        /// Creates the specified MobileAppSupersedence using POST.
        /// </summary>
        /// <param name="mobileAppSupersedenceToCreate">The MobileAppSupersedence to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MobileAppSupersedence.</returns>
        System.Threading.Tasks.Task<MobileAppSupersedence> CreateAsync(MobileAppSupersedence mobileAppSupersedenceToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified MobileAppSupersedence.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified MobileAppSupersedence.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified MobileAppSupersedence.
        /// </summary>
        /// <returns>The MobileAppSupersedence.</returns>
        System.Threading.Tasks.Task<MobileAppSupersedence> GetAsync();

        /// <summary>
        /// Gets the specified MobileAppSupersedence.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MobileAppSupersedence.</returns>
        System.Threading.Tasks.Task<MobileAppSupersedence> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified MobileAppSupersedence using PATCH.
        /// </summary>
        /// <param name="mobileAppSupersedenceToUpdate">The MobileAppSupersedence to update.</param>
        /// <returns>The updated MobileAppSupersedence.</returns>
        System.Threading.Tasks.Task<MobileAppSupersedence> UpdateAsync(MobileAppSupersedence mobileAppSupersedenceToUpdate);

        /// <summary>
        /// Updates the specified MobileAppSupersedence using PATCH.
        /// </summary>
        /// <param name="mobileAppSupersedenceToUpdate">The MobileAppSupersedence to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MobileAppSupersedence.</returns>
        System.Threading.Tasks.Task<MobileAppSupersedence> UpdateAsync(MobileAppSupersedence mobileAppSupersedenceToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IMobileAppSupersedenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IMobileAppSupersedenceRequest Expand(Expression<Func<MobileAppSupersedence, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IMobileAppSupersedenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IMobileAppSupersedenceRequest Select(Expression<Func<MobileAppSupersedence, object>> selectExpression);

    }
}
