// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.ServiceFabric.Common
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Service Deleted event.
    /// </summary>
    public partial class ServiceDeletedEvent : ServiceEvent
    {
        /// <summary>
        /// Initializes a new instance of the ServiceDeletedEvent class.
        /// </summary>
        /// <param name="eventInstanceId">The identifier for the FabricEvent instance.</param>
        /// <param name="timeStamp">The time event was logged.</param>
        /// <param name="serviceId">The identity of the service. This is an encoded representation of the service name. This is
        /// used in the REST APIs to identify the service resource.
        /// Starting in version 6.0, hierarchical names are delimited with the "\~" character. For example, if the service name
        /// is "fabric:/myapp/app1/svc1",
        /// the service identity would be "myapp~app1\~svc1" in 6.0+ and "myapp/app1/svc1" in previous versions.
        /// </param>
        /// <param name="serviceTypeName">Service type name.</param>
        /// <param name="applicationName">Application name.</param>
        /// <param name="applicationTypeName">Application type name.</param>
        /// <param name="serviceInstance">Id of Service instance.</param>
        /// <param name="isStateful">Indicates if Service is stateful.</param>
        /// <param name="partitionCount">Number of partitions.</param>
        /// <param name="targetReplicaSetSize">Size of target replicas set.</param>
        /// <param name="minReplicaSetSize">Minimum size of replicas set.</param>
        /// <param name="servicePackageVersion">Version of Service package.</param>
        /// <param name="hasCorrelatedEvents">Shows there is existing related events available.</param>
        public ServiceDeletedEvent(
            Guid? eventInstanceId,
            DateTime? timeStamp,
            string serviceId,
            string serviceTypeName,
            string applicationName,
            string applicationTypeName,
            long? serviceInstance,
            bool? isStateful,
            int? partitionCount,
            int? targetReplicaSetSize,
            int? minReplicaSetSize,
            string servicePackageVersion,
            bool? hasCorrelatedEvents = default(bool?))
            : base(
                eventInstanceId,
                timeStamp,
                Common.FabricEventKind.ServiceDeleted,
                serviceId,
                hasCorrelatedEvents)
        {
            serviceTypeName.ThrowIfNull(nameof(serviceTypeName));
            applicationName.ThrowIfNull(nameof(applicationName));
            applicationTypeName.ThrowIfNull(nameof(applicationTypeName));
            serviceInstance.ThrowIfNull(nameof(serviceInstance));
            isStateful.ThrowIfNull(nameof(isStateful));
            partitionCount.ThrowIfNull(nameof(partitionCount));
            targetReplicaSetSize.ThrowIfNull(nameof(targetReplicaSetSize));
            minReplicaSetSize.ThrowIfNull(nameof(minReplicaSetSize));
            servicePackageVersion.ThrowIfNull(nameof(servicePackageVersion));
            this.ServiceTypeName = serviceTypeName;
            this.ApplicationName = applicationName;
            this.ApplicationTypeName = applicationTypeName;
            this.ServiceInstance = serviceInstance;
            this.IsStateful = isStateful;
            this.PartitionCount = partitionCount;
            this.TargetReplicaSetSize = targetReplicaSetSize;
            this.MinReplicaSetSize = minReplicaSetSize;
            this.ServicePackageVersion = servicePackageVersion;
        }

        /// <summary>
        /// Gets service type name.
        /// </summary>
        public string ServiceTypeName { get; }

        /// <summary>
        /// Gets application name.
        /// </summary>
        public string ApplicationName { get; }

        /// <summary>
        /// Gets application type name.
        /// </summary>
        public string ApplicationTypeName { get; }

        /// <summary>
        /// Gets id of Service instance.
        /// </summary>
        public long? ServiceInstance { get; }

        /// <summary>
        /// Gets indicates if Service is stateful.
        /// </summary>
        public bool? IsStateful { get; }

        /// <summary>
        /// Gets number of partitions.
        /// </summary>
        public int? PartitionCount { get; }

        /// <summary>
        /// Gets size of target replicas set.
        /// </summary>
        public int? TargetReplicaSetSize { get; }

        /// <summary>
        /// Gets minimum size of replicas set.
        /// </summary>
        public int? MinReplicaSetSize { get; }

        /// <summary>
        /// Gets version of Service package.
        /// </summary>
        public string ServicePackageVersion { get; }
    }
}
