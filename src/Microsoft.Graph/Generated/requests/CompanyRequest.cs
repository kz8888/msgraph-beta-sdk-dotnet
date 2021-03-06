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
    /// The type CompanyRequest.
    /// </summary>
    public partial class CompanyRequest : BaseRequest, ICompanyRequest
    {
        /// <summary>
        /// Constructs a new CompanyRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public CompanyRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Company using POST.
        /// </summary>
        /// <param name="companyToCreate">The Company to create.</param>
        /// <returns>The created Company.</returns>
        public System.Threading.Tasks.Task<Company> CreateAsync(Company companyToCreate)
        {
            return this.CreateAsync(companyToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified Company using POST.
        /// </summary>
        /// <param name="companyToCreate">The Company to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Company.</returns>
        public async System.Threading.Tasks.Task<Company> CreateAsync(Company companyToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<Company>(companyToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified Company.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified Company.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<Company>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified Company.
        /// </summary>
        /// <returns>The Company.</returns>
        public System.Threading.Tasks.Task<Company> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified Company.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Company.</returns>
        public async System.Threading.Tasks.Task<Company> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<Company>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified Company using PATCH.
        /// </summary>
        /// <param name="companyToUpdate">The Company to update.</param>
        /// <returns>The updated Company.</returns>
        public System.Threading.Tasks.Task<Company> UpdateAsync(Company companyToUpdate)
        {
            return this.UpdateAsync(companyToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified Company using PATCH.
        /// </summary>
        /// <param name="companyToUpdate">The Company to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Company.</returns>
        public async System.Threading.Tasks.Task<Company> UpdateAsync(Company companyToUpdate, CancellationToken cancellationToken)
        {
			if (companyToUpdate.AdditionalData != null)
			{
				if (companyToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					companyToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, companyToUpdate.GetType().Name)
						});
				}
			}
            if (companyToUpdate.AdditionalData != null)
            {
                if (companyToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    companyToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, companyToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<Company>(companyToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ICompanyRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ICompanyRequest Expand(Expression<Func<Company, object>> expandExpression)
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
        public ICompanyRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ICompanyRequest Select(Expression<Func<Company, object>> selectExpression)
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
        /// <param name="companyToInitialize">The <see cref="Company"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Company companyToInitialize)
        {

            if (companyToInitialize != null && companyToInitialize.AdditionalData != null)
            {

                if (companyToInitialize.Accounts != null && companyToInitialize.Accounts.CurrentPage != null)
                {
                    companyToInitialize.Accounts.AdditionalData = companyToInitialize.AdditionalData;

                    object nextPageLink;
                    companyToInitialize.AdditionalData.TryGetValue("accounts@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        companyToInitialize.Accounts.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (companyToInitialize.AgedAccountsPayable != null && companyToInitialize.AgedAccountsPayable.CurrentPage != null)
                {
                    companyToInitialize.AgedAccountsPayable.AdditionalData = companyToInitialize.AdditionalData;

                    object nextPageLink;
                    companyToInitialize.AdditionalData.TryGetValue("agedAccountsPayable@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        companyToInitialize.AgedAccountsPayable.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (companyToInitialize.AgedAccountsReceivable != null && companyToInitialize.AgedAccountsReceivable.CurrentPage != null)
                {
                    companyToInitialize.AgedAccountsReceivable.AdditionalData = companyToInitialize.AdditionalData;

                    object nextPageLink;
                    companyToInitialize.AdditionalData.TryGetValue("agedAccountsReceivable@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        companyToInitialize.AgedAccountsReceivable.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (companyToInitialize.CompanyInformation != null && companyToInitialize.CompanyInformation.CurrentPage != null)
                {
                    companyToInitialize.CompanyInformation.AdditionalData = companyToInitialize.AdditionalData;

                    object nextPageLink;
                    companyToInitialize.AdditionalData.TryGetValue("companyInformation@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        companyToInitialize.CompanyInformation.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (companyToInitialize.CountriesRegions != null && companyToInitialize.CountriesRegions.CurrentPage != null)
                {
                    companyToInitialize.CountriesRegions.AdditionalData = companyToInitialize.AdditionalData;

                    object nextPageLink;
                    companyToInitialize.AdditionalData.TryGetValue("countriesRegions@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        companyToInitialize.CountriesRegions.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (companyToInitialize.Currencies != null && companyToInitialize.Currencies.CurrentPage != null)
                {
                    companyToInitialize.Currencies.AdditionalData = companyToInitialize.AdditionalData;

                    object nextPageLink;
                    companyToInitialize.AdditionalData.TryGetValue("currencies@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        companyToInitialize.Currencies.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (companyToInitialize.CustomerPaymentJournals != null && companyToInitialize.CustomerPaymentJournals.CurrentPage != null)
                {
                    companyToInitialize.CustomerPaymentJournals.AdditionalData = companyToInitialize.AdditionalData;

                    object nextPageLink;
                    companyToInitialize.AdditionalData.TryGetValue("customerPaymentJournals@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        companyToInitialize.CustomerPaymentJournals.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (companyToInitialize.CustomerPayments != null && companyToInitialize.CustomerPayments.CurrentPage != null)
                {
                    companyToInitialize.CustomerPayments.AdditionalData = companyToInitialize.AdditionalData;

                    object nextPageLink;
                    companyToInitialize.AdditionalData.TryGetValue("customerPayments@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        companyToInitialize.CustomerPayments.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (companyToInitialize.Customers != null && companyToInitialize.Customers.CurrentPage != null)
                {
                    companyToInitialize.Customers.AdditionalData = companyToInitialize.AdditionalData;

                    object nextPageLink;
                    companyToInitialize.AdditionalData.TryGetValue("customers@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        companyToInitialize.Customers.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (companyToInitialize.Dimensions != null && companyToInitialize.Dimensions.CurrentPage != null)
                {
                    companyToInitialize.Dimensions.AdditionalData = companyToInitialize.AdditionalData;

                    object nextPageLink;
                    companyToInitialize.AdditionalData.TryGetValue("dimensions@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        companyToInitialize.Dimensions.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (companyToInitialize.DimensionValues != null && companyToInitialize.DimensionValues.CurrentPage != null)
                {
                    companyToInitialize.DimensionValues.AdditionalData = companyToInitialize.AdditionalData;

                    object nextPageLink;
                    companyToInitialize.AdditionalData.TryGetValue("dimensionValues@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        companyToInitialize.DimensionValues.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (companyToInitialize.Employees != null && companyToInitialize.Employees.CurrentPage != null)
                {
                    companyToInitialize.Employees.AdditionalData = companyToInitialize.AdditionalData;

                    object nextPageLink;
                    companyToInitialize.AdditionalData.TryGetValue("employees@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        companyToInitialize.Employees.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (companyToInitialize.GeneralLedgerEntries != null && companyToInitialize.GeneralLedgerEntries.CurrentPage != null)
                {
                    companyToInitialize.GeneralLedgerEntries.AdditionalData = companyToInitialize.AdditionalData;

                    object nextPageLink;
                    companyToInitialize.AdditionalData.TryGetValue("generalLedgerEntries@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        companyToInitialize.GeneralLedgerEntries.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (companyToInitialize.ItemCategories != null && companyToInitialize.ItemCategories.CurrentPage != null)
                {
                    companyToInitialize.ItemCategories.AdditionalData = companyToInitialize.AdditionalData;

                    object nextPageLink;
                    companyToInitialize.AdditionalData.TryGetValue("itemCategories@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        companyToInitialize.ItemCategories.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (companyToInitialize.Items != null && companyToInitialize.Items.CurrentPage != null)
                {
                    companyToInitialize.Items.AdditionalData = companyToInitialize.AdditionalData;

                    object nextPageLink;
                    companyToInitialize.AdditionalData.TryGetValue("items@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        companyToInitialize.Items.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (companyToInitialize.JournalLines != null && companyToInitialize.JournalLines.CurrentPage != null)
                {
                    companyToInitialize.JournalLines.AdditionalData = companyToInitialize.AdditionalData;

                    object nextPageLink;
                    companyToInitialize.AdditionalData.TryGetValue("journalLines@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        companyToInitialize.JournalLines.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (companyToInitialize.Journals != null && companyToInitialize.Journals.CurrentPage != null)
                {
                    companyToInitialize.Journals.AdditionalData = companyToInitialize.AdditionalData;

                    object nextPageLink;
                    companyToInitialize.AdditionalData.TryGetValue("journals@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        companyToInitialize.Journals.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (companyToInitialize.PaymentMethods != null && companyToInitialize.PaymentMethods.CurrentPage != null)
                {
                    companyToInitialize.PaymentMethods.AdditionalData = companyToInitialize.AdditionalData;

                    object nextPageLink;
                    companyToInitialize.AdditionalData.TryGetValue("paymentMethods@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        companyToInitialize.PaymentMethods.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (companyToInitialize.PaymentTerms != null && companyToInitialize.PaymentTerms.CurrentPage != null)
                {
                    companyToInitialize.PaymentTerms.AdditionalData = companyToInitialize.AdditionalData;

                    object nextPageLink;
                    companyToInitialize.AdditionalData.TryGetValue("paymentTerms@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        companyToInitialize.PaymentTerms.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (companyToInitialize.Picture != null && companyToInitialize.Picture.CurrentPage != null)
                {
                    companyToInitialize.Picture.AdditionalData = companyToInitialize.AdditionalData;

                    object nextPageLink;
                    companyToInitialize.AdditionalData.TryGetValue("picture@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        companyToInitialize.Picture.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (companyToInitialize.PurchaseInvoiceLines != null && companyToInitialize.PurchaseInvoiceLines.CurrentPage != null)
                {
                    companyToInitialize.PurchaseInvoiceLines.AdditionalData = companyToInitialize.AdditionalData;

                    object nextPageLink;
                    companyToInitialize.AdditionalData.TryGetValue("purchaseInvoiceLines@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        companyToInitialize.PurchaseInvoiceLines.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (companyToInitialize.PurchaseInvoices != null && companyToInitialize.PurchaseInvoices.CurrentPage != null)
                {
                    companyToInitialize.PurchaseInvoices.AdditionalData = companyToInitialize.AdditionalData;

                    object nextPageLink;
                    companyToInitialize.AdditionalData.TryGetValue("purchaseInvoices@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        companyToInitialize.PurchaseInvoices.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (companyToInitialize.SalesCreditMemoLines != null && companyToInitialize.SalesCreditMemoLines.CurrentPage != null)
                {
                    companyToInitialize.SalesCreditMemoLines.AdditionalData = companyToInitialize.AdditionalData;

                    object nextPageLink;
                    companyToInitialize.AdditionalData.TryGetValue("salesCreditMemoLines@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        companyToInitialize.SalesCreditMemoLines.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (companyToInitialize.SalesCreditMemos != null && companyToInitialize.SalesCreditMemos.CurrentPage != null)
                {
                    companyToInitialize.SalesCreditMemos.AdditionalData = companyToInitialize.AdditionalData;

                    object nextPageLink;
                    companyToInitialize.AdditionalData.TryGetValue("salesCreditMemos@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        companyToInitialize.SalesCreditMemos.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (companyToInitialize.SalesInvoiceLines != null && companyToInitialize.SalesInvoiceLines.CurrentPage != null)
                {
                    companyToInitialize.SalesInvoiceLines.AdditionalData = companyToInitialize.AdditionalData;

                    object nextPageLink;
                    companyToInitialize.AdditionalData.TryGetValue("salesInvoiceLines@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        companyToInitialize.SalesInvoiceLines.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (companyToInitialize.SalesInvoices != null && companyToInitialize.SalesInvoices.CurrentPage != null)
                {
                    companyToInitialize.SalesInvoices.AdditionalData = companyToInitialize.AdditionalData;

                    object nextPageLink;
                    companyToInitialize.AdditionalData.TryGetValue("salesInvoices@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        companyToInitialize.SalesInvoices.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (companyToInitialize.SalesOrderLines != null && companyToInitialize.SalesOrderLines.CurrentPage != null)
                {
                    companyToInitialize.SalesOrderLines.AdditionalData = companyToInitialize.AdditionalData;

                    object nextPageLink;
                    companyToInitialize.AdditionalData.TryGetValue("salesOrderLines@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        companyToInitialize.SalesOrderLines.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (companyToInitialize.SalesOrders != null && companyToInitialize.SalesOrders.CurrentPage != null)
                {
                    companyToInitialize.SalesOrders.AdditionalData = companyToInitialize.AdditionalData;

                    object nextPageLink;
                    companyToInitialize.AdditionalData.TryGetValue("salesOrders@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        companyToInitialize.SalesOrders.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (companyToInitialize.SalesQuoteLines != null && companyToInitialize.SalesQuoteLines.CurrentPage != null)
                {
                    companyToInitialize.SalesQuoteLines.AdditionalData = companyToInitialize.AdditionalData;

                    object nextPageLink;
                    companyToInitialize.AdditionalData.TryGetValue("salesQuoteLines@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        companyToInitialize.SalesQuoteLines.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (companyToInitialize.SalesQuotes != null && companyToInitialize.SalesQuotes.CurrentPage != null)
                {
                    companyToInitialize.SalesQuotes.AdditionalData = companyToInitialize.AdditionalData;

                    object nextPageLink;
                    companyToInitialize.AdditionalData.TryGetValue("salesQuotes@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        companyToInitialize.SalesQuotes.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (companyToInitialize.ShipmentMethods != null && companyToInitialize.ShipmentMethods.CurrentPage != null)
                {
                    companyToInitialize.ShipmentMethods.AdditionalData = companyToInitialize.AdditionalData;

                    object nextPageLink;
                    companyToInitialize.AdditionalData.TryGetValue("shipmentMethods@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        companyToInitialize.ShipmentMethods.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (companyToInitialize.TaxAreas != null && companyToInitialize.TaxAreas.CurrentPage != null)
                {
                    companyToInitialize.TaxAreas.AdditionalData = companyToInitialize.AdditionalData;

                    object nextPageLink;
                    companyToInitialize.AdditionalData.TryGetValue("taxAreas@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        companyToInitialize.TaxAreas.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (companyToInitialize.TaxGroups != null && companyToInitialize.TaxGroups.CurrentPage != null)
                {
                    companyToInitialize.TaxGroups.AdditionalData = companyToInitialize.AdditionalData;

                    object nextPageLink;
                    companyToInitialize.AdditionalData.TryGetValue("taxGroups@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        companyToInitialize.TaxGroups.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (companyToInitialize.UnitsOfMeasure != null && companyToInitialize.UnitsOfMeasure.CurrentPage != null)
                {
                    companyToInitialize.UnitsOfMeasure.AdditionalData = companyToInitialize.AdditionalData;

                    object nextPageLink;
                    companyToInitialize.AdditionalData.TryGetValue("unitsOfMeasure@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        companyToInitialize.UnitsOfMeasure.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (companyToInitialize.Vendors != null && companyToInitialize.Vendors.CurrentPage != null)
                {
                    companyToInitialize.Vendors.AdditionalData = companyToInitialize.AdditionalData;

                    object nextPageLink;
                    companyToInitialize.AdditionalData.TryGetValue("vendors@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        companyToInitialize.Vendors.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
