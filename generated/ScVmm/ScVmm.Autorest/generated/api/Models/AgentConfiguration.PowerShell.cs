// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.PowerShell;

    /// <summary>
    /// Configurable properties that the user can set locally via the azcmagent config command, or remotely via ARM.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(AgentConfigurationTypeConverter))]
    public partial class AgentConfiguration
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.AgentConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AgentConfiguration(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ProxyUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAgentConfigurationInternal)this).ProxyUrl = (string) content.GetValueForProperty("ProxyUrl",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAgentConfigurationInternal)this).ProxyUrl, global::System.Convert.ToString);
            }
            if (content.Contains("IncomingConnectionsPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAgentConfigurationInternal)this).IncomingConnectionsPort = (System.Collections.Generic.List<string>) content.GetValueForProperty("IncomingConnectionsPort",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAgentConfigurationInternal)this).IncomingConnectionsPort, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ExtensionsAllowList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAgentConfigurationInternal)this).ExtensionsAllowList = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IConfigurationExtension>) content.GetValueForProperty("ExtensionsAllowList",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAgentConfigurationInternal)this).ExtensionsAllowList, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IConfigurationExtension>(__y, Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ConfigurationExtensionTypeConverter.ConvertFrom));
            }
            if (content.Contains("ExtensionsBlockList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAgentConfigurationInternal)this).ExtensionsBlockList = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IConfigurationExtension>) content.GetValueForProperty("ExtensionsBlockList",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAgentConfigurationInternal)this).ExtensionsBlockList, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IConfigurationExtension>(__y, Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ConfigurationExtensionTypeConverter.ConvertFrom));
            }
            if (content.Contains("ProxyBypass"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAgentConfigurationInternal)this).ProxyBypass = (System.Collections.Generic.List<string>) content.GetValueForProperty("ProxyBypass",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAgentConfigurationInternal)this).ProxyBypass, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ExtensionsEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAgentConfigurationInternal)this).ExtensionsEnabled = (string) content.GetValueForProperty("ExtensionsEnabled",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAgentConfigurationInternal)this).ExtensionsEnabled, global::System.Convert.ToString);
            }
            if (content.Contains("GuestConfigurationEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAgentConfigurationInternal)this).GuestConfigurationEnabled = (string) content.GetValueForProperty("GuestConfigurationEnabled",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAgentConfigurationInternal)this).GuestConfigurationEnabled, global::System.Convert.ToString);
            }
            if (content.Contains("ConfigMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAgentConfigurationInternal)this).ConfigMode = (string) content.GetValueForProperty("ConfigMode",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAgentConfigurationInternal)this).ConfigMode, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.AgentConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AgentConfiguration(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ProxyUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAgentConfigurationInternal)this).ProxyUrl = (string) content.GetValueForProperty("ProxyUrl",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAgentConfigurationInternal)this).ProxyUrl, global::System.Convert.ToString);
            }
            if (content.Contains("IncomingConnectionsPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAgentConfigurationInternal)this).IncomingConnectionsPort = (System.Collections.Generic.List<string>) content.GetValueForProperty("IncomingConnectionsPort",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAgentConfigurationInternal)this).IncomingConnectionsPort, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ExtensionsAllowList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAgentConfigurationInternal)this).ExtensionsAllowList = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IConfigurationExtension>) content.GetValueForProperty("ExtensionsAllowList",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAgentConfigurationInternal)this).ExtensionsAllowList, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IConfigurationExtension>(__y, Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ConfigurationExtensionTypeConverter.ConvertFrom));
            }
            if (content.Contains("ExtensionsBlockList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAgentConfigurationInternal)this).ExtensionsBlockList = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IConfigurationExtension>) content.GetValueForProperty("ExtensionsBlockList",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAgentConfigurationInternal)this).ExtensionsBlockList, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IConfigurationExtension>(__y, Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ConfigurationExtensionTypeConverter.ConvertFrom));
            }
            if (content.Contains("ProxyBypass"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAgentConfigurationInternal)this).ProxyBypass = (System.Collections.Generic.List<string>) content.GetValueForProperty("ProxyBypass",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAgentConfigurationInternal)this).ProxyBypass, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ExtensionsEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAgentConfigurationInternal)this).ExtensionsEnabled = (string) content.GetValueForProperty("ExtensionsEnabled",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAgentConfigurationInternal)this).ExtensionsEnabled, global::System.Convert.ToString);
            }
            if (content.Contains("GuestConfigurationEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAgentConfigurationInternal)this).GuestConfigurationEnabled = (string) content.GetValueForProperty("GuestConfigurationEnabled",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAgentConfigurationInternal)this).GuestConfigurationEnabled, global::System.Convert.ToString);
            }
            if (content.Contains("ConfigMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAgentConfigurationInternal)this).ConfigMode = (string) content.GetValueForProperty("ConfigMode",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAgentConfigurationInternal)this).ConfigMode, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.AgentConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAgentConfiguration" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAgentConfiguration DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AgentConfiguration(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.AgentConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAgentConfiguration" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAgentConfiguration DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AgentConfiguration(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AgentConfiguration" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="AgentConfiguration" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAgentConfiguration FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode.Parse(jsonText));

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
    /// Configurable properties that the user can set locally via the azcmagent config command, or remotely via ARM.
    [System.ComponentModel.TypeConverter(typeof(AgentConfigurationTypeConverter))]
    public partial interface IAgentConfiguration

    {

    }
}