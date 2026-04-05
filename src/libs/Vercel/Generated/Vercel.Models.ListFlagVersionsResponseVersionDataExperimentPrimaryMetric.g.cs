
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListFlagVersionsResponseVersionDataExperimentPrimaryMetric
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ListFlagVersionsResponseVersionDataExperimentPrimaryMetricMetricTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.ListFlagVersionsResponseVersionDataExperimentPrimaryMetricMetricType MetricType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metricUnit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ListFlagVersionsResponseVersionDataExperimentPrimaryMetricMetricUnitJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.ListFlagVersionsResponseVersionDataExperimentPrimaryMetricMetricUnit MetricUnit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("directionality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ListFlagVersionsResponseVersionDataExperimentPrimaryMetricDirectionalityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.ListFlagVersionsResponseVersionDataExperimentPrimaryMetricDirectionality Directionality { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListFlagVersionsResponseVersionDataExperimentPrimaryMetric" /> class.
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
        public ListFlagVersionsResponseVersionDataExperimentPrimaryMetric(
            string name,
            global::Vercel.ListFlagVersionsResponseVersionDataExperimentPrimaryMetricMetricType metricType,
            global::Vercel.ListFlagVersionsResponseVersionDataExperimentPrimaryMetricMetricUnit metricUnit,
            global::Vercel.ListFlagVersionsResponseVersionDataExperimentPrimaryMetricDirectionality directionality,
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
        /// Initializes a new instance of the <see cref="ListFlagVersionsResponseVersionDataExperimentPrimaryMetric" /> class.
        /// </summary>
        public ListFlagVersionsResponseVersionDataExperimentPrimaryMetric()
        {
        }
    }
}