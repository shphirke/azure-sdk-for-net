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
using Microsoft.Azure.Insights;
using Microsoft.Azure.Insights.Models;

namespace Microsoft.Azure.Insights
{
    public static partial class UsageMetricsOperationsExtensions
    {
        /// <summary>
        /// The List operation lists the usage metrics for the resource.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Insights.IUsageMetricsOperations.
        /// </param>
        /// <param name='resourceUri'>
        /// Required. The resource identifier of the target resource to get
        /// usages for.
        /// </param>
        /// <param name='filterString'>
        /// Optional. An OData $filter expression that supports querying by the
        /// name of the usage. For example, "name.value eq 'Percentage CPU'".
        /// Name is optional, meaning the expression may be "".
        /// </param>
        /// <returns>
        /// The List Usage Metric operation response.
        /// </returns>
        public static UsageMetricListResponse List(this IUsageMetricsOperations operations, string resourceUri, string filterString)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IUsageMetricsOperations)s).ListAsync(resourceUri, filterString);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The List operation lists the usage metrics for the resource.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.Insights.IUsageMetricsOperations.
        /// </param>
        /// <param name='resourceUri'>
        /// Required. The resource identifier of the target resource to get
        /// usages for.
        /// </param>
        /// <param name='filterString'>
        /// Optional. An OData $filter expression that supports querying by the
        /// name of the usage. For example, "name.value eq 'Percentage CPU'".
        /// Name is optional, meaning the expression may be "".
        /// </param>
        /// <returns>
        /// The List Usage Metric operation response.
        /// </returns>
        public static Task<UsageMetricListResponse> ListAsync(this IUsageMetricsOperations operations, string resourceUri, string filterString)
        {
            return operations.ListAsync(resourceUri, filterString, CancellationToken.None);
        }
    }
}
