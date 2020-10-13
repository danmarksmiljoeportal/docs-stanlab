//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.8.2.0 (NJsonSchema v10.2.1.0 (Newtonsoft.Json v12.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

#nullable enable

#pragma warning disable 108 // Disable "CS0108 '{derivedDto}.ToJson()' hides inherited member '{dtoBase}.ToJson()'. Use the new keyword if hiding was intended."
#pragma warning disable 114 // Disable "CS0114 '{derivedDto}.RaisePropertyChanged(String)' hides inherited member 'dtoBase.RaisePropertyChanged(String)'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword."
#pragma warning disable 472 // Disable "CS0472 The result of the expression is always 'false' since a value of type 'Int32' is never equal to 'null' of type 'Int32?'
#pragma warning disable 1573 // Disable "CS1573 Parameter '...' has no matching param tag in the XML comment for ...
#pragma warning disable 1591 // Disable "CS1591 Missing XML comment for publicly visible type or member ..."

namespace Dmp.Stanlab.References.RequisitionApi.Specifications
{
    using System = global::System;
    
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.8.2.0 (NJsonSchema v10.2.1.0 (Newtonsoft.Json v12.0.0.0))")]
    public abstract class ContractControllerBase : Microsoft.AspNetCore.Mvc.Controller
    {
        /// <summary>List contracts</summary>
        /// <returns>Success</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("contracts", Name = "GetContracts")]
        public abstract System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<LaboratoryContract>> GetContracts();
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.8.2.0 (NJsonSchema v10.2.1.0 (Newtonsoft.Json v12.0.0.0))")]
    public abstract class BillingAccountControllerBase : Microsoft.AspNetCore.Mvc.Controller
    {
        /// <summary>List billing accounts</summary>
        /// <returns>Success</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("billing-accounts", Name = "GetBillingAccounts")]
        public abstract System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<BillingAccount>> GetBillingAccounts();
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.8.2.0 (NJsonSchema v10.2.1.0 (Newtonsoft.Json v12.0.0.0))")]
    public abstract class LaboratoryTestControllerBase : Microsoft.AspNetCore.Mvc.Controller
    {
        /// <summary>Cancel laboratory test</summary>
        /// <param name="reference">The laboratory's internal reference for the laboratory test</param>
        /// <returns>Success</returns>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("tests/{reference}/cancel", Name = "CancelLaboratoryTest")]
        public abstract System.Threading.Tasks.Task CancelLaboratoryTest([Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] string reference, [Microsoft.AspNetCore.Mvc.FromBody] [Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] CancelLaboratoryTestRequest body);
    
        /// <summary>Submit requisition</summary>
        /// <returns>Success</returns>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("tests", Name = "SubmitRequisition")]
        public abstract System.Threading.Tasks.Task<SubmitRequisitionResponse> SubmitRequisition([Microsoft.AspNetCore.Mvc.FromBody] [Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] SubmitRequisitionRequest body);
    
    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class BillingAccount 
    {
        /// <summary>The laboratory's internal reference (customer ID, account number etc.) for the billing account</summary>
        [Newtonsoft.Json.JsonProperty("reference", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Reference { get; set; }= default!;
    
        /// <summary>Name</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }= default!;
    
        /// <summary>Description</summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class AnalysisOffering 
    {
        /// <summary>Sample matrix. Stancode list 1129</summary>
        [Newtonsoft.Json.JsonProperty("matrix", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Matrix { get; set; }= default!;
    
        /// <summary>Analysis parameter. Stancode list 1008</summary>
        [Newtonsoft.Json.JsonProperty("parameter", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Parameter { get; set; }= default!;
    
        /// <summary>Sample fraction that determines in which fraction the analysis will be performed, e.g. total, filtration concentrate or filtered volume. Stancode list 1030</summary>
        [Newtonsoft.Json.JsonProperty("fraction", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Fraction { get; set; }= default!;
    
        /// <summary>Unit in which the analysis result is reported. Stancode list 1009</summary>
        [Newtonsoft.Json.JsonProperty("unit", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Unit { get; set; }= default!;
    
        /// <summary>Analytical method for the analysis. Stancode list 1010</summary>
        [Newtonsoft.Json.JsonProperty("method", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Method { get; set; }= default!;
    
        /// <summary>Lower limit of detection (LoD) in the specified reporting unit. The detection limit is the lowest quantity of a substance that can be distinguished from the absence of that substance</summary>
        [Newtonsoft.Json.JsonProperty("detectionLimit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DetectionLimit { get; set; }= default!;
    
        /// <summary>Lower limit of quantification (QoD) in the specified reporting unit. The quantification limit is the limit at which the difference between two distinct values can be reasonably discerned and the analytical method cannot operate with an acceptable precision</summary>
        [Newtonsoft.Json.JsonProperty("quantificationLimit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? QuantificationLimit { get; set; }= default!;
    
        /// <summary>Absolute expanded relative uncertainty for the analysis in the measurement range specified in the method, calibration or accreditation</summary>
        [Newtonsoft.Json.JsonProperty("relativeUncertainty", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? RelativeUncertainty { get; set; }= default!;
    
        /// <summary>Indicates if the analysis is performed according to accreditation, e.g. DANAK or ILAC</summary>
        [Newtonsoft.Json.JsonProperty("accredited", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Accredited { get; set; }= default!;
    
        /// <summary>List of strings representing requirements for sampling containers</summary>
        [Newtonsoft.Json.JsonProperty("containers", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<string> Containers { get; set; }= default!;
    
        /// <summary>Expected turnaround time in week days under normal conditions</summary>
        [Newtonsoft.Json.JsonProperty("turnaroundTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int TurnaroundTime { get; set; }= default!;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class LaboratoryContract 
    {
        /// <summary>The laboratory's internal reference (contract number, delivery term code, etc.) for the contract</summary>
        [Newtonsoft.Json.JsonProperty("reference", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Reference { get; set; }= default!;
    
        /// <summary>Description</summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }= default!;
    
        /// <summary>Delivery Terms</summary>
        [Newtonsoft.Json.JsonProperty("deliveryTerms", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DeliveryTerms { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("analyses", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<AnalysisOffering> Analyses { get; set; }= default!;
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class CancelLaboratoryTestRequest 
    {
        /// <summary>Remarks og reason for cancellation</summary>
        [Newtonsoft.Json.JsonProperty("remarks", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Remarks { get; set; }= default!;
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class Contact 
    {
        /// <summary>Contact name or intials</summary>
        [Newtonsoft.Json.JsonProperty("person", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Person { get; set; }= default!;
    
        /// <summary>Contact phone number</summary>
        [Newtonsoft.Json.JsonProperty("phone", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Phone { get; set; }= default!;
    
        /// <summary>Contact email address</summary>
        [Newtonsoft.Json.JsonProperty("email", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Email { get; set; }= default!;
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class Analysis 
    {
        /// <summary>Analysis parameter. Stancode list 1008</summary>
        [Newtonsoft.Json.JsonProperty("parameter", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Parameter { get; set; }= default!;
    
        /// <summary>Sample fraction that determines in which fraction the analysis will be performed, e.g. total, filtration concentrate or filtered volume. Stancode list 1030</summary>
        [Newtonsoft.Json.JsonProperty("fraction", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Fraction { get; set; }= default!;
    
        /// <summary>Unit in which the analysis result is reported. Stancode list 1009</summary>
        [Newtonsoft.Json.JsonProperty("unit", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Unit { get; set; }= default!;
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class AnalysisPackage 
    {
        /// <summary>Analysis package fingerprint</summary>
        [Newtonsoft.Json.JsonProperty("fingerprint", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Fingerprint { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("analyses", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<Analysis> Analyses { get; set; }= default!;
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class SubmitRequisitionRequest 
    {
        /// <summary>Stanlab Reporting API Endpoint that is the system in which the sample information exists</summary>
        [Newtonsoft.Json.JsonProperty("reportingEndpoint", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ReportingEndpoint { get; set; }= default!;
    
        /// <summary>Unique sample identifier generated by the end system</summary>
        [Newtonsoft.Json.JsonProperty("sampleId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid SampleId { get; set; }= default!;
    
        /// <summary>The laboratory's internal reference (contract number, delivery term code, etc.) for the contract</summary>
        [Newtonsoft.Json.JsonProperty("contractReference", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContractReference { get; set; }= default!;
    
        /// <summary>The laboratory's internal reference (customer ID, account number etc.) for the billing account</summary>
        [Newtonsoft.Json.JsonProperty("billingAccountReference", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BillingAccountReference { get; set; }= default!;
    
        /// <summary>Contact information for requisition/order related queries</summary>
        [Newtonsoft.Json.JsonProperty("contact", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Contact Contact { get; set; }= default!;
    
        /// <summary>Contact information for sampling related queries</summary>
        [Newtonsoft.Json.JsonProperty("samplingContact", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Contact SamplingContact { get; set; }= default!;
    
        /// <summary>Invoice reference</summary>
        [Newtonsoft.Json.JsonProperty("orderReference", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OrderReference { get; set; }= default!;
    
        /// <summary>Invoice line reference</summary>
        [Newtonsoft.Json.JsonProperty("orderLineReference", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OrderLineReference { get; set; }= default!;
    
        /// <summary>The applicant's remarks regarding the requisition</summary>
        [Newtonsoft.Json.JsonProperty("remarks", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Remarks { get; set; }= default!;
    
        /// <summary>References on the physical sample containers, e.g. pre-printed barcodes or serial numbers</summary>
        [Newtonsoft.Json.JsonProperty("containerReferences", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<string> ContainerReferences { get; set; }= default!;
    
        /// <summary>List of analysis packages to be analysed on the sample</summary>
        [Newtonsoft.Json.JsonProperty("packages", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<AnalysisPackage> Packages { get; set; }= default!;
    
        /// <summary>Number of week days the sample must be stored after the analysis is finished. If null, the storage time is according to the contract</summary>
        [Newtonsoft.Json.JsonProperty("storageTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? StorageTime { get; set; }= default!;
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class SubmitRequisitionResponse 
    {
        /// <summary>The laboratory's internal reference for the resulting laboratory test</summary>
        [Newtonsoft.Json.JsonProperty("laboratoryTestReference", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LaboratoryTestReference { get; set; }= default!;
    
        /// <summary>Number of week days the sample is stored after the analysis is finished</summary>
        [Newtonsoft.Json.JsonProperty("storageTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int StorageTime { get; set; }= default!;
    
    
    }

}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108