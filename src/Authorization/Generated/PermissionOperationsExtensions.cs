// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.Authorization;
using Microsoft.Azure.Management.Authorization.Models;

namespace Microsoft.Azure.Management.Authorization
{
    public static partial class PermissionOperationsExtensions
    {
        /// <summary>
        /// Gets a resource permissions.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Authorization.IPermissionOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group. The name is case
        /// insensitive.
        /// </param>
        /// <param name='identity'>
        /// Required. Resource
        /// </param>
        /// <returns>
        /// Permissions information.
        /// </returns>
        public static PermissionGetResult ListForResource(this IPermissionOperations operations, string resourceGroupName, ResourceIdentity identity)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IPermissionOperations)s).ListForResourceAsync(resourceGroupName, identity);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets a resource permissions.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Authorization.IPermissionOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group. The name is case
        /// insensitive.
        /// </param>
        /// <param name='identity'>
        /// Required. Resource
        /// </param>
        /// <returns>
        /// Permissions information.
        /// </returns>
        public static Task<PermissionGetResult> ListForResourceAsync(this IPermissionOperations operations, string resourceGroupName, ResourceIdentity identity)
        {
            return operations.ListForResourceAsync(resourceGroupName, identity, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets a resource group permissions.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Authorization.IPermissionOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. Name of the resource group to get the permissions for.The
        /// name is case insensitive.
        /// </param>
        /// <returns>
        /// Permissions information.
        /// </returns>
        public static PermissionGetResult ListForResourceGroup(this IPermissionOperations operations, string resourceGroupName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IPermissionOperations)s).ListForResourceGroupAsync(resourceGroupName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets a resource group permissions.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Authorization.IPermissionOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. Name of the resource group to get the permissions for.The
        /// name is case insensitive.
        /// </param>
        /// <returns>
        /// Permissions information.
        /// </returns>
        public static Task<PermissionGetResult> ListForResourceGroupAsync(this IPermissionOperations operations, string resourceGroupName)
        {
            return operations.ListForResourceGroupAsync(resourceGroupName, CancellationToken.None);
        }
    }
}
