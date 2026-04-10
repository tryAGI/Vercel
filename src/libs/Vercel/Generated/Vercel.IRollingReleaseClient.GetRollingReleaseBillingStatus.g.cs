#nullable enable

namespace Vercel
{
    public partial interface IRollingReleaseClient
    {
        /// <summary>
        /// Get rolling release billing status<br/>
        /// Get the Rolling Releases billing status for a project. The team level billing status is used to determine if the project can be configured for rolling releases.
        /// </summary>
        /// <param name="idOrName">
        /// Project ID or project name (URL-encoded)
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
        global::System.Threading.Tasks.Task<global::Vercel.OneOf<global::Vercel.GetRollingReleaseBillingStatusResponseVariant1, global::Vercel.GetRollingReleaseBillingStatusResponseVariant2, global::Vercel.GetRollingReleaseBillingStatusResponseVariant3, global::Vercel.GetRollingReleaseBillingStatusResponseVariant4>> GetRollingReleaseBillingStatusAsync(
            string idOrName,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}