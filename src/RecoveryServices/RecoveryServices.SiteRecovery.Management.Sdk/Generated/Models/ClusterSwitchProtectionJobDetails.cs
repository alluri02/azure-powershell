// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using System.Linq;

    /// <summary>
    /// This class represents details for switch cluster protection job.
    /// </summary>
    [Newtonsoft.Json.JsonObject("ClusterSwitchProtectionJobDetails")]
    public partial class ClusterSwitchProtectionJobDetails : JobDetails
    {
        /// <summary>
        /// Initializes a new instance of the ClusterSwitchProtectionJobDetails class.
        /// </summary>
        public ClusterSwitchProtectionJobDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ClusterSwitchProtectionJobDetails class.
        /// </summary>

        /// <param name="affectedObjectDetails">The affected object properties like source server, source cloud, target
        /// server, target cloud etc. based on the workflow object details.
        /// </param>

        /// <param name="newReplicationProtectionClusterId">ARM Id of the new replication protection cluster.
        /// </param>
        public ClusterSwitchProtectionJobDetails(System.Collections.Generic.IDictionary<string, string> affectedObjectDetails = default(System.Collections.Generic.IDictionary<string, string>), string newReplicationProtectionClusterId = default(string))

        : base(affectedObjectDetails)
        {
            this.NewReplicationProtectionClusterId = newReplicationProtectionClusterId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets aRM Id of the new replication protection cluster.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "newReplicationProtectionClusterId")]
        public string NewReplicationProtectionClusterId {get; set; }
    }
}