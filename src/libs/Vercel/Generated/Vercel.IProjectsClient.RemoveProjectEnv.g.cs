#nullable enable

namespace Vercel
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Remove an environment variable<br/>
        /// Delete a specific environment variable for a given project by passing the environment variable identifier and either passing the project `id` or `name` in the URL.
        /// </summary>
        /// <param name="idOrName">
        /// The unique project identifier or the project name<br/>
        /// Example: prj_XLKmu1DyR1eY7zq8UgeRKbA7yVLA
        /// </param>
        /// <param name="id">
        /// The unique environment variable identifier<br/>
        /// Example: XMbOEya1gUUO1ir4
        /// </param>
        /// <param name="customEnvironmentId">
        /// The unique custom environment identifier within the project<br/>
        /// Example: env_123abc4567
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
        global::System.Threading.Tasks.Task<global::Vercel.OneOf<global::System.Collections.Generic.IList<global::Vercel.RemoveProjectEnvResponseVariant1Item>, global::Vercel.RemoveProjectEnvResponseVariant2, global::Vercel.RemoveProjectEnvResponseVariant3>> RemoveProjectEnvAsync(
            string idOrName,
            string id,
            string? customEnvironmentId = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}