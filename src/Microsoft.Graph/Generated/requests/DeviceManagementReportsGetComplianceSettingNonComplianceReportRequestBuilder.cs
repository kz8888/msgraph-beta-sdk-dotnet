// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type DeviceManagementReportsGetComplianceSettingNonComplianceReportRequestBuilder.
    /// </summary>
    public partial class DeviceManagementReportsGetComplianceSettingNonComplianceReportRequestBuilder : BaseActionMethodRequestBuilder<IDeviceManagementReportsGetComplianceSettingNonComplianceReportRequest>, IDeviceManagementReportsGetComplianceSettingNonComplianceReportRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="DeviceManagementReportsGetComplianceSettingNonComplianceReportRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="name">A name parameter for the OData method call.</param>
        /// <param name="select">A select parameter for the OData method call.</param>
        /// <param name="search">A search parameter for the OData method call.</param>
        /// <param name="groupBy">A groupBy parameter for the OData method call.</param>
        /// <param name="orderBy">A orderBy parameter for the OData method call.</param>
        /// <param name="skip">A skip parameter for the OData method call.</param>
        /// <param name="top">A top parameter for the OData method call.</param>
        /// <param name="sessionId">A sessionId parameter for the OData method call.</param>
        /// <param name="filter">A filter parameter for the OData method call.</param>
        public DeviceManagementReportsGetComplianceSettingNonComplianceReportRequestBuilder(
            string requestUrl,
            IBaseClient client,
            string name,
            IEnumerable<string> select,
            string search,
            IEnumerable<string> groupBy,
            IEnumerable<string> orderBy,
            Int32? skip,
            Int32? top,
            string sessionId,
            string filter)
            : base(requestUrl, client)
        {
            this.SetParameter("name", name, true);
            this.SetParameter("select", select, true);
            this.SetParameter("search", search, true);
            this.SetParameter("groupBy", groupBy, true);
            this.SetParameter("orderBy", orderBy, true);
            this.SetParameter("skip", skip, true);
            this.SetParameter("top", top, true);
            this.SetParameter("sessionId", sessionId, true);
            this.SetParameter("filter", filter, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IDeviceManagementReportsGetComplianceSettingNonComplianceReportRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new DeviceManagementReportsGetComplianceSettingNonComplianceReportRequest(functionUrl, this.Client, options);

            if (this.HasParameter("name"))
            {
                request.RequestBody.Name = this.GetParameter<string>("name");
            }

            if (this.HasParameter("select"))
            {
                request.RequestBody.Select = this.GetParameter<IEnumerable<string>>("select");
            }

            if (this.HasParameter("search"))
            {
                request.RequestBody.Search = this.GetParameter<string>("search");
            }

            if (this.HasParameter("groupBy"))
            {
                request.RequestBody.GroupBy = this.GetParameter<IEnumerable<string>>("groupBy");
            }

            if (this.HasParameter("orderBy"))
            {
                request.RequestBody.OrderBy = this.GetParameter<IEnumerable<string>>("orderBy");
            }

            if (this.HasParameter("skip"))
            {
                request.RequestBody.Skip = this.GetParameter<Int32?>("skip");
            }

            if (this.HasParameter("top"))
            {
                request.RequestBody.Top = this.GetParameter<Int32?>("top");
            }

            if (this.HasParameter("sessionId"))
            {
                request.RequestBody.SessionId = this.GetParameter<string>("sessionId");
            }

            if (this.HasParameter("filter"))
            {
                request.RequestBody.Filter = this.GetParameter<string>("filter");
            }

            return request;
        }
    }
}
