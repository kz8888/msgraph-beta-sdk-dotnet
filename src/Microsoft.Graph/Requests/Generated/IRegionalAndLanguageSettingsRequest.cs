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
    /// The interface IRegionalAndLanguageSettingsRequest.
    /// </summary>
    public partial interface IRegionalAndLanguageSettingsRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified RegionalAndLanguageSettings using POST.
        /// </summary>
        /// <param name="regionalAndLanguageSettingsToCreate">The RegionalAndLanguageSettings to create.</param>
        /// <returns>The created RegionalAndLanguageSettings.</returns>
        System.Threading.Tasks.Task<RegionalAndLanguageSettings> CreateAsync(RegionalAndLanguageSettings regionalAndLanguageSettingsToCreate);        /// <summary>
        /// Creates the specified RegionalAndLanguageSettings using POST.
        /// </summary>
        /// <param name="regionalAndLanguageSettingsToCreate">The RegionalAndLanguageSettings to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created RegionalAndLanguageSettings.</returns>
        System.Threading.Tasks.Task<RegionalAndLanguageSettings> CreateAsync(RegionalAndLanguageSettings regionalAndLanguageSettingsToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified RegionalAndLanguageSettings.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified RegionalAndLanguageSettings.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified RegionalAndLanguageSettings.
        /// </summary>
        /// <returns>The RegionalAndLanguageSettings.</returns>
        System.Threading.Tasks.Task<RegionalAndLanguageSettings> GetAsync();

        /// <summary>
        /// Gets the specified RegionalAndLanguageSettings.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The RegionalAndLanguageSettings.</returns>
        System.Threading.Tasks.Task<RegionalAndLanguageSettings> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified RegionalAndLanguageSettings using PATCH.
        /// </summary>
        /// <param name="regionalAndLanguageSettingsToUpdate">The RegionalAndLanguageSettings to update.</param>
        /// <returns>The updated RegionalAndLanguageSettings.</returns>
        System.Threading.Tasks.Task<RegionalAndLanguageSettings> UpdateAsync(RegionalAndLanguageSettings regionalAndLanguageSettingsToUpdate);

        /// <summary>
        /// Updates the specified RegionalAndLanguageSettings using PATCH.
        /// </summary>
        /// <param name="regionalAndLanguageSettingsToUpdate">The RegionalAndLanguageSettings to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated RegionalAndLanguageSettings.</returns>
        System.Threading.Tasks.Task<RegionalAndLanguageSettings> UpdateAsync(RegionalAndLanguageSettings regionalAndLanguageSettingsToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IRegionalAndLanguageSettingsRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IRegionalAndLanguageSettingsRequest Expand(Expression<Func<RegionalAndLanguageSettings, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IRegionalAndLanguageSettingsRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IRegionalAndLanguageSettingsRequest Select(Expression<Func<RegionalAndLanguageSettings, object>> selectExpression);

    }
}