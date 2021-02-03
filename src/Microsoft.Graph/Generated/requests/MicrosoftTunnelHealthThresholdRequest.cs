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
    /// The type MicrosoftTunnelHealthThresholdRequest.
    /// </summary>
    public partial class MicrosoftTunnelHealthThresholdRequest : BaseRequest, IMicrosoftTunnelHealthThresholdRequest
    {
        /// <summary>
        /// Constructs a new MicrosoftTunnelHealthThresholdRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public MicrosoftTunnelHealthThresholdRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified MicrosoftTunnelHealthThreshold using POST.
        /// </summary>
        /// <param name="microsoftTunnelHealthThresholdToCreate">The MicrosoftTunnelHealthThreshold to create.</param>
        /// <returns>The created MicrosoftTunnelHealthThreshold.</returns>
        public System.Threading.Tasks.Task<MicrosoftTunnelHealthThreshold> CreateAsync(MicrosoftTunnelHealthThreshold microsoftTunnelHealthThresholdToCreate)
        {
            return this.CreateAsync(microsoftTunnelHealthThresholdToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified MicrosoftTunnelHealthThreshold using POST.
        /// </summary>
        /// <param name="microsoftTunnelHealthThresholdToCreate">The MicrosoftTunnelHealthThreshold to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MicrosoftTunnelHealthThreshold.</returns>
        public async System.Threading.Tasks.Task<MicrosoftTunnelHealthThreshold> CreateAsync(MicrosoftTunnelHealthThreshold microsoftTunnelHealthThresholdToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<MicrosoftTunnelHealthThreshold>(microsoftTunnelHealthThresholdToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified MicrosoftTunnelHealthThreshold.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified MicrosoftTunnelHealthThreshold.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<MicrosoftTunnelHealthThreshold>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified MicrosoftTunnelHealthThreshold.
        /// </summary>
        /// <returns>The MicrosoftTunnelHealthThreshold.</returns>
        public System.Threading.Tasks.Task<MicrosoftTunnelHealthThreshold> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified MicrosoftTunnelHealthThreshold.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MicrosoftTunnelHealthThreshold.</returns>
        public async System.Threading.Tasks.Task<MicrosoftTunnelHealthThreshold> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<MicrosoftTunnelHealthThreshold>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified MicrosoftTunnelHealthThreshold using PATCH.
        /// </summary>
        /// <param name="microsoftTunnelHealthThresholdToUpdate">The MicrosoftTunnelHealthThreshold to update.</param>
        /// <returns>The updated MicrosoftTunnelHealthThreshold.</returns>
        public System.Threading.Tasks.Task<MicrosoftTunnelHealthThreshold> UpdateAsync(MicrosoftTunnelHealthThreshold microsoftTunnelHealthThresholdToUpdate)
        {
            return this.UpdateAsync(microsoftTunnelHealthThresholdToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified MicrosoftTunnelHealthThreshold using PATCH.
        /// </summary>
        /// <param name="microsoftTunnelHealthThresholdToUpdate">The MicrosoftTunnelHealthThreshold to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MicrosoftTunnelHealthThreshold.</returns>
        public async System.Threading.Tasks.Task<MicrosoftTunnelHealthThreshold> UpdateAsync(MicrosoftTunnelHealthThreshold microsoftTunnelHealthThresholdToUpdate, CancellationToken cancellationToken)
        {
			if (microsoftTunnelHealthThresholdToUpdate.AdditionalData != null)
			{
				if (microsoftTunnelHealthThresholdToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					microsoftTunnelHealthThresholdToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, microsoftTunnelHealthThresholdToUpdate.GetType().Name)
						});
				}
			}
            if (microsoftTunnelHealthThresholdToUpdate.AdditionalData != null)
            {
                if (microsoftTunnelHealthThresholdToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    microsoftTunnelHealthThresholdToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, microsoftTunnelHealthThresholdToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<MicrosoftTunnelHealthThreshold>(microsoftTunnelHealthThresholdToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMicrosoftTunnelHealthThresholdRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMicrosoftTunnelHealthThresholdRequest Expand(Expression<Func<MicrosoftTunnelHealthThreshold, object>> expandExpression)
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
        public IMicrosoftTunnelHealthThresholdRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IMicrosoftTunnelHealthThresholdRequest Select(Expression<Func<MicrosoftTunnelHealthThreshold, object>> selectExpression)
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
        /// <param name="microsoftTunnelHealthThresholdToInitialize">The <see cref="MicrosoftTunnelHealthThreshold"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(MicrosoftTunnelHealthThreshold microsoftTunnelHealthThresholdToInitialize)
        {

        }
    }
}
