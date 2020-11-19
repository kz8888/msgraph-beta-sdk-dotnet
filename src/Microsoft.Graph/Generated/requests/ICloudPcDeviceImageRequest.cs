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
    /// The interface ICloudPcDeviceImageRequest.
    /// </summary>
    public partial interface ICloudPcDeviceImageRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified CloudPcDeviceImage using POST.
        /// </summary>
        /// <param name="cloudPcDeviceImageToCreate">The CloudPcDeviceImage to create.</param>
        /// <returns>The created CloudPcDeviceImage.</returns>
        System.Threading.Tasks.Task<CloudPcDeviceImage> CreateAsync(CloudPcDeviceImage cloudPcDeviceImageToCreate);        /// <summary>
        /// Creates the specified CloudPcDeviceImage using POST.
        /// </summary>
        /// <param name="cloudPcDeviceImageToCreate">The CloudPcDeviceImage to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created CloudPcDeviceImage.</returns>
        System.Threading.Tasks.Task<CloudPcDeviceImage> CreateAsync(CloudPcDeviceImage cloudPcDeviceImageToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified CloudPcDeviceImage.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified CloudPcDeviceImage.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified CloudPcDeviceImage.
        /// </summary>
        /// <returns>The CloudPcDeviceImage.</returns>
        System.Threading.Tasks.Task<CloudPcDeviceImage> GetAsync();

        /// <summary>
        /// Gets the specified CloudPcDeviceImage.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The CloudPcDeviceImage.</returns>
        System.Threading.Tasks.Task<CloudPcDeviceImage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified CloudPcDeviceImage using PATCH.
        /// </summary>
        /// <param name="cloudPcDeviceImageToUpdate">The CloudPcDeviceImage to update.</param>
        /// <returns>The updated CloudPcDeviceImage.</returns>
        System.Threading.Tasks.Task<CloudPcDeviceImage> UpdateAsync(CloudPcDeviceImage cloudPcDeviceImageToUpdate);

        /// <summary>
        /// Updates the specified CloudPcDeviceImage using PATCH.
        /// </summary>
        /// <param name="cloudPcDeviceImageToUpdate">The CloudPcDeviceImage to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated CloudPcDeviceImage.</returns>
        System.Threading.Tasks.Task<CloudPcDeviceImage> UpdateAsync(CloudPcDeviceImage cloudPcDeviceImageToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ICloudPcDeviceImageRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ICloudPcDeviceImageRequest Expand(Expression<Func<CloudPcDeviceImage, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ICloudPcDeviceImageRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ICloudPcDeviceImageRequest Select(Expression<Func<CloudPcDeviceImage, object>> selectExpression);

    }
}