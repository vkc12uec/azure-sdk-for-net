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
using Microsoft.Azure.Insights.Models;
using Microsoft.WindowsAzure.Common.Internals;

namespace Microsoft.Azure.Insights.Models
{
    /// <summary>
    /// The Azure event log entries are of type EventData
    /// </summary>
    public partial class EventData
    {
        private SenderAuthorization _authorization;
        
        /// <summary>
        /// Optional. Gets or sets the authorization.This is the authorization
        /// used by the user who has performed the operation that led to this
        /// event.
        /// </summary>
        public SenderAuthorization Authorization
        {
            get { return this._authorization; }
            set { this._authorization = value; }
        }
        
        private IDictionary<string, string> _claims;
        
        /// <summary>
        /// Optional. Gets or sets the claims
        /// </summary>
        public IDictionary<string, string> Claims
        {
            get { return this._claims; }
            set { this._claims = value; }
        }
        
        private string _correlationId;
        
        /// <summary>
        /// Optional. Gets or sets the correlation Id.The correlation Id is
        /// shared among the events that belong to the same deployment.
        /// </summary>
        public string CorrelationId
        {
            get { return this._correlationId; }
            set { this._correlationId = value; }
        }
        
        private string _description;
        
        /// <summary>
        /// Optional. Gets or sets the description of the event.
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }
        
        private EventChannels _eventChannels;
        
        /// <summary>
        /// Optional. Gets or sets the event channels.The regular event logs,
        /// that you see in the Azure Management Portals, flow through the
        /// 'Operation' channel.
        /// </summary>
        public EventChannels EventChannels
        {
            get { return this._eventChannels; }
            set { this._eventChannels = value; }
        }
        
        private string _eventDataId;
        
        /// <summary>
        /// Optional. Gets or sets the event data Id.This is a unique
        /// identifier for an event.
        /// </summary>
        public string EventDataId
        {
            get { return this._eventDataId; }
            set { this._eventDataId = value; }
        }
        
        private LocalizableString _eventName;
        
        /// <summary>
        /// Optional. Gets or sets the event name.This value should not be
        /// confused with OperationName.For practical purposes, OperationName
        /// might be more appealing to end users.
        /// </summary>
        public LocalizableString EventName
        {
            get { return this._eventName; }
            set { this._eventName = value; }
        }
        
        private LocalizableString _eventSource;
        
        /// <summary>
        /// Optional. Gets or sets the event source.This value indicates the
        /// source that generated the event.
        /// </summary>
        public LocalizableString EventSource
        {
            get { return this._eventSource; }
            set { this._eventSource = value; }
        }
        
        private DateTime _eventTimestamp;
        
        /// <summary>
        /// Optional. Gets or sets the occurrence time of event
        /// </summary>
        public DateTime EventTimestamp
        {
            get { return this._eventTimestamp; }
            set { this._eventTimestamp = value; }
        }
        
        private HttpRequestInfo _httpRequest;
        
        /// <summary>
        /// Optional. Gets or sets the HTTP request info.The client IP address
        /// of the user who initiated the event is captured as part of the
        /// HTTP request info.
        /// </summary>
        public HttpRequestInfo HttpRequest
        {
            get { return this._httpRequest; }
            set { this._httpRequest = value; }
        }
        
        private EventLevel _level;
        
        /// <summary>
        /// Optional. Gets or sets the event level
        /// </summary>
        public EventLevel Level
        {
            get { return this._level; }
            set { this._level = value; }
        }
        
        private string _operationId;
        
        /// <summary>
        /// Optional. Gets or sets the operation idThis value should not be
        /// confused with EventName.
        /// </summary>
        public string OperationId
        {
            get { return this._operationId; }
            set { this._operationId = value; }
        }
        
        private LocalizableString _operationName;
        
        /// <summary>
        /// Optional. Gets or sets the operation name.
        /// </summary>
        public LocalizableString OperationName
        {
            get { return this._operationName; }
            set { this._operationName = value; }
        }
        
        private IDictionary<string, string> _properties;
        
        /// <summary>
        /// Optional. Gets or sets the property bag
        /// </summary>
        public IDictionary<string, string> Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }
        
        private string _resourceGroupName;
        
        /// <summary>
        /// Optional. Gets or sets the resource group name.  (see
        /// http://msdn.microsoft.com/en-us/library/azure/dn790546.aspx for
        /// more information)
        /// </summary>
        public string ResourceGroupName
        {
            get { return this._resourceGroupName; }
            set { this._resourceGroupName = value; }
        }
        
        private LocalizableString _resourceProviderName;
        
        /// <summary>
        /// Optional. Gets or sets the resource provider name.  (see
        /// http://msdn.microsoft.com/en-us/library/azure/dn790572.aspx for
        /// more information)
        /// </summary>
        public LocalizableString ResourceProviderName
        {
            get { return this._resourceProviderName; }
            set { this._resourceProviderName = value; }
        }
        
        private string _resourceUri;
        
        /// <summary>
        /// Optional. Gets or sets the resource uri  (see
        /// http://msdn.microsoft.com/en-us/library/azure/dn790569.aspx for
        /// more information)
        /// </summary>
        public string ResourceUri
        {
            get { return this._resourceUri; }
            set { this._resourceUri = value; }
        }
        
        private LocalizableString _status;
        
        /// <summary>
        /// Optional. Gets or sets the event status.Some typical values are:
        /// Started, Succeeded, Failed
        /// </summary>
        public LocalizableString Status
        {
            get { return this._status; }
            set { this._status = value; }
        }
        
        private DateTime _submissionTimestamp;
        
        /// <summary>
        /// Optional. Gets or sets the event submission time.This value should
        /// not be confused eventTimestamp. As there might be a delay between
        /// the occurence time of the event, and the time that the event is
        /// submitted to the Azure logging infrastructure.
        /// </summary>
        public DateTime SubmissionTimestamp
        {
            get { return this._submissionTimestamp; }
            set { this._submissionTimestamp = value; }
        }
        
        private string _subscriptionId;
        
        /// <summary>
        /// Optional. Gets or sets the Azure subscription Id
        /// </summary>
        public string SubscriptionId
        {
            get { return this._subscriptionId; }
            set { this._subscriptionId = value; }
        }
        
        private LocalizableString _subStatus;
        
        /// <summary>
        /// Optional. Gets or sets the event sub status.Most of the time, when
        /// included, this captures the HTTP status code.
        /// </summary>
        public LocalizableString SubStatus
        {
            get { return this._subStatus; }
            set { this._subStatus = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the EventData class.
        /// </summary>
        public EventData()
        {
            this.Claims = new LazyDictionary<string, string>();
            this.Properties = new LazyDictionary<string, string>();
        }
    }
}
