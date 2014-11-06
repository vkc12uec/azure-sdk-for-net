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
using Microsoft.Azure.Management.WebSites.Models;
using Microsoft.WindowsAzure.Common.Internals;

namespace Microsoft.Azure.Management.WebSites.Models
{
    /// <summary>
    /// Historical metric snapshot data for the web site.
    /// </summary>
    public partial class HistoricalUsageMetricData
    {
        private string _displayName;
        
        /// <summary>
        /// Optional. The display name of the metric, including spaces.
        /// </summary>
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }
        
        private DateTime _endTime;
        
        /// <summary>
        /// Optional. The end time of the data reported.
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional. The name of the metric.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private string _primaryAggregationType;
        
        /// <summary>
        /// Optional. The primary data aggregation type. This value is usually
        /// Total.
        /// </summary>
        public string PrimaryAggregationType
        {
            get { return this._primaryAggregationType; }
            set { this._primaryAggregationType = value; }
        }
        
        private DateTime _startTime;
        
        /// <summary>
        /// Optional. The start time of the data reported.
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }
        
        private string _timeGrain;
        
        /// <summary>
        /// Optional. Length of time (rollup) during which the information was
        /// gathered. For more information, see Supported Rollups.
        /// </summary>
        public string TimeGrain
        {
            get { return this._timeGrain; }
            set { this._timeGrain = value; }
        }
        
        private string _unit;
        
        /// <summary>
        /// Optional. The unit of measurement for the metric (for example,
        /// milliseconds, bytes, or count).
        /// </summary>
        public string Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }
        
        private IList<HistoricalUsageMetricSample> _values;
        
        /// <summary>
        /// Optional. One or more MetricSample elements.
        /// </summary>
        public IList<HistoricalUsageMetricSample> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the HistoricalUsageMetricData class.
        /// </summary>
        public HistoricalUsageMetricData()
        {
            this.Values = new LazyList<HistoricalUsageMetricSample>();
        }
    }
}
