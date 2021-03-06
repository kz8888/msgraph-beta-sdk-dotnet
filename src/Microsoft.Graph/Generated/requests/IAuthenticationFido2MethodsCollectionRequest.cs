// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IAuthenticationFido2MethodsCollectionRequest.
    /// </summary>
    public partial interface IAuthenticationFido2MethodsCollectionRequest : IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified Fido2AuthenticationMethod to the collection via POST.
        /// </summary>
        /// <param name="fido2AuthenticationMethod">The Fido2AuthenticationMethod to add.</param>
        /// <returns>The created Fido2AuthenticationMethod.</returns>
        System.Threading.Tasks.Task<Fido2AuthenticationMethod> AddAsync(Fido2AuthenticationMethod fido2AuthenticationMethod);

        /// <summary>
        /// Adds the specified Fido2AuthenticationMethod to the collection via POST.
        /// </summary>
        /// <param name="fido2AuthenticationMethod">The Fido2AuthenticationMethod to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Fido2AuthenticationMethod.</returns>
        System.Threading.Tasks.Task<Fido2AuthenticationMethod> AddAsync(Fido2AuthenticationMethod fido2AuthenticationMethod, CancellationToken cancellationToken);
        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IAuthenticationFido2MethodsCollectionPage> GetAsync();

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IAuthenticationFido2MethodsCollectionPage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAuthenticationFido2MethodsCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAuthenticationFido2MethodsCollectionRequest Expand(Expression<Func<Fido2AuthenticationMethod, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAuthenticationFido2MethodsCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAuthenticationFido2MethodsCollectionRequest Select(Expression<Func<Fido2AuthenticationMethod, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IAuthenticationFido2MethodsCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IAuthenticationFido2MethodsCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IAuthenticationFido2MethodsCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IAuthenticationFido2MethodsCollectionRequest OrderBy(string value);
    }
}
