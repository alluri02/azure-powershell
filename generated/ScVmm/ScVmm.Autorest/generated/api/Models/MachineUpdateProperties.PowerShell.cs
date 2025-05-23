// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.PowerShell;

    /// <summary>Describes the ARM updatable properties of a hybrid machine.</summary>
    [System.ComponentModel.TypeConverter(typeof(MachineUpdatePropertiesTypeConverter))]
    public partial class MachineUpdateProperties
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.MachineUpdateProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdateProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdateProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new MachineUpdateProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.MachineUpdateProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdateProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdateProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new MachineUpdateProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="MachineUpdateProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="MachineUpdateProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdateProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.MachineUpdateProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal MachineUpdateProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("LocationData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).LocationData = (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ILocationData) content.GetValueForProperty("LocationData",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).LocationData, Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.LocationDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("CloudMetadata"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).CloudMetadata = (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ICloudMetadata) content.GetValueForProperty("CloudMetadata",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).CloudMetadata, Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.CloudMetadataTypeConverter.ConvertFrom);
            }
            if (content.Contains("AgentUpgrade"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).AgentUpgrade = (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAgentUpgrade) content.GetValueForProperty("AgentUpgrade",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).AgentUpgrade, Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.AgentUpgradeTypeConverter.ConvertFrom);
            }
            if (content.Contains("ParentClusterResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).ParentClusterResourceId = (string) content.GetValueForProperty("ParentClusterResourceId",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).ParentClusterResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateLinkScopeResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).PrivateLinkScopeResourceId = (string) content.GetValueForProperty("PrivateLinkScopeResourceId",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).PrivateLinkScopeResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("OSProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).OSProfile = (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IOSProfile) content.GetValueForProperty("OSProfile",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).OSProfile, Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.OSProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("LocationDataName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).LocationDataName = (string) content.GetValueForProperty("LocationDataName",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).LocationDataName, global::System.Convert.ToString);
            }
            if (content.Contains("LocationDataCity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).LocationDataCity = (string) content.GetValueForProperty("LocationDataCity",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).LocationDataCity, global::System.Convert.ToString);
            }
            if (content.Contains("LocationDataDistrict"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).LocationDataDistrict = (string) content.GetValueForProperty("LocationDataDistrict",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).LocationDataDistrict, global::System.Convert.ToString);
            }
            if (content.Contains("CloudMetadataProvider"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).CloudMetadataProvider = (string) content.GetValueForProperty("CloudMetadataProvider",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).CloudMetadataProvider, global::System.Convert.ToString);
            }
            if (content.Contains("AgentUpgradeDesiredVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).AgentUpgradeDesiredVersion = (string) content.GetValueForProperty("AgentUpgradeDesiredVersion",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).AgentUpgradeDesiredVersion, global::System.Convert.ToString);
            }
            if (content.Contains("AgentUpgradeCorrelationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).AgentUpgradeCorrelationId = (string) content.GetValueForProperty("AgentUpgradeCorrelationId",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).AgentUpgradeCorrelationId, global::System.Convert.ToString);
            }
            if (content.Contains("LocationDataCountryOrRegion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).LocationDataCountryOrRegion = (string) content.GetValueForProperty("LocationDataCountryOrRegion",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).LocationDataCountryOrRegion, global::System.Convert.ToString);
            }
            if (content.Contains("AgentUpgradeEnableAutomaticUpgrade"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).AgentUpgradeEnableAutomaticUpgrade = (bool?) content.GetValueForProperty("AgentUpgradeEnableAutomaticUpgrade",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).AgentUpgradeEnableAutomaticUpgrade, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AgentUpgradeLastAttemptDesiredVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).AgentUpgradeLastAttemptDesiredVersion = (string) content.GetValueForProperty("AgentUpgradeLastAttemptDesiredVersion",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).AgentUpgradeLastAttemptDesiredVersion, global::System.Convert.ToString);
            }
            if (content.Contains("AgentUpgradeLastAttemptTimestamp"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).AgentUpgradeLastAttemptTimestamp = (string) content.GetValueForProperty("AgentUpgradeLastAttemptTimestamp",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).AgentUpgradeLastAttemptTimestamp, global::System.Convert.ToString);
            }
            if (content.Contains("AgentUpgradeLastAttemptStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).AgentUpgradeLastAttemptStatus = (string) content.GetValueForProperty("AgentUpgradeLastAttemptStatus",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).AgentUpgradeLastAttemptStatus, global::System.Convert.ToString);
            }
            if (content.Contains("AgentUpgradeLastAttemptMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).AgentUpgradeLastAttemptMessage = (string) content.GetValueForProperty("AgentUpgradeLastAttemptMessage",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).AgentUpgradeLastAttemptMessage, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.MachineUpdateProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal MachineUpdateProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("LocationData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).LocationData = (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ILocationData) content.GetValueForProperty("LocationData",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).LocationData, Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.LocationDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("CloudMetadata"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).CloudMetadata = (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ICloudMetadata) content.GetValueForProperty("CloudMetadata",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).CloudMetadata, Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.CloudMetadataTypeConverter.ConvertFrom);
            }
            if (content.Contains("AgentUpgrade"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).AgentUpgrade = (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAgentUpgrade) content.GetValueForProperty("AgentUpgrade",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).AgentUpgrade, Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.AgentUpgradeTypeConverter.ConvertFrom);
            }
            if (content.Contains("ParentClusterResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).ParentClusterResourceId = (string) content.GetValueForProperty("ParentClusterResourceId",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).ParentClusterResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateLinkScopeResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).PrivateLinkScopeResourceId = (string) content.GetValueForProperty("PrivateLinkScopeResourceId",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).PrivateLinkScopeResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("OSProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).OSProfile = (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IOSProfile) content.GetValueForProperty("OSProfile",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).OSProfile, Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.OSProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("LocationDataName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).LocationDataName = (string) content.GetValueForProperty("LocationDataName",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).LocationDataName, global::System.Convert.ToString);
            }
            if (content.Contains("LocationDataCity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).LocationDataCity = (string) content.GetValueForProperty("LocationDataCity",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).LocationDataCity, global::System.Convert.ToString);
            }
            if (content.Contains("LocationDataDistrict"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).LocationDataDistrict = (string) content.GetValueForProperty("LocationDataDistrict",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).LocationDataDistrict, global::System.Convert.ToString);
            }
            if (content.Contains("CloudMetadataProvider"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).CloudMetadataProvider = (string) content.GetValueForProperty("CloudMetadataProvider",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).CloudMetadataProvider, global::System.Convert.ToString);
            }
            if (content.Contains("AgentUpgradeDesiredVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).AgentUpgradeDesiredVersion = (string) content.GetValueForProperty("AgentUpgradeDesiredVersion",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).AgentUpgradeDesiredVersion, global::System.Convert.ToString);
            }
            if (content.Contains("AgentUpgradeCorrelationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).AgentUpgradeCorrelationId = (string) content.GetValueForProperty("AgentUpgradeCorrelationId",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).AgentUpgradeCorrelationId, global::System.Convert.ToString);
            }
            if (content.Contains("LocationDataCountryOrRegion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).LocationDataCountryOrRegion = (string) content.GetValueForProperty("LocationDataCountryOrRegion",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).LocationDataCountryOrRegion, global::System.Convert.ToString);
            }
            if (content.Contains("AgentUpgradeEnableAutomaticUpgrade"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).AgentUpgradeEnableAutomaticUpgrade = (bool?) content.GetValueForProperty("AgentUpgradeEnableAutomaticUpgrade",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).AgentUpgradeEnableAutomaticUpgrade, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AgentUpgradeLastAttemptDesiredVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).AgentUpgradeLastAttemptDesiredVersion = (string) content.GetValueForProperty("AgentUpgradeLastAttemptDesiredVersion",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).AgentUpgradeLastAttemptDesiredVersion, global::System.Convert.ToString);
            }
            if (content.Contains("AgentUpgradeLastAttemptTimestamp"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).AgentUpgradeLastAttemptTimestamp = (string) content.GetValueForProperty("AgentUpgradeLastAttemptTimestamp",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).AgentUpgradeLastAttemptTimestamp, global::System.Convert.ToString);
            }
            if (content.Contains("AgentUpgradeLastAttemptStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).AgentUpgradeLastAttemptStatus = (string) content.GetValueForProperty("AgentUpgradeLastAttemptStatus",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).AgentUpgradeLastAttemptStatus, global::System.Convert.ToString);
            }
            if (content.Contains("AgentUpgradeLastAttemptMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).AgentUpgradeLastAttemptMessage = (string) content.GetValueForProperty("AgentUpgradeLastAttemptMessage",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineUpdatePropertiesInternal)this).AgentUpgradeLastAttemptMessage, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// Describes the ARM updatable properties of a hybrid machine.
    [System.ComponentModel.TypeConverter(typeof(MachineUpdatePropertiesTypeConverter))]
    public partial interface IMachineUpdateProperties

    {

    }
}