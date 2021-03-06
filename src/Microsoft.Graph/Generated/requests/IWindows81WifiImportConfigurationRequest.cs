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
    /// The interface IWindows81WifiImportConfigurationRequest.
    /// </summary>
    public partial interface IWindows81WifiImportConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Windows81WifiImportConfiguration using POST.
        /// </summary>
        /// <param name="windows81WifiImportConfigurationToCreate">The Windows81WifiImportConfiguration to create.</param>
        /// <returns>The created Windows81WifiImportConfiguration.</returns>
        System.Threading.Tasks.Task<Windows81WifiImportConfiguration> CreateAsync(Windows81WifiImportConfiguration windows81WifiImportConfigurationToCreate);        /// <summary>
        /// Creates the specified Windows81WifiImportConfiguration using POST.
        /// </summary>
        /// <param name="windows81WifiImportConfigurationToCreate">The Windows81WifiImportConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Windows81WifiImportConfiguration.</returns>
        System.Threading.Tasks.Task<Windows81WifiImportConfiguration> CreateAsync(Windows81WifiImportConfiguration windows81WifiImportConfigurationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Windows81WifiImportConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Windows81WifiImportConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Windows81WifiImportConfiguration.
        /// </summary>
        /// <returns>The Windows81WifiImportConfiguration.</returns>
        System.Threading.Tasks.Task<Windows81WifiImportConfiguration> GetAsync();

        /// <summary>
        /// Gets the specified Windows81WifiImportConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Windows81WifiImportConfiguration.</returns>
        System.Threading.Tasks.Task<Windows81WifiImportConfiguration> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Windows81WifiImportConfiguration using PATCH.
        /// </summary>
        /// <param name="windows81WifiImportConfigurationToUpdate">The Windows81WifiImportConfiguration to update.</param>
        /// <returns>The updated Windows81WifiImportConfiguration.</returns>
        System.Threading.Tasks.Task<Windows81WifiImportConfiguration> UpdateAsync(Windows81WifiImportConfiguration windows81WifiImportConfigurationToUpdate);

        /// <summary>
        /// Updates the specified Windows81WifiImportConfiguration using PATCH.
        /// </summary>
        /// <param name="windows81WifiImportConfigurationToUpdate">The Windows81WifiImportConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Windows81WifiImportConfiguration.</returns>
        System.Threading.Tasks.Task<Windows81WifiImportConfiguration> UpdateAsync(Windows81WifiImportConfiguration windows81WifiImportConfigurationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindows81WifiImportConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindows81WifiImportConfigurationRequest Expand(Expression<Func<Windows81WifiImportConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindows81WifiImportConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindows81WifiImportConfigurationRequest Select(Expression<Func<Windows81WifiImportConfiguration, object>> selectExpression);

    }
}
