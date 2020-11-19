// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type UserJoinedTeamsCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial class UserJoinedTeamsCollectionWithReferencesRequestBuilder : BaseRequestBuilder, IUserJoinedTeamsCollectionWithReferencesRequestBuilder
    {

        /// <summary>
        /// Constructs a new UserJoinedTeamsCollectionWithReferencesRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public UserJoinedTeamsCollectionWithReferencesRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IUserJoinedTeamsCollectionWithReferencesRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IUserJoinedTeamsCollectionWithReferencesRequest Request(IEnumerable<Option> options)
        {
            return new UserJoinedTeamsCollectionWithReferencesRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ITeamWithReferenceRequestBuilder"/> for the specified UserTeam.
        /// </summary>
        /// <param name="id">The ID for the UserTeam.</param>
        /// <returns>The <see cref="ITeamWithReferenceRequestBuilder"/>.</returns>
        public ITeamWithReferenceRequestBuilder this[string id]
        {
            get
            {
                return new TeamWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
        /// <summary>
        /// Gets an <see cref="IUserJoinedTeamsCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IUserJoinedTeamsCollectionReferencesRequestBuilder"/>.</returns>
        public IUserJoinedTeamsCollectionReferencesRequestBuilder References
        {
            get
            {
                return new UserJoinedTeamsCollectionReferencesRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}