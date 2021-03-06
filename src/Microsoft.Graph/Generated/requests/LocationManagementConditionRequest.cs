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
    /// The type LocationManagementConditionRequest.
    /// </summary>
    public partial class LocationManagementConditionRequest : BaseRequest, ILocationManagementConditionRequest
    {
        /// <summary>
        /// Constructs a new LocationManagementConditionRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public LocationManagementConditionRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified LocationManagementCondition using POST.
        /// </summary>
        /// <param name="locationManagementConditionToCreate">The LocationManagementCondition to create.</param>
        /// <returns>The created LocationManagementCondition.</returns>
        public System.Threading.Tasks.Task<LocationManagementCondition> CreateAsync(LocationManagementCondition locationManagementConditionToCreate)
        {
            return this.CreateAsync(locationManagementConditionToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified LocationManagementCondition using POST.
        /// </summary>
        /// <param name="locationManagementConditionToCreate">The LocationManagementCondition to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created LocationManagementCondition.</returns>
        public async System.Threading.Tasks.Task<LocationManagementCondition> CreateAsync(LocationManagementCondition locationManagementConditionToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<LocationManagementCondition>(locationManagementConditionToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified LocationManagementCondition.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified LocationManagementCondition.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<LocationManagementCondition>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified LocationManagementCondition.
        /// </summary>
        /// <returns>The LocationManagementCondition.</returns>
        public System.Threading.Tasks.Task<LocationManagementCondition> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified LocationManagementCondition.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The LocationManagementCondition.</returns>
        public async System.Threading.Tasks.Task<LocationManagementCondition> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<LocationManagementCondition>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified LocationManagementCondition using PATCH.
        /// </summary>
        /// <param name="locationManagementConditionToUpdate">The LocationManagementCondition to update.</param>
        /// <returns>The updated LocationManagementCondition.</returns>
        public System.Threading.Tasks.Task<LocationManagementCondition> UpdateAsync(LocationManagementCondition locationManagementConditionToUpdate)
        {
            return this.UpdateAsync(locationManagementConditionToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified LocationManagementCondition using PATCH.
        /// </summary>
        /// <param name="locationManagementConditionToUpdate">The LocationManagementCondition to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated LocationManagementCondition.</returns>
        public async System.Threading.Tasks.Task<LocationManagementCondition> UpdateAsync(LocationManagementCondition locationManagementConditionToUpdate, CancellationToken cancellationToken)
        {
			if (locationManagementConditionToUpdate.AdditionalData != null)
			{
				if (locationManagementConditionToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					locationManagementConditionToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, locationManagementConditionToUpdate.GetType().Name)
						});
				}
			}
            if (locationManagementConditionToUpdate.AdditionalData != null)
            {
                if (locationManagementConditionToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    locationManagementConditionToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, locationManagementConditionToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<LocationManagementCondition>(locationManagementConditionToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ILocationManagementConditionRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ILocationManagementConditionRequest Expand(Expression<Func<LocationManagementCondition, object>> expandExpression)
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
        public ILocationManagementConditionRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ILocationManagementConditionRequest Select(Expression<Func<LocationManagementCondition, object>> selectExpression)
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
        /// <param name="locationManagementConditionToInitialize">The <see cref="LocationManagementCondition"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(LocationManagementCondition locationManagementConditionToInitialize)
        {

        }
    }
}
