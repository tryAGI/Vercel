#nullable enable

namespace Vercel
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Retrieve a list of projects<br/>
        /// Allows to retrieve the list of projects of the authenticated user or team. The list will be paginated and the provided query parameters allow filtering the returned projects.
        /// </summary>
        /// <param name="from">
        /// Query only projects updated after the given timestamp or continuation token.
        /// </param>
        /// <param name="gitForkProtection">
        /// Specifies whether PRs from Git forks should require a team member's authorization before it can be deployed<br/>
        /// Example: 1
        /// </param>
        /// <param name="limit">
        /// Limit the number of projects returned
        /// </param>
        /// <param name="search">
        /// Search projects by the name field
        /// </param>
        /// <param name="repo">
        /// Filter results by repo. Also used for project count
        /// </param>
        /// <param name="repoId">
        /// Filter results by Repository ID.
        /// </param>
        /// <param name="repoUrl">
        /// Filter results by Repository URL.<br/>
        /// Example: https://github.com/vercel/next.js
        /// </param>
        /// <param name="excludeRepos">
        /// Filter results by excluding those projects that belong to a repo
        /// </param>
        /// <param name="edgeConfigId">
        /// Filter results by connected Edge Config ID
        /// </param>
        /// <param name="edgeConfigTokenId">
        /// Filter results by connected Edge Config Token ID
        /// </param>
        /// <param name="deprecated"></param>
        /// <param name="elasticConcurrencyEnabled">
        /// Filter results by projects with elastic concurrency enabled<br/>
        /// Example: 1
        /// </param>
        /// <param name="staticIpsEnabled">
        /// Filter results by projects with Static IPs enabled<br/>
        /// Example: 1
        /// </param>
        /// <param name="buildMachineTypes">
        /// Filter results by build machine types. Accepts comma-separated values. Use \"default\" for projects without a build machine type set.<br/>
        /// Example: default,enhanced
        /// </param>
        /// <param name="buildQueueConfiguration">
        /// Filter results by build queue configuration. SKIP_NAMESPACE_QUEUE includes projects without a configuration set.<br/>
        /// Example: SKIP_NAMESPACE_QUEUE
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.OneOf<global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant1Item>, global::Vercel.GetProjectsResponseVariant2, global::Vercel.GetProjectsResponseVariant3>> GetProjectsAsync(
            string? from = default,
            global::Vercel.GetProjectsGitForkProtection? gitForkProtection = default,
            string? limit = default,
            string? search = default,
            string? repo = default,
            string? repoId = default,
            string? repoUrl = default,
            string? excludeRepos = default,
            string? edgeConfigId = default,
            string? edgeConfigTokenId = default,
            bool? deprecated = default,
            global::Vercel.GetProjectsElasticConcurrencyEnabled? elasticConcurrencyEnabled = default,
            global::Vercel.GetProjectsStaticIpsEnabled? staticIpsEnabled = default,
            string? buildMachineTypes = default,
            global::Vercel.GetProjectsBuildQueueConfiguration? buildQueueConfiguration = default,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}