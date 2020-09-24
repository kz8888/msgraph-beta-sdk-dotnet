// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type GroupPolicyDefinitionRequestBuilder.
    /// </summary>
    public partial class GroupPolicyDefinitionRequestBuilder : EntityRequestBuilder, IGroupPolicyDefinitionRequestBuilder
    {

        /// <summary>
        /// Constructs a new GroupPolicyDefinitionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GroupPolicyDefinitionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IGroupPolicyDefinitionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IGroupPolicyDefinitionRequest Request(IEnumerable<Option> options)
        {
            return new GroupPolicyDefinitionRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Category.
        /// </summary>
        /// <returns>The <see cref="IGroupPolicyCategoryWithReferenceRequestBuilder"/>.</returns>
        public IGroupPolicyCategoryWithReferenceRequestBuilder Category
        {
            get
            {
                return new GroupPolicyCategoryWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl("category"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for DefinitionFile.
        /// </summary>
        /// <returns>The <see cref="IGroupPolicyDefinitionFileWithReferenceRequestBuilder"/>.</returns>
        public IGroupPolicyDefinitionFileWithReferenceRequestBuilder DefinitionFile
        {
            get
            {
                return new GroupPolicyDefinitionFileWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl("definitionFile"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Presentations.
        /// </summary>
        /// <returns>The <see cref="IGroupPolicyDefinitionPresentationsCollectionRequestBuilder"/>.</returns>
        public IGroupPolicyDefinitionPresentationsCollectionRequestBuilder Presentations
        {
            get
            {
                return new GroupPolicyDefinitionPresentationsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("presentations"), this.Client);
            }
        }
    
    }
}