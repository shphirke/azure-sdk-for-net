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
using System.Collections.Generic;
using System.Linq;
using Microsoft.WindowsAzure.Common.Internals;

namespace Microsoft.Azure.Management.Authorization.Models
{
    /// <summary>
    /// Role definition permissions.
    /// </summary>
    public partial class Permission
    {
        private IList<string> _actions;
        
        /// <summary>
        /// Optional. Role definition allowed actions.
        /// </summary>
        public IList<string> Actions
        {
            get { return this._actions; }
            set { this._actions = value; }
        }
        
        private IList<string> _notActions;
        
        /// <summary>
        /// Optional. Role definition denied actions.
        /// </summary>
        public IList<string> NotActions
        {
            get { return this._notActions; }
            set { this._notActions = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Permission class.
        /// </summary>
        public Permission()
        {
            this.Actions = new LazyList<string>();
            this.NotActions = new LazyList<string>();
        }
    }
}
