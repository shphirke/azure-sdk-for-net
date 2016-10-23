// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for DatabaseTransparentDataEncryptionConfigurationsOperations.
    /// </summary>
    public static partial class DatabaseTransparentDataEncryptionConfigurationsOperationsExtensions
    {
            /// <summary>
            /// Creates or updates an Azure SQL Database Transparent Data Encryption
            /// Operation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the resource belongs.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL Server
            /// </param>
            /// <param name='databaseName'>
            /// The name of the Azure SQL Database for which setting the Transparent Data
            /// Encryption applies.
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for creating or updating transparent data
            /// encryption.
            /// </param>
            public static TransparentDataEncryption Get(this IDatabaseTransparentDataEncryptionConfigurationsOperations operations, string resourceGroupName, string serverName, string databaseName, TransparentDataEncryption parameters)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IDatabaseTransparentDataEncryptionConfigurationsOperations)s).GetAsync(resourceGroupName, serverName, databaseName, parameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates an Azure SQL Database Transparent Data Encryption
            /// Operation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the Resource Group to which the resource belongs.
            /// </param>
            /// <param name='serverName'>
            /// The name of the Azure SQL Server
            /// </param>
            /// <param name='databaseName'>
            /// The name of the Azure SQL Database for which setting the Transparent Data
            /// Encryption applies.
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for creating or updating transparent data
            /// encryption.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<TransparentDataEncryption> GetAsync(this IDatabaseTransparentDataEncryptionConfigurationsOperations operations, string resourceGroupName, string serverName, string databaseName, TransparentDataEncryption parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}