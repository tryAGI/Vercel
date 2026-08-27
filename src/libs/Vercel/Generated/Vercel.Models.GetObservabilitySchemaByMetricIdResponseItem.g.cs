
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetObservabilitySchemaByMetricIdResponseItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimensions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.GetObservabilitySchemaByMetricIdResponseItemDimension> Dimensions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Unit { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aggregations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Aggregations { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultAggregation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DefaultAggregation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetObservabilitySchemaByMetricIdResponseItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="description"></param>
        /// <param name="dimensions"></param>
        /// <param name="unit"></param>
        /// <param name="aggregations"></param>
        /// <param name="defaultAggregation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetObservabilitySchemaByMetricIdResponseItem(
            string id,
            string description,
            global::System.Collections.Generic.IList<global::Vercel.GetObservabilitySchemaByMetricIdResponseItemDimension> dimensions,
            string unit,
            global::System.Collections.Generic.IList<string> aggregations,
            string defaultAggregation)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Dimensions = dimensions ?? throw new global::System.ArgumentNullException(nameof(dimensions));
            this.Unit = unit ?? throw new global::System.ArgumentNullException(nameof(unit));
            this.Aggregations = aggregations ?? throw new global::System.ArgumentNullException(nameof(aggregations));
            this.DefaultAggregation = defaultAggregation ?? throw new global::System.ArgumentNullException(nameof(defaultAggregation));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetObservabilitySchemaByMetricIdResponseItem" /> class.
        /// </summary>
        public GetObservabilitySchemaByMetricIdResponseItem()
        {
        }

    }
}