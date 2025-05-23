// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for ReplicationVaultHealthOperations
    /// </summary>
    public static partial class ReplicationVaultHealthOperationsExtensions
    {
        /// <summary>
        /// Gets the health details of the vault.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the recovery services vault.
        /// </param>
        public static VaultHealthDetails Get(this IReplicationVaultHealthOperations operations, string resourceGroupName, string resourceName)
        {
                return ((IReplicationVaultHealthOperations)operations).GetAsync(resourceGroupName, resourceName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets the health details of the vault.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<VaultHealthDetails> GetAsync(this IReplicationVaultHealthOperations operations, string resourceGroupName, string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Refreshes health summary of the vault.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the recovery services vault.
        /// </param>
        public static VaultHealthDetails Refresh(this IReplicationVaultHealthOperations operations, string resourceGroupName, string resourceName)
        {
                return ((IReplicationVaultHealthOperations)operations).RefreshAsync(resourceGroupName, resourceName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Refreshes health summary of the vault.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<VaultHealthDetails> RefreshAsync(this IReplicationVaultHealthOperations operations, string resourceGroupName, string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.RefreshWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Refreshes health summary of the vault.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the recovery services vault.
        /// </param>
        public static VaultHealthDetails BeginRefresh(this IReplicationVaultHealthOperations operations, string resourceGroupName, string resourceName)
        {
                return ((IReplicationVaultHealthOperations)operations).BeginRefreshAsync(resourceGroupName, resourceName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Refreshes health summary of the vault.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<VaultHealthDetails> BeginRefreshAsync(this IReplicationVaultHealthOperations operations, string resourceGroupName, string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.BeginRefreshWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
