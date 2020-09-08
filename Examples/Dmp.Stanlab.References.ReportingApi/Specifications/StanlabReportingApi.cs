//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.7.0.0 (NJsonSchema v10.1.24.0 (Newtonsoft.Json v12.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

#nullable enable

#pragma warning disable 108 // Disable "CS0108 '{derivedDto}.ToJson()' hides inherited member '{dtoBase}.ToJson()'. Use the new keyword if hiding was intended."
#pragma warning disable 114 // Disable "CS0114 '{derivedDto}.RaisePropertyChanged(String)' hides inherited member 'dtoBase.RaisePropertyChanged(String)'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword."
#pragma warning disable 472 // Disable "CS0472 The result of the expression is always 'false' since a value of type 'Int32' is never equal to 'null' of type 'Int32?'
#pragma warning disable 1573 // Disable "CS1573 Parameter '...' has no matching param tag in the XML comment for ...
#pragma warning disable 1591 // Disable "CS1591 Missing XML comment for publicly visible type or member ..."

namespace Dmp.Stanlab.References.ReportingApi.Specifications
{
    using System = global::System;
    
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.7.0.0 (NJsonSchema v10.1.24.0 (Newtonsoft.Json v12.0.0.0))")]
    public abstract class SampleControllerBase : Microsoft.AspNetCore.Mvc.Controller
    {
        /// <summary>Get sample</summary>
        /// <param name="sampleId">Sample ID</param>
        /// <returns>Success</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("samples/{sampleId}", Name = "GetSample")]
        public abstract System.Threading.Tasks.Task<Sample> GetSample([Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] System.Guid sampleId);
    
        /// <summary>Deletes a sample</summary>
        /// <returns>Success</returns>
        [Microsoft.AspNetCore.Mvc.HttpDelete, Microsoft.AspNetCore.Mvc.Route("samples/{sampleId}", Name = "DeleteSample")]
        public abstract System.Threading.Tasks.Task DeleteSample([Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] System.Guid sampleId);
    
        /// <summary>Submit sample</summary>
        /// <returns>Success</returns>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("samples", Name = "SubmitSample")]
        public abstract System.Threading.Tasks.Task<System.Guid> SubmitSample([Microsoft.AspNetCore.Mvc.FromBody] [Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] SubmitSampleRequest body);
    
        /// <summary>Submit laboratory test</summary>
        /// <param name="sampleId">Sample ID</param>
        /// <returns>Success</returns>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("samples/{sampleId}/tests", Name = "SubmitLaboratoryTest")]
        public abstract System.Threading.Tasks.Task SubmitLaboratoryTest([Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] System.Guid sampleId, [Microsoft.AspNetCore.Mvc.FromBody] [Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] SubmitLaboratoryTestRequest body);
    
        /// <summary>Delete laboratory test</summary>
        /// <param name="sampleId">Sample ID</param>
        /// <param name="reference">The laboratory's internal reference for the laboratory test</param>
        /// <returns>Success</returns>
        [Microsoft.AspNetCore.Mvc.HttpDelete, Microsoft.AspNetCore.Mvc.Route("samples/{sampleId}/tests/{reference}", Name = "DeleteLaboratoryTest")]
        public abstract System.Threading.Tasks.Task DeleteLaboratoryTest([Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] System.Guid sampleId, [Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] string reference);
    
    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.24.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class ObservationFacility 
    {
        /// <summary>Unique identifier of the observation facility, e.g. measurement point id or station id</summary>
        [Newtonsoft.Json.JsonProperty("observationFacilityId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ObservationFacilityId { get; set; }= default!;
    
        /// <summary>Name of the observation facility</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }= default!;
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.24.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class Actor 
    {
        /// <summary>Company identifier, i.e. CVR-number for Danish companies prefixed with DK, e.g. DK29776938</summary>
        [Newtonsoft.Json.JsonProperty("company", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Company { get; set; }= default!;
    
        /// <summary>Person name, initials, id etc</summary>
        [Newtonsoft.Json.JsonProperty("person", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Person { get; set; }= default!;
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.24.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class Sampling 
    {
        [Newtonsoft.Json.JsonProperty("sampler", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Actor Sampler { get; set; } = new Actor();
    
        /// <summary>Sampling method. Stancode list 1010</summary>
        [Newtonsoft.Json.JsonProperty("method", Required = Newtonsoft.Json.Required.Always)]
        public int Method { get; set; }= default!;
    
        /// <summary>Sampling equipment. Stancode list 1006</summary>
        [Newtonsoft.Json.JsonProperty("equipment", Required = Newtonsoft.Json.Required.Always)]
        public int Equipment { get; set; }= default!;
    
        /// <summary>The sampler's remarks</summary>
        [Newtonsoft.Json.JsonProperty("remarks", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Remarks { get; set; }= default!;
    
        /// <summary>Start time of the sampling</summary>
        [Newtonsoft.Json.JsonProperty("samplingStarted", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTimeOffset SamplingStarted { get; set; }= default!;
    
        /// <summary>End time of the sampling</summary>
        [Newtonsoft.Json.JsonProperty("samplingEnded", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? SamplingEnded { get; set; }= default!;
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.24.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class Measurement 
    {
        /// <summary>Measurement parameter. Stancode list 1008</summary>
        [Newtonsoft.Json.JsonProperty("parameter", Required = Newtonsoft.Json.Required.Always)]
        public int Parameter { get; set; }= default!;
    
        /// <summary>Unit in which the analysis result is reported. Stancode list 1009</summary>
        [Newtonsoft.Json.JsonProperty("unit", Required = Newtonsoft.Json.Required.Always)]
        public int Unit { get; set; }= default!;
    
        /// <summary>Method. Stancode list 1010</summary>
        [Newtonsoft.Json.JsonProperty("method", Required = Newtonsoft.Json.Required.Always)]
        public int Method { get; set; }= default!;
    
        /// <summary>Indicates if the analysis is performed according to accreditation, e.g. DANAK or ILAC</summary>
        [Newtonsoft.Json.JsonProperty("accredited", Required = Newtonsoft.Json.Required.Always)]
        public bool Accredited { get; set; }= default!;
    
        /// <summary>Time when the measurement was performed</summary>
        [Newtonsoft.Json.JsonProperty("time", Required = Newtonsoft.Json.Required.AllowNull)]
        public System.DateTimeOffset? Time { get; set; }= default!;
    
        /// <summary>Optional attribute value. Stancode list 1077</summary>
        [Newtonsoft.Json.JsonProperty("attribute", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Attribute { get; set; }= default!;
    
        /// <summary>Measurement result value</summary>
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.Always)]
        public double Value { get; set; }= default!;
    
        /// <summary>Name of the person, company or party that performed the measurement</summary>
        [Newtonsoft.Json.JsonProperty("executor", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Executor { get; set; }= default!;
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.24.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class Observation 
    {
        /// <summary>Parameter that specifies the observation. Stancode list 1008</summary>
        [Newtonsoft.Json.JsonProperty("parameter", Required = Newtonsoft.Json.Required.Always)]
        public int Parameter { get; set; }= default!;
    
        /// <summary>Stancode list identifier, e.g. 1060 for color</summary>
        [Newtonsoft.Json.JsonProperty("stancodeList", Required = Newtonsoft.Json.Required.Always)]
        public int StancodeList { get; set; }= default!;
    
        /// <summary>Stancode value from the specified stancode list</summary>
        [Newtonsoft.Json.JsonProperty("stancode", Required = Newtonsoft.Json.Required.Always)]
        public int Stancode { get; set; }= default!;
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.24.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class AnalysisResult 
    {
        /// <summary>Analysis parameter. Stancode list 1008</summary>
        [Newtonsoft.Json.JsonProperty("parameter", Required = Newtonsoft.Json.Required.Always)]
        public int Parameter { get; set; }= default!;
    
        /// <summary>Sample fraction that indicates in which fraction the analysis was performed, e.g. total, filtration concentrate or filtered volume. Stancode list 1026</summary>
        [Newtonsoft.Json.JsonProperty("fraction", Required = Newtonsoft.Json.Required.Always)]
        public int Fraction { get; set; }= default!;
    
        /// <summary>Unit in which the analysis result is reported. Stancode list 1009</summary>
        [Newtonsoft.Json.JsonProperty("unit", Required = Newtonsoft.Json.Required.Always)]
        public int Unit { get; set; }= default!;
    
        /// <summary>Analytical method for the analysis. Stancode list 1010</summary>
        [Newtonsoft.Json.JsonProperty("method", Required = Newtonsoft.Json.Required.Always)]
        public int Method { get; set; }= default!;
    
        /// <summary>Optional attribute value. Stancode list 1077</summary>
        [Newtonsoft.Json.JsonProperty("attribute", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Attribute { get; set; }= default!;
    
        /// <summary>Analysis result value</summary>
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.Always)]
        public double Value { get; set; }= default!;
    
        /// <summary>Name of the person, company or party that performed the analysis</summary>
        [Newtonsoft.Json.JsonProperty("laboratory", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Laboratory { get; set; }= default!;
    
        /// <summary>Time when the analysis was started</summary>
        [Newtonsoft.Json.JsonProperty("time", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Time { get; set; }= default!;
    
        /// <summary>Lower limit of detection (LoD) in the specified reporting unit. The detection limit is the lowest quantity of a substance that can be distinguished from the absence of that substance</summary>
        [Newtonsoft.Json.JsonProperty("detectionLimit", Required = Newtonsoft.Json.Required.Always)]
        public double DetectionLimit { get; set; }= default!;
    
        /// <summary>Lower limit of quantification (QoD) in the specified reporting unit. The quantification limit is the limit at which the difference between two distinct values can be reasonably discerned and the analytical method cannot operate with an acceptable precision</summary>
        [Newtonsoft.Json.JsonProperty("quantificationLimit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? QuantificationLimit { get; set; }= default!;
    
        /// <summary>Expanded relative uncertainty for the analysis in the measurement range specified in the method, calibration or accreditation</summary>
        [Newtonsoft.Json.JsonProperty("relativeUncertainty", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? RelativeUncertainty { get; set; }= default!;
    
        /// <summary>Absolute uncertainty in the specified unit</summary>
        [Newtonsoft.Json.JsonProperty("absoluteUncertainty", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AbsoluteUncertainty { get; set; }= default!;
    
        /// <summary>Indicates if the analysis is performed according to accreditation, e.g. DANAK or ILAC</summary>
        [Newtonsoft.Json.JsonProperty("accredited", Required = Newtonsoft.Json.Required.Always)]
        public bool Accredited { get; set; }= default!;
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.24.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class Document 
    {
        /// <summary>Title of the document</summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Title { get; set; }= default!;
    
        /// <summary>URL of the document</summary>
        [Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Url { get; set; }= default!;
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.24.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class LaboratoryTest 
    {
        /// <summary>The laboratory's internal reference for the laboratory test</summary>
        [Newtonsoft.Json.JsonProperty("reference", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Reference { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("laboratory", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Actor Laboratory { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("applicant", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Actor Applicant { get; set; }= default!;
    
        /// <summary>Time when the sample was physically registered on the laboratory</summary>
        [Newtonsoft.Json.JsonProperty("registered", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Registered { get; set; }= default!;
    
        /// <summary>Time when the analyses were finished</summary>
        [Newtonsoft.Json.JsonProperty("finished", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Finished { get; set; }= default!;
    
        /// <summary>Storage temperature on the laboratory. Stancode list 1080</summary>
        [Newtonsoft.Json.JsonProperty("storageTemperature", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int StorageTemperature { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("analyses", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<AnalysisResult> Analyses { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("appendix", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Document? Appendix { get; set; }= default!;
    
        /// <summary>The laboratory's remarks</summary>
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
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.24.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class Sample 
    {
        /// <summary>Unique sample identifier</summary>
        [Newtonsoft.Json.JsonProperty("sampleId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid SampleId { get; set; }= default!;
    
        /// <summary>Sample label</summary>
        [Newtonsoft.Json.JsonProperty("label", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Label { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("observationFacility", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ObservationFacility ObservationFacility { get; set; }= default!;
    
        /// <summary>Additional sampling location details</summary>
        [Newtonsoft.Json.JsonProperty("location", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Location { get; set; }= default!;
    
        /// <summary>Examination purpose. Stancode list 1081</summary>
        [Newtonsoft.Json.JsonProperty("purpose", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Purpose { get; set; }= default!;
    
        /// <summary>Sample type. Stancode list 1005</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Type { get; set; }= default!;
    
        /// <summary>Sample matrix. Stancode list 1129</summary>
        [Newtonsoft.Json.JsonProperty("matrix", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Matrix { get; set; }= default!;
    
        /// <summary>Optional deep link to the system</summary>
        [Newtonsoft.Json.JsonProperty("link", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Link { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("sampling", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Sampling? Sampling { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("measurements", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<Measurement> Measurements { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("observations", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<Observation> Observations { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("laboratoryTests", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<LaboratoryTest> LaboratoryTests { get; set; }= default!;
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.24.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class SubmitSampleRequest 
    {
        /// <summary>Unique sample identifier. The system will automatically generate an id if it is not specified</summary>
        [Newtonsoft.Json.JsonProperty("sampleId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? SampleId { get; set; }= default!;
    
        /// <summary>The unique identifier of the observation facility, e.g. measurement point id or station id</summary>
        [Newtonsoft.Json.JsonProperty("observationFacilityId", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string ObservationFacilityId { get; set; }= default!;
    
        /// <summary>Additional sampling location details</summary>
        [Newtonsoft.Json.JsonProperty("location", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Location { get; set; }= default!;
    
        /// <summary>Examination purpose. Stancode list 1081</summary>
        [Newtonsoft.Json.JsonProperty("purpose", Required = Newtonsoft.Json.Required.Always)]
        public int Purpose { get; set; }= default!;
    
        /// <summary>Sample type. Stancode list 1005</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
        public int Type { get; set; }= default!;
    
        /// <summary>Sample matrix. Stancode list 1129</summary>
        [Newtonsoft.Json.JsonProperty("matrix", Required = Newtonsoft.Json.Required.Always)]
        public int Matrix { get; set; }= default!;
    
        /// <summary>Sample label</summary>
        [Newtonsoft.Json.JsonProperty("label", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Label { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("sampling", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Sampling? Sampling { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("measurements", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.List<Measurement> Measurements { get; set; } = new System.Collections.Generic.List<Measurement>();
    
        [Newtonsoft.Json.JsonProperty("observations", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.List<Observation> Observations { get; set; } = new System.Collections.Generic.List<Observation>();
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.24.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class SubmitLaboratoryTestRequest 
    {
        /// <summary>The laboratory's internal reference for the laboratory test</summary>
        [Newtonsoft.Json.JsonProperty("reference", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Reference { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("applicant", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Actor Applicant { get; set; } = new Actor();
    
        [Newtonsoft.Json.JsonProperty("laboratory", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Actor Laboratory { get; set; } = new Actor();
    
        /// <summary>Time when the sample was physically registered on the laboratory</summary>
        [Newtonsoft.Json.JsonProperty("registered", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTimeOffset Registered { get; set; }= default!;
    
        /// <summary>Time when the analyses were finished</summary>
        [Newtonsoft.Json.JsonProperty("finished", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTimeOffset Finished { get; set; }= default!;
    
        /// <summary>Storage temperature on the laboratory. Stancode list 1080</summary>
        [Newtonsoft.Json.JsonProperty("storageTemperature", Required = Newtonsoft.Json.Required.Always)]
        public int StorageTemperature { get; set; }= default!;
    
        /// <summary>The laboratory's remarks</summary>
        [Newtonsoft.Json.JsonProperty("remarks", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Remarks { get; set; }= default!;
    
        [Newtonsoft.Json.JsonProperty("analyses", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.List<AnalysisResult> Analyses { get; set; } = new System.Collections.Generic.List<AnalysisResult>();
    
        /// <summary>Base64 encoded document</summary>
        [Newtonsoft.Json.JsonProperty("appendix", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public byte[]? Appendix { get; set; }= default!;
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }

}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108