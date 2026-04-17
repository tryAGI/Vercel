
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetMicrofrontendsInGroupResponseProject
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
        public global::Vercel.GetMicrofrontendsInGroupResponseProjectAnalytics? Analytics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appliedCve55182Migration")]
        public bool? AppliedCve55182Migration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speedInsights")]
        public global::Vercel.GetMicrofrontendsInGroupResponseProjectSpeedInsights? SpeedInsights { get; set; }

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
        public global::System.Collections.Generic.IList<global::Vercel.GetMicrofrontendsInGroupResponseProjectConnectConfiguration>? ConnectConfigurations { get; set; }

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
        public global::Vercel.GetMicrofrontendsInGroupResponseProjectCrons? Crons { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataCache")]
        public global::Vercel.GetMicrofrontendsInGroupResponseProjectDataCache? DataCache { get; set; }

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
        public required global::Vercel.GetMicrofrontendsInGroupResponseProjectDeploymentExpiration DeploymentExpiration { get; set; }

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
        public global::System.Collections.Generic.IList<global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItem>? Env { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customEnvironments")]
        public global::System.Collections.Generic.IList<global::Vercel.GetMicrofrontendsInGroupResponseProjectCustomEnvironment>? CustomEnvironments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("framework")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetMicrofrontendsInGroupResponseProjectFrameworkJsonConverter))]
        public global::Vercel.GetMicrofrontendsInGroupResponseProjectFramework? Framework { get; set; }

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
        public global::System.Collections.Generic.IList<global::Vercel.GetMicrofrontendsInGroupResponseProjectIpBucket>? IpBuckets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobs")]
        public global::Vercel.GetMicrofrontendsInGroupResponseProjectJobs? Jobs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latestDeployments")]
        public global::System.Collections.Generic.IList<global::Vercel.GetMicrofrontendsInGroupResponseProjectLatestDeployment>? LatestDeployments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("link")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.GetMicrofrontendsInGroupResponseProjectLinkVariant1, global::Vercel.GetMicrofrontendsInGroupResponseProjectLinkVariant2, global::Vercel.GetMicrofrontendsInGroupResponseProjectLinkVariant3, global::Vercel.GetMicrofrontendsInGroupResponseProjectLinkVariant4, global::Vercel.GetMicrofrontendsInGroupResponseProjectLinkVariant5, global::Vercel.GetMicrofrontendsInGroupResponseProjectLinkVariant6>))]
        public global::Vercel.OneOf<global::Vercel.GetMicrofrontendsInGroupResponseProjectLinkVariant1, global::Vercel.GetMicrofrontendsInGroupResponseProjectLinkVariant2, global::Vercel.GetMicrofrontendsInGroupResponseProjectLinkVariant3, global::Vercel.GetMicrofrontendsInGroupResponseProjectLinkVariant4, global::Vercel.GetMicrofrontendsInGroupResponseProjectLinkVariant5, global::Vercel.GetMicrofrontendsInGroupResponseProjectLinkVariant6>? Link { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microfrontends")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.GetMicrofrontendsInGroupResponseProjectMicrofrontendsVariant1, global::Vercel.GetMicrofrontendsInGroupResponseProjectMicrofrontendsVariant2, global::Vercel.GetMicrofrontendsInGroupResponseProjectMicrofrontendsVariant3>))]
        public global::Vercel.OneOf<global::Vercel.GetMicrofrontendsInGroupResponseProjectMicrofrontendsVariant1, global::Vercel.GetMicrofrontendsInGroupResponseProjectMicrofrontendsVariant2, global::Vercel.GetMicrofrontendsInGroupResponseProjectMicrofrontendsVariant3>? Microfrontends { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetMicrofrontendsInGroupResponseProjectNodeVersionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetMicrofrontendsInGroupResponseProjectNodeVersion NodeVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("optionsAllowlist")]
        public global::Vercel.GetMicrofrontendsInGroupResponseProjectOptionsAllowlist? OptionsAllowlist { get; set; }

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
        public required global::Vercel.GetMicrofrontendsInGroupResponseProjectResourceConfig ResourceConfig { get; set; }

        /// <summary>
        /// Description of why a project was rolled back, and by whom. Note that lastAliasRequest contains the from/to details of the rollback.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rollbackDescription")]
        public global::Vercel.GetMicrofrontendsInGroupResponseProjectRollbackDescription? RollbackDescription { get; set; }

        /// <summary>
        /// Project-level rolling release configuration that defines how deployments should be gradually rolled out
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rollingRelease")]
        public global::Vercel.GetMicrofrontendsInGroupResponseProjectRollingRelease? RollingRelease { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultResourceConfig")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetMicrofrontendsInGroupResponseProjectDefaultResourceConfig DefaultResourceConfig { get; set; }

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
        public global::Vercel.GetMicrofrontendsInGroupResponseProjectStaticIps? StaticIps { get; set; }

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
        public global::Vercel.GetMicrofrontendsInGroupResponseProjectSsoProtection? SsoProtection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targets")]
        public global::System.Collections.Generic.Dictionary<string, global::Vercel.GetMicrofrontendsInGroupResponseProjectTargets2?>? Targets { get; set; }

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
        public global::Vercel.GetMicrofrontendsInGroupResponseProjectPermissions? Permissions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastRollbackTarget")]
        public object? LastRollbackTarget { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastAliasRequest")]
        public global::Vercel.GetMicrofrontendsInGroupResponseProjectLastAliasRequest? LastAliasRequest { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.GetMicrofrontendsInGroupResponseProjectTrustedIpsVariant1, global::Vercel.GetMicrofrontendsInGroupResponseProjectTrustedIpsVariant2>))]
        public global::Vercel.OneOf<global::Vercel.GetMicrofrontendsInGroupResponseProjectTrustedIpsVariant1, global::Vercel.GetMicrofrontendsInGroupResponseProjectTrustedIpsVariant2>? TrustedIps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trustedSources")]
        public global::Vercel.GetMicrofrontendsInGroupResponseProjectTrustedSources? TrustedSources { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitComments")]
        public global::Vercel.GetMicrofrontendsInGroupResponseProjectGitComments? GitComments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitProviderOptions")]
        public global::Vercel.GetMicrofrontendsInGroupResponseProjectGitProviderOptions? GitProviderOptions { get; set; }

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
        public global::Vercel.GetMicrofrontendsInGroupResponseProjectWebAnalytics? WebAnalytics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security")]
        public global::Vercel.GetMicrofrontendsInGroupResponseProjectSecurity? Security { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oidcTokenConfig")]
        public global::Vercel.GetMicrofrontendsInGroupResponseProjectOidcTokenConfig? OidcTokenConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier")]
        public string? Tier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flatRateTier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetMicrofrontendsInGroupResponseProjectFlatRateTierJsonConverter))]
        public global::Vercel.GetMicrofrontendsInGroupResponseProjectFlatRateTier? FlatRateTier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usageStatus")]
        public global::Vercel.GetMicrofrontendsInGroupResponseProjectUsageStatus? UsageStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("features")]
        public global::Vercel.GetMicrofrontendsInGroupResponseProjectFeatures? Features { get; set; }

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
        public global::Vercel.GetMicrofrontendsInGroupResponseProjectAbuse? Abuse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("internalRoutes")]
        public global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.GetMicrofrontendsInGroupResponseProjectInternalRouteVariant1, global::Vercel.GetMicrofrontendsInGroupResponseProjectInternalRouteVariant2>>? InternalRoutes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasDeployments")]
        public bool? HasDeployments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissedToasts")]
        public global::System.Collections.Generic.IList<global::Vercel.GetMicrofrontendsInGroupResponseProjectDismissedToast>? DismissedToasts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protectedSourcemaps")]
        public bool? ProtectedSourcemaps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracing")]
        public global::Vercel.GetMicrofrontendsInGroupResponseProjectTracing? Tracing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMicrofrontendsInGroupResponseProject" /> class.
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
        public GetMicrofrontendsInGroupResponseProject(
            string accountId,
            global::Vercel.GetMicrofrontendsInGroupResponseProjectDeploymentExpiration deploymentExpiration,
            bool directoryListing,
            string id,
            string name,
            global::Vercel.GetMicrofrontendsInGroupResponseProjectNodeVersion nodeVersion,
            global::Vercel.GetMicrofrontendsInGroupResponseProjectResourceConfig resourceConfig,
            global::Vercel.GetMicrofrontendsInGroupResponseProjectDefaultResourceConfig defaultResourceConfig,
            global::Vercel.GetMicrofrontendsInGroupResponseProjectAnalytics? analytics,
            bool? appliedCve55182Migration,
            global::Vercel.GetMicrofrontendsInGroupResponseProjectSpeedInsights? speedInsights,
            bool? autoExposeSystemEnvs,
            bool? autoAssignCustomDomains,
            string? autoAssignCustomDomainsUpdatedBy,
            string? buildCommand,
            string? commandForIgnoringBuildStep,
            global::System.Collections.Generic.IList<global::Vercel.GetMicrofrontendsInGroupResponseProjectConnectConfiguration>? connectConfigurations,
            string? connectConfigurationId,
            bool? connectBuildsEnabled,
            string? passiveConnectConfigurationId,
            double? createdAt,
            bool? customerSupportCodeVisibility,
            global::Vercel.GetMicrofrontendsInGroupResponseProjectCrons? crons,
            global::Vercel.GetMicrofrontendsInGroupResponseProjectDataCache? dataCache,
            object? delegatedProtection,
            string? devCommand,
            string? installCommand,
            global::System.Collections.Generic.IList<global::Vercel.GetMicrofrontendsInGroupResponseProjectEnvItem>? env,
            global::System.Collections.Generic.IList<global::Vercel.GetMicrofrontendsInGroupResponseProjectCustomEnvironment>? customEnvironments,
            global::Vercel.GetMicrofrontendsInGroupResponseProjectFramework? framework,
            bool? gitForkProtection,
            bool? gitLFS,
            global::System.Collections.Generic.IList<global::Vercel.GetMicrofrontendsInGroupResponseProjectIpBucket>? ipBuckets,
            global::Vercel.GetMicrofrontendsInGroupResponseProjectJobs? jobs,
            global::System.Collections.Generic.IList<global::Vercel.GetMicrofrontendsInGroupResponseProjectLatestDeployment>? latestDeployments,
            global::Vercel.OneOf<global::Vercel.GetMicrofrontendsInGroupResponseProjectLinkVariant1, global::Vercel.GetMicrofrontendsInGroupResponseProjectLinkVariant2, global::Vercel.GetMicrofrontendsInGroupResponseProjectLinkVariant3, global::Vercel.GetMicrofrontendsInGroupResponseProjectLinkVariant4, global::Vercel.GetMicrofrontendsInGroupResponseProjectLinkVariant5, global::Vercel.GetMicrofrontendsInGroupResponseProjectLinkVariant6>? link,
            global::Vercel.OneOf<global::Vercel.GetMicrofrontendsInGroupResponseProjectMicrofrontendsVariant1, global::Vercel.GetMicrofrontendsInGroupResponseProjectMicrofrontendsVariant2, global::Vercel.GetMicrofrontendsInGroupResponseProjectMicrofrontendsVariant3>? microfrontends,
            global::Vercel.GetMicrofrontendsInGroupResponseProjectOptionsAllowlist? optionsAllowlist,
            string? outputDirectory,
            object? passwordProtection,
            bool? productionDeploymentsFastLane,
            bool? publicSource,
            global::Vercel.GetMicrofrontendsInGroupResponseProjectRollbackDescription? rollbackDescription,
            global::Vercel.GetMicrofrontendsInGroupResponseProjectRollingRelease? rollingRelease,
            string? rootDirectory,
            bool? serverlessFunctionZeroConfigFailover,
            double? skewProtectionBoundaryAt,
            double? skewProtectionMaxAge,
            global::System.Collections.Generic.IList<string>? skewProtectionAllowedDomains,
            bool? skipGitConnectDuringLink,
            global::Vercel.GetMicrofrontendsInGroupResponseProjectStaticIps? staticIps,
            bool? sourceFilesOutsideRootDirectory,
            bool? enableAffectedProjectsDeployments,
            bool? enableExternalRewriteCaching,
            global::Vercel.GetMicrofrontendsInGroupResponseProjectSsoProtection? ssoProtection,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.GetMicrofrontendsInGroupResponseProjectTargets2?>? targets,
            double? transferCompletedAt,
            double? transferStartedAt,
            string? transferToAccountId,
            string? transferredFromAccountId,
            double? updatedAt,
            bool? live,
            bool? enablePreviewFeedback,
            bool? enableProductionFeedback,
            global::Vercel.GetMicrofrontendsInGroupResponseProjectPermissions? permissions,
            object? lastRollbackTarget,
            global::Vercel.GetMicrofrontendsInGroupResponseProjectLastAliasRequest? lastAliasRequest,
            object? protectionBypass,
            bool? hasActiveBranches,
            global::Vercel.OneOf<global::Vercel.GetMicrofrontendsInGroupResponseProjectTrustedIpsVariant1, global::Vercel.GetMicrofrontendsInGroupResponseProjectTrustedIpsVariant2>? trustedIps,
            global::Vercel.GetMicrofrontendsInGroupResponseProjectTrustedSources? trustedSources,
            global::Vercel.GetMicrofrontendsInGroupResponseProjectGitComments? gitComments,
            global::Vercel.GetMicrofrontendsInGroupResponseProjectGitProviderOptions? gitProviderOptions,
            bool? paused,
            string? concurrencyBucketName,
            global::Vercel.GetMicrofrontendsInGroupResponseProjectWebAnalytics? webAnalytics,
            global::Vercel.GetMicrofrontendsInGroupResponseProjectSecurity? security,
            global::Vercel.GetMicrofrontendsInGroupResponseProjectOidcTokenConfig? oidcTokenConfig,
            string? tier,
            global::Vercel.GetMicrofrontendsInGroupResponseProjectFlatRateTier? flatRateTier,
            global::Vercel.GetMicrofrontendsInGroupResponseProjectUsageStatus? usageStatus,
            global::Vercel.GetMicrofrontendsInGroupResponseProjectFeatures? features,
            bool? v0,
            bool? v0Created,
            global::Vercel.GetMicrofrontendsInGroupResponseProjectAbuse? abuse,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.GetMicrofrontendsInGroupResponseProjectInternalRouteVariant1, global::Vercel.GetMicrofrontendsInGroupResponseProjectInternalRouteVariant2>>? internalRoutes,
            bool? hasDeployments,
            global::System.Collections.Generic.IList<global::Vercel.GetMicrofrontendsInGroupResponseProjectDismissedToast>? dismissedToasts,
            bool? protectedSourcemaps,
            global::Vercel.GetMicrofrontendsInGroupResponseProjectTracing? tracing)
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
        /// Initializes a new instance of the <see cref="GetMicrofrontendsInGroupResponseProject" /> class.
        /// </summary>
        public GetMicrofrontendsInGroupResponseProject()
        {
        }
    }
}