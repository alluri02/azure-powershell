// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.PowerShell;

    /// <summary>Address details for an order item.</summary>
    [System.ComponentModel.TypeConverter(typeof(AddressDetailsTypeConverter))]
    public partial class AddressDetails
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.AddressDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AddressDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ForwardAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressDetailsInternal)this).ForwardAddress = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressProperties) content.GetValueForProperty("ForwardAddress",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressDetailsInternal)this).ForwardAddress, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.AddressPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReturnAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressDetailsInternal)this).ReturnAddress = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressProperties) content.GetValueForProperty("ReturnAddress",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressDetailsInternal)this).ReturnAddress, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.AddressPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ForwardAddressShippingAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressDetailsInternal)this).ForwardAddressShippingAddress = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IShippingAddress) content.GetValueForProperty("ForwardAddressShippingAddress",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressDetailsInternal)this).ForwardAddressShippingAddress, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.ShippingAddressTypeConverter.ConvertFrom);
            }
            if (content.Contains("ForwardAddressContactDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressDetailsInternal)this).ForwardAddressContactDetail = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IContactDetails) content.GetValueForProperty("ForwardAddressContactDetail",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressDetailsInternal)this).ForwardAddressContactDetail, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.ContactDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReturnAddressShippingAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressDetailsInternal)this).ReturnAddressShippingAddress = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IShippingAddress) content.GetValueForProperty("ReturnAddressShippingAddress",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressDetailsInternal)this).ReturnAddressShippingAddress, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.ShippingAddressTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReturnAddressContactDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressDetailsInternal)this).ReturnAddressContactDetail = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IContactDetails) content.GetValueForProperty("ReturnAddressContactDetail",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressDetailsInternal)this).ReturnAddressContactDetail, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.ContactDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ForwardAddressValidationStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressDetailsInternal)this).ForwardAddressValidationStatus = (string) content.GetValueForProperty("ForwardAddressValidationStatus",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressDetailsInternal)this).ForwardAddressValidationStatus, global::System.Convert.ToString);
            }
            if (content.Contains("ReturnAddressValidationStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressDetailsInternal)this).ReturnAddressValidationStatus = (string) content.GetValueForProperty("ReturnAddressValidationStatus",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressDetailsInternal)this).ReturnAddressValidationStatus, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.AddressDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AddressDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ForwardAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressDetailsInternal)this).ForwardAddress = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressProperties) content.GetValueForProperty("ForwardAddress",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressDetailsInternal)this).ForwardAddress, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.AddressPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReturnAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressDetailsInternal)this).ReturnAddress = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressProperties) content.GetValueForProperty("ReturnAddress",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressDetailsInternal)this).ReturnAddress, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.AddressPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ForwardAddressShippingAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressDetailsInternal)this).ForwardAddressShippingAddress = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IShippingAddress) content.GetValueForProperty("ForwardAddressShippingAddress",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressDetailsInternal)this).ForwardAddressShippingAddress, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.ShippingAddressTypeConverter.ConvertFrom);
            }
            if (content.Contains("ForwardAddressContactDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressDetailsInternal)this).ForwardAddressContactDetail = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IContactDetails) content.GetValueForProperty("ForwardAddressContactDetail",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressDetailsInternal)this).ForwardAddressContactDetail, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.ContactDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReturnAddressShippingAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressDetailsInternal)this).ReturnAddressShippingAddress = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IShippingAddress) content.GetValueForProperty("ReturnAddressShippingAddress",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressDetailsInternal)this).ReturnAddressShippingAddress, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.ShippingAddressTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReturnAddressContactDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressDetailsInternal)this).ReturnAddressContactDetail = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IContactDetails) content.GetValueForProperty("ReturnAddressContactDetail",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressDetailsInternal)this).ReturnAddressContactDetail, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.ContactDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ForwardAddressValidationStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressDetailsInternal)this).ForwardAddressValidationStatus = (string) content.GetValueForProperty("ForwardAddressValidationStatus",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressDetailsInternal)this).ForwardAddressValidationStatus, global::System.Convert.ToString);
            }
            if (content.Contains("ReturnAddressValidationStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressDetailsInternal)this).ReturnAddressValidationStatus = (string) content.GetValueForProperty("ReturnAddressValidationStatus",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressDetailsInternal)this).ReturnAddressValidationStatus, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.AddressDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressDetails" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AddressDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.AddressDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressDetails" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AddressDetails(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AddressDetails" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="AddressDetails" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IAddressDetails FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Address details for an order item.
    [System.ComponentModel.TypeConverter(typeof(AddressDetailsTypeConverter))]
    public partial interface IAddressDetails

    {

    }
}