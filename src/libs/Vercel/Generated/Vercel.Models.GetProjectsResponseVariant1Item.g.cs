
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectsResponseVariant1Item
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
        public required global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant1ItemAlia> Alias { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analytics")]
        public global::Vercel.GetProjectsResponseVariant1ItemAnalytics? Analytics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appliedCve55182Migration")]
        public bool? AppliedCve55182Migration { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("customerSupportCodeVisibility")]
        public bool? CustomerSupportCodeVisibility { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public double? CreatedAt { get; set; }

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
        /// Retention policies for deployments. These are enforced at the project level, but we also maintain an instance of this at the team level as a default policy that gets applied to new projects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentExpiration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetProjectsResponseVariant1ItemDeploymentExpiration DeploymentExpiration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installCommand")]
        public string? InstallCommand { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ipBuckets")]
        public global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant1ItemIpBucket>? IpBuckets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        public global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant1ItemEnvItem>? Env { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("framework")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectsResponseVariant1ItemFrameworkJsonConverter))]
        public global::Vercel.GetProjectsResponseVariant1ItemFramework? Framework { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitForkProtection")]
        public bool? GitForkProtection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latestDeployments")]
        public global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant1ItemLatestDeployment>? LatestDeployments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("link")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.GetProjectsResponseVariant1ItemLinkVariant1, global::Vercel.GetProjectsResponseVariant1ItemLinkVariant2, global::Vercel.GetProjectsResponseVariant1ItemLinkVariant3, global::Vercel.GetProjectsResponseVariant1ItemLinkVariant4, global::Vercel.GetProjectsResponseVariant1ItemLinkVariant5, global::Vercel.GetProjectsResponseVariant1ItemLinkVariant6>))]
        public global::Vercel.OneOf<global::Vercel.GetProjectsResponseVariant1ItemLinkVariant1, global::Vercel.GetProjectsResponseVariant1ItemLinkVariant2, global::Vercel.GetProjectsResponseVariant1ItemLinkVariant3, global::Vercel.GetProjectsResponseVariant1ItemLinkVariant4, global::Vercel.GetProjectsResponseVariant1ItemLinkVariant5, global::Vercel.GetProjectsResponseVariant1ItemLinkVariant6>? Link { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectsResponseVariant1ItemNodeVersionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetProjectsResponseVariant1ItemNodeVersion NodeVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputDirectory")]
        public string? OutputDirectory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passwordProtection")]
        public object? PasswordProtection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publicSource")]
        public bool? PublicSource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceConfig")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetProjectsResponseVariant1ItemResourceConfig ResourceConfig { get; set; }

        /// <summary>
        /// Project-level rolling release configuration that defines how deployments should be gradually rolled out
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rollingRelease")]
        public global::Vercel.GetProjectsResponseVariant1ItemRollingRelease? RollingRelease { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rootDirectory")]
        public string? RootDirectory { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("speedInsights")]
        public global::Vercel.GetProjectsResponseVariant1ItemSpeedInsights? SpeedInsights { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("ssoProtection")]
        public global::Vercel.GetProjectsResponseVariant1ItemSsoProtection? SsoProtection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targets")]
        public global::System.Collections.Generic.Dictionary<string, global::Vercel.GetProjectsResponseVariant1ItemTargets2?>? Targets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transferCompletedAt")]
        public double? TransferCompletedAt { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("transferredFromAccountId")]
        public string? TransferredFromAccountId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public double? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("live")]
        public bool? Live { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasActiveBranches")]
        public bool? HasActiveBranches { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitComments")]
        public global::Vercel.GetProjectsResponseVariant1ItemGitComments? GitComments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitProviderOptions")]
        public global::Vercel.GetProjectsResponseVariant1ItemGitProviderOptions? GitProviderOptions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paused")]
        public bool? Paused { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webAnalytics")]
        public global::Vercel.GetProjectsResponseVariant1ItemWebAnalytics? WebAnalytics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security")]
        public global::Vercel.GetProjectsResponseVariant1ItemSecurity? Security { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oidcTokenConfig")]
        public global::Vercel.GetProjectsResponseVariant1ItemOidcTokenConfig? OidcTokenConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier")]
        public string? Tier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("abuse")]
        public global::Vercel.GetProjectsResponseVariant1ItemAbuse? Abuse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("internalRoutes")]
        public global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.GetProjectsResponseVariant1ItemInternalRouteVariant1, global::Vercel.GetProjectsResponseVariant1ItemInternalRouteVariant2>>? InternalRoutes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant1Item" /> class.
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="alias"></param>
        /// <param name="directoryListing"></param>
        /// <param name="deploymentExpiration">
        /// Retention policies for deployments. These are enforced at the project level, but we also maintain an instance of this at the team level as a default policy that gets applied to new projects.
        /// </param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="nodeVersion"></param>
        /// <param name="resourceConfig"></param>
        /// <param name="serverlessFunctionRegion"></param>
        /// <param name="analytics"></param>
        /// <param name="appliedCve55182Migration"></param>
        /// <param name="autoExposeSystemEnvs"></param>
        /// <param name="autoAssignCustomDomains"></param>
        /// <param name="autoAssignCustomDomainsUpdatedBy"></param>
        /// <param name="buildCommand"></param>
        /// <param name="commandForIgnoringBuildStep"></param>
        /// <param name="customerSupportCodeVisibility"></param>
        /// <param name="createdAt"></param>
        /// <param name="devCommand"></param>
        /// <param name="installCommand"></param>
        /// <param name="ipBuckets"></param>
        /// <param name="env"></param>
        /// <param name="framework"></param>
        /// <param name="gitForkProtection"></param>
        /// <param name="latestDeployments"></param>
        /// <param name="link"></param>
        /// <param name="outputDirectory"></param>
        /// <param name="passwordProtection"></param>
        /// <param name="publicSource"></param>
        /// <param name="rollingRelease">
        /// Project-level rolling release configuration that defines how deployments should be gradually rolled out
        /// </param>
        /// <param name="rootDirectory"></param>
        /// <param name="serverlessFunctionZeroConfigFailover"></param>
        /// <param name="speedInsights"></param>
        /// <param name="skipGitConnectDuringLink"></param>
        /// <param name="sourceFilesOutsideRootDirectory"></param>
        /// <param name="ssoProtection"></param>
        /// <param name="targets"></param>
        /// <param name="transferCompletedAt"></param>
        /// <param name="transferStartedAt"></param>
        /// <param name="transferToAccountId"></param>
        /// <param name="transferredFromAccountId"></param>
        /// <param name="updatedAt"></param>
        /// <param name="live"></param>
        /// <param name="hasActiveBranches"></param>
        /// <param name="gitComments"></param>
        /// <param name="gitProviderOptions"></param>
        /// <param name="paused"></param>
        /// <param name="webAnalytics"></param>
        /// <param name="security"></param>
        /// <param name="oidcTokenConfig"></param>
        /// <param name="tier"></param>
        /// <param name="abuse"></param>
        /// <param name="internalRoutes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectsResponseVariant1Item(
            string accountId,
            global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant1ItemAlia> alias,
            bool directoryListing,
            global::Vercel.GetProjectsResponseVariant1ItemDeploymentExpiration deploymentExpiration,
            string id,
            string name,
            global::Vercel.GetProjectsResponseVariant1ItemNodeVersion nodeVersion,
            global::Vercel.GetProjectsResponseVariant1ItemResourceConfig resourceConfig,
            string serverlessFunctionRegion,
            global::Vercel.GetProjectsResponseVariant1ItemAnalytics? analytics,
            bool? appliedCve55182Migration,
            bool? autoExposeSystemEnvs,
            bool? autoAssignCustomDomains,
            string? autoAssignCustomDomainsUpdatedBy,
            string? buildCommand,
            string? commandForIgnoringBuildStep,
            bool? customerSupportCodeVisibility,
            double? createdAt,
            string? devCommand,
            string? installCommand,
            global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant1ItemIpBucket>? ipBuckets,
            global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant1ItemEnvItem>? env,
            global::Vercel.GetProjectsResponseVariant1ItemFramework? framework,
            bool? gitForkProtection,
            global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant1ItemLatestDeployment>? latestDeployments,
            global::Vercel.OneOf<global::Vercel.GetProjectsResponseVariant1ItemLinkVariant1, global::Vercel.GetProjectsResponseVariant1ItemLinkVariant2, global::Vercel.GetProjectsResponseVariant1ItemLinkVariant3, global::Vercel.GetProjectsResponseVariant1ItemLinkVariant4, global::Vercel.GetProjectsResponseVariant1ItemLinkVariant5, global::Vercel.GetProjectsResponseVariant1ItemLinkVariant6>? link,
            string? outputDirectory,
            object? passwordProtection,
            bool? publicSource,
            global::Vercel.GetProjectsResponseVariant1ItemRollingRelease? rollingRelease,
            string? rootDirectory,
            bool? serverlessFunctionZeroConfigFailover,
            global::Vercel.GetProjectsResponseVariant1ItemSpeedInsights? speedInsights,
            bool? skipGitConnectDuringLink,
            bool? sourceFilesOutsideRootDirectory,
            global::Vercel.GetProjectsResponseVariant1ItemSsoProtection? ssoProtection,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.GetProjectsResponseVariant1ItemTargets2?>? targets,
            double? transferCompletedAt,
            double? transferStartedAt,
            string? transferToAccountId,
            string? transferredFromAccountId,
            double? updatedAt,
            bool? live,
            bool? hasActiveBranches,
            global::Vercel.GetProjectsResponseVariant1ItemGitComments? gitComments,
            global::Vercel.GetProjectsResponseVariant1ItemGitProviderOptions? gitProviderOptions,
            bool? paused,
            global::Vercel.GetProjectsResponseVariant1ItemWebAnalytics? webAnalytics,
            global::Vercel.GetProjectsResponseVariant1ItemSecurity? security,
            global::Vercel.GetProjectsResponseVariant1ItemOidcTokenConfig? oidcTokenConfig,
            string? tier,
            global::Vercel.GetProjectsResponseVariant1ItemAbuse? abuse,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.GetProjectsResponseVariant1ItemInternalRouteVariant1, global::Vercel.GetProjectsResponseVariant1ItemInternalRouteVariant2>>? internalRoutes)
        {
            this.AccountId = accountId ?? throw new global::System.ArgumentNullException(nameof(accountId));
            this.Alias = alias ?? throw new global::System.ArgumentNullException(nameof(alias));
            this.Analytics = analytics;
            this.AppliedCve55182Migration = appliedCve55182Migration;
            this.AutoExposeSystemEnvs = autoExposeSystemEnvs;
            this.AutoAssignCustomDomains = autoAssignCustomDomains;
            this.AutoAssignCustomDomainsUpdatedBy = autoAssignCustomDomainsUpdatedBy;
            this.BuildCommand = buildCommand;
            this.CommandForIgnoringBuildStep = commandForIgnoringBuildStep;
            this.CustomerSupportCodeVisibility = customerSupportCodeVisibility;
            this.CreatedAt = createdAt;
            this.DevCommand = devCommand;
            this.DirectoryListing = directoryListing;
            this.DeploymentExpiration = deploymentExpiration ?? throw new global::System.ArgumentNullException(nameof(deploymentExpiration));
            this.InstallCommand = installCommand;
            this.IpBuckets = ipBuckets;
            this.Env = env;
            this.Framework = framework;
            this.GitForkProtection = gitForkProtection;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.LatestDeployments = latestDeployments;
            this.Link = link;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.NodeVersion = nodeVersion;
            this.OutputDirectory = outputDirectory;
            this.PasswordProtection = passwordProtection;
            this.PublicSource = publicSource;
            this.ResourceConfig = resourceConfig ?? throw new global::System.ArgumentNullException(nameof(resourceConfig));
            this.RollingRelease = rollingRelease;
            this.RootDirectory = rootDirectory;
            this.ServerlessFunctionRegion = serverlessFunctionRegion ?? throw new global::System.ArgumentNullException(nameof(serverlessFunctionRegion));
            this.ServerlessFunctionZeroConfigFailover = serverlessFunctionZeroConfigFailover;
            this.SpeedInsights = speedInsights;
            this.SkipGitConnectDuringLink = skipGitConnectDuringLink;
            this.SourceFilesOutsideRootDirectory = sourceFilesOutsideRootDirectory;
            this.SsoProtection = ssoProtection;
            this.Targets = targets;
            this.TransferCompletedAt = transferCompletedAt;
            this.TransferStartedAt = transferStartedAt;
            this.TransferToAccountId = transferToAccountId;
            this.TransferredFromAccountId = transferredFromAccountId;
            this.UpdatedAt = updatedAt;
            this.Live = live;
            this.HasActiveBranches = hasActiveBranches;
            this.GitComments = gitComments;
            this.GitProviderOptions = gitProviderOptions;
            this.Paused = paused;
            this.WebAnalytics = webAnalytics;
            this.Security = security;
            this.OidcTokenConfig = oidcTokenConfig;
            this.Tier = tier;
            this.Abuse = abuse;
            this.InternalRoutes = internalRoutes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant1Item" /> class.
        /// </summary>
        public GetProjectsResponseVariant1Item()
        {
        }
    }
}