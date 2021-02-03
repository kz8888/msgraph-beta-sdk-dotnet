// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IMethodCollectionPage.cs.tt

namespace Microsoft.Graph.Ediscovery
{
    using Newtonsoft.Json;

    /// <summary>
    /// The interface ITagAsHierarchyCollectionPage.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.InterfaceConverter<TagAsHierarchyCollectionPage>))]
    public interface ITagAsHierarchyCollectionPage : Microsoft.Graph.ICollectionPage<Tag>
    {
        /// <summary>
        /// Gets the next page <see cref="ITagAsHierarchyRequest"/> instance.
        /// </summary>
        ITagAsHierarchyRequest NextPageRequest { get; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(Microsoft.Graph.IBaseClient client, string nextPageLinkString);
    }
}
