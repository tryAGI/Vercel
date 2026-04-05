
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FlagExperimentPrimaryMetric
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.FlagExperimentPrimaryMetricMetricTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.FlagExperimentPrimaryMetricMetricType MetricType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metricUnit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.FlagExperimentPrimaryMetricMetricUnitJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.FlagExperimentPrimaryMetricMetricUnit MetricUnit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("directionality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.FlagExperimentPrimaryMetricDirectionalityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.FlagExperimentPrimaryMetricDirectionality Directionality { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FlagExperimentPrimaryMetric" /> class.
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
        public FlagExperimentPrimaryMetric(
            string name,
            global::Vercel.FlagExperimentPrimaryMetricMetricType metricType,
            global::Vercel.FlagExperimentPrimaryMetricMetricUnit metricUnit,
            global::Vercel.FlagExperimentPrimaryMetricDirectionality directionality,
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
        /// Initializes a new instance of the <see cref="FlagExperimentPrimaryMetric" /> class.
        /// </summary>
        public FlagExperimentPrimaryMetric()
        {
        }
    }
}