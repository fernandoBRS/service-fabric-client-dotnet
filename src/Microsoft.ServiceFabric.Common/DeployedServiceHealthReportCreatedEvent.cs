// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.ServiceFabric.Common
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Deployed Service Health Report Created event.
    /// </summary>
    public partial class DeployedServiceHealthReportCreatedEvent : ApplicationEvent
    {
        /// <summary>
        /// Initializes a new instance of the DeployedServiceHealthReportCreatedEvent class.
        /// </summary>
        /// <param name="eventInstanceId">The identifier for the FabricEvent instance.</param>
        /// <param name="timeStamp">The time event was logged.</param>
        /// <param name="applicationId">The identity of the application. This is an encoded representation of the application
        /// name. This is used in the REST APIs to identify the application resource.
        /// Starting in version 6.0, hierarchical names are delimited with the "\~" character. For example, if the application
        /// name is "fabric:/myapp/app1",
        /// the application identity would be "myapp\~app1" in 6.0+ and "myapp/app1" in previous versions.
        /// </param>
        /// <param name="serviceManifestName">Service manifest name.</param>
        /// <param name="servicePackageInstanceId">Id of Service package instance.</param>
        /// <param name="servicePackageActivationId">Id of Service package activation.</param>
        /// <param name="nodeName">The name of a Service Fabric node.</param>
        /// <param name="sourceId">Id of report source.</param>
        /// <param name="property">Describes the property.</param>
        /// <param name="healthState">Describes the property health state.</param>
        /// <param name="tTLTimespan">Time to live in milli-seconds.</param>
        /// <param name="sequenceNumber">Sequence number of report.</param>
        /// <param name="description">Description of report.</param>
        /// <param name="removeWhenExpired">Indicates the removal when it expires.</param>
        /// <param name="sourceUtcTimestamp">Source time.</param>
        /// <param name="hasCorrelatedEvents">Shows there is existing related events available.</param>
        public DeployedServiceHealthReportCreatedEvent(
            Guid? eventInstanceId,
            DateTime? timeStamp,
            string applicationId,
            string serviceManifestName,
            long? servicePackageInstanceId,
            string servicePackageActivationId,
            NodeName nodeName,
            string sourceId,
            string property,
            string healthState,
            long? tTLTimespan,
            long? sequenceNumber,
            string description,
            bool? removeWhenExpired,
            DateTime? sourceUtcTimestamp,
            bool? hasCorrelatedEvents = default(bool?))
            : base(
                eventInstanceId,
                timeStamp,
                Common.FabricEventKind.DeployedServiceHealthReportCreated,
                applicationId,
                hasCorrelatedEvents)
        {
            serviceManifestName.ThrowIfNull(nameof(serviceManifestName));
            servicePackageInstanceId.ThrowIfNull(nameof(servicePackageInstanceId));
            servicePackageActivationId.ThrowIfNull(nameof(servicePackageActivationId));
            nodeName.ThrowIfNull(nameof(nodeName));
            sourceId.ThrowIfNull(nameof(sourceId));
            property.ThrowIfNull(nameof(property));
            healthState.ThrowIfNull(nameof(healthState));
            tTLTimespan.ThrowIfNull(nameof(tTLTimespan));
            sequenceNumber.ThrowIfNull(nameof(sequenceNumber));
            description.ThrowIfNull(nameof(description));
            removeWhenExpired.ThrowIfNull(nameof(removeWhenExpired));
            sourceUtcTimestamp.ThrowIfNull(nameof(sourceUtcTimestamp));
            this.ServiceManifestName = serviceManifestName;
            this.ServicePackageInstanceId = servicePackageInstanceId;
            this.ServicePackageActivationId = servicePackageActivationId;
            this.NodeName = nodeName;
            this.SourceId = sourceId;
            this.Property = property;
            this.HealthState = healthState;
            this.TTLTimespan = tTLTimespan;
            this.SequenceNumber = sequenceNumber;
            this.Description = description;
            this.RemoveWhenExpired = removeWhenExpired;
            this.SourceUtcTimestamp = sourceUtcTimestamp;
        }

        /// <summary>
        /// Gets service manifest name.
        /// </summary>
        public string ServiceManifestName { get; }

        /// <summary>
        /// Gets id of Service package instance.
        /// </summary>
        public long? ServicePackageInstanceId { get; }

        /// <summary>
        /// Gets id of Service package activation.
        /// </summary>
        public string ServicePackageActivationId { get; }

        /// <summary>
        /// Gets the name of a Service Fabric node.
        /// </summary>
        public NodeName NodeName { get; }

        /// <summary>
        /// Gets id of report source.
        /// </summary>
        public string SourceId { get; }

        /// <summary>
        /// Gets describes the property.
        /// </summary>
        public string Property { get; }

        /// <summary>
        /// Gets describes the property health state.
        /// </summary>
        public string HealthState { get; }

        /// <summary>
        /// Gets time to live in milli-seconds.
        /// </summary>
        public long? TTLTimespan { get; }

        /// <summary>
        /// Gets sequence number of report.
        /// </summary>
        public long? SequenceNumber { get; }

        /// <summary>
        /// Gets description of report.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// Gets indicates the removal when it expires.
        /// </summary>
        public bool? RemoveWhenExpired { get; }

        /// <summary>
        /// Gets source time.
        /// </summary>
        public DateTime? SourceUtcTimestamp { get; }
    }
}
