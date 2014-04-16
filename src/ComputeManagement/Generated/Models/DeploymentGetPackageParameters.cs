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

namespace Microsoft.WindowsAzure.Management.Compute.Models
{
    /// <summary>
    /// Parameters supplied to the Get Package operation.
    /// </summary>
    public partial class DeploymentGetPackageParameters
    {
        private Uri _containerUri;
        
        /// <summary>
        /// Required. Specifies the URI of the container to which the packages
        /// will be saved.
        /// </summary>
        public Uri ContainerUri
        {
            get { return this._containerUri; }
            set { this._containerUri = value; }
        }
        
        private bool? _overwriteExisting;
        
        /// <summary>
        /// Optional. Specifies whether an existing package in the storage
        /// container should be overwritten.
        /// </summary>
        public bool? OverwriteExisting
        {
            get { return this._overwriteExisting; }
            set { this._overwriteExisting = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DeploymentGetPackageParameters
        /// class.
        /// </summary>
        public DeploymentGetPackageParameters()
        {
        }
    }
}