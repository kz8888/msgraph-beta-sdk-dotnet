// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type ProfileCardPropertyRequest.
    /// </summary>
    public partial class ProfileCardPropertyRequest : BaseRequest, IProfileCardPropertyRequest
    {
        /// <summary>
        /// Constructs a new ProfileCardPropertyRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ProfileCardPropertyRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified ProfileCardProperty using POST.
        /// </summary>
        /// <param name="profileCardPropertyToCreate">The ProfileCardProperty to create.</param>
        /// <returns>The created ProfileCardProperty.</returns>
        public System.Threading.Tasks.Task<ProfileCardProperty> CreateAsync(ProfileCardProperty profileCardPropertyToCreate)
        {
            return this.CreateAsync(profileCardPropertyToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified ProfileCardProperty using POST.
        /// </summary>
        /// <param name="profileCardPropertyToCreate">The ProfileCardProperty to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ProfileCardProperty.</returns>
        public async System.Threading.Tasks.Task<ProfileCardProperty> CreateAsync(ProfileCardProperty profileCardPropertyToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<ProfileCardProperty>(profileCardPropertyToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified ProfileCardProperty.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified ProfileCardProperty.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<ProfileCardProperty>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified ProfileCardProperty.
        /// </summary>
        /// <returns>The ProfileCardProperty.</returns>
        public System.Threading.Tasks.Task<ProfileCardProperty> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified ProfileCardProperty.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ProfileCardProperty.</returns>
        public async System.Threading.Tasks.Task<ProfileCardProperty> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<ProfileCardProperty>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified ProfileCardProperty using PATCH.
        /// </summary>
        /// <param name="profileCardPropertyToUpdate">The ProfileCardProperty to update.</param>
        /// <returns>The updated ProfileCardProperty.</returns>
        public System.Threading.Tasks.Task<ProfileCardProperty> UpdateAsync(ProfileCardProperty profileCardPropertyToUpdate)
        {
            return this.UpdateAsync(profileCardPropertyToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified ProfileCardProperty using PATCH.
        /// </summary>
        /// <param name="profileCardPropertyToUpdate">The ProfileCardProperty to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ProfileCardProperty.</returns>
        public async System.Threading.Tasks.Task<ProfileCardProperty> UpdateAsync(ProfileCardProperty profileCardPropertyToUpdate, CancellationToken cancellationToken)
        {
			if (profileCardPropertyToUpdate.AdditionalData != null)
			{
				if (profileCardPropertyToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					profileCardPropertyToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, profileCardPropertyToUpdate.GetType().Name)
						});
				}
			}
            if (profileCardPropertyToUpdate.AdditionalData != null)
            {
                if (profileCardPropertyToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    profileCardPropertyToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, profileCardPropertyToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<ProfileCardProperty>(profileCardPropertyToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IProfileCardPropertyRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IProfileCardPropertyRequest Expand(Expression<Func<ProfileCardProperty, object>> expandExpression)
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
        public IProfileCardPropertyRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IProfileCardPropertyRequest Select(Expression<Func<ProfileCardProperty, object>> selectExpression)
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
        /// <param name="profileCardPropertyToInitialize">The <see cref="ProfileCardProperty"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(ProfileCardProperty profileCardPropertyToInitialize)
        {

        }
    }
}