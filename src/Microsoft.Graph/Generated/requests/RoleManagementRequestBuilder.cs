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
    /// The type RoleManagementRequestBuilder.
    /// </summary>
    public partial class RoleManagementRequestBuilder : EntityRequestBuilder, IRoleManagementRequestBuilder
    {

        /// <summary>
        /// Constructs a new RoleManagementRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public RoleManagementRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IRoleManagementRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IRoleManagementRequest Request(IEnumerable<Option> options)
        {
            return new RoleManagementRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Directory.
        /// </summary>
        /// <returns>The <see cref="IRbacApplicationRequestBuilder"/>.</returns>
        public IRbacApplicationRequestBuilder Directory
        {
            get
            {
                return new RbacApplicationRequestBuilder(this.AppendSegmentToRequestUrl("directory"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for DeviceManagement.
        /// </summary>
        /// <returns>The <see cref="IRbacApplicationMultipleRequestBuilder"/>.</returns>
        public IRbacApplicationMultipleRequestBuilder DeviceManagement
        {
            get
            {
                return new RbacApplicationMultipleRequestBuilder(this.AppendSegmentToRequestUrl("deviceManagement"), this.Client);
            }
        }
    
    }
}