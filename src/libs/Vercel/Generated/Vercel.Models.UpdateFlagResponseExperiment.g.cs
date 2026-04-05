
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateFlagResponseExperiment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numVariants")]
        public double? NumVariants { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("surfaceArea")]
        public string? SurfaceArea { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stickyRequirement")]
        public bool? StickyRequirement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("layer")]
        public string? Layer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrailMetrics")]
        public global::System.Collections.Generic.IList<global::Vercel.UpdateFlagResponseExperimentGuardrailMetric>? GuardrailMetrics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hypothesis")]
        public string? Hypothesis { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("device")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateFlagResponseExperimentDeviceJsonConverter))]
        public global::Vercel.UpdateFlagResponseExperimentDevice? Device { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("controlVariantId")]
        public string? ControlVariantId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startedAt")]
        public double? StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endedAt")]
        public double? EndedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allocationUnit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateFlagResponseExperimentAllocationUnitJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateFlagResponseExperimentAllocationUnit AllocationUnit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primaryMetrics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.UpdateFlagResponseExperimentPrimaryMetric> PrimaryMetrics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateFlagResponseExperimentStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateFlagResponseExperimentStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFlagResponseExperiment" /> class.
        /// </summary>
        /// <param name="allocationUnit"></param>
        /// <param name="primaryMetrics"></param>
        /// <param name="status"></param>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <param name="numVariants"></param>
        /// <param name="surfaceArea"></param>
        /// <param name="stickyRequirement"></param>
        /// <param name="layer"></param>
        /// <param name="guardrailMetrics"></param>
        /// <param name="hypothesis"></param>
        /// <param name="device"></param>
        /// <param name="controlVariantId"></param>
        /// <param name="startedAt"></param>
        /// <param name="endedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateFlagResponseExperiment(
            global::Vercel.UpdateFlagResponseExperimentAllocationUnit allocationUnit,
            global::System.Collections.Generic.IList<global::Vercel.UpdateFlagResponseExperimentPrimaryMetric> primaryMetrics,
            global::Vercel.UpdateFlagResponseExperimentStatus status,
            string? name,
            string? id,
            double? numVariants,
            string? surfaceArea,
            bool? stickyRequirement,
            string? layer,
            global::System.Collections.Generic.IList<global::Vercel.UpdateFlagResponseExperimentGuardrailMetric>? guardrailMetrics,
            string? hypothesis,
            global::Vercel.UpdateFlagResponseExperimentDevice? device,
            string? controlVariantId,
            double? startedAt,
            double? endedAt)
        {
            this.Name = name;
            this.Id = id;
            this.NumVariants = numVariants;
            this.SurfaceArea = surfaceArea;
            this.StickyRequirement = stickyRequirement;
            this.Layer = layer;
            this.GuardrailMetrics = guardrailMetrics;
            this.Hypothesis = hypothesis;
            this.Device = device;
            this.ControlVariantId = controlVariantId;
            this.StartedAt = startedAt;
            this.EndedAt = endedAt;
            this.AllocationUnit = allocationUnit;
            this.PrimaryMetrics = primaryMetrics ?? throw new global::System.ArgumentNullException(nameof(primaryMetrics));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFlagResponseExperiment" /> class.
        /// </summary>
        public UpdateFlagResponseExperiment()
        {
        }
    }
}