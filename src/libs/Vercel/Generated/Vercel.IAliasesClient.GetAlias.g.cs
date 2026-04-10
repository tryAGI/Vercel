#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Vercel
{
    public partial interface IAliasesClient
    {
        /// <summary>
        /// Get an Alias<br/>
        /// Retrieves an Alias for the given host name or alias ID.
        /// </summary>
        /// <param name="from">
        /// Get the alias only if it was created after the provided timestamp<br/>
        /// Example: 1540095775951L
        /// </param>
        /// <param name="idOrAlias">
        /// The alias or alias ID to be retrieved<br/>
        /// Example: example.vercel.app
        /// </param>
        /// <param name="projectId">
        /// Get the alias only if it is assigned to the provided project ID<br/>
        /// Example: prj_12HKQaOmR5t5Uy6vdcQsNIiZgHGB
        /// </param>
        /// <param name="since">
        /// Get the alias only if it was created after this JavaScript timestamp<br/>
        /// Example: 1540095775941L
        /// </param>
        /// <param name="until">
        /// Get the alias only if it was created before this JavaScript timestamp<br/>
        /// Example: 1540095775951L
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
        global::System.Threading.Tasks.Task<global::Vercel.GetAliasResponse> GetAliasAsync(
            string idOrAlias,
            double? from = default,
            string? projectId = default,
            double? since = default,
            double? until = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}