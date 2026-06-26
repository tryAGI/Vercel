#nullable enable

namespace Vercel
{
    public partial interface IWebAnalyticsClient
    {
        /// <summary>
        /// Counts page views<br/>
        /// Counts the number of page views on a project (production only), since Web Analytics was enabled. Results can be filtered on supported dimensions.
        /// </summary>
        /// <param name="projectId">
        /// The project identifier or the project name<br/>
        /// Example: prj_XLKmu1DyR1eY7zq8UgeRKbA7yVLA
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
        /// <param name="filter">
        /// OData-compliant filter. Encode the value when sending it in a URL.<br/>
        /// Allows filtering on one or multiple dimensions.<br/>
        /// Supported dimensions: country, deviceType, environment, requestPath, referrerHostname, osName, browserName, route, utmSource, utmMedium, utmCampaign, utmContent, utmTerm.<br/>
        /// JSON dimensions filtered by key: flags/&lt;name&gt;, for example flags/beta_banner eq 'true'. Wrap keys containing characters other than letters, digits, and underscores in single quotes, for example flags/'my-flag' eq 'true'.<br/>
        /// Supported operations include eq, ne, in, and logical operators and, or, not with parentheses. Functions such as startswith are supported by the OData parser.<br/>
        /// Example: route eq '/home'
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
        global::System.Threading.Tasks.Task<global::Vercel.CountPageviewsResponse> CountPageviewsAsync(
            string projectId,
            global::Vercel.AnyOf<double?, string>? since = default,
            global::Vercel.AnyOf<double?, string>? until = default,
            string? filter = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Counts page views<br/>
        /// Counts the number of page views on a project (production only), since Web Analytics was enabled. Results can be filtered on supported dimensions.
        /// </summary>
        /// <param name="projectId">
        /// The project identifier or the project name<br/>
        /// Example: prj_XLKmu1DyR1eY7zq8UgeRKbA7yVLA
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
        /// <param name="filter">
        /// OData-compliant filter. Encode the value when sending it in a URL.<br/>
        /// Allows filtering on one or multiple dimensions.<br/>
        /// Supported dimensions: country, deviceType, environment, requestPath, referrerHostname, osName, browserName, route, utmSource, utmMedium, utmCampaign, utmContent, utmTerm.<br/>
        /// JSON dimensions filtered by key: flags/&lt;name&gt;, for example flags/beta_banner eq 'true'. Wrap keys containing characters other than letters, digits, and underscores in single quotes, for example flags/'my-flag' eq 'true'.<br/>
        /// Supported operations include eq, ne, in, and logical operators and, or, not with parentheses. Functions such as startswith are supported by the OData parser.<br/>
        /// Example: route eq '/home'
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.CountPageviewsResponse>> CountPageviewsAsResponseAsync(
            string projectId,
            global::Vercel.AnyOf<double?, string>? since = default,
            global::Vercel.AnyOf<double?, string>? until = default,
            string? filter = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}