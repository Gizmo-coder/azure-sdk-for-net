// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Details of UnprepareNetworkPolicies for Subnet. </summary>
    public partial class UnprepareNetworkPoliciesRequest
    {
        /// <summary> Initializes a new instance of UnprepareNetworkPoliciesRequest. </summary>
        public UnprepareNetworkPoliciesRequest()
        {
        }

        /// <summary> Initializes a new instance of UnprepareNetworkPoliciesRequest. </summary>
        /// <param name="serviceName"> The name of the service for which subnet is being unprepared for. </param>
        internal UnprepareNetworkPoliciesRequest(string serviceName)
        {
            ServiceName = serviceName;
        }

        /// <summary> The name of the service for which subnet is being unprepared for. </summary>
        public string ServiceName { get; set; }
    }
}
