// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface ITimeCardRequestBuilder.
    /// </summary>
    public partial interface ITimeCardRequestBuilder : IChangeTrackedEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new ITimeCardRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new ITimeCardRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for TimeCardClockOut.
        /// </summary>
        /// <returns>The <see cref="ITimeCardClockOutRequestBuilder"/>.</returns>
        ITimeCardClockOutRequestBuilder ClockOut(
            bool? atApprovedLocation = null,
            ItemBody notes = null);

        /// <summary>
        /// Gets the request builder for TimeCardConfirm.
        /// </summary>
        /// <returns>The <see cref="ITimeCardConfirmRequestBuilder"/>.</returns>
        ITimeCardConfirmRequestBuilder Confirm();

        /// <summary>
        /// Gets the request builder for TimeCardEndBreak.
        /// </summary>
        /// <returns>The <see cref="ITimeCardEndBreakRequestBuilder"/>.</returns>
        ITimeCardEndBreakRequestBuilder EndBreak(
            bool? atApprovedLocation = null,
            ItemBody notes = null);

        /// <summary>
        /// Gets the request builder for TimeCardStartBreak.
        /// </summary>
        /// <returns>The <see cref="ITimeCardStartBreakRequestBuilder"/>.</returns>
        ITimeCardStartBreakRequestBuilder StartBreak(
            bool? atApprovedLocation = null,
            ItemBody notes = null);
    
    }
}