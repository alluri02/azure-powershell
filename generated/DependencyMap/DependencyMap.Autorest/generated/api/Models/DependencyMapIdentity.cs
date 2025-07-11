// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Runtime.Extensions;

    public partial class DependencyMapIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.IDependencyMapIdentity,
        Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Models.IDependencyMapIdentityInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Origin(Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="MapName" /> property.</summary>
        private string _mapName;

        /// <summary>Maps resource name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Origin(Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.PropertyOrigin.Owned)]
        public string MapName { get => this._mapName; set => this._mapName = value; }

        /// <summary>Backing field for <see cref="ResourceGroupName" /> property.</summary>
        private string _resourceGroupName;

        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Origin(Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => this._resourceGroupName; set => this._resourceGroupName = value; }

        /// <summary>Backing field for <see cref="SourceName" /> property.</summary>
        private string _sourceName;

        /// <summary>discovery source resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Origin(Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.PropertyOrigin.Owned)]
        public string SourceName { get => this._sourceName; set => this._sourceName = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>The ID of the target subscription. The value must be an UUID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Origin(Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.PropertyOrigin.Owned)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Creates an new <see cref="DependencyMapIdentity" /> instance.</summary>
        public DependencyMapIdentity()
        {

        }
    }
    public partial interface IDependencyMapIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Runtime.IJsonSerializable
    {
        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource identity path",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>Maps resource name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Maps resource name",
        SerializedName = @"mapName",
        PossibleTypes = new [] { typeof(string) })]
        string MapName { get; set; }
        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the resource group. The name is case insensitive.",
        SerializedName = @"resourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceGroupName { get; set; }
        /// <summary>discovery source resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"discovery source resource",
        SerializedName = @"sourceName",
        PossibleTypes = new [] { typeof(string) })]
        string SourceName { get; set; }
        /// <summary>The ID of the target subscription. The value must be an UUID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DependencyMap.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The ID of the target subscription. The value must be an UUID.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string SubscriptionId { get; set; }

    }
    internal partial interface IDependencyMapIdentityInternal

    {
        /// <summary>Resource identity path</summary>
        string Id { get; set; }
        /// <summary>Maps resource name</summary>
        string MapName { get; set; }
        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        string ResourceGroupName { get; set; }
        /// <summary>discovery source resource</summary>
        string SourceName { get; set; }
        /// <summary>The ID of the target subscription. The value must be an UUID.</summary>
        string SubscriptionId { get; set; }

    }
}