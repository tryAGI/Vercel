#nullable enable

namespace Vercel
{
    public partial interface IVercelClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CreateObservabilityQueryAsync(

            global::Vercel.CreateObservabilityQueryRequest request,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<string>> CreateObservabilityQueryAsResponseAsync(

            global::Vercel.CreateObservabilityQueryRequest request,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CreateObservabilityQueryAsync(
            string metric,
            object scope,
            string? aggregation = default,
            global::System.Collections.Generic.IList<string>? groupBy = default,
            string? filter = default,
            double? limit = default,
            string? orderBy = default,
            global::Vercel.CreateObservabilityQueryRequestOrderDirection? orderDirection = default,
            object? granularity = default,
            string? startTime = default,
            string? endTime = default,
            string? bucketTimezone = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}