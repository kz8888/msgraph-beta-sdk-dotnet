// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type DeviceManagementSettingDefinitionsCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceManagementSettingDefinitionsCollectionRequestBuilder : BaseRequestBuilder, IDeviceManagementSettingDefinitionsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceManagementSettingDefinitionsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceManagementSettingDefinitionsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceManagementSettingDefinitionsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceManagementSettingDefinitionsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceManagementSettingDefinitionsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDeviceManagementSettingDefinitionRequestBuilder"/> for the specified DeviceManagementDeviceManagementSettingDefinition.
        /// </summary>
        /// <param name="id">The ID for the DeviceManagementDeviceManagementSettingDefinition.</param>
        /// <returns>The <see cref="IDeviceManagementSettingDefinitionRequestBuilder"/>.</returns>
        public IDeviceManagementSettingDefinitionRequestBuilder this[string id]
        {
            get
            {
                return new DeviceManagementSettingDefinitionRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
