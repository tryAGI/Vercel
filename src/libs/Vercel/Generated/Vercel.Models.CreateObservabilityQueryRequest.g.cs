
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateObservabilityQueryRequest
    {
        /// <summary>
        /// Metric id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Metric { get; set; }

        /// <summary>
        /// Owner or project scope for the query
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Scope { get; set; }

        /// <summary>
        /// Aggregation function to apply. Some aggregations require a dimension: use &lt;agg&gt;/&lt;dimension&gt;, for example unique/visitor_id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aggregation")]
        public string? Aggregation { get; set; }

        /// <summary>
        /// Dimensions to group results by. JSON dimensions support nested refs, for example event_data/checkout_step. Nested keys containing characters that OData cannot parse as an identifier, such as '-', spaces, quotes, or '/', must be wrapped in single quotes (escape embedded single quotes by doubling them), for example flags/'enable-comments-view' or event_data/'some property''s/value'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groupBy")]
        public global::System.Collections.Generic.IList<string>? GroupBy { get; set; }

        /// <summary>
        /// Filter to apply to the query. JSON dimensions support nested refs, for example event_data/checkout_step eq 'payment'. Nested keys containing characters that OData cannot parse as an identifier, such as '-', spaces, quotes, or '/', must be wrapped in single quotes (escape embedded single quotes by doubling them), for example flags/'enable-comments-view' eq true or event_data/'some property''s/value' eq true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public string? Filter { get; set; }

        /// <summary>
        /// Maximum number of results
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public double? Limit { get; set; }

        /// <summary>
        /// Rollup column to order grouped results by. Use the generated rollup key for the requested metric and aggregation. Defaults to the query engine count rollup.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orderBy")]
        public string? OrderBy { get; set; }

        /// <summary>
        /// Direction to order grouped results by. Defaults to desc.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orderDirection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateObservabilityQueryRequestOrderDirectionJsonConverter))]
        public global::Vercel.CreateObservabilityQueryRequestOrderDirection? OrderDirection { get; set; }

        /// <summary>
        /// Time bucket size
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("granularity")]
        public object? Granularity { get; set; }

        /// <summary>
        /// Start timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startTime")]
        public string? StartTime { get; set; }

        /// <summary>
        /// End timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endTime")]
        public string? EndTime { get; set; }

        /// <summary>
        /// IANA timezone (e.g. Europe/Paris) used only to align calendar buckets (1d/1mo) to that zone's day/month boundaries. startTime/endTime and all output timestamps are always UTC. No effect on sub-day granularities.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucketTimezone")]
        public string? BucketTimezone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateObservabilityQueryRequest" /> class.
        /// </summary>
        /// <param name="metric">
        /// Metric id
        /// </param>
        /// <param name="scope">
        /// Owner or project scope for the query
        /// </param>
        /// <param name="aggregation">
        /// Aggregation function to apply. Some aggregations require a dimension: use &lt;agg&gt;/&lt;dimension&gt;, for example unique/visitor_id.
        /// </param>
        /// <param name="groupBy">
        /// Dimensions to group results by. JSON dimensions support nested refs, for example event_data/checkout_step. Nested keys containing characters that OData cannot parse as an identifier, such as '-', spaces, quotes, or '/', must be wrapped in single quotes (escape embedded single quotes by doubling them), for example flags/'enable-comments-view' or event_data/'some property''s/value'.
        /// </param>
        /// <param name="filter">
        /// Filter to apply to the query. JSON dimensions support nested refs, for example event_data/checkout_step eq 'payment'. Nested keys containing characters that OData cannot parse as an identifier, such as '-', spaces, quotes, or '/', must be wrapped in single quotes (escape embedded single quotes by doubling them), for example flags/'enable-comments-view' eq true or event_data/'some property''s/value' eq true.
        /// </param>
        /// <param name="limit">
        /// Maximum number of results
        /// </param>
        /// <param name="orderBy">
        /// Rollup column to order grouped results by. Use the generated rollup key for the requested metric and aggregation. Defaults to the query engine count rollup.
        /// </param>
        /// <param name="orderDirection">
        /// Direction to order grouped results by. Defaults to desc.
        /// </param>
        /// <param name="granularity">
        /// Time bucket size
        /// </param>
        /// <param name="startTime">
        /// Start timestamp
        /// </param>
        /// <param name="endTime">
        /// End timestamp
        /// </param>
        /// <param name="bucketTimezone">
        /// IANA timezone (e.g. Europe/Paris) used only to align calendar buckets (1d/1mo) to that zone's day/month boundaries. startTime/endTime and all output timestamps are always UTC. No effect on sub-day granularities.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateObservabilityQueryRequest(
            string metric,
            object scope,
            string? aggregation,
            global::System.Collections.Generic.IList<string>? groupBy,
            string? filter,
            double? limit,
            string? orderBy,
            global::Vercel.CreateObservabilityQueryRequestOrderDirection? orderDirection,
            object? granularity,
            string? startTime,
            string? endTime,
            string? bucketTimezone)
        {
            this.Metric = metric ?? throw new global::System.ArgumentNullException(nameof(metric));
            this.Scope = scope ?? throw new global::System.ArgumentNullException(nameof(scope));
            this.Aggregation = aggregation;
            this.GroupBy = groupBy;
            this.Filter = filter;
            this.Limit = limit;
            this.OrderBy = orderBy;
            this.OrderDirection = orderDirection;
            this.Granularity = granularity;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.BucketTimezone = bucketTimezone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateObservabilityQueryRequest" /> class.
        /// </summary>
        public CreateObservabilityQueryRequest()
        {
        }

    }
}