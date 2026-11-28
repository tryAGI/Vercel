#nullable enable

namespace Vercel
{
    public partial interface IFeatureFlagsClient
    {
        /// <summary>
        /// Sign flag overrides<br/>
        /// Signs flag overrides for the `vercel-flag-overrides` cookie, which the Flags SDK accepts without a `FLAGS_SECRET`. The overrides apply to one environment of the project and of the projects that share its microfrontends groups. An access token requires permission to read the project and an `environment`. A Vercel OIDC token signs only for its own project and environment.
        /// </summary>
        /// <param name="projectIdOrName">
        /// The project id or name
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.SignFlagOverridesResponse> SignFlagOverridesAsync(
            string projectIdOrName,

            global::Vercel.SignFlagOverridesRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Sign flag overrides<br/>
        /// Signs flag overrides for the `vercel-flag-overrides` cookie, which the Flags SDK accepts without a `FLAGS_SECRET`. The overrides apply to one environment of the project and of the projects that share its microfrontends groups. An access token requires permission to read the project and an `environment`. A Vercel OIDC token signs only for its own project and environment.
        /// </summary>
        /// <param name="projectIdOrName">
        /// The project id or name
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.SignFlagOverridesResponse>> SignFlagOverridesAsResponseAsync(
            string projectIdOrName,

            global::Vercel.SignFlagOverridesRequest request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Sign flag overrides<br/>
        /// Signs flag overrides for the `vercel-flag-overrides` cookie, which the Flags SDK accepts without a `FLAGS_SECRET`. The overrides apply to one environment of the project and of the projects that share its microfrontends groups. An access token requires permission to read the project and an `environment`. A Vercel OIDC token signs only for its own project and environment.
        /// </summary>
        /// <param name="projectIdOrName">
        /// The project id or name
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="overrides">
        /// The value of each overridden flag, by flag key
        /// </param>
        /// <param name="environment">
        /// production, preview, development or the slug of a custom environment. Defaults to the environment of a Vercel OIDC token.
        /// </param>
        /// <param name="ttl">
        /// Seconds until the overrides expire. Defaults to one hour, at most one day.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.SignFlagOverridesResponse> SignFlagOverridesAsync(
            string projectIdOrName,
            object overrides,
            string? teamId = default,
            string? slug = default,
            string? environment = default,
            int? ttl = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}