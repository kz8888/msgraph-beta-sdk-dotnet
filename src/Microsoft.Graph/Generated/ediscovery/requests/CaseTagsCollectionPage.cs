// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionPage.cs.tt

namespace Microsoft.Graph.Ediscovery
{
    using System;

    /// <summary>
    /// The type CaseTagsCollectionPage.
    /// </summary>
    public partial class CaseTagsCollectionPage : Microsoft.Graph.CollectionPage<Tag>, ICaseTagsCollectionPage
    {
        /// <summary>
        /// Gets the next page <see cref="ICaseTagsCollectionRequest"/> instance.
        /// </summary>
        public ICaseTagsCollectionRequest NextPageRequest { get; private set; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        public void InitializeNextPageRequest(Microsoft.Graph.IBaseClient client, string nextPageLinkString)
        {
            if (!string.IsNullOrEmpty(nextPageLinkString))
            {
                this.NextPageRequest = new CaseTagsCollectionRequest(
                    nextPageLinkString,
                    client,
                    null);
            }
        }
    }
}
