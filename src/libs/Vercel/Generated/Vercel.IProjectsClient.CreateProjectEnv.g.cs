#nullable enable

namespace Vercel
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Create one or more environment variables<br/>
        /// Create one or more environment variables for a project by passing its `key`, `value`, `type` and `target` and by specifying the project by either passing the project `id` or `name` in the URL. If you include `upsert=true` as a query parameter, a new environment variable will not be created if it already exists but, the existing variable's value will be updated.
        /// </summary>
        /// <param name="idOrName">
        /// The unique project identifier or the project name<br/>
        /// Example: prj_XLKmu1DyR1eY7zq8UgeRKbA7yVLA
        /// </param>
        /// <param name="upsert">
        /// Allow override of environment variable if it already exists<br/>
        /// Example: true
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
        global::System.Threading.Tasks.Task<global::Vercel.CreateProjectEnvResponse> CreateProjectEnvAsync(
            string idOrName,

            global::Vercel.OneOf<global::Vercel.CreateProjectEnvRequest2, global::System.Collections.Generic.IList<global::Vercel.CreateProjectEnvRequestItem>> request,
            string? upsert = default,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create one or more environment variables<br/>
        /// Create one or more environment variables for a project by passing its `key`, `value`, `type` and `target` and by specifying the project by either passing the project `id` or `name` in the URL. If you include `upsert=true` as a query parameter, a new environment variable will not be created if it already exists but, the existing variable's value will be updated.
        /// </summary>
        /// <param name="idOrName">
        /// The unique project identifier or the project name<br/>
        /// Example: prj_XLKmu1DyR1eY7zq8UgeRKbA7yVLA
        /// </param>
        /// <param name="upsert">
        /// Allow override of environment variable if it already exists<br/>
        /// Example: true
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateProjectEnvResponse> CreateProjectEnvAsync(
            string idOrName,
            string? upsert = default,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}