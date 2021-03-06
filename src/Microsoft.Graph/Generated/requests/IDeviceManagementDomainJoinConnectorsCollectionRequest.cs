// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IDeviceManagementDomainJoinConnectorsCollectionRequest.
    /// </summary>
    public partial interface IDeviceManagementDomainJoinConnectorsCollectionRequest : IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified DeviceManagementDomainJoinConnector to the collection via POST.
        /// </summary>
        /// <param name="deviceManagementDomainJoinConnector">The DeviceManagementDomainJoinConnector to add.</param>
        /// <returns>The created DeviceManagementDomainJoinConnector.</returns>
        System.Threading.Tasks.Task<DeviceManagementDomainJoinConnector> AddAsync(DeviceManagementDomainJoinConnector deviceManagementDomainJoinConnector);

        /// <summary>
        /// Adds the specified DeviceManagementDomainJoinConnector to the collection via POST.
        /// </summary>
        /// <param name="deviceManagementDomainJoinConnector">The DeviceManagementDomainJoinConnector to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementDomainJoinConnector.</returns>
        System.Threading.Tasks.Task<DeviceManagementDomainJoinConnector> AddAsync(DeviceManagementDomainJoinConnector deviceManagementDomainJoinConnector, CancellationToken cancellationToken);
        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IDeviceManagementDomainJoinConnectorsCollectionPage> GetAsync();

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IDeviceManagementDomainJoinConnectorsCollectionPage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementDomainJoinConnectorsCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementDomainJoinConnectorsCollectionRequest Expand(Expression<Func<DeviceManagementDomainJoinConnector, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementDomainJoinConnectorsCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementDomainJoinConnectorsCollectionRequest Select(Expression<Func<DeviceManagementDomainJoinConnector, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementDomainJoinConnectorsCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementDomainJoinConnectorsCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementDomainJoinConnectorsCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementDomainJoinConnectorsCollectionRequest OrderBy(string value);
    }
}
