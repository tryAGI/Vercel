#nullable enable

namespace Vercel
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Edit an environment variable<br/>
        /// Edit a specific environment variable for a given project by passing the environment variable identifier and either passing the project `id` or `name` in the URL.
        /// </summary>
        /// <param name="idOrName">
        /// The unique project identifier or the project name<br/>
        /// Example: prj_XLKmu1DyR1eY7zq8UgeRKbA7yVLA
        /// </param>
        /// <param name="id">
        /// The unique environment variable identifier<br/>
        /// Example: XMbOEya1gUUO1ir4
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
        global::System.Threading.Tasks.Task<global::Vercel.EditProjectEnvResponse> EditProjectEnvAsync(
            string idOrName,
            string id,

            global::Vercel.EditProjectEnvRequest request,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit an environment variable<br/>
        /// Edit a specific environment variable for a given project by passing the environment variable identifier and either passing the project `id` or `name` in the URL.
        /// </summary>
        /// <param name="idOrName">
        /// The unique project identifier or the project name<br/>
        /// Example: prj_XLKmu1DyR1eY7zq8UgeRKbA7yVLA
        /// </param>
        /// <param name="id">
        /// The unique environment variable identifier<br/>
        /// Example: XMbOEya1gUUO1ir4
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="key">
        /// The name of the environment variable<br/>
        /// Example: GITHUB_APP_ID
        /// </param>
        /// <param name="target">
        /// The target environment of the environment variable<br/>
        /// Example: [preview]
        /// </param>
        /// <param name="gitBranch">
        /// If defined, the git branch of the environment variable (must have target=preview)<br/>
        /// Example: feature-1
        /// </param>
        /// <param name="type">
        /// The type of environment variable<br/>
        /// Example: plain
        /// </param>
        /// <param name="value">
        /// The value of the environment variable<br/>
        /// Example: bkWIjbnxcvo78
        /// </param>
        /// <param name="customEnvironmentIds">
        /// The custom environments that the environment variable should be synced to
        /// </param>
        /// <param name="comment">
        /// A comment to add context on what this env var is for<br/>
        /// Example: database connection string for production
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.EditProjectEnvResponse> EditProjectEnvAsync(
            string idOrName,
            string id,
            string? teamId = default,
            string? slug = default,
            string? key = default,
            global::System.Collections.Generic.IList<global::Vercel.EditProjectEnvRequestTargetItem>? target = default,
            string? gitBranch = default,
            global::Vercel.EditProjectEnvRequestType? type = default,
            string? value = default,
            global::System.Collections.Generic.IList<string>? customEnvironmentIds = default,
            string? comment = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}