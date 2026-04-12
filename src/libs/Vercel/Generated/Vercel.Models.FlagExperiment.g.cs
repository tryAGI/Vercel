
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FlagExperiment
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
        public global::System.Collections.Generic.IList<global::Vercel.FlagExperimentGuardrailMetric>? GuardrailMetrics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hypothesis")]
        public string? Hypothesis { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("device")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.FlagExperimentDeviceJsonConverter))]
        public global::Vercel.FlagExperimentDevice? Device { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("decision")]
        public string? Decision { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("decisionReason")]
        public string? DecisionReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("durationUnit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.FlagExperimentDurationUnitJsonConverter))]
        public global::Vercel.FlagExperimentDurationUnit? DurationUnit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allocationPercent")]
        public double? AllocationPercent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allocationUnit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.FlagExperimentAllocationUnitJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.FlagExperimentAllocationUnit AllocationUnit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primaryMetrics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.FlagExperimentPrimaryMetric> PrimaryMetrics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.FlagExperimentStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.FlagExperimentStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FlagExperiment" /> class.
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
        /// <param name="decision"></param>
        /// <param name="decisionReason"></param>
        /// <param name="duration"></param>
        /// <param name="durationUnit"></param>
        /// <param name="allocationPercent"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FlagExperiment(
            global::Vercel.FlagExperimentAllocationUnit allocationUnit,
            global::System.Collections.Generic.IList<global::Vercel.FlagExperimentPrimaryMetric> primaryMetrics,
            global::Vercel.FlagExperimentStatus status,
            string? name,
            string? id,
            double? numVariants,
            string? surfaceArea,
            bool? stickyRequirement,
            string? layer,
            global::System.Collections.Generic.IList<global::Vercel.FlagExperimentGuardrailMetric>? guardrailMetrics,
            string? hypothesis,
            global::Vercel.FlagExperimentDevice? device,
            string? controlVariantId,
            double? startedAt,
            double? endedAt,
            string? decision,
            string? decisionReason,
            double? duration,
            global::Vercel.FlagExperimentDurationUnit? durationUnit,
            double? allocationPercent)
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
            this.Decision = decision;
            this.DecisionReason = decisionReason;
            this.Duration = duration;
            this.DurationUnit = durationUnit;
            this.AllocationPercent = allocationPercent;
            this.AllocationUnit = allocationUnit;
            this.PrimaryMetrics = primaryMetrics ?? throw new global::System.ArgumentNullException(nameof(primaryMetrics));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FlagExperiment" /> class.
        /// </summary>
        public FlagExperiment()
        {
        }
    }
}