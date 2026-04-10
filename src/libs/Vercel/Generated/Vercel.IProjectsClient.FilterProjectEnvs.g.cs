#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Vercel
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Retrieve the environment variables of a project by id or name<br/>
        /// Retrieve the environment variables for a given project by passing either the project `id` or `name` in the URL.
        /// </summary>
        /// <param name="idOrName">
        /// The unique project identifier or the project name<br/>
        /// Example: prj_XLKmu1DyR1eY7zq8UgeRKbA7yVLA
        /// </param>
        /// <param name="gitBranch">
        /// If defined, the git branch of the environment variable to filter the results (must have target=preview)<br/>
        /// Example: feature-1
        /// </param>
        /// <param name="decrypt">
        /// If true, the environment variable value will be decrypted<br/>
        /// Example: true
        /// </param>
        /// <param name="source">
        /// The source that is calling the endpoint.<br/>
        /// Example: vercel-cli:pull
        /// </param>
        /// <param name="customEnvironmentId">
        /// The unique custom environment identifier within the project<br/>
        /// Example: env_123abc4567
        /// </param>
        /// <param name="customEnvironmentSlug">
        /// The custom environment slug (name) within the project<br/>
        /// Example: my-custom-env
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
        global::System.Threading.Tasks.Task<global::Vercel.OneOf<global::Vercel.FilterProjectEnvsResponseVariant1, global::Vercel.FilterProjectEnvsResponseVariant2, global::Vercel.FilterProjectEnvsResponseVariant3>> FilterProjectEnvsAsync(
            string idOrName,
            string? gitBranch = default,
            global::Vercel.FilterProjectEnvsDecrypt? decrypt = default,
            string? source = default,
            string? customEnvironmentId = default,
            string? customEnvironmentSlug = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}