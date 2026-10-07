
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared0b1c50a27c68575d
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accountId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccountId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared29b35dda7b3e47c4> Alias { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analytics")]
        public global::Vercel.AutoSDKShared0b1c50a27c68575dAnalytics? Analytics { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appliedCve55182Migration")]
        public bool? AppliedCve55182Migration { get; set; }

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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoExposeSystemEnvs")]
        public bool? AutoExposeSystemEnvs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildCommand")]
        public string? BuildCommand { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commandForIgnoringBuildStep")]
        public string? CommandForIgnoringBuildStep { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public double? CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedf1f589ae3ca84945JsonConverter))]
        public global::Vercel.AutoSDKSharedf1f589ae3ca84945? Creator { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customerSupportCodeVisibility")]
        public bool? CustomerSupportCodeVisibility { get; set; }

        /// <summary>
        /// Retention policies for deployments. These are enforced at the project level, but we also maintain an instance of this at the team level as a default policy that gets applied to new projects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentExpiration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared0b1c50a27c68575dDeploymentExpiration DeploymentExpiration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("devCommand")]
        public string? DevCommand { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("directoryListing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool DirectoryListing { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared470bc56668090392>? Env { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("framework")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared0b1c50a27c68575dFrameworkJsonConverter))]
        public global::Vercel.AutoSDKShared0b1c50a27c68575dFramework? Framework { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitComments")]
        public global::Vercel.AutoSDKShared0b1c50a27c68575dGitComments? GitComments { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitForkProtection")]
        public bool? GitForkProtection { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitProviderOptions")]
        public global::Vercel.AutoSDKSharedc12640b06f1c9105? GitProviderOptions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasActiveBranches")]
        public bool? HasActiveBranches { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installCommand")]
        public string? InstallCommand { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("internalRoutes")]
        public global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.AutoSDKShared0b1c50a27c68575dInternalRouteVariant1, global::Vercel.AutoSDKShared0b1c50a27c68575dInternalRouteVariant2>>? InternalRoutes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ipBuckets")]
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared0b1c50a27c68575dIpBucket>? IpBuckets { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latestDeployments")]
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedbca3e7a986162538>? LatestDeployments { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("link")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharede0f9d68fc63cf31dJsonConverter))]
        public global::Vercel.AutoSDKSharede0f9d68fc63cf31d? Link { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("live")]
        public bool? Live { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodeVersion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared0b1c50a27c68575dNodeVersionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared0b1c50a27c68575dNodeVersion NodeVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oidcTokenConfig")]
        public global::Vercel.AutoSDKShared0b1c50a27c68575dOidcTokenConfig? OidcTokenConfig { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputDirectory")]
        public string? OutputDirectory { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passport")]
        public global::Vercel.AutoSDKShared0b1c50a27c68575dPassport? Passport { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passwordProtection")]
        public object? PasswordProtection { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paused")]
        public bool? Paused { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceConfig")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared0b1c50a27c68575dResourceConfig ResourceConfig { get; set; }

        /// <summary>
        /// Project-level rolling release configuration that defines how deployments should be gradually rolled out
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rollingRelease")]
        public global::Vercel.AutoSDKSharedce0c7f50e384322c? RollingRelease { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rootDirectory")]
        public string? RootDirectory { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security")]
        public global::Vercel.AutoSDKShared9a99a7cde55f3566? Security { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serverlessFunctionRegion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServerlessFunctionRegion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serverlessFunctionZeroConfigFailover")]
        public bool? ServerlessFunctionZeroConfigFailover { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipGitConnectDuringLink")]
        public bool? SkipGitConnectDuringLink { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceFilesOutsideRootDirectory")]
        public bool? SourceFilesOutsideRootDirectory { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speedInsights")]
        public global::Vercel.AutoSDKShared0b1c50a27c68575dSpeedInsights? SpeedInsights { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ssoProtection")]
        public global::Vercel.AutoSDKShared0b1c50a27c68575dSsoProtection? SsoProtection { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targets")]
        public global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared8422af433e1bf486?>? Targets { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared0b1c50a27c68575dTierJsonConverter))]
        public global::Vercel.AutoSDKShared0b1c50a27c68575dTier? Tier { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transferCompletedAt")]
        public double? TransferCompletedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transferredFromAccountId")]
        public string? TransferredFromAccountId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transferStartedAt")]
        public double? TransferStartedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transferToAccountId")]
        public string? TransferToAccountId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trustedSources")]
        public global::Vercel.AutoSDKShared94938587734e5f57? TrustedSources { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public double? UpdatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webAnalytics")]
        public global::Vercel.AutoSDKShared0b1c50a27c68575dWebAnalytics? WebAnalytics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared0b1c50a27c68575d" /> class.
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="alias"></param>
        /// <param name="deploymentExpiration">
        /// Retention policies for deployments. These are enforced at the project level, but we also maintain an instance of this at the team level as a default policy that gets applied to new projects.
        /// </param>
        /// <param name="directoryListing"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="nodeVersion"></param>
        /// <param name="resourceConfig"></param>
        /// <param name="serverlessFunctionRegion"></param>
        /// <param name="analytics"></param>
        /// <param name="appliedCve55182Migration"></param>
        /// <param name="autoAssignCustomDomains"></param>
        /// <param name="autoAssignCustomDomainsUpdatedBy"></param>
        /// <param name="autoExposeSystemEnvs"></param>
        /// <param name="buildCommand"></param>
        /// <param name="commandForIgnoringBuildStep"></param>
        /// <param name="createdAt"></param>
        /// <param name="creator"></param>
        /// <param name="customerSupportCodeVisibility"></param>
        /// <param name="devCommand"></param>
        /// <param name="env"></param>
        /// <param name="framework"></param>
        /// <param name="gitComments"></param>
        /// <param name="gitForkProtection"></param>
        /// <param name="gitProviderOptions"></param>
        /// <param name="hasActiveBranches"></param>
        /// <param name="installCommand"></param>
        /// <param name="internalRoutes"></param>
        /// <param name="ipBuckets"></param>
        /// <param name="latestDeployments"></param>
        /// <param name="link"></param>
        /// <param name="live"></param>
        /// <param name="oidcTokenConfig"></param>
        /// <param name="outputDirectory"></param>
        /// <param name="passport"></param>
        /// <param name="passwordProtection"></param>
        /// <param name="paused"></param>
        /// <param name="rollingRelease">
        /// Project-level rolling release configuration that defines how deployments should be gradually rolled out
        /// </param>
        /// <param name="rootDirectory"></param>
        /// <param name="security"></param>
        /// <param name="serverlessFunctionZeroConfigFailover"></param>
        /// <param name="skipGitConnectDuringLink"></param>
        /// <param name="sourceFilesOutsideRootDirectory"></param>
        /// <param name="speedInsights"></param>
        /// <param name="ssoProtection"></param>
        /// <param name="targets"></param>
        /// <param name="tier"></param>
        /// <param name="transferCompletedAt"></param>
        /// <param name="transferredFromAccountId"></param>
        /// <param name="transferStartedAt"></param>
        /// <param name="transferToAccountId"></param>
        /// <param name="trustedSources"></param>
        /// <param name="updatedAt"></param>
        /// <param name="webAnalytics"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared0b1c50a27c68575d(
            string accountId,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared29b35dda7b3e47c4> alias,
            global::Vercel.AutoSDKShared0b1c50a27c68575dDeploymentExpiration deploymentExpiration,
            bool directoryListing,
            string id,
            string name,
            global::Vercel.AutoSDKShared0b1c50a27c68575dNodeVersion nodeVersion,
            global::Vercel.AutoSDKShared0b1c50a27c68575dResourceConfig resourceConfig,
            string serverlessFunctionRegion,
            global::Vercel.AutoSDKShared0b1c50a27c68575dAnalytics? analytics,
            bool? appliedCve55182Migration,
            bool? autoAssignCustomDomains,
            string? autoAssignCustomDomainsUpdatedBy,
            bool? autoExposeSystemEnvs,
            string? buildCommand,
            string? commandForIgnoringBuildStep,
            double? createdAt,
            global::Vercel.AutoSDKSharedf1f589ae3ca84945? creator,
            bool? customerSupportCodeVisibility,
            string? devCommand,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared470bc56668090392>? env,
            global::Vercel.AutoSDKShared0b1c50a27c68575dFramework? framework,
            global::Vercel.AutoSDKShared0b1c50a27c68575dGitComments? gitComments,
            bool? gitForkProtection,
            global::Vercel.AutoSDKSharedc12640b06f1c9105? gitProviderOptions,
            bool? hasActiveBranches,
            string? installCommand,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.AutoSDKShared0b1c50a27c68575dInternalRouteVariant1, global::Vercel.AutoSDKShared0b1c50a27c68575dInternalRouteVariant2>>? internalRoutes,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared0b1c50a27c68575dIpBucket>? ipBuckets,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedbca3e7a986162538>? latestDeployments,
            global::Vercel.AutoSDKSharede0f9d68fc63cf31d? link,
            bool? live,
            global::Vercel.AutoSDKShared0b1c50a27c68575dOidcTokenConfig? oidcTokenConfig,
            string? outputDirectory,
            global::Vercel.AutoSDKShared0b1c50a27c68575dPassport? passport,
            object? passwordProtection,
            bool? paused,
            global::Vercel.AutoSDKSharedce0c7f50e384322c? rollingRelease,
            string? rootDirectory,
            global::Vercel.AutoSDKShared9a99a7cde55f3566? security,
            bool? serverlessFunctionZeroConfigFailover,
            bool? skipGitConnectDuringLink,
            bool? sourceFilesOutsideRootDirectory,
            global::Vercel.AutoSDKShared0b1c50a27c68575dSpeedInsights? speedInsights,
            global::Vercel.AutoSDKShared0b1c50a27c68575dSsoProtection? ssoProtection,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared8422af433e1bf486?>? targets,
            global::Vercel.AutoSDKShared0b1c50a27c68575dTier? tier,
            double? transferCompletedAt,
            string? transferredFromAccountId,
            double? transferStartedAt,
            string? transferToAccountId,
            global::Vercel.AutoSDKShared94938587734e5f57? trustedSources,
            double? updatedAt,
            global::Vercel.AutoSDKShared0b1c50a27c68575dWebAnalytics? webAnalytics)
        {
            this.AccountId = accountId ?? throw new global::System.ArgumentNullException(nameof(accountId));
            this.Alias = alias ?? throw new global::System.ArgumentNullException(nameof(alias));
            this.Analytics = analytics;
            this.AppliedCve55182Migration = appliedCve55182Migration;
            this.AutoAssignCustomDomains = autoAssignCustomDomains;
            this.AutoAssignCustomDomainsUpdatedBy = autoAssignCustomDomainsUpdatedBy;
            this.AutoExposeSystemEnvs = autoExposeSystemEnvs;
            this.BuildCommand = buildCommand;
            this.CommandForIgnoringBuildStep = commandForIgnoringBuildStep;
            this.CreatedAt = createdAt;
            this.Creator = creator;
            this.CustomerSupportCodeVisibility = customerSupportCodeVisibility;
            this.DeploymentExpiration = deploymentExpiration ?? throw new global::System.ArgumentNullException(nameof(deploymentExpiration));
            this.DevCommand = devCommand;
            this.DirectoryListing = directoryListing;
            this.Env = env;
            this.Framework = framework;
            this.GitComments = gitComments;
            this.GitForkProtection = gitForkProtection;
            this.GitProviderOptions = gitProviderOptions;
            this.HasActiveBranches = hasActiveBranches;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.InstallCommand = installCommand;
            this.InternalRoutes = internalRoutes;
            this.IpBuckets = ipBuckets;
            this.LatestDeployments = latestDeployments;
            this.Link = link;
            this.Live = live;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.NodeVersion = nodeVersion;
            this.OidcTokenConfig = oidcTokenConfig;
            this.OutputDirectory = outputDirectory;
            this.Passport = passport;
            this.PasswordProtection = passwordProtection;
            this.Paused = paused;
            this.ResourceConfig = resourceConfig ?? throw new global::System.ArgumentNullException(nameof(resourceConfig));
            this.RollingRelease = rollingRelease;
            this.RootDirectory = rootDirectory;
            this.Security = security;
            this.ServerlessFunctionRegion = serverlessFunctionRegion ?? throw new global::System.ArgumentNullException(nameof(serverlessFunctionRegion));
            this.ServerlessFunctionZeroConfigFailover = serverlessFunctionZeroConfigFailover;
            this.SkipGitConnectDuringLink = skipGitConnectDuringLink;
            this.SourceFilesOutsideRootDirectory = sourceFilesOutsideRootDirectory;
            this.SpeedInsights = speedInsights;
            this.SsoProtection = ssoProtection;
            this.Targets = targets;
            this.Tier = tier;
            this.TransferCompletedAt = transferCompletedAt;
            this.TransferredFromAccountId = transferredFromAccountId;
            this.TransferStartedAt = transferStartedAt;
            this.TransferToAccountId = transferToAccountId;
            this.TrustedSources = trustedSources;
            this.UpdatedAt = updatedAt;
            this.WebAnalytics = webAnalytics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared0b1c50a27c68575d" /> class.
        /// </summary>
        public AutoSDKShared0b1c50a27c68575d()
        {
        }

    }
}