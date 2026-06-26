#nullable enable

namespace Vercel
{
    public partial interface IWebAnalyticsClient
    {
        /// <summary>
        /// Aggregates page views<br/>
        /// Counts pageviews on a project, within the requested date range. Results are either aggregated or broken down over time. Results can additionally be broken down by one dimension, and filtered by multiple dimensions.
        /// </summary>
        /// <param name="projectId">
        /// The project identifier or the project name<br/>
        /// Example: prj_XLKmu1DyR1eY7zq8UgeRKbA7yVLA
        /// </param>
        /// <param name="by">
        /// Up to two dimensions used to break down results.<br/>
        /// At most one time granularity is allowed: hour, day, week, month, year.<br/>
        /// Other dimensions: country, deviceType, environment, requestPath, referrerHostname, osName, browserName, route, utmSource, utmMedium, utmCampaign, utmContent, utmTerm.<br/>
        /// JSON dimensions: flags. Used bare, it breaks down results by key, for example flags returns one group per flag name. With a key, it breaks down results by that key's value, for example flags/beta_banner. Wrap keys containing characters other than letters, digits, and underscores in single quotes, for example flags/'my-flag'.<br/>
        /// Example: [day, country]
        /// </param>
        /// <param name="since">
        /// Timestamp in milliseconds, or a valid Date string.<br/>
        /// Selects data from (including) this date and time.<br/>
        /// Will be adjusted according to the desired time granularity.<br/>
        /// Example: 2024-09-01T00:00:00.000Z
        /// </param>
        /// <param name="until">
        /// Timestamp in milliseconds, or a valid Date string.<br/>
        /// Selects data until (including) this date.<br/>
        /// Will be adjusted according to the desired time granularity.<br/>
        /// Example: 2024-09-08T00:00:00.000Z
        /// </param>
        /// <param name="limit">
        /// Number of distinct results, default to 10. Other results are grouped into "Others" group.<br/>
        /// Default Value: 10<br/>
        /// Example: 3
        /// </param>
        /// <param name="filter">
        /// OData-compliant filter. Encode the value when sending it in a URL.<br/>
        /// Allows filtering on one or multiple dimensions. By default, filters for production environment only.<br/>
        /// Supported dimensions: country, deviceType, environment, requestPath, referrerHostname, osName, browserName, route, utmSource, utmMedium, utmCampaign, utmContent, utmTerm.<br/>
        /// JSON dimensions filtered by key: flags/&lt;name&gt;, for example flags/beta_banner eq 'true'. Wrap keys containing characters other than letters, digits, and underscores in single quotes, for example flags/'my-flag' eq 'true'.<br/>
        /// Supported operations include eq, ne, in, and logical operators and, or, not with parentheses. Functions such as startswith are supported by the OData parser.<br/>
        /// Example: requestPath eq '/docs'
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AggregatePageviewsResponse> AggregatePageviewsAsync(
            string projectId,
            global::System.Collections.Generic.IList<global::Vercel.AnyOf<global::Vercel.AggregatePageviewsByItemEnum?, object>> by,
            global::Vercel.AnyOf<double?, string> since,
            global::Vercel.AnyOf<double?, string> until,
            int? limit = default,
            string? filter = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Aggregates page views<br/>
        /// Counts pageviews on a project, within the requested date range. Results are either aggregated or broken down over time. Results can additionally be broken down by one dimension, and filtered by multiple dimensions.
        /// </summary>
        /// <param name="projectId">
        /// The project identifier or the project name<br/>
        /// Example: prj_XLKmu1DyR1eY7zq8UgeRKbA7yVLA
        /// </param>
        /// <param name="by">
        /// Up to two dimensions used to break down results.<br/>
        /// At most one time granularity is allowed: hour, day, week, month, year.<br/>
        /// Other dimensions: country, deviceType, environment, requestPath, referrerHostname, osName, browserName, route, utmSource, utmMedium, utmCampaign, utmContent, utmTerm.<br/>
        /// JSON dimensions: flags. Used bare, it breaks down results by key, for example flags returns one group per flag name. With a key, it breaks down results by that key's value, for example flags/beta_banner. Wrap keys containing characters other than letters, digits, and underscores in single quotes, for example flags/'my-flag'.<br/>
        /// Example: [day, country]
        /// </param>
        /// <param name="since">
        /// Timestamp in milliseconds, or a valid Date string.<br/>
        /// Selects data from (including) this date and time.<br/>
        /// Will be adjusted according to the desired time granularity.<br/>
        /// Example: 2024-09-01T00:00:00.000Z
        /// </param>
        /// <param name="until">
        /// Timestamp in milliseconds, or a valid Date string.<br/>
        /// Selects data until (including) this date.<br/>
        /// Will be adjusted according to the desired time granularity.<br/>
        /// Example: 2024-09-08T00:00:00.000Z
        /// </param>
        /// <param name="limit">
        /// Number of distinct results, default to 10. Other results are grouped into "Others" group.<br/>
        /// Default Value: 10<br/>
        /// Example: 3
        /// </param>
        /// <param name="filter">
        /// OData-compliant filter. Encode the value when sending it in a URL.<br/>
        /// Allows filtering on one or multiple dimensions. By default, filters for production environment only.<br/>
        /// Supported dimensions: country, deviceType, environment, requestPath, referrerHostname, osName, browserName, route, utmSource, utmMedium, utmCampaign, utmContent, utmTerm.<br/>
        /// JSON dimensions filtered by key: flags/&lt;name&gt;, for example flags/beta_banner eq 'true'. Wrap keys containing characters other than letters, digits, and underscores in single quotes, for example flags/'my-flag' eq 'true'.<br/>
        /// Supported operations include eq, ne, in, and logical operators and, or, not with parentheses. Functions such as startswith are supported by the OData parser.<br/>
        /// Example: requestPath eq '/docs'
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.AggregatePageviewsResponse>> AggregatePageviewsAsResponseAsync(
            string projectId,
            global::System.Collections.Generic.IList<global::Vercel.AnyOf<global::Vercel.AggregatePageviewsByItemEnum?, object>> by,
            global::Vercel.AnyOf<double?, string> since,
            global::Vercel.AnyOf<double?, string> until,
            int? limit = default,
            string? filter = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}