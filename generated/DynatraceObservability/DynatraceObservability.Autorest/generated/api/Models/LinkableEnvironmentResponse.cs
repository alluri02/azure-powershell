// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Runtime.Extensions;

    /// <summary>Response for getting all the linkable environments</summary>
    public partial class LinkableEnvironmentResponse :
        Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.ILinkableEnvironmentResponse,
        Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.ILinkableEnvironmentResponseInternal
    {

        /// <summary>Backing field for <see cref="EnvironmentId" /> property.</summary>
        private string _environmentId;

        /// <summary>environment id for which user is an admin</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Origin(Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.PropertyOrigin.Owned)]
        public string EnvironmentId { get => this._environmentId; set => this._environmentId = value; }

        /// <summary>Backing field for <see cref="EnvironmentName" /> property.</summary>
        private string _environmentName;

        /// <summary>Name of the environment</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Origin(Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.PropertyOrigin.Owned)]
        public string EnvironmentName { get => this._environmentName; set => this._environmentName = value; }

        /// <summary>Internal Acessors for PlanData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IPlanData Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.ILinkableEnvironmentResponseInternal.PlanData { get => (this._planData = this._planData ?? new Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.PlanData()); set { {_planData = value;} } }

        /// <summary>Backing field for <see cref="PlanData" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IPlanData _planData;

        /// <summary>Billing plan information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Origin(Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IPlanData PlanData { get => (this._planData = this._planData ?? new Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.PlanData()); set => this._planData = value; }

        /// <summary>different billing cycles like MONTHLY/WEEKLY. this could be enum</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Origin(Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.PropertyOrigin.Inlined)]
        public string PlanDataBillingCycle { get => ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IPlanDataInternal)PlanData).BillingCycle; set => ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IPlanDataInternal)PlanData).BillingCycle = value ?? null; }

        /// <summary>date when plan was applied</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Origin(Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.PropertyOrigin.Inlined)]
        public global::System.DateTime? PlanDataEffectiveDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IPlanDataInternal)PlanData).EffectiveDate; set => ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IPlanDataInternal)PlanData).EffectiveDate = value ?? default(global::System.DateTime); }

        /// <summary>plan id as published by Dynatrace</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Origin(Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.PropertyOrigin.Inlined)]
        public string PlanDataPlanDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IPlanDataInternal)PlanData).PlanDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IPlanDataInternal)PlanData).PlanDetail = value ?? null; }

        /// <summary>different usage type like PAYG/COMMITTED. this could be enum</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Origin(Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.PropertyOrigin.Inlined)]
        public string PlanDataUsageType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IPlanDataInternal)PlanData).UsageType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IPlanDataInternal)PlanData).UsageType = value ?? null; }

        /// <summary>Creates an new <see cref="LinkableEnvironmentResponse" /> instance.</summary>
        public LinkableEnvironmentResponse()
        {

        }
    }
    /// Response for getting all the linkable environments
    public partial interface ILinkableEnvironmentResponse :
        Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Runtime.IJsonSerializable
    {
        /// <summary>environment id for which user is an admin</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"environment id for which user is an admin",
        SerializedName = @"environmentId",
        PossibleTypes = new [] { typeof(string) })]
        string EnvironmentId { get; set; }
        /// <summary>Name of the environment</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of the environment",
        SerializedName = @"environmentName",
        PossibleTypes = new [] { typeof(string) })]
        string EnvironmentName { get; set; }
        /// <summary>different billing cycles like MONTHLY/WEEKLY. this could be enum</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"different billing cycles like MONTHLY/WEEKLY. this could be enum",
        SerializedName = @"billingCycle",
        PossibleTypes = new [] { typeof(string) })]
        string PlanDataBillingCycle { get; set; }
        /// <summary>date when plan was applied</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"date when plan was applied",
        SerializedName = @"effectiveDate",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? PlanDataEffectiveDate { get; set; }
        /// <summary>plan id as published by Dynatrace</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"plan id as published by Dynatrace",
        SerializedName = @"planDetails",
        PossibleTypes = new [] { typeof(string) })]
        string PlanDataPlanDetail { get; set; }
        /// <summary>different usage type like PAYG/COMMITTED. this could be enum</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"different usage type like PAYG/COMMITTED. this could be enum",
        SerializedName = @"usageType",
        PossibleTypes = new [] { typeof(string) })]
        string PlanDataUsageType { get; set; }

    }
    /// Response for getting all the linkable environments
    internal partial interface ILinkableEnvironmentResponseInternal

    {
        /// <summary>environment id for which user is an admin</summary>
        string EnvironmentId { get; set; }
        /// <summary>Name of the environment</summary>
        string EnvironmentName { get; set; }
        /// <summary>Billing plan information.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IPlanData PlanData { get; set; }
        /// <summary>different billing cycles like MONTHLY/WEEKLY. this could be enum</summary>
        string PlanDataBillingCycle { get; set; }
        /// <summary>date when plan was applied</summary>
        global::System.DateTime? PlanDataEffectiveDate { get; set; }
        /// <summary>plan id as published by Dynatrace</summary>
        string PlanDataPlanDetail { get; set; }
        /// <summary>different usage type like PAYG/COMMITTED. this could be enum</summary>
        string PlanDataUsageType { get; set; }

    }
}