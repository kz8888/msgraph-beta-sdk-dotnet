// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityCollectionRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IDeviceManagementWindowsAutopilotDeploymentProfilesCollectionRequest.
    /// </summary>
    public partial interface IDeviceManagementWindowsAutopilotDeploymentProfilesCollectionRequest : IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified WindowsAutopilotDeploymentProfile to the collection via POST.
        /// </summary>
        /// <param name="windowsAutopilotDeploymentProfile">The WindowsAutopilotDeploymentProfile to add.</param>
        /// <returns>The created WindowsAutopilotDeploymentProfile.</returns>
        System.Threading.Tasks.Task<WindowsAutopilotDeploymentProfile> AddAsync(WindowsAutopilotDeploymentProfile windowsAutopilotDeploymentProfile);

        /// <summary>
        /// Adds the specified WindowsAutopilotDeploymentProfile to the collection via POST.
        /// </summary>
        /// <param name="windowsAutopilotDeploymentProfile">The WindowsAutopilotDeploymentProfile to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsAutopilotDeploymentProfile.</returns>
        System.Threading.Tasks.Task<WindowsAutopilotDeploymentProfile> AddAsync(WindowsAutopilotDeploymentProfile windowsAutopilotDeploymentProfile, CancellationToken cancellationToken);
        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IDeviceManagementWindowsAutopilotDeploymentProfilesCollectionPage> GetAsync();

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IDeviceManagementWindowsAutopilotDeploymentProfilesCollectionPage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementWindowsAutopilotDeploymentProfilesCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementWindowsAutopilotDeploymentProfilesCollectionRequest Expand(Expression<Func<WindowsAutopilotDeploymentProfile, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementWindowsAutopilotDeploymentProfilesCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementWindowsAutopilotDeploymentProfilesCollectionRequest Select(Expression<Func<WindowsAutopilotDeploymentProfile, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementWindowsAutopilotDeploymentProfilesCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementWindowsAutopilotDeploymentProfilesCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementWindowsAutopilotDeploymentProfilesCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementWindowsAutopilotDeploymentProfilesCollectionRequest OrderBy(string value);
    }
}