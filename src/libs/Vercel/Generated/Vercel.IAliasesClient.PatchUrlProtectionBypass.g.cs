#nullable enable

namespace Vercel
{
    public partial interface IAliasesClient
    {
        /// <summary>
        /// Update the protection bypass for a URL<br/>
        /// Update the protection bypass for the alias or deployment URL (used for user access &amp; comment access for deployments). Used as shareable links and user scoped access for Vercel Authentication and also to allow external (logged in) people to comment on previews for Preview Comments (next-live-mode).
        /// </summary>
        /// <param name="id">
        /// The alias or deployment ID
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
        global::System.Threading.Tasks.Task<string> PatchUrlProtectionBypassAsync(
            string id,

            global::Vercel.OneOf<global::Vercel.PatchUrlProtectionBypassRequestVariant1, global::Vercel.PatchUrlProtectionBypassRequestVariant2, global::Vercel.PatchUrlProtectionBypassRequestVariant3> request,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update the protection bypass for a URL<br/>
        /// Update the protection bypass for the alias or deployment URL (used for user access &amp; comment access for deployments). Used as shareable links and user scoped access for Vercel Authentication and also to allow external (logged in) people to comment on previews for Preview Comments (next-live-mode).
        /// </summary>
        /// <param name="id">
        /// The alias or deployment ID
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> PatchUrlProtectionBypassAsync(
            string id,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}