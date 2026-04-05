#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Vercel
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Create a new project<br/>
        /// Allows to create a new project with the provided configuration. It only requires the project `name` but more configuration can be provided to override the defaults.
        /// </summary>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateProjectResponse> CreateProjectAsync(

            global::Vercel.CreateProjectRequest request,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new project<br/>
        /// Allows to create a new project with the provided configuration. It only requires the project `name` but more configuration can be provided to override the defaults.
        /// </summary>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="enablePreviewFeedback">
        /// Opt-in to preview toolbar on the project level
        /// </param>
        /// <param name="enableProductionFeedback">
        /// Opt-in to production toolbar on the project level
        /// </param>
        /// <param name="previewDeploymentsDisabled">
        /// Specifies whether preview deployments are disabled for this project.
        /// </param>
        /// <param name="previewDeploymentSuffix">
        /// Custom domain suffix for preview deployments. Takes precedence over team-level suffix. Must be a domain owned by the team.
        /// </param>
        /// <param name="buildCommand">
        /// The build command for this project. When `null` is used this value will be automatically detected
        /// </param>
        /// <param name="commandForIgnoringBuildStep"></param>
        /// <param name="devCommand">
        /// The dev command for this project. When `null` is used this value will be automatically detected
        /// </param>
        /// <param name="environmentVariables">
        /// Collection of ENV Variables the Project will use
        /// </param>
        /// <param name="framework">
        /// The framework that is being used for this project. When `null` is used no framework is selected
        /// </param>
        /// <param name="gitRepository">
        /// The Git Repository that will be connected to the project. When this is defined, any pushes to the specified connected Git Repository will be automatically deployed
        /// </param>
        /// <param name="installCommand">
        /// The install command for this project. When `null` is used this value will be automatically detected
        /// </param>
        /// <param name="name">
        /// The desired name for the project<br/>
        /// Example: a-project-name
        /// </param>
        /// <param name="ssoProtection">
        /// The Vercel Auth setting for the project (historically named \"SSO Protection\")
        /// </param>
        /// <param name="outputDirectory">
        /// The output directory of the project. When `null` is used this value will be automatically detected
        /// </param>
        /// <param name="publicSource">
        /// Specifies whether the source code and logs of the deployments for this project should be public or not
        /// </param>
        /// <param name="rootDirectory">
        /// The name of a directory or relative path to the source code of your project. When `null` is used it will default to the project root
        /// </param>
        /// <param name="serverlessFunctionRegion">
        /// The region to deploy Serverless Functions in this project
        /// </param>
        /// <param name="serverlessFunctionZeroConfigFailover">
        /// Specifies whether Zero Config Failover is enabled for this project.
        /// </param>
        /// <param name="oidcTokenConfig">
        /// OpenID Connect JSON Web Token generation configuration.
        /// </param>
        /// <param name="enableAffectedProjectsDeployments">
        /// Opt-in to skip deployments when there are no changes to the root directory and its dependencies
        /// </param>
        /// <param name="resourceConfig">
        /// Specifies resource override configuration for the project
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateProjectResponse> CreateProjectAsync(
            string name,
            string? teamId = default,
            string? slug = default,
            bool? enablePreviewFeedback = default,
            bool? enableProductionFeedback = default,
            bool? previewDeploymentsDisabled = default,
            string? previewDeploymentSuffix = default,
            string? buildCommand = default,
            string? commandForIgnoringBuildStep = default,
            string? devCommand = default,
            global::System.Collections.Generic.IList<global::Vercel.CreateProjectRequestEnvironmentVariable>? environmentVariables = default,
            global::Vercel.CreateProjectRequestFramework? framework = default,
            global::Vercel.CreateProjectRequestGitRepository? gitRepository = default,
            string? installCommand = default,
            global::Vercel.CreateProjectRequestSsoProtection? ssoProtection = default,
            string? outputDirectory = default,
            bool? publicSource = default,
            string? rootDirectory = default,
            string? serverlessFunctionRegion = default,
            bool? serverlessFunctionZeroConfigFailover = default,
            global::Vercel.CreateProjectRequestOidcTokenConfig? oidcTokenConfig = default,
            bool? enableAffectedProjectsDeployments = default,
            global::Vercel.CreateProjectRequestResourceConfig? resourceConfig = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}