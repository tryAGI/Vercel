#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Vercel
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Update an existing project<br/>
        /// Update the fields of a project using either its `name` or `id`.
        /// </summary>
        /// <param name="idOrName">
        /// The unique project identifier or the project name<br/>
        /// Example: prj_12HKQaOmR5t5Uy6vdcQsNIiZgHGB
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
        global::System.Threading.Tasks.Task<global::Vercel.UpdateProjectResponse> UpdateProjectAsync(
            string idOrName,

            global::Vercel.UpdateProjectRequest request,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an existing project<br/>
        /// Update the fields of a project using either its `name` or `id`.
        /// </summary>
        /// <param name="idOrName">
        /// The unique project identifier or the project name<br/>
        /// Example: prj_12HKQaOmR5t5Uy6vdcQsNIiZgHGB
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="autoExposeSystemEnvs"></param>
        /// <param name="autoAssignCustomDomains"></param>
        /// <param name="autoAssignCustomDomainsUpdatedBy"></param>
        /// <param name="buildCommand">
        /// The build command for this project. When `null` is used this value will be automatically detected
        /// </param>
        /// <param name="commandForIgnoringBuildStep"></param>
        /// <param name="customerSupportCodeVisibility">
        /// Specifies whether customer support can see git source for a deployment
        /// </param>
        /// <param name="devCommand">
        /// The dev command for this project. When `null` is used this value will be automatically detected
        /// </param>
        /// <param name="directoryListing"></param>
        /// <param name="framework">
        /// The framework that is being used for this project. When `null` is used no framework is selected
        /// </param>
        /// <param name="gitForkProtection">
        /// Specifies whether PRs from Git forks should require a team member's authorization before it can be deployed
        /// </param>
        /// <param name="gitLFS">
        /// Specifies whether Git LFS is enabled for this project.
        /// </param>
        /// <param name="protectedSourcemaps">
        /// Specifies whether sourcemaps are protected and require authentication to access.
        /// </param>
        /// <param name="installCommand">
        /// The install command for this project. When `null` is used this value will be automatically detected
        /// </param>
        /// <param name="name">
        /// The desired name for the project<br/>
        /// Example: a-project-name
        /// </param>
        /// <param name="nodeVersion"></param>
        /// <param name="outputDirectory">
        /// The output directory of the project. When `null` is used this value will be automatically detected
        /// </param>
        /// <param name="previewDeploymentsDisabled">
        /// Specifies whether preview deployments are disabled for this project.
        /// </param>
        /// <param name="previewDeploymentSuffix">
        /// Custom domain suffix for preview deployments. Takes precedence over team-level suffix. Must be a domain owned by the team.
        /// </param>
        /// <param name="publicSource">
        /// Specifies whether the source code and logs of the deployments for this project should be public or not
        /// </param>
        /// <param name="resourceConfig">
        /// Specifies resource override configuration for the project
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
        /// <param name="skewProtectionBoundaryAt">
        /// Deployments created before this absolute datetime have Skew Protection disabled. Value is in milliseconds since epoch to match \"createdAt\" fields.
        /// </param>
        /// <param name="skewProtectionMaxAge">
        /// Deployments created before this rolling window have Skew Protection disabled. Value is in seconds to match \"revalidate\" fields.
        /// </param>
        /// <param name="skewProtectionAllowedDomains">
        /// Cross-site domains allowed to fetch skew-protected assets (hostnames, optionally with leading wildcard like *.example.com).
        /// </param>
        /// <param name="sourceFilesOutsideRootDirectory">
        /// Indicates if there are source files outside of the root directory
        /// </param>
        /// <param name="enablePreviewFeedback">
        /// Opt-in to preview toolbar on the project level
        /// </param>
        /// <param name="enableProductionFeedback">
        /// Opt-in to production toolbar on the project level
        /// </param>
        /// <param name="enableAffectedProjectsDeployments">
        /// Opt-in to skip deployments when there are no changes to the root directory and its dependencies
        /// </param>
        /// <param name="enableExternalRewriteCaching">
        /// Specifies whether external rewrite caching is enabled for this project.
        /// </param>
        /// <param name="staticIps">
        /// Manage Static IPs for this project
        /// </param>
        /// <param name="tracing">
        /// Tracing configuration for this project
        /// </param>
        /// <param name="oidcTokenConfig">
        /// OpenID Connect JSON Web Token generation configuration.
        /// </param>
        /// <param name="passwordProtection">
        /// Allows to protect project deployments with a password
        /// </param>
        /// <param name="ssoProtection">
        /// Ensures visitors to your Preview Deployments are logged into Vercel and have a minimum of Viewer access on your team
        /// </param>
        /// <param name="trustedIps">
        /// Restricts access to deployments based on the incoming request IP address
        /// </param>
        /// <param name="optionsAllowlist">
        /// Specify a list of paths that should not be protected by Deployment Protection to enable Cors preflight requests
        /// </param>
        /// <param name="connectConfigurations">
        /// The list of connections from project environment to Secure Compute network
        /// </param>
        /// <param name="dismissedToasts">
        /// An array of objects representing a Dismissed Toast in regards to a Project. Objects are either merged with existing toasts (on key match), or added to the `dimissedToasts` array.`
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.UpdateProjectResponse> UpdateProjectAsync(
            string idOrName,
            string? teamId = default,
            string? slug = default,
            bool? autoExposeSystemEnvs = default,
            bool? autoAssignCustomDomains = default,
            string? autoAssignCustomDomainsUpdatedBy = default,
            string? buildCommand = default,
            string? commandForIgnoringBuildStep = default,
            bool? customerSupportCodeVisibility = default,
            string? devCommand = default,
            bool? directoryListing = default,
            global::Vercel.UpdateProjectRequestFramework? framework = default,
            bool? gitForkProtection = default,
            bool? gitLFS = default,
            bool? protectedSourcemaps = default,
            string? installCommand = default,
            string? name = default,
            global::Vercel.UpdateProjectRequestNodeVersion? nodeVersion = default,
            string? outputDirectory = default,
            bool? previewDeploymentsDisabled = default,
            string? previewDeploymentSuffix = default,
            bool? publicSource = default,
            global::Vercel.UpdateProjectRequestResourceConfig? resourceConfig = default,
            string? rootDirectory = default,
            string? serverlessFunctionRegion = default,
            bool? serverlessFunctionZeroConfigFailover = default,
            int? skewProtectionBoundaryAt = default,
            int? skewProtectionMaxAge = default,
            global::System.Collections.Generic.IList<string>? skewProtectionAllowedDomains = default,
            bool? sourceFilesOutsideRootDirectory = default,
            bool? enablePreviewFeedback = default,
            bool? enableProductionFeedback = default,
            bool? enableAffectedProjectsDeployments = default,
            bool? enableExternalRewriteCaching = default,
            global::Vercel.UpdateProjectRequestStaticIps? staticIps = default,
            global::Vercel.UpdateProjectRequestTracing? tracing = default,
            global::Vercel.UpdateProjectRequestOidcTokenConfig? oidcTokenConfig = default,
            global::Vercel.UpdateProjectRequestPasswordProtection? passwordProtection = default,
            global::Vercel.UpdateProjectRequestSsoProtection? ssoProtection = default,
            global::Vercel.UpdateProjectRequestTrustedIps? trustedIps = default,
            global::Vercel.UpdateProjectRequestOptionsAllowlist? optionsAllowlist = default,
            global::System.Collections.Generic.IList<global::Vercel.UpdateProjectRequestConnectConfiguration>? connectConfigurations = default,
            global::System.Collections.Generic.IList<global::Vercel.UpdateProjectRequestDismissedToast>? dismissedToasts = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}