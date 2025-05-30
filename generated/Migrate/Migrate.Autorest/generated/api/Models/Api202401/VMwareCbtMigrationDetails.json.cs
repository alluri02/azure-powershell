// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>VMwareCbt provider specific settings.</summary>
    public partial class VMwareCbtMigrationDetails
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IVMwareCbtMigrationDetails.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IVMwareCbtMigrationDetails.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IVMwareCbtMigrationDetails FromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject json ? new VMwareCbtMigrationDetails(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="VMwareCbtMigrationDetails" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="VMwareCbtMigrationDetails" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            __migrationProviderSpecificSettings?.ToJson(container, serializationMode);
            AddIf( null != this._targetVMSecurityProfile ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) this._targetVMSecurityProfile.ToJson(null,serializationMode) : null, "targetVmSecurityProfile" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._gatewayOperationDetail ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) this._gatewayOperationDetail.ToJson(null,serializationMode) : null, "gatewayOperationDetails" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._vmwareMachineId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._vmwareMachineId.ToString()) : null, "vmwareMachineId" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._oSType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._oSType.ToString()) : null, "osType" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._oSName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._oSName.ToString()) : null, "osName" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._firmwareType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._firmwareType.ToString()) : null, "firmwareType" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._targetGeneration)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._targetGeneration.ToString()) : null, "targetGeneration" ,container.Add );
            }
            AddIf( null != (((object)this._licenseType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._licenseType.ToString()) : null, "licenseType" ,container.Add );
            AddIf( null != (((object)this._sqlServerLicenseType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._sqlServerLicenseType.ToString()) : null, "sqlServerLicenseType" ,container.Add );
            AddIf( null != (((object)this._linuxLicenseType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._linuxLicenseType.ToString()) : null, "linuxLicenseType" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._dataMoverRunAsAccountId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._dataMoverRunAsAccountId.ToString()) : null, "dataMoverRunAsAccountId" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._snapshotRunAsAccountId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._snapshotRunAsAccountId.ToString()) : null, "snapshotRunAsAccountId" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._storageAccountId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._storageAccountId.ToString()) : null, "storageAccountId" ,container.Add );
            }
            AddIf( null != (((object)this._targetVMName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._targetVMName.ToString()) : null, "targetVmName" ,container.Add );
            AddIf( null != (((object)this._targetVMSize)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._targetVMSize.ToString()) : null, "targetVmSize" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._targetLocation)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._targetLocation.ToString()) : null, "targetLocation" ,container.Add );
            }
            AddIf( null != (((object)this._targetResourceGroupId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._targetResourceGroupId.ToString()) : null, "targetResourceGroupId" ,container.Add );
            AddIf( null != (((object)this._targetAvailabilitySetId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._targetAvailabilitySetId.ToString()) : null, "targetAvailabilitySetId" ,container.Add );
            AddIf( null != (((object)this._targetAvailabilityZone)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._targetAvailabilityZone.ToString()) : null, "targetAvailabilityZone" ,container.Add );
            AddIf( null != (((object)this._targetProximityPlacementGroupId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._targetProximityPlacementGroupId.ToString()) : null, "targetProximityPlacementGroupId" ,container.Add );
            AddIf( null != (((object)this._confidentialVMKeyVaultId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._confidentialVMKeyVaultId.ToString()) : null, "confidentialVmKeyVaultId" ,container.Add );
            AddIf( null != (((object)this._targetBootDiagnosticsStorageAccountId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._targetBootDiagnosticsStorageAccountId.ToString()) : null, "targetBootDiagnosticsStorageAccountId" ,container.Add );
            AddIf( null != this._targetVMTag ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) this._targetVMTag.ToJson(null,serializationMode) : null, "targetVmTags" ,container.Add );
            if (null != this._protectedDisk)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.XNodeArray();
                foreach( var __x in this._protectedDisk )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("protectedDisks",__w);
            }
            AddIf( null != (((object)this._targetNetworkId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._targetNetworkId.ToString()) : null, "targetNetworkId" ,container.Add );
            AddIf( null != (((object)this._testNetworkId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._testNetworkId.ToString()) : null, "testNetworkId" ,container.Add );
            if (null != this._vMNic)
            {
                var __r = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.XNodeArray();
                foreach( var __s in this._vMNic )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("vmNics",__r);
            }
            AddIf( null != this._targetNicTag ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) this._targetNicTag.ToJson(null,serializationMode) : null, "targetNicTags" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._migrationRecoveryPointId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._migrationRecoveryPointId.ToString()) : null, "migrationRecoveryPointId" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._lastRecoveryPointReceived ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._lastRecoveryPointReceived?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "lastRecoveryPointReceived" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._lastRecoveryPointId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._lastRecoveryPointId.ToString()) : null, "lastRecoveryPointId" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._initialSeedingProgressPercentage ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNumber((int)this._initialSeedingProgressPercentage) : null, "initialSeedingProgressPercentage" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._migrationProgressPercentage ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNumber((int)this._migrationProgressPercentage) : null, "migrationProgressPercentage" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._resyncProgressPercentage ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNumber((int)this._resyncProgressPercentage) : null, "resyncProgressPercentage" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._resumeProgressPercentage ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNumber((int)this._resumeProgressPercentage) : null, "resumeProgressPercentage" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._deltaSyncProgressPercentage ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNumber((int)this._deltaSyncProgressPercentage) : null, "deltaSyncProgressPercentage" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._isCheckSumResyncCycle)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._isCheckSumResyncCycle.ToString()) : null, "isCheckSumResyncCycle" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._initialSeedingRetryCount ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNumber((long)this._initialSeedingRetryCount) : null, "initialSeedingRetryCount" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._resyncRetryCount ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNumber((long)this._resyncRetryCount) : null, "resyncRetryCount" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._resumeRetryCount ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNumber((long)this._resumeRetryCount) : null, "resumeRetryCount" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._deltaSyncRetryCount ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNumber((long)this._deltaSyncRetryCount) : null, "deltaSyncRetryCount" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._resyncRequired)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._resyncRequired.ToString()) : null, "resyncRequired" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._resyncState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._resyncState.ToString()) : null, "resyncState" ,container.Add );
            }
            AddIf( null != (((object)this._performAutoResync)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._performAutoResync.ToString()) : null, "performAutoResync" ,container.Add );
            AddIf( null != this._seedDiskTag ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) this._seedDiskTag.ToJson(null,serializationMode) : null, "seedDiskTags" ,container.Add );
            AddIf( null != this._targetDiskTag ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) this._targetDiskTag.ToJson(null,serializationMode) : null, "targetDiskTags" ,container.Add );
            if (null != this._supportedOSVersion)
            {
                var __m = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.XNodeArray();
                foreach( var __n in this._supportedOSVersion )
                {
                    AddIf(null != (((object)__n)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(__n.ToString()) : null ,__m.Add);
                }
                container.Add("supportedOSVersions",__m);
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._operationName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._operationName.ToString()) : null, "operationName" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._applianceMonitoringDetail ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) this._applianceMonitoringDetail.ToJson(null,serializationMode) : null, "applianceMonitoringDetails" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject into a new instance of <see cref="VMwareCbtMigrationDetails" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal VMwareCbtMigrationDetails(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            __migrationProviderSpecificSettings = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.MigrationProviderSpecificSettings(json);
            {_targetVMSecurityProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject>("targetVmSecurityProfile"), out var __jsonTargetVMSecurityProfile) ? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.VMwareCbtSecurityProfileProperties.FromJson(__jsonTargetVMSecurityProfile) : TargetVMSecurityProfile;}
            {_gatewayOperationDetail = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject>("gatewayOperationDetails"), out var __jsonGatewayOperationDetails) ? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.GatewayOperationDetails.FromJson(__jsonGatewayOperationDetails) : GatewayOperationDetail;}
            {_vmwareMachineId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("vmwareMachineId"), out var __jsonVmwareMachineId) ? (string)__jsonVmwareMachineId : (string)VmwareMachineId;}
            {_oSType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("osType"), out var __jsonOSType) ? (string)__jsonOSType : (string)OSType;}
            {_oSName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("osName"), out var __jsonOSName) ? (string)__jsonOSName : (string)OSName;}
            {_firmwareType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("firmwareType"), out var __jsonFirmwareType) ? (string)__jsonFirmwareType : (string)FirmwareType;}
            {_targetGeneration = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("targetGeneration"), out var __jsonTargetGeneration) ? (string)__jsonTargetGeneration : (string)TargetGeneration;}
            {_licenseType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("licenseType"), out var __jsonLicenseType) ? (string)__jsonLicenseType : (string)LicenseType;}
            {_sqlServerLicenseType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("sqlServerLicenseType"), out var __jsonSqlServerLicenseType) ? (string)__jsonSqlServerLicenseType : (string)SqlServerLicenseType;}
            {_linuxLicenseType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("linuxLicenseType"), out var __jsonLinuxLicenseType) ? (string)__jsonLinuxLicenseType : (string)LinuxLicenseType;}
            {_dataMoverRunAsAccountId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("dataMoverRunAsAccountId"), out var __jsonDataMoverRunAsAccountId) ? (string)__jsonDataMoverRunAsAccountId : (string)DataMoverRunAsAccountId;}
            {_snapshotRunAsAccountId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("snapshotRunAsAccountId"), out var __jsonSnapshotRunAsAccountId) ? (string)__jsonSnapshotRunAsAccountId : (string)SnapshotRunAsAccountId;}
            {_storageAccountId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("storageAccountId"), out var __jsonStorageAccountId) ? (string)__jsonStorageAccountId : (string)StorageAccountId;}
            {_targetVMName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("targetVmName"), out var __jsonTargetVMName) ? (string)__jsonTargetVMName : (string)TargetVMName;}
            {_targetVMSize = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("targetVmSize"), out var __jsonTargetVMSize) ? (string)__jsonTargetVMSize : (string)TargetVMSize;}
            {_targetLocation = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("targetLocation"), out var __jsonTargetLocation) ? (string)__jsonTargetLocation : (string)TargetLocation;}
            {_targetResourceGroupId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("targetResourceGroupId"), out var __jsonTargetResourceGroupId) ? (string)__jsonTargetResourceGroupId : (string)TargetResourceGroupId;}
            {_targetAvailabilitySetId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("targetAvailabilitySetId"), out var __jsonTargetAvailabilitySetId) ? (string)__jsonTargetAvailabilitySetId : (string)TargetAvailabilitySetId;}
            {_targetAvailabilityZone = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("targetAvailabilityZone"), out var __jsonTargetAvailabilityZone) ? (string)__jsonTargetAvailabilityZone : (string)TargetAvailabilityZone;}
            {_targetProximityPlacementGroupId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("targetProximityPlacementGroupId"), out var __jsonTargetProximityPlacementGroupId) ? (string)__jsonTargetProximityPlacementGroupId : (string)TargetProximityPlacementGroupId;}
            {_confidentialVMKeyVaultId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("confidentialVmKeyVaultId"), out var __jsonConfidentialVMKeyVaultId) ? (string)__jsonConfidentialVMKeyVaultId : (string)ConfidentialVMKeyVaultId;}
            {_targetBootDiagnosticsStorageAccountId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("targetBootDiagnosticsStorageAccountId"), out var __jsonTargetBootDiagnosticsStorageAccountId) ? (string)__jsonTargetBootDiagnosticsStorageAccountId : (string)TargetBootDiagnosticsStorageAccountId;}
            {_targetVMTag = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject>("targetVmTags"), out var __jsonTargetVMTags) ? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.VMwareCbtMigrationDetailsTargetVmtags.FromJson(__jsonTargetVMTags) : TargetVMTag;}
            {_protectedDisk = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonArray>("protectedDisks"), out var __jsonProtectedDisks) ? If( __jsonProtectedDisks as Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IVMwareCbtProtectedDiskDetails[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IVMwareCbtProtectedDiskDetails) (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.VMwareCbtProtectedDiskDetails.FromJson(__u) )) ))() : null : ProtectedDisk;}
            {_targetNetworkId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("targetNetworkId"), out var __jsonTargetNetworkId) ? (string)__jsonTargetNetworkId : (string)TargetNetworkId;}
            {_testNetworkId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("testNetworkId"), out var __jsonTestNetworkId) ? (string)__jsonTestNetworkId : (string)TestNetworkId;}
            {_vMNic = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonArray>("vmNics"), out var __jsonVMNics) ? If( __jsonVMNics as Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IVMwareCbtNicDetails[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IVMwareCbtNicDetails) (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.VMwareCbtNicDetails.FromJson(__p) )) ))() : null : VMNic;}
            {_targetNicTag = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject>("targetNicTags"), out var __jsonTargetNicTags) ? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.VMwareCbtMigrationDetailsTargetNicTags.FromJson(__jsonTargetNicTags) : TargetNicTag;}
            {_migrationRecoveryPointId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("migrationRecoveryPointId"), out var __jsonMigrationRecoveryPointId) ? (string)__jsonMigrationRecoveryPointId : (string)MigrationRecoveryPointId;}
            {_lastRecoveryPointReceived = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("lastRecoveryPointReceived"), out var __jsonLastRecoveryPointReceived) ? global::System.DateTime.TryParse((string)__jsonLastRecoveryPointReceived, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonLastRecoveryPointReceivedValue) ? __jsonLastRecoveryPointReceivedValue : LastRecoveryPointReceived : LastRecoveryPointReceived;}
            {_lastRecoveryPointId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("lastRecoveryPointId"), out var __jsonLastRecoveryPointId) ? (string)__jsonLastRecoveryPointId : (string)LastRecoveryPointId;}
            {_initialSeedingProgressPercentage = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNumber>("initialSeedingProgressPercentage"), out var __jsonInitialSeedingProgressPercentage) ? (int?)__jsonInitialSeedingProgressPercentage : InitialSeedingProgressPercentage;}
            {_migrationProgressPercentage = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNumber>("migrationProgressPercentage"), out var __jsonMigrationProgressPercentage) ? (int?)__jsonMigrationProgressPercentage : MigrationProgressPercentage;}
            {_resyncProgressPercentage = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNumber>("resyncProgressPercentage"), out var __jsonResyncProgressPercentage) ? (int?)__jsonResyncProgressPercentage : ResyncProgressPercentage;}
            {_resumeProgressPercentage = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNumber>("resumeProgressPercentage"), out var __jsonResumeProgressPercentage) ? (int?)__jsonResumeProgressPercentage : ResumeProgressPercentage;}
            {_deltaSyncProgressPercentage = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNumber>("deltaSyncProgressPercentage"), out var __jsonDeltaSyncProgressPercentage) ? (int?)__jsonDeltaSyncProgressPercentage : DeltaSyncProgressPercentage;}
            {_isCheckSumResyncCycle = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("isCheckSumResyncCycle"), out var __jsonIsCheckSumResyncCycle) ? (string)__jsonIsCheckSumResyncCycle : (string)IsCheckSumResyncCycle;}
            {_initialSeedingRetryCount = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNumber>("initialSeedingRetryCount"), out var __jsonInitialSeedingRetryCount) ? (long?)__jsonInitialSeedingRetryCount : InitialSeedingRetryCount;}
            {_resyncRetryCount = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNumber>("resyncRetryCount"), out var __jsonResyncRetryCount) ? (long?)__jsonResyncRetryCount : ResyncRetryCount;}
            {_resumeRetryCount = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNumber>("resumeRetryCount"), out var __jsonResumeRetryCount) ? (long?)__jsonResumeRetryCount : ResumeRetryCount;}
            {_deltaSyncRetryCount = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNumber>("deltaSyncRetryCount"), out var __jsonDeltaSyncRetryCount) ? (long?)__jsonDeltaSyncRetryCount : DeltaSyncRetryCount;}
            {_resyncRequired = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("resyncRequired"), out var __jsonResyncRequired) ? (string)__jsonResyncRequired : (string)ResyncRequired;}
            {_resyncState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("resyncState"), out var __jsonResyncState) ? (string)__jsonResyncState : (string)ResyncState;}
            {_performAutoResync = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("performAutoResync"), out var __jsonPerformAutoResync) ? (string)__jsonPerformAutoResync : (string)PerformAutoResync;}
            {_seedDiskTag = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject>("seedDiskTags"), out var __jsonSeedDiskTags) ? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.VMwareCbtMigrationDetailsSeedDiskTags.FromJson(__jsonSeedDiskTags) : SeedDiskTag;}
            {_targetDiskTag = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject>("targetDiskTags"), out var __jsonTargetDiskTags) ? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.VMwareCbtMigrationDetailsTargetDiskTags.FromJson(__jsonTargetDiskTags) : TargetDiskTag;}
            {_supportedOSVersion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonArray>("supportedOSVersions"), out var __jsonSupportedOSVersions) ? If( __jsonSupportedOSVersions as Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__l, (__k)=>(string) (__k is Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString __j ? (string)(__j.ToString()) : null)) ))() : null : SupportedOSVersion;}
            {_operationName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("operationName"), out var __jsonOperationName) ? (string)__jsonOperationName : (string)OperationName;}
            {_applianceMonitoringDetail = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject>("applianceMonitoringDetails"), out var __jsonApplianceMonitoringDetails) ? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.ApplianceMonitoringDetails.FromJson(__jsonApplianceMonitoringDetails) : ApplianceMonitoringDetail;}
            AfterFromJson(json);
        }
    }
}