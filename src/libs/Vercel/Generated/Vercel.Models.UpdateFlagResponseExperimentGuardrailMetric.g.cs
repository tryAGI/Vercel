
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateFlagResponseExperimentGuardrailMetric
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metricFormula")]
        public string? MetricFormula { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metricType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateFlagResponseExperimentGuardrailMetricMetricTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateFlagResponseExperimentGuardrailMetricMetricType MetricType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metricUnit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateFlagResponseExperimentGuardrailMetricMetricUnitJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateFlagResponseExperimentGuardrailMetricMetricUnit MetricUnit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("directionality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateFlagResponseExperimentGuardrailMetricDirectionalityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateFlagResponseExperimentGuardrailMetricDirectionality Directionality { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFlagResponseExperimentGuardrailMetric" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="metricType"></param>
        /// <param name="metricUnit"></param>
        /// <param name="directionality"></param>
        /// <param name="description"></param>
        /// <param name="metricFormula"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateFlagResponseExperimentGuardrailMetric(
            string name,
            global::Vercel.UpdateFlagResponseExperimentGuardrailMetricMetricType metricType,
            global::Vercel.UpdateFlagResponseExperimentGuardrailMetricMetricUnit metricUnit,
            global::Vercel.UpdateFlagResponseExperimentGuardrailMetricDirectionality directionality,
            string? description,
            string? metricFormula)
        {
            this.Description = description;
            this.MetricFormula = metricFormula;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.MetricType = metricType;
            this.MetricUnit = metricUnit;
            this.Directionality = directionality;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFlagResponseExperimentGuardrailMetric" /> class.
        /// </summary>
        public UpdateFlagResponseExperimentGuardrailMetric()
        {
        }
    }
}