// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Compute.Admin
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for QuotasOperations.
    /// </summary>
    public static partial class QuotasOperationsExtensions
    {
            /// <summary>
            /// Returns the requested Compute quota.
            /// </summary>
            /// <remarks>
            /// Get an existing Compute Quota.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Location of the resource.
            /// </param>
            /// <param name='quotaName'>
            /// Name of the quota.
            /// </param>
            public static Quota Get(this IQuotasOperations operations, string location, string quotaName)
            {
                return operations.GetAsync(location, quotaName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the requested Compute quota.
            /// </summary>
            /// <remarks>
            /// Get an existing Compute Quota.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Location of the resource.
            /// </param>
            /// <param name='quotaName'>
            /// Name of the quota.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Quota> GetAsync(this IQuotasOperations operations, string location, string quotaName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(location, quotaName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or Updates a Compute Quota.
            /// </summary>
            /// <remarks>
            /// Creates or Updates a Compute Quota with the provided quota parameters.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Location of the resource.
            /// </param>
            /// <param name='quotaName'>
            /// Name of the quota.
            /// </param>
            /// <param name='newQuota'>
            /// New quota to create.
            /// </param>
            public static Quota CreateOrUpdate(this IQuotasOperations operations, string location, string quotaName, Quota newQuota)
            {
                return operations.CreateOrUpdateAsync(location, quotaName, newQuota).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or Updates a Compute Quota.
            /// </summary>
            /// <remarks>
            /// Creates or Updates a Compute Quota with the provided quota parameters.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Location of the resource.
            /// </param>
            /// <param name='quotaName'>
            /// Name of the quota.
            /// </param>
            /// <param name='newQuota'>
            /// New quota to create.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Quota> CreateOrUpdateAsync(this IQuotasOperations operations, string location, string quotaName, Quota newQuota, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(location, quotaName, newQuota, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes specified Compute quota
            /// </summary>
            /// <remarks>
            /// Delete an existing Compute quota.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Location of the resource.
            /// </param>
            /// <param name='quotaName'>
            /// Name of the quota.
            /// </param>
            public static void Delete(this IQuotasOperations operations, string location, string quotaName)
            {
                operations.DeleteAsync(location, quotaName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes specified Compute quota
            /// </summary>
            /// <remarks>
            /// Delete an existing Compute quota.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Location of the resource.
            /// </param>
            /// <param name='quotaName'>
            /// Name of the quota.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IQuotasOperations operations, string location, string quotaName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(location, quotaName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Lists all Compute quotas.
            /// </summary>
            /// <remarks>
            /// Get a list of existing Compute quotas.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Location of the resource.
            /// </param>
            public static IEnumerable<Quota> List(this IQuotasOperations operations, string location)
            {
                return operations.ListAsync(location).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all Compute quotas.
            /// </summary>
            /// <remarks>
            /// Get a list of existing Compute quotas.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Location of the resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<Quota>> ListAsync(this IQuotasOperations operations, string location, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(location, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
