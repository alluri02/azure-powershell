// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.PowerShell;

    /// <summary>Details of a reservation order being returned.</summary>
    [System.ComponentModel.TypeConverter(typeof(ReservationOrderResponseTypeConverter))]
    public partial class ReservationOrderResponse
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ReservationOrderResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponse" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponse DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ReservationOrderResponse(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ReservationOrderResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponse" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponse DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ReservationOrderResponse(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ReservationOrderResponse" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ReservationOrderResponse" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponse FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ReservationOrderResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ReservationOrderResponse(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ReservationOrderPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Etag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).Etag = (int?) content.GetValueForProperty("Etag",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).Etag, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("PlanInformation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).PlanInformation = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderBillingPlanInformation) content.GetValueForProperty("PlanInformation",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).PlanInformation, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ReservationOrderBillingPlanInformationTypeConverter.ConvertFrom);
            }
            if (content.Contains("DisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).DisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("RequestDateTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).RequestDateTime = (global::System.DateTime?) content.GetValueForProperty("RequestDateTime",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).RequestDateTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("CreatedDateTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).CreatedDateTime = (global::System.DateTime?) content.GetValueForProperty("CreatedDateTime",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).CreatedDateTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ExpiryDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).ExpiryDate = (global::System.DateTime?) content.GetValueForProperty("ExpiryDate",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).ExpiryDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ExpiryDateTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).ExpiryDateTime = (global::System.DateTime?) content.GetValueForProperty("ExpiryDateTime",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).ExpiryDateTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("BenefitStartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).BenefitStartTime = (global::System.DateTime?) content.GetValueForProperty("BenefitStartTime",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).BenefitStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("OriginalQuantity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).OriginalQuantity = (int?) content.GetValueForProperty("OriginalQuantity",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).OriginalQuantity, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("Term"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).Term = (string) content.GetValueForProperty("Term",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).Term, global::System.Convert.ToString);
            }
            if (content.Contains("BillingPlan"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).BillingPlan = (string) content.GetValueForProperty("BillingPlan",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).BillingPlan, global::System.Convert.ToString);
            }
            if (content.Contains("Reservations"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).Reservations = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationResponse>) content.GetValueForProperty("Reservations",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).Reservations, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationResponse>(__y, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ReservationResponseTypeConverter.ConvertFrom));
            }
            if (content.Contains("ReviewDateTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).ReviewDateTime = (global::System.DateTime?) content.GetValueForProperty("ReviewDateTime",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).ReviewDateTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("PlanInformationPricingCurrencyTotal"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).PlanInformationPricingCurrencyTotal = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IPrice) content.GetValueForProperty("PlanInformationPricingCurrencyTotal",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).PlanInformationPricingCurrencyTotal, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.PriceTypeConverter.ConvertFrom);
            }
            if (content.Contains("PlanInformationStartDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).PlanInformationStartDate = (global::System.DateTime?) content.GetValueForProperty("PlanInformationStartDate",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).PlanInformationStartDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("PlanInformationNextPaymentDueDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).PlanInformationNextPaymentDueDate = (global::System.DateTime?) content.GetValueForProperty("PlanInformationNextPaymentDueDate",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).PlanInformationNextPaymentDueDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("PlanInformationTransaction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).PlanInformationTransaction = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IPaymentDetail>) content.GetValueForProperty("PlanInformationTransaction",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).PlanInformationTransaction, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IPaymentDetail>(__y, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.PaymentDetailTypeConverter.ConvertFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ReservationOrderResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ReservationOrderResponse(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ReservationOrderPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Etag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).Etag = (int?) content.GetValueForProperty("Etag",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).Etag, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("PlanInformation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).PlanInformation = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderBillingPlanInformation) content.GetValueForProperty("PlanInformation",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).PlanInformation, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ReservationOrderBillingPlanInformationTypeConverter.ConvertFrom);
            }
            if (content.Contains("DisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).DisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("RequestDateTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).RequestDateTime = (global::System.DateTime?) content.GetValueForProperty("RequestDateTime",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).RequestDateTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("CreatedDateTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).CreatedDateTime = (global::System.DateTime?) content.GetValueForProperty("CreatedDateTime",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).CreatedDateTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ExpiryDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).ExpiryDate = (global::System.DateTime?) content.GetValueForProperty("ExpiryDate",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).ExpiryDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ExpiryDateTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).ExpiryDateTime = (global::System.DateTime?) content.GetValueForProperty("ExpiryDateTime",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).ExpiryDateTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("BenefitStartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).BenefitStartTime = (global::System.DateTime?) content.GetValueForProperty("BenefitStartTime",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).BenefitStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("OriginalQuantity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).OriginalQuantity = (int?) content.GetValueForProperty("OriginalQuantity",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).OriginalQuantity, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("Term"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).Term = (string) content.GetValueForProperty("Term",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).Term, global::System.Convert.ToString);
            }
            if (content.Contains("BillingPlan"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).BillingPlan = (string) content.GetValueForProperty("BillingPlan",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).BillingPlan, global::System.Convert.ToString);
            }
            if (content.Contains("Reservations"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).Reservations = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationResponse>) content.GetValueForProperty("Reservations",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).Reservations, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationResponse>(__y, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.ReservationResponseTypeConverter.ConvertFrom));
            }
            if (content.Contains("ReviewDateTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).ReviewDateTime = (global::System.DateTime?) content.GetValueForProperty("ReviewDateTime",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).ReviewDateTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("PlanInformationPricingCurrencyTotal"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).PlanInformationPricingCurrencyTotal = (Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IPrice) content.GetValueForProperty("PlanInformationPricingCurrencyTotal",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).PlanInformationPricingCurrencyTotal, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.PriceTypeConverter.ConvertFrom);
            }
            if (content.Contains("PlanInformationStartDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).PlanInformationStartDate = (global::System.DateTime?) content.GetValueForProperty("PlanInformationStartDate",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).PlanInformationStartDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("PlanInformationNextPaymentDueDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).PlanInformationNextPaymentDueDate = (global::System.DateTime?) content.GetValueForProperty("PlanInformationNextPaymentDueDate",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).PlanInformationNextPaymentDueDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("PlanInformationTransaction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).PlanInformationTransaction = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IPaymentDetail>) content.GetValueForProperty("PlanInformationTransaction",((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationOrderResponseInternal)this).PlanInformationTransaction, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IPaymentDetail>(__y, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.PaymentDetailTypeConverter.ConvertFrom));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Details of a reservation order being returned.
    [System.ComponentModel.TypeConverter(typeof(ReservationOrderResponseTypeConverter))]
    public partial interface IReservationOrderResponse

    {

    }
}