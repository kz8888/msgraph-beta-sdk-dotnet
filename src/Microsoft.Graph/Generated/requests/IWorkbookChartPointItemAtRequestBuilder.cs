// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IMethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IWorkbookChartPointItemAtRequestBuilder.
    /// </summary>
    public partial interface IWorkbookChartPointItemAtRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IWorkbookChartPointItemAtRequest Request(IEnumerable<Option> options = null);
        /// <summary>
        /// Gets the request builder for WorkbookChartPointCountRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartPointCountRequestBuilder"/>.</returns>
        IWorkbookChartPointCountRequestBuilder Count();
        /// <summary>
        /// Gets the request builder for WorkbookChartPointItemAtRequestBuilder.
        /// </summary>
        /// <param name="index">A index parameter for the OData method call.</param>
        /// <returns>The <see cref="IWorkbookChartPointItemAtRequestBuilder"/>.</returns>
        IWorkbookChartPointItemAtRequestBuilder ItemAt(
            Int32 index);
        /// <summary>
        /// Gets the request builder for Format.
        /// Encapsulates the format properties chart point. Read-only.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartPointFormatRequestBuilder"/>.</returns>
        IWorkbookChartPointFormatRequestBuilder Format  { get; }
    }
}
