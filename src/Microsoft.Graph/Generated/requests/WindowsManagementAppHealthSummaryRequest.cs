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
    /// The type WindowsManagementAppHealthSummaryRequest.
    /// </summary>
    public partial class WindowsManagementAppHealthSummaryRequest : BaseRequest, IWindowsManagementAppHealthSummaryRequest
    {
        /// <summary>
        /// Constructs a new WindowsManagementAppHealthSummaryRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public WindowsManagementAppHealthSummaryRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified WindowsManagementAppHealthSummary using POST.
        /// </summary>
        /// <param name="windowsManagementAppHealthSummaryToCreate">The WindowsManagementAppHealthSummary to create.</param>
        /// <returns>The created WindowsManagementAppHealthSummary.</returns>
        public System.Threading.Tasks.Task<WindowsManagementAppHealthSummary> CreateAsync(WindowsManagementAppHealthSummary windowsManagementAppHealthSummaryToCreate)
        {
            return this.CreateAsync(windowsManagementAppHealthSummaryToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified WindowsManagementAppHealthSummary using POST.
        /// </summary>
        /// <param name="windowsManagementAppHealthSummaryToCreate">The WindowsManagementAppHealthSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsManagementAppHealthSummary.</returns>
        public async System.Threading.Tasks.Task<WindowsManagementAppHealthSummary> CreateAsync(WindowsManagementAppHealthSummary windowsManagementAppHealthSummaryToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<WindowsManagementAppHealthSummary>(windowsManagementAppHealthSummaryToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified WindowsManagementAppHealthSummary.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified WindowsManagementAppHealthSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<WindowsManagementAppHealthSummary>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified WindowsManagementAppHealthSummary.
        /// </summary>
        /// <returns>The WindowsManagementAppHealthSummary.</returns>
        public System.Threading.Tasks.Task<WindowsManagementAppHealthSummary> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified WindowsManagementAppHealthSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsManagementAppHealthSummary.</returns>
        public async System.Threading.Tasks.Task<WindowsManagementAppHealthSummary> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<WindowsManagementAppHealthSummary>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified WindowsManagementAppHealthSummary using PATCH.
        /// </summary>
        /// <param name="windowsManagementAppHealthSummaryToUpdate">The WindowsManagementAppHealthSummary to update.</param>
        /// <returns>The updated WindowsManagementAppHealthSummary.</returns>
        public System.Threading.Tasks.Task<WindowsManagementAppHealthSummary> UpdateAsync(WindowsManagementAppHealthSummary windowsManagementAppHealthSummaryToUpdate)
        {
            return this.UpdateAsync(windowsManagementAppHealthSummaryToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified WindowsManagementAppHealthSummary using PATCH.
        /// </summary>
        /// <param name="windowsManagementAppHealthSummaryToUpdate">The WindowsManagementAppHealthSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WindowsManagementAppHealthSummary.</returns>
        public async System.Threading.Tasks.Task<WindowsManagementAppHealthSummary> UpdateAsync(WindowsManagementAppHealthSummary windowsManagementAppHealthSummaryToUpdate, CancellationToken cancellationToken)
        {
			if (windowsManagementAppHealthSummaryToUpdate.AdditionalData != null)
			{
				if (windowsManagementAppHealthSummaryToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					windowsManagementAppHealthSummaryToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, windowsManagementAppHealthSummaryToUpdate.GetType().Name)
						});
				}
			}
            if (windowsManagementAppHealthSummaryToUpdate.AdditionalData != null)
            {
                if (windowsManagementAppHealthSummaryToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    windowsManagementAppHealthSummaryToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, windowsManagementAppHealthSummaryToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<WindowsManagementAppHealthSummary>(windowsManagementAppHealthSummaryToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWindowsManagementAppHealthSummaryRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWindowsManagementAppHealthSummaryRequest Expand(Expression<Func<WindowsManagementAppHealthSummary, object>> expandExpression)
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
        public IWindowsManagementAppHealthSummaryRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IWindowsManagementAppHealthSummaryRequest Select(Expression<Func<WindowsManagementAppHealthSummary, object>> selectExpression)
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
        /// <param name="windowsManagementAppHealthSummaryToInitialize">The <see cref="WindowsManagementAppHealthSummary"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(WindowsManagementAppHealthSummary windowsManagementAppHealthSummaryToInitialize)
        {

        }
    }
}
