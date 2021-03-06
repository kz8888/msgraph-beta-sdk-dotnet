// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IMethodCollectionPage.cs.tt

namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The interface IDeviceConfigurationAssignCollectionPage.
    /// </summary>
    [JsonConverter(typeof(InterfaceConverter<DeviceConfigurationAssignCollectionPage>))]
    public interface IDeviceConfigurationAssignCollectionPage : ICollectionPage<DeviceConfigurationAssignment>
    {
        /// <summary>
        /// Gets the next page <see cref="IDeviceConfigurationAssignRequest"/> instance.
        /// </summary>
        IDeviceConfigurationAssignRequest NextPageRequest { get; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString);
    }
}
