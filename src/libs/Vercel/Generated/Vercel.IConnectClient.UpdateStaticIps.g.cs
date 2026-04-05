#nullable enable

namespace Vercel
{
    public partial interface IConnectClient
    {
        /// <summary>
        /// Configures Static IPs for a project<br/>
        /// Allows configuring Static IPs for a project
        /// </summary>
        /// <param name="idOrName">
        /// The unique project identifier or the project name
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Vercel.UpdateStaticIpsResponseItem>> UpdateStaticIpsAsync(
            string idOrName,

            global::Vercel.UpdateStaticIpsRequest request,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Configures Static IPs for a project<br/>
        /// Allows configuring Static IPs for a project
        /// </summary>
        /// <param name="idOrName">
        /// The unique project identifier or the project name
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="builds">
        /// Whether to use Static IPs for builds.
        /// </param>
        /// <param name="regions"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Vercel.UpdateStaticIpsResponseItem>> UpdateStaticIpsAsync(
            string idOrName,
            string? teamId = default,
            string? slug = default,
            bool? builds = default,
            global::System.Collections.Generic.IList<string>? regions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}