// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type UserExperienceAnalyticsBaselineRequest.
    /// </summary>
    public partial class UserExperienceAnalyticsBaselineRequest : BaseRequest, IUserExperienceAnalyticsBaselineRequest
    {
        /// <summary>
        /// Constructs a new UserExperienceAnalyticsBaselineRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public UserExperienceAnalyticsBaselineRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified UserExperienceAnalyticsBaseline using POST.
        /// </summary>
        /// <param name="userExperienceAnalyticsBaselineToCreate">The UserExperienceAnalyticsBaseline to create.</param>
        /// <returns>The created UserExperienceAnalyticsBaseline.</returns>
        public System.Threading.Tasks.Task<UserExperienceAnalyticsBaseline> CreateAsync(UserExperienceAnalyticsBaseline userExperienceAnalyticsBaselineToCreate)
        {
            return this.CreateAsync(userExperienceAnalyticsBaselineToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified UserExperienceAnalyticsBaseline using POST.
        /// </summary>
        /// <param name="userExperienceAnalyticsBaselineToCreate">The UserExperienceAnalyticsBaseline to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UserExperienceAnalyticsBaseline.</returns>
        public async System.Threading.Tasks.Task<UserExperienceAnalyticsBaseline> CreateAsync(UserExperienceAnalyticsBaseline userExperienceAnalyticsBaselineToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<UserExperienceAnalyticsBaseline>(userExperienceAnalyticsBaselineToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified UserExperienceAnalyticsBaseline.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified UserExperienceAnalyticsBaseline.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<UserExperienceAnalyticsBaseline>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified UserExperienceAnalyticsBaseline.
        /// </summary>
        /// <returns>The UserExperienceAnalyticsBaseline.</returns>
        public System.Threading.Tasks.Task<UserExperienceAnalyticsBaseline> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified UserExperienceAnalyticsBaseline.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UserExperienceAnalyticsBaseline.</returns>
        public async System.Threading.Tasks.Task<UserExperienceAnalyticsBaseline> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<UserExperienceAnalyticsBaseline>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsBaseline using PATCH.
        /// </summary>
        /// <param name="userExperienceAnalyticsBaselineToUpdate">The UserExperienceAnalyticsBaseline to update.</param>
        /// <returns>The updated UserExperienceAnalyticsBaseline.</returns>
        public System.Threading.Tasks.Task<UserExperienceAnalyticsBaseline> UpdateAsync(UserExperienceAnalyticsBaseline userExperienceAnalyticsBaselineToUpdate)
        {
            return this.UpdateAsync(userExperienceAnalyticsBaselineToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsBaseline using PATCH.
        /// </summary>
        /// <param name="userExperienceAnalyticsBaselineToUpdate">The UserExperienceAnalyticsBaseline to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UserExperienceAnalyticsBaseline.</returns>
        public async System.Threading.Tasks.Task<UserExperienceAnalyticsBaseline> UpdateAsync(UserExperienceAnalyticsBaseline userExperienceAnalyticsBaselineToUpdate, CancellationToken cancellationToken)
        {
			if (userExperienceAnalyticsBaselineToUpdate.AdditionalData != null)
			{
				if (userExperienceAnalyticsBaselineToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					userExperienceAnalyticsBaselineToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, userExperienceAnalyticsBaselineToUpdate.GetType().Name)
						});
				}
			}
            if (userExperienceAnalyticsBaselineToUpdate.AdditionalData != null)
            {
                if (userExperienceAnalyticsBaselineToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    userExperienceAnalyticsBaselineToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, userExperienceAnalyticsBaselineToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<UserExperienceAnalyticsBaseline>(userExperienceAnalyticsBaselineToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUserExperienceAnalyticsBaselineRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUserExperienceAnalyticsBaselineRequest Expand(Expression<Func<UserExperienceAnalyticsBaseline, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IUserExperienceAnalyticsBaselineRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IUserExperienceAnalyticsBaselineRequest Select(Expression<Func<UserExperienceAnalyticsBaseline, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="userExperienceAnalyticsBaselineToInitialize">The <see cref="UserExperienceAnalyticsBaseline"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(UserExperienceAnalyticsBaseline userExperienceAnalyticsBaselineToInitialize)
        {

        }
    }
}
