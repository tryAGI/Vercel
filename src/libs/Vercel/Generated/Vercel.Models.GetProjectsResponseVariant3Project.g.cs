
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectsResponseVariant3Project
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
        [global::System.Text.Json.Serialization.JsonPropertyName("analytics")]
        public global::Vercel.GetProjectsResponseVariant3ProjectAnalytics? Analytics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appliedCve55182Migration")]
        public bool? AppliedCve55182Migration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speedInsights")]
        public global::Vercel.GetProjectsResponseVariant3ProjectSpeedInsights? SpeedInsights { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("connectConfigurations")]
        public global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant3ProjectConnectConfiguration>? ConnectConfigurations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectConfigurationId")]
        public string? ConnectConfigurationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectBuildsEnabled")]
        public bool? ConnectBuildsEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passiveConnectConfigurationId")]
        public string? PassiveConnectConfigurationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public double? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customerSupportCodeVisibility")]
        public bool? CustomerSupportCodeVisibility { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crons")]
        public global::Vercel.GetProjectsResponseVariant3ProjectCrons? Crons { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataCache")]
        public global::Vercel.GetProjectsResponseVariant3ProjectDataCache? DataCache { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delegatedProtection")]
        public object? DelegatedProtection { get; set; }

        /// <summary>
        /// Retention policies for deployments. These are enforced at the project level, but we also maintain an instance of this at the team level as a default policy that gets applied to new projects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentExpiration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetProjectsResponseVariant3ProjectDeploymentExpiration DeploymentExpiration { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("installCommand")]
        public string? InstallCommand { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        public global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant3ProjectEnvItem>? Env { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customEnvironments")]
        public global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant3ProjectCustomEnvironment>? CustomEnvironments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("framework")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectsResponseVariant3ProjectFrameworkJsonConverter))]
        public global::Vercel.GetProjectsResponseVariant3ProjectFramework? Framework { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitForkProtection")]
        public bool? GitForkProtection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitLFS")]
        public bool? GitLFS { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ipBuckets")]
        public global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant3ProjectIpBucket>? IpBuckets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobs")]
        public global::Vercel.GetProjectsResponseVariant3ProjectJobs? Jobs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latestDeployments")]
        public global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant3ProjectLatestDeployment>? LatestDeployments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("link")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.GetProjectsResponseVariant3ProjectLinkVariant1, global::Vercel.GetProjectsResponseVariant3ProjectLinkVariant2, global::Vercel.GetProjectsResponseVariant3ProjectLinkVariant3, global::Vercel.GetProjectsResponseVariant3ProjectLinkVariant4, global::Vercel.GetProjectsResponseVariant3ProjectLinkVariant5, global::Vercel.GetProjectsResponseVariant3ProjectLinkVariant6>))]
        public global::Vercel.OneOf<global::Vercel.GetProjectsResponseVariant3ProjectLinkVariant1, global::Vercel.GetProjectsResponseVariant3ProjectLinkVariant2, global::Vercel.GetProjectsResponseVariant3ProjectLinkVariant3, global::Vercel.GetProjectsResponseVariant3ProjectLinkVariant4, global::Vercel.GetProjectsResponseVariant3ProjectLinkVariant5, global::Vercel.GetProjectsResponseVariant3ProjectLinkVariant6>? Link { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microfrontends")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.GetProjectsResponseVariant3ProjectMicrofrontendsVariant1, global::Vercel.GetProjectsResponseVariant3ProjectMicrofrontendsVariant2, global::Vercel.GetProjectsResponseVariant3ProjectMicrofrontendsVariant3>))]
        public global::Vercel.OneOf<global::Vercel.GetProjectsResponseVariant3ProjectMicrofrontendsVariant1, global::Vercel.GetProjectsResponseVariant3ProjectMicrofrontendsVariant2, global::Vercel.GetProjectsResponseVariant3ProjectMicrofrontendsVariant3>? Microfrontends { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectsResponseVariant3ProjectNodeVersionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetProjectsResponseVariant3ProjectNodeVersion NodeVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("optionsAllowlist")]
        public global::Vercel.GetProjectsResponseVariant3ProjectOptionsAllowlist? OptionsAllowlist { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("productionDeploymentsFastLane")]
        public bool? ProductionDeploymentsFastLane { get; set; }

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
        public required global::Vercel.GetProjectsResponseVariant3ProjectResourceConfig ResourceConfig { get; set; }

        /// <summary>
        /// Description of why a project was rolled back, and by whom. Note that lastAliasRequest contains the from/to details of the rollback.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rollbackDescription")]
        public global::Vercel.GetProjectsResponseVariant3ProjectRollbackDescription? RollbackDescription { get; set; }

        /// <summary>
        /// Project-level rolling release configuration that defines how deployments should be gradually rolled out
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rollingRelease")]
        public global::Vercel.GetProjectsResponseVariant3ProjectRollingRelease? RollingRelease { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultResourceConfig")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetProjectsResponseVariant3ProjectDefaultResourceConfig DefaultResourceConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rootDirectory")]
        public string? RootDirectory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serverlessFunctionZeroConfigFailover")]
        public bool? ServerlessFunctionZeroConfigFailover { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skewProtectionBoundaryAt")]
        public double? SkewProtectionBoundaryAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skewProtectionMaxAge")]
        public double? SkewProtectionMaxAge { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skewProtectionAllowedDomains")]
        public global::System.Collections.Generic.IList<string>? SkewProtectionAllowedDomains { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipGitConnectDuringLink")]
        public bool? SkipGitConnectDuringLink { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("staticIps")]
        public global::Vercel.GetProjectsResponseVariant3ProjectStaticIps? StaticIps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceFilesOutsideRootDirectory")]
        public bool? SourceFilesOutsideRootDirectory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enableAffectedProjectsDeployments")]
        public bool? EnableAffectedProjectsDeployments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enableExternalRewriteCaching")]
        public bool? EnableExternalRewriteCaching { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ssoProtection")]
        public global::Vercel.GetProjectsResponseVariant3ProjectSsoProtection? SsoProtection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targets")]
        public global::System.Collections.Generic.Dictionary<string, global::Vercel.GetProjectsResponseVariant3ProjectTargets2?>? Targets { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("enablePreviewFeedback")]
        public bool? EnablePreviewFeedback { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enableProductionFeedback")]
        public bool? EnableProductionFeedback { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        public global::Vercel.GetProjectsResponseVariant3ProjectPermissions? Permissions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastRollbackTarget")]
        public object? LastRollbackTarget { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastAliasRequest")]
        public global::Vercel.GetProjectsResponseVariant3ProjectLastAliasRequest? LastAliasRequest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protectionBypass")]
        public object? ProtectionBypass { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasActiveBranches")]
        public bool? HasActiveBranches { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trustedIps")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.GetProjectsResponseVariant3ProjectTrustedIpsVariant1, global::Vercel.GetProjectsResponseVariant3ProjectTrustedIpsVariant2>))]
        public global::Vercel.OneOf<global::Vercel.GetProjectsResponseVariant3ProjectTrustedIpsVariant1, global::Vercel.GetProjectsResponseVariant3ProjectTrustedIpsVariant2>? TrustedIps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trustedSources")]
        public global::Vercel.GetProjectsResponseVariant3ProjectTrustedSources? TrustedSources { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitComments")]
        public global::Vercel.GetProjectsResponseVariant3ProjectGitComments? GitComments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitProviderOptions")]
        public global::Vercel.GetProjectsResponseVariant3ProjectGitProviderOptions? GitProviderOptions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paused")]
        public bool? Paused { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrencyBucketName")]
        public string? ConcurrencyBucketName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webAnalytics")]
        public global::Vercel.GetProjectsResponseVariant3ProjectWebAnalytics? WebAnalytics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security")]
        public global::Vercel.GetProjectsResponseVariant3ProjectSecurity? Security { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oidcTokenConfig")]
        public global::Vercel.GetProjectsResponseVariant3ProjectOidcTokenConfig? OidcTokenConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier")]
        public string? Tier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flatRateTier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectsResponseVariant3ProjectFlatRateTierJsonConverter))]
        public global::Vercel.GetProjectsResponseVariant3ProjectFlatRateTier? FlatRateTier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usageStatus")]
        public global::Vercel.GetProjectsResponseVariant3ProjectUsageStatus? UsageStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("features")]
        public global::Vercel.GetProjectsResponseVariant3ProjectFeatures? Features { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("v0")]
        public bool? V0 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("v0Created")]
        public bool? V0Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("abuse")]
        public global::Vercel.GetProjectsResponseVariant3ProjectAbuse? Abuse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("internalRoutes")]
        public global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.GetProjectsResponseVariant3ProjectInternalRouteVariant1, global::Vercel.GetProjectsResponseVariant3ProjectInternalRouteVariant2>>? InternalRoutes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasDeployments")]
        public bool? HasDeployments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissedToasts")]
        public global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant3ProjectDismissedToast>? DismissedToasts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protectedSourcemaps")]
        public bool? ProtectedSourcemaps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracing")]
        public global::Vercel.GetProjectsResponseVariant3ProjectTracing? Tracing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant3Project" /> class.
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="deploymentExpiration">
        /// Retention policies for deployments. These are enforced at the project level, but we also maintain an instance of this at the team level as a default policy that gets applied to new projects.
        /// </param>
        /// <param name="directoryListing"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="nodeVersion"></param>
        /// <param name="resourceConfig"></param>
        /// <param name="defaultResourceConfig"></param>
        /// <param name="analytics"></param>
        /// <param name="appliedCve55182Migration"></param>
        /// <param name="speedInsights"></param>
        /// <param name="autoExposeSystemEnvs"></param>
        /// <param name="autoAssignCustomDomains"></param>
        /// <param name="autoAssignCustomDomainsUpdatedBy"></param>
        /// <param name="buildCommand"></param>
        /// <param name="commandForIgnoringBuildStep"></param>
        /// <param name="connectConfigurations"></param>
        /// <param name="connectConfigurationId"></param>
        /// <param name="connectBuildsEnabled"></param>
        /// <param name="passiveConnectConfigurationId"></param>
        /// <param name="createdAt"></param>
        /// <param name="customerSupportCodeVisibility"></param>
        /// <param name="crons"></param>
        /// <param name="dataCache"></param>
        /// <param name="delegatedProtection"></param>
        /// <param name="devCommand"></param>
        /// <param name="installCommand"></param>
        /// <param name="env"></param>
        /// <param name="customEnvironments"></param>
        /// <param name="framework"></param>
        /// <param name="gitForkProtection"></param>
        /// <param name="gitLFS"></param>
        /// <param name="ipBuckets"></param>
        /// <param name="jobs"></param>
        /// <param name="latestDeployments"></param>
        /// <param name="link"></param>
        /// <param name="microfrontends"></param>
        /// <param name="optionsAllowlist"></param>
        /// <param name="outputDirectory"></param>
        /// <param name="passwordProtection"></param>
        /// <param name="productionDeploymentsFastLane"></param>
        /// <param name="publicSource"></param>
        /// <param name="rollbackDescription">
        /// Description of why a project was rolled back, and by whom. Note that lastAliasRequest contains the from/to details of the rollback.
        /// </param>
        /// <param name="rollingRelease">
        /// Project-level rolling release configuration that defines how deployments should be gradually rolled out
        /// </param>
        /// <param name="rootDirectory"></param>
        /// <param name="serverlessFunctionZeroConfigFailover"></param>
        /// <param name="skewProtectionBoundaryAt"></param>
        /// <param name="skewProtectionMaxAge"></param>
        /// <param name="skewProtectionAllowedDomains"></param>
        /// <param name="skipGitConnectDuringLink"></param>
        /// <param name="staticIps"></param>
        /// <param name="sourceFilesOutsideRootDirectory"></param>
        /// <param name="enableAffectedProjectsDeployments"></param>
        /// <param name="enableExternalRewriteCaching"></param>
        /// <param name="ssoProtection"></param>
        /// <param name="targets"></param>
        /// <param name="transferCompletedAt"></param>
        /// <param name="transferStartedAt"></param>
        /// <param name="transferToAccountId"></param>
        /// <param name="transferredFromAccountId"></param>
        /// <param name="updatedAt"></param>
        /// <param name="live"></param>
        /// <param name="enablePreviewFeedback"></param>
        /// <param name="enableProductionFeedback"></param>
        /// <param name="permissions"></param>
        /// <param name="lastRollbackTarget"></param>
        /// <param name="lastAliasRequest"></param>
        /// <param name="protectionBypass"></param>
        /// <param name="hasActiveBranches"></param>
        /// <param name="trustedIps"></param>
        /// <param name="trustedSources"></param>
        /// <param name="gitComments"></param>
        /// <param name="gitProviderOptions"></param>
        /// <param name="paused"></param>
        /// <param name="concurrencyBucketName"></param>
        /// <param name="webAnalytics"></param>
        /// <param name="security"></param>
        /// <param name="oidcTokenConfig"></param>
        /// <param name="tier"></param>
        /// <param name="flatRateTier"></param>
        /// <param name="usageStatus"></param>
        /// <param name="features"></param>
        /// <param name="v0"></param>
        /// <param name="v0Created"></param>
        /// <param name="abuse"></param>
        /// <param name="internalRoutes"></param>
        /// <param name="hasDeployments"></param>
        /// <param name="dismissedToasts"></param>
        /// <param name="protectedSourcemaps"></param>
        /// <param name="tracing"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectsResponseVariant3Project(
            string accountId,
            global::Vercel.GetProjectsResponseVariant3ProjectDeploymentExpiration deploymentExpiration,
            bool directoryListing,
            string id,
            string name,
            global::Vercel.GetProjectsResponseVariant3ProjectNodeVersion nodeVersion,
            global::Vercel.GetProjectsResponseVariant3ProjectResourceConfig resourceConfig,
            global::Vercel.GetProjectsResponseVariant3ProjectDefaultResourceConfig defaultResourceConfig,
            global::Vercel.GetProjectsResponseVariant3ProjectAnalytics? analytics,
            bool? appliedCve55182Migration,
            global::Vercel.GetProjectsResponseVariant3ProjectSpeedInsights? speedInsights,
            bool? autoExposeSystemEnvs,
            bool? autoAssignCustomDomains,
            string? autoAssignCustomDomainsUpdatedBy,
            string? buildCommand,
            string? commandForIgnoringBuildStep,
            global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant3ProjectConnectConfiguration>? connectConfigurations,
            string? connectConfigurationId,
            bool? connectBuildsEnabled,
            string? passiveConnectConfigurationId,
            double? createdAt,
            bool? customerSupportCodeVisibility,
            global::Vercel.GetProjectsResponseVariant3ProjectCrons? crons,
            global::Vercel.GetProjectsResponseVariant3ProjectDataCache? dataCache,
            object? delegatedProtection,
            string? devCommand,
            string? installCommand,
            global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant3ProjectEnvItem>? env,
            global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant3ProjectCustomEnvironment>? customEnvironments,
            global::Vercel.GetProjectsResponseVariant3ProjectFramework? framework,
            bool? gitForkProtection,
            bool? gitLFS,
            global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant3ProjectIpBucket>? ipBuckets,
            global::Vercel.GetProjectsResponseVariant3ProjectJobs? jobs,
            global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant3ProjectLatestDeployment>? latestDeployments,
            global::Vercel.OneOf<global::Vercel.GetProjectsResponseVariant3ProjectLinkVariant1, global::Vercel.GetProjectsResponseVariant3ProjectLinkVariant2, global::Vercel.GetProjectsResponseVariant3ProjectLinkVariant3, global::Vercel.GetProjectsResponseVariant3ProjectLinkVariant4, global::Vercel.GetProjectsResponseVariant3ProjectLinkVariant5, global::Vercel.GetProjectsResponseVariant3ProjectLinkVariant6>? link,
            global::Vercel.OneOf<global::Vercel.GetProjectsResponseVariant3ProjectMicrofrontendsVariant1, global::Vercel.GetProjectsResponseVariant3ProjectMicrofrontendsVariant2, global::Vercel.GetProjectsResponseVariant3ProjectMicrofrontendsVariant3>? microfrontends,
            global::Vercel.GetProjectsResponseVariant3ProjectOptionsAllowlist? optionsAllowlist,
            string? outputDirectory,
            object? passwordProtection,
            bool? productionDeploymentsFastLane,
            bool? publicSource,
            global::Vercel.GetProjectsResponseVariant3ProjectRollbackDescription? rollbackDescription,
            global::Vercel.GetProjectsResponseVariant3ProjectRollingRelease? rollingRelease,
            string? rootDirectory,
            bool? serverlessFunctionZeroConfigFailover,
            double? skewProtectionBoundaryAt,
            double? skewProtectionMaxAge,
            global::System.Collections.Generic.IList<string>? skewProtectionAllowedDomains,
            bool? skipGitConnectDuringLink,
            global::Vercel.GetProjectsResponseVariant3ProjectStaticIps? staticIps,
            bool? sourceFilesOutsideRootDirectory,
            bool? enableAffectedProjectsDeployments,
            bool? enableExternalRewriteCaching,
            global::Vercel.GetProjectsResponseVariant3ProjectSsoProtection? ssoProtection,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.GetProjectsResponseVariant3ProjectTargets2?>? targets,
            double? transferCompletedAt,
            double? transferStartedAt,
            string? transferToAccountId,
            string? transferredFromAccountId,
            double? updatedAt,
            bool? live,
            bool? enablePreviewFeedback,
            bool? enableProductionFeedback,
            global::Vercel.GetProjectsResponseVariant3ProjectPermissions? permissions,
            object? lastRollbackTarget,
            global::Vercel.GetProjectsResponseVariant3ProjectLastAliasRequest? lastAliasRequest,
            object? protectionBypass,
            bool? hasActiveBranches,
            global::Vercel.OneOf<global::Vercel.GetProjectsResponseVariant3ProjectTrustedIpsVariant1, global::Vercel.GetProjectsResponseVariant3ProjectTrustedIpsVariant2>? trustedIps,
            global::Vercel.GetProjectsResponseVariant3ProjectTrustedSources? trustedSources,
            global::Vercel.GetProjectsResponseVariant3ProjectGitComments? gitComments,
            global::Vercel.GetProjectsResponseVariant3ProjectGitProviderOptions? gitProviderOptions,
            bool? paused,
            string? concurrencyBucketName,
            global::Vercel.GetProjectsResponseVariant3ProjectWebAnalytics? webAnalytics,
            global::Vercel.GetProjectsResponseVariant3ProjectSecurity? security,
            global::Vercel.GetProjectsResponseVariant3ProjectOidcTokenConfig? oidcTokenConfig,
            string? tier,
            global::Vercel.GetProjectsResponseVariant3ProjectFlatRateTier? flatRateTier,
            global::Vercel.GetProjectsResponseVariant3ProjectUsageStatus? usageStatus,
            global::Vercel.GetProjectsResponseVariant3ProjectFeatures? features,
            bool? v0,
            bool? v0Created,
            global::Vercel.GetProjectsResponseVariant3ProjectAbuse? abuse,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.GetProjectsResponseVariant3ProjectInternalRouteVariant1, global::Vercel.GetProjectsResponseVariant3ProjectInternalRouteVariant2>>? internalRoutes,
            bool? hasDeployments,
            global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant3ProjectDismissedToast>? dismissedToasts,
            bool? protectedSourcemaps,
            global::Vercel.GetProjectsResponseVariant3ProjectTracing? tracing)
        {
            this.AccountId = accountId ?? throw new global::System.ArgumentNullException(nameof(accountId));
            this.Analytics = analytics;
            this.AppliedCve55182Migration = appliedCve55182Migration;
            this.SpeedInsights = speedInsights;
            this.AutoExposeSystemEnvs = autoExposeSystemEnvs;
            this.AutoAssignCustomDomains = autoAssignCustomDomains;
            this.AutoAssignCustomDomainsUpdatedBy = autoAssignCustomDomainsUpdatedBy;
            this.BuildCommand = buildCommand;
            this.CommandForIgnoringBuildStep = commandForIgnoringBuildStep;
            this.ConnectConfigurations = connectConfigurations;
            this.ConnectConfigurationId = connectConfigurationId;
            this.ConnectBuildsEnabled = connectBuildsEnabled;
            this.PassiveConnectConfigurationId = passiveConnectConfigurationId;
            this.CreatedAt = createdAt;
            this.CustomerSupportCodeVisibility = customerSupportCodeVisibility;
            this.Crons = crons;
            this.DataCache = dataCache;
            this.DelegatedProtection = delegatedProtection;
            this.DeploymentExpiration = deploymentExpiration ?? throw new global::System.ArgumentNullException(nameof(deploymentExpiration));
            this.DevCommand = devCommand;
            this.DirectoryListing = directoryListing;
            this.InstallCommand = installCommand;
            this.Env = env;
            this.CustomEnvironments = customEnvironments;
            this.Framework = framework;
            this.GitForkProtection = gitForkProtection;
            this.GitLFS = gitLFS;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.IpBuckets = ipBuckets;
            this.Jobs = jobs;
            this.LatestDeployments = latestDeployments;
            this.Link = link;
            this.Microfrontends = microfrontends;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.NodeVersion = nodeVersion;
            this.OptionsAllowlist = optionsAllowlist;
            this.OutputDirectory = outputDirectory;
            this.PasswordProtection = passwordProtection;
            this.ProductionDeploymentsFastLane = productionDeploymentsFastLane;
            this.PublicSource = publicSource;
            this.ResourceConfig = resourceConfig ?? throw new global::System.ArgumentNullException(nameof(resourceConfig));
            this.RollbackDescription = rollbackDescription;
            this.RollingRelease = rollingRelease;
            this.DefaultResourceConfig = defaultResourceConfig ?? throw new global::System.ArgumentNullException(nameof(defaultResourceConfig));
            this.RootDirectory = rootDirectory;
            this.ServerlessFunctionZeroConfigFailover = serverlessFunctionZeroConfigFailover;
            this.SkewProtectionBoundaryAt = skewProtectionBoundaryAt;
            this.SkewProtectionMaxAge = skewProtectionMaxAge;
            this.SkewProtectionAllowedDomains = skewProtectionAllowedDomains;
            this.SkipGitConnectDuringLink = skipGitConnectDuringLink;
            this.StaticIps = staticIps;
            this.SourceFilesOutsideRootDirectory = sourceFilesOutsideRootDirectory;
            this.EnableAffectedProjectsDeployments = enableAffectedProjectsDeployments;
            this.EnableExternalRewriteCaching = enableExternalRewriteCaching;
            this.SsoProtection = ssoProtection;
            this.Targets = targets;
            this.TransferCompletedAt = transferCompletedAt;
            this.TransferStartedAt = transferStartedAt;
            this.TransferToAccountId = transferToAccountId;
            this.TransferredFromAccountId = transferredFromAccountId;
            this.UpdatedAt = updatedAt;
            this.Live = live;
            this.EnablePreviewFeedback = enablePreviewFeedback;
            this.EnableProductionFeedback = enableProductionFeedback;
            this.Permissions = permissions;
            this.LastRollbackTarget = lastRollbackTarget;
            this.LastAliasRequest = lastAliasRequest;
            this.ProtectionBypass = protectionBypass;
            this.HasActiveBranches = hasActiveBranches;
            this.TrustedIps = trustedIps;
            this.TrustedSources = trustedSources;
            this.GitComments = gitComments;
            this.GitProviderOptions = gitProviderOptions;
            this.Paused = paused;
            this.ConcurrencyBucketName = concurrencyBucketName;
            this.WebAnalytics = webAnalytics;
            this.Security = security;
            this.OidcTokenConfig = oidcTokenConfig;
            this.Tier = tier;
            this.FlatRateTier = flatRateTier;
            this.UsageStatus = usageStatus;
            this.Features = features;
            this.V0 = v0;
            this.V0Created = v0Created;
            this.Abuse = abuse;
            this.InternalRoutes = internalRoutes;
            this.HasDeployments = hasDeployments;
            this.DismissedToasts = dismissedToasts;
            this.ProtectedSourcemaps = protectedSourcemaps;
            this.Tracing = tracing;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant3Project" /> class.
        /// </summary>
        public GetProjectsResponseVariant3Project()
        {
        }
    }
}