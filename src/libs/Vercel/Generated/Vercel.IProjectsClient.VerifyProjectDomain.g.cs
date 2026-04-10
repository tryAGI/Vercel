#nullable enable

namespace Vercel
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Verify project domain<br/>
        /// Attempts to verify a project domain with `verified = false` by checking the correctness of the project domain's `verification` challenge.
        /// </summary>
        /// <param name="idOrName">
        /// The unique project identifier or the project name<br/>
        /// Example: prj_12HKQaOmR5t5Uy6vdcQsNIiZgHGB
        /// </param>
        /// <param name="domain">
        /// The domain name you want to verify<br/>
        /// Example: example.com
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
        global::System.Threading.Tasks.Task<global::Vercel.VerifyProjectDomainResponse> VerifyProjectDomainAsync(
            string idOrName,
            string domain,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}