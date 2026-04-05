
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateProjectRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoExposeSystemEnvs")]
        public bool? AutoExposeSystemEnvs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoAssignCustomDomains")]
        public bool? AutoAssignCustomDomains { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoAssignCustomDomainsUpdatedBy")]
        public string? AutoAssignCustomDomainsUpdatedBy { get; set; }

        /// <summary>
        /// The build command for this project. When `null` is used this value will be automatically detected
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildCommand")]
        public string? BuildCommand { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commandForIgnoringBuildStep")]
        public string? CommandForIgnoringBuildStep { get; set; }

        /// <summary>
        /// Specifies whether customer support can see git source for a deployment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customerSupportCodeVisibility")]
        public bool? CustomerSupportCodeVisibility { get; set; }

        /// <summary>
        /// The dev command for this project. When `null` is used this value will be automatically detected
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("devCommand")]
        public string? DevCommand { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("directoryListing")]
        public bool? DirectoryListing { get; set; }

        /// <summary>
        /// The framework that is being used for this project. When `null` is used no framework is selected
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("framework")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateProjectRequestFrameworkJsonConverter))]
        public global::Vercel.UpdateProjectRequestFramework? Framework { get; set; }

        /// <summary>
        /// Specifies whether PRs from Git forks should require a team member's authorization before it can be deployed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitForkProtection")]
        public bool? GitForkProtection { get; set; }

        /// <summary>
        /// Specifies whether Git LFS is enabled for this project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitLFS")]
        public bool? GitLFS { get; set; }

        /// <summary>
        /// Specifies whether sourcemaps are protected and require authentication to access.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protectedSourcemaps")]
        public bool? ProtectedSourcemaps { get; set; }

        /// <summary>
        /// The install command for this project. When `null` is used this value will be automatically detected
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installCommand")]
        public string? InstallCommand { get; set; }

        /// <summary>
        /// The desired name for the project<br/>
        /// Example: a-project-name
        /// </summary>
        /// <example>a-project-name</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodeVersion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateProjectRequestNodeVersionJsonConverter))]
        public global::Vercel.UpdateProjectRequestNodeVersion? NodeVersion { get; set; }

        /// <summary>
        /// The output directory of the project. When `null` is used this value will be automatically detected
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputDirectory")]
        public string? OutputDirectory { get; set; }

        /// <summary>
        /// Specifies whether preview deployments are disabled for this project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previewDeploymentsDisabled")]
        public bool? PreviewDeploymentsDisabled { get; set; }

        /// <summary>
        /// Custom domain suffix for preview deployments. Takes precedence over team-level suffix. Must be a domain owned by the team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previewDeploymentSuffix")]
        public string? PreviewDeploymentSuffix { get; set; }

        /// <summary>
        /// Specifies whether the source code and logs of the deployments for this project should be public or not
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publicSource")]
        public bool? PublicSource { get; set; }

        /// <summary>
        /// Specifies resource override configuration for the project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceConfig")]
        public global::Vercel.UpdateProjectRequestResourceConfig? ResourceConfig { get; set; }

        /// <summary>
        /// The name of a directory or relative path to the source code of your project. When `null` is used it will default to the project root
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rootDirectory")]
        public string? RootDirectory { get; set; }

        /// <summary>
        /// The region to deploy Serverless Functions in this project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serverlessFunctionRegion")]
        public string? ServerlessFunctionRegion { get; set; }

        /// <summary>
        /// Specifies whether Zero Config Failover is enabled for this project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serverlessFunctionZeroConfigFailover")]
        public bool? ServerlessFunctionZeroConfigFailover { get; set; }

        /// <summary>
        /// Deployments created before this absolute datetime have Skew Protection disabled. Value is in milliseconds since epoch to match \"createdAt\" fields.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skewProtectionBoundaryAt")]
        public int? SkewProtectionBoundaryAt { get; set; }

        /// <summary>
        /// Deployments created before this rolling window have Skew Protection disabled. Value is in seconds to match \"revalidate\" fields.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skewProtectionMaxAge")]
        public int? SkewProtectionMaxAge { get; set; }

        /// <summary>
        /// Cross-site domains allowed to fetch skew-protected assets (hostnames, optionally with leading wildcard like *.example.com).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skewProtectionAllowedDomains")]
        public global::System.Collections.Generic.IList<string>? SkewProtectionAllowedDomains { get; set; }

        /// <summary>
        /// Opts-out of the message prompting a CLI user to connect a Git repository in `vercel link`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipGitConnectDuringLink")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? SkipGitConnectDuringLink { get; set; }

        /// <summary>
        /// Indicates if there are source files outside of the root directory
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceFilesOutsideRootDirectory")]
        public bool? SourceFilesOutsideRootDirectory { get; set; }

        /// <summary>
        /// Opt-in to preview toolbar on the project level
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enablePreviewFeedback")]
        public bool? EnablePreviewFeedback { get; set; }

        /// <summary>
        /// Opt-in to production toolbar on the project level
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enableProductionFeedback")]
        public bool? EnableProductionFeedback { get; set; }

        /// <summary>
        /// Opt-in to skip deployments when there are no changes to the root directory and its dependencies
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enableAffectedProjectsDeployments")]
        public bool? EnableAffectedProjectsDeployments { get; set; }

        /// <summary>
        /// Specifies whether external rewrite caching is enabled for this project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enableExternalRewriteCaching")]
        public bool? EnableExternalRewriteCaching { get; set; }

        /// <summary>
        /// Manage Static IPs for this project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("staticIps")]
        public global::Vercel.UpdateProjectRequestStaticIps? StaticIps { get; set; }

        /// <summary>
        /// Tracing configuration for this project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracing")]
        public global::Vercel.UpdateProjectRequestTracing? Tracing { get; set; }

        /// <summary>
        /// OpenID Connect JSON Web Token generation configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oidcTokenConfig")]
        public global::Vercel.UpdateProjectRequestOidcTokenConfig? OidcTokenConfig { get; set; }

        /// <summary>
        /// Allows to protect project deployments with a password
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passwordProtection")]
        public global::Vercel.UpdateProjectRequestPasswordProtection? PasswordProtection { get; set; }

        /// <summary>
        /// Ensures visitors to your Preview Deployments are logged into Vercel and have a minimum of Viewer access on your team
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ssoProtection")]
        public global::Vercel.UpdateProjectRequestSsoProtection? SsoProtection { get; set; }

        /// <summary>
        /// Restricts access to deployments based on the incoming request IP address
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trustedIps")]
        public global::Vercel.UpdateProjectRequestTrustedIps? TrustedIps { get; set; }

        /// <summary>
        /// Specify a list of paths that should not be protected by Deployment Protection to enable Cors preflight requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("optionsAllowlist")]
        public global::Vercel.UpdateProjectRequestOptionsAllowlist? OptionsAllowlist { get; set; }

        /// <summary>
        /// The list of connections from project environment to Secure Compute network
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectConfigurations")]
        public global::System.Collections.Generic.IList<global::Vercel.UpdateProjectRequestConnectConfiguration>? ConnectConfigurations { get; set; }

        /// <summary>
        /// An array of objects representing a Dismissed Toast in regards to a Project. Objects are either merged with existing toasts (on key match), or added to the `dimissedToasts` array.`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissedToasts")]
        public global::System.Collections.Generic.IList<global::Vercel.UpdateProjectRequestDismissedToast>? DismissedToasts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequest" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectRequest(
            bool? autoExposeSystemEnvs,
            bool? autoAssignCustomDomains,
            string? autoAssignCustomDomainsUpdatedBy,
            string? buildCommand,
            string? commandForIgnoringBuildStep,
            bool? customerSupportCodeVisibility,
            string? devCommand,
            bool? directoryListing,
            global::Vercel.UpdateProjectRequestFramework? framework,
            bool? gitForkProtection,
            bool? gitLFS,
            bool? protectedSourcemaps,
            string? installCommand,
            string? name,
            global::Vercel.UpdateProjectRequestNodeVersion? nodeVersion,
            string? outputDirectory,
            bool? previewDeploymentsDisabled,
            string? previewDeploymentSuffix,
            bool? publicSource,
            global::Vercel.UpdateProjectRequestResourceConfig? resourceConfig,
            string? rootDirectory,
            string? serverlessFunctionRegion,
            bool? serverlessFunctionZeroConfigFailover,
            int? skewProtectionBoundaryAt,
            int? skewProtectionMaxAge,
            global::System.Collections.Generic.IList<string>? skewProtectionAllowedDomains,
            bool? sourceFilesOutsideRootDirectory,
            bool? enablePreviewFeedback,
            bool? enableProductionFeedback,
            bool? enableAffectedProjectsDeployments,
            bool? enableExternalRewriteCaching,
            global::Vercel.UpdateProjectRequestStaticIps? staticIps,
            global::Vercel.UpdateProjectRequestTracing? tracing,
            global::Vercel.UpdateProjectRequestOidcTokenConfig? oidcTokenConfig,
            global::Vercel.UpdateProjectRequestPasswordProtection? passwordProtection,
            global::Vercel.UpdateProjectRequestSsoProtection? ssoProtection,
            global::Vercel.UpdateProjectRequestTrustedIps? trustedIps,
            global::Vercel.UpdateProjectRequestOptionsAllowlist? optionsAllowlist,
            global::System.Collections.Generic.IList<global::Vercel.UpdateProjectRequestConnectConfiguration>? connectConfigurations,
            global::System.Collections.Generic.IList<global::Vercel.UpdateProjectRequestDismissedToast>? dismissedToasts)
        {
            this.AutoExposeSystemEnvs = autoExposeSystemEnvs;
            this.AutoAssignCustomDomains = autoAssignCustomDomains;
            this.AutoAssignCustomDomainsUpdatedBy = autoAssignCustomDomainsUpdatedBy;
            this.BuildCommand = buildCommand;
            this.CommandForIgnoringBuildStep = commandForIgnoringBuildStep;
            this.CustomerSupportCodeVisibility = customerSupportCodeVisibility;
            this.DevCommand = devCommand;
            this.DirectoryListing = directoryListing;
            this.Framework = framework;
            this.GitForkProtection = gitForkProtection;
            this.GitLFS = gitLFS;
            this.ProtectedSourcemaps = protectedSourcemaps;
            this.InstallCommand = installCommand;
            this.Name = name;
            this.NodeVersion = nodeVersion;
            this.OutputDirectory = outputDirectory;
            this.PreviewDeploymentsDisabled = previewDeploymentsDisabled;
            this.PreviewDeploymentSuffix = previewDeploymentSuffix;
            this.PublicSource = publicSource;
            this.ResourceConfig = resourceConfig;
            this.RootDirectory = rootDirectory;
            this.ServerlessFunctionRegion = serverlessFunctionRegion;
            this.ServerlessFunctionZeroConfigFailover = serverlessFunctionZeroConfigFailover;
            this.SkewProtectionBoundaryAt = skewProtectionBoundaryAt;
            this.SkewProtectionMaxAge = skewProtectionMaxAge;
            this.SkewProtectionAllowedDomains = skewProtectionAllowedDomains;
            this.SourceFilesOutsideRootDirectory = sourceFilesOutsideRootDirectory;
            this.EnablePreviewFeedback = enablePreviewFeedback;
            this.EnableProductionFeedback = enableProductionFeedback;
            this.EnableAffectedProjectsDeployments = enableAffectedProjectsDeployments;
            this.EnableExternalRewriteCaching = enableExternalRewriteCaching;
            this.StaticIps = staticIps;
            this.Tracing = tracing;
            this.OidcTokenConfig = oidcTokenConfig;
            this.PasswordProtection = passwordProtection;
            this.SsoProtection = ssoProtection;
            this.TrustedIps = trustedIps;
            this.OptionsAllowlist = optionsAllowlist;
            this.ConnectConfigurations = connectConfigurations;
            this.DismissedToasts = dismissedToasts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequest" /> class.
        /// </summary>
        public UpdateProjectRequest()
        {
        }
    }
}