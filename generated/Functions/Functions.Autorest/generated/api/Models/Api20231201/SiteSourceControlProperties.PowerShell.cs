// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201
{
    using Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.PowerShell;

    /// <summary>SiteSourceControl resource specific properties</summary>
    [System.ComponentModel.TypeConverter(typeof(SiteSourceControlPropertiesTypeConverter))]
    public partial class SiteSourceControlProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.SiteSourceControlProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SiteSourceControlProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.SiteSourceControlProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SiteSourceControlProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SiteSourceControlProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="SiteSourceControlProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.SiteSourceControlProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SiteSourceControlProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("GitHubActionConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).GitHubActionConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IGitHubActionConfiguration) content.GetValueForProperty("GitHubActionConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).GitHubActionConfiguration, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.GitHubActionConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("RepoUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).RepoUrl = (string) content.GetValueForProperty("RepoUrl",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).RepoUrl, global::System.Convert.ToString);
            }
            if (content.Contains("Branch"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).Branch = (string) content.GetValueForProperty("Branch",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).Branch, global::System.Convert.ToString);
            }
            if (content.Contains("IsManualIntegration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).IsManualIntegration = (bool?) content.GetValueForProperty("IsManualIntegration",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).IsManualIntegration, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IsGitHubAction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).IsGitHubAction = (bool?) content.GetValueForProperty("IsGitHubAction",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).IsGitHubAction, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("DeploymentRollbackEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).DeploymentRollbackEnabled = (bool?) content.GetValueForProperty("DeploymentRollbackEnabled",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).DeploymentRollbackEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IsMercurial"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).IsMercurial = (bool?) content.GetValueForProperty("IsMercurial",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).IsMercurial, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("GitHubActionConfigurationCodeConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).GitHubActionConfigurationCodeConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IGitHubActionCodeConfiguration) content.GetValueForProperty("GitHubActionConfigurationCodeConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).GitHubActionConfigurationCodeConfiguration, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.GitHubActionCodeConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("GitHubActionConfigurationContainerConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).GitHubActionConfigurationContainerConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IGitHubActionContainerConfiguration) content.GetValueForProperty("GitHubActionConfigurationContainerConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).GitHubActionConfigurationContainerConfiguration, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.GitHubActionContainerConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("GitHubActionConfigurationIsLinux"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).GitHubActionConfigurationIsLinux = (bool?) content.GetValueForProperty("GitHubActionConfigurationIsLinux",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).GitHubActionConfigurationIsLinux, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("GitHubActionConfigurationGenerateWorkflowFile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).GitHubActionConfigurationGenerateWorkflowFile = (bool?) content.GetValueForProperty("GitHubActionConfigurationGenerateWorkflowFile",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).GitHubActionConfigurationGenerateWorkflowFile, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("CodeConfigurationRuntimeStack"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).CodeConfigurationRuntimeStack = (string) content.GetValueForProperty("CodeConfigurationRuntimeStack",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).CodeConfigurationRuntimeStack, global::System.Convert.ToString);
            }
            if (content.Contains("CodeConfigurationRuntimeVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).CodeConfigurationRuntimeVersion = (string) content.GetValueForProperty("CodeConfigurationRuntimeVersion",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).CodeConfigurationRuntimeVersion, global::System.Convert.ToString);
            }
            if (content.Contains("ContainerConfigurationServerUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).ContainerConfigurationServerUrl = (string) content.GetValueForProperty("ContainerConfigurationServerUrl",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).ContainerConfigurationServerUrl, global::System.Convert.ToString);
            }
            if (content.Contains("ContainerConfigurationImageName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).ContainerConfigurationImageName = (string) content.GetValueForProperty("ContainerConfigurationImageName",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).ContainerConfigurationImageName, global::System.Convert.ToString);
            }
            if (content.Contains("ContainerConfigurationUsername"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).ContainerConfigurationUsername = (string) content.GetValueForProperty("ContainerConfigurationUsername",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).ContainerConfigurationUsername, global::System.Convert.ToString);
            }
            if (content.Contains("ContainerConfigurationPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).ContainerConfigurationPassword = (string) content.GetValueForProperty("ContainerConfigurationPassword",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).ContainerConfigurationPassword, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.SiteSourceControlProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SiteSourceControlProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("GitHubActionConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).GitHubActionConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IGitHubActionConfiguration) content.GetValueForProperty("GitHubActionConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).GitHubActionConfiguration, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.GitHubActionConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("RepoUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).RepoUrl = (string) content.GetValueForProperty("RepoUrl",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).RepoUrl, global::System.Convert.ToString);
            }
            if (content.Contains("Branch"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).Branch = (string) content.GetValueForProperty("Branch",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).Branch, global::System.Convert.ToString);
            }
            if (content.Contains("IsManualIntegration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).IsManualIntegration = (bool?) content.GetValueForProperty("IsManualIntegration",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).IsManualIntegration, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IsGitHubAction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).IsGitHubAction = (bool?) content.GetValueForProperty("IsGitHubAction",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).IsGitHubAction, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("DeploymentRollbackEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).DeploymentRollbackEnabled = (bool?) content.GetValueForProperty("DeploymentRollbackEnabled",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).DeploymentRollbackEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IsMercurial"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).IsMercurial = (bool?) content.GetValueForProperty("IsMercurial",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).IsMercurial, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("GitHubActionConfigurationCodeConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).GitHubActionConfigurationCodeConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IGitHubActionCodeConfiguration) content.GetValueForProperty("GitHubActionConfigurationCodeConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).GitHubActionConfigurationCodeConfiguration, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.GitHubActionCodeConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("GitHubActionConfigurationContainerConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).GitHubActionConfigurationContainerConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IGitHubActionContainerConfiguration) content.GetValueForProperty("GitHubActionConfigurationContainerConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).GitHubActionConfigurationContainerConfiguration, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.GitHubActionContainerConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("GitHubActionConfigurationIsLinux"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).GitHubActionConfigurationIsLinux = (bool?) content.GetValueForProperty("GitHubActionConfigurationIsLinux",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).GitHubActionConfigurationIsLinux, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("GitHubActionConfigurationGenerateWorkflowFile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).GitHubActionConfigurationGenerateWorkflowFile = (bool?) content.GetValueForProperty("GitHubActionConfigurationGenerateWorkflowFile",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).GitHubActionConfigurationGenerateWorkflowFile, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("CodeConfigurationRuntimeStack"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).CodeConfigurationRuntimeStack = (string) content.GetValueForProperty("CodeConfigurationRuntimeStack",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).CodeConfigurationRuntimeStack, global::System.Convert.ToString);
            }
            if (content.Contains("CodeConfigurationRuntimeVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).CodeConfigurationRuntimeVersion = (string) content.GetValueForProperty("CodeConfigurationRuntimeVersion",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).CodeConfigurationRuntimeVersion, global::System.Convert.ToString);
            }
            if (content.Contains("ContainerConfigurationServerUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).ContainerConfigurationServerUrl = (string) content.GetValueForProperty("ContainerConfigurationServerUrl",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).ContainerConfigurationServerUrl, global::System.Convert.ToString);
            }
            if (content.Contains("ContainerConfigurationImageName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).ContainerConfigurationImageName = (string) content.GetValueForProperty("ContainerConfigurationImageName",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).ContainerConfigurationImageName, global::System.Convert.ToString);
            }
            if (content.Contains("ContainerConfigurationUsername"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).ContainerConfigurationUsername = (string) content.GetValueForProperty("ContainerConfigurationUsername",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).ContainerConfigurationUsername, global::System.Convert.ToString);
            }
            if (content.Contains("ContainerConfigurationPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).ContainerConfigurationPassword = (string) content.GetValueForProperty("ContainerConfigurationPassword",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteSourceControlPropertiesInternal)this).ContainerConfigurationPassword, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// SiteSourceControl resource specific properties
    [System.ComponentModel.TypeConverter(typeof(SiteSourceControlPropertiesTypeConverter))]
    public partial interface ISiteSourceControlProperties

    {

    }
}