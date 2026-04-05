
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateProjectResponse
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
        public global::Vercel.CreateProjectResponseAnalytics? Analytics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appliedCve55182Migration")]
        public bool? AppliedCve55182Migration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speedInsights")]
        public global::Vercel.CreateProjectResponseSpeedInsights? SpeedInsights { get; set; }

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
        public global::System.Collections.Generic.IList<global::Vercel.CreateProjectResponseConnectConfiguration>? ConnectConfigurations { get; set; }

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
        public global::Vercel.CreateProjectResponseCrons? Crons { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataCache")]
        public global::Vercel.CreateProjectResponseDataCache? DataCache { get; set; }

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
        public required global::Vercel.CreateProjectResponseDeploymentExpiration DeploymentExpiration { get; set; }

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
        public global::System.Collections.Generic.IList<global::Vercel.CreateProjectResponseEnvItem>? Env { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customEnvironments")]
        public global::System.Collections.Generic.IList<global::Vercel.CreateProjectResponseCustomEnvironment>? CustomEnvironments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("framework")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateProjectResponseFrameworkJsonConverter))]
        public global::Vercel.CreateProjectResponseFramework? Framework { get; set; }

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
        public global::System.Collections.Generic.IList<global::Vercel.CreateProjectResponseIpBucket>? IpBuckets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobs")]
        public global::Vercel.CreateProjectResponseJobs? Jobs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latestDeployments")]
        public global::System.Collections.Generic.IList<global::Vercel.CreateProjectResponseLatestDeployment>? LatestDeployments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("link")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.CreateProjectResponseLinkVariant1, global::Vercel.CreateProjectResponseLinkVariant2, global::Vercel.CreateProjectResponseLinkVariant3, global::Vercel.CreateProjectResponseLinkVariant4, global::Vercel.CreateProjectResponseLinkVariant5, global::Vercel.CreateProjectResponseLinkVariant6>))]
        public global::Vercel.OneOf<global::Vercel.CreateProjectResponseLinkVariant1, global::Vercel.CreateProjectResponseLinkVariant2, global::Vercel.CreateProjectResponseLinkVariant3, global::Vercel.CreateProjectResponseLinkVariant4, global::Vercel.CreateProjectResponseLinkVariant5, global::Vercel.CreateProjectResponseLinkVariant6>? Link { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microfrontends")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.CreateProjectResponseMicrofrontendsVariant1, global::Vercel.CreateProjectResponseMicrofrontendsVariant2, global::Vercel.CreateProjectResponseMicrofrontendsVariant3>))]
        public global::Vercel.OneOf<global::Vercel.CreateProjectResponseMicrofrontendsVariant1, global::Vercel.CreateProjectResponseMicrofrontendsVariant2, global::Vercel.CreateProjectResponseMicrofrontendsVariant3>? Microfrontends { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateProjectResponseNodeVersionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateProjectResponseNodeVersion NodeVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("optionsAllowlist")]
        public global::Vercel.CreateProjectResponseOptionsAllowlist? OptionsAllowlist { get; set; }

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
        public required global::Vercel.CreateProjectResponseResourceConfig ResourceConfig { get; set; }

        /// <summary>
        /// Description of why a project was rolled back, and by whom. Note that lastAliasRequest contains the from/to details of the rollback.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rollbackDescription")]
        public global::Vercel.CreateProjectResponseRollbackDescription? RollbackDescription { get; set; }

        /// <summary>
        /// Project-level rolling release configuration that defines how deployments should be gradually rolled out
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rollingRelease")]
        public global::Vercel.CreateProjectResponseRollingRelease? RollingRelease { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultResourceConfig")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateProjectResponseDefaultResourceConfig DefaultResourceConfig { get; set; }

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
        public global::Vercel.CreateProjectResponseStaticIps? StaticIps { get; set; }

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
        public global::Vercel.CreateProjectResponseSsoProtection? SsoProtection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targets")]
        public global::System.Collections.Generic.Dictionary<string, global::Vercel.CreateProjectResponseTargets2?>? Targets { get; set; }

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
        public global::Vercel.CreateProjectResponsePermissions? Permissions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastRollbackTarget")]
        public object? LastRollbackTarget { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastAliasRequest")]
        public global::Vercel.CreateProjectResponseLastAliasRequest? LastAliasRequest { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.CreateProjectResponseTrustedIpsVariant1, global::Vercel.CreateProjectResponseTrustedIpsVariant2>))]
        public global::Vercel.OneOf<global::Vercel.CreateProjectResponseTrustedIpsVariant1, global::Vercel.CreateProjectResponseTrustedIpsVariant2>? TrustedIps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitComments")]
        public global::Vercel.CreateProjectResponseGitComments? GitComments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitProviderOptions")]
        public global::Vercel.CreateProjectResponseGitProviderOptions? GitProviderOptions { get; set; }

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
        public global::Vercel.CreateProjectResponseWebAnalytics? WebAnalytics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security")]
        public global::Vercel.CreateProjectResponseSecurity? Security { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oidcTokenConfig")]
        public global::Vercel.CreateProjectResponseOidcTokenConfig? OidcTokenConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier")]
        public string? Tier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flatRateTier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateProjectResponseFlatRateTierJsonConverter))]
        public global::Vercel.CreateProjectResponseFlatRateTier? FlatRateTier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usageStatus")]
        public global::Vercel.CreateProjectResponseUsageStatus? UsageStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("features")]
        public global::Vercel.CreateProjectResponseFeatures? Features { get; set; }

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
        public global::Vercel.CreateProjectResponseAbuse? Abuse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("internalRoutes")]
        public global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.CreateProjectResponseInternalRouteVariant1, global::Vercel.CreateProjectResponseInternalRouteVariant2>>? InternalRoutes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasDeployments")]
        public bool? HasDeployments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissedToasts")]
        public global::System.Collections.Generic.IList<global::Vercel.CreateProjectResponseDismissedToast>? DismissedToasts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protectedSourcemaps")]
        public bool? ProtectedSourcemaps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracing")]
        public global::Vercel.CreateProjectResponseTracing? Tracing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectResponse" /> class.
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
        public CreateProjectResponse(
            string accountId,
            global::Vercel.CreateProjectResponseDeploymentExpiration deploymentExpiration,
            bool directoryListing,
            string id,
            string name,
            global::Vercel.CreateProjectResponseNodeVersion nodeVersion,
            global::Vercel.CreateProjectResponseResourceConfig resourceConfig,
            global::Vercel.CreateProjectResponseDefaultResourceConfig defaultResourceConfig,
            global::Vercel.CreateProjectResponseAnalytics? analytics,
            bool? appliedCve55182Migration,
            global::Vercel.CreateProjectResponseSpeedInsights? speedInsights,
            bool? autoExposeSystemEnvs,
            bool? autoAssignCustomDomains,
            string? autoAssignCustomDomainsUpdatedBy,
            string? buildCommand,
            string? commandForIgnoringBuildStep,
            global::System.Collections.Generic.IList<global::Vercel.CreateProjectResponseConnectConfiguration>? connectConfigurations,
            string? connectConfigurationId,
            bool? connectBuildsEnabled,
            string? passiveConnectConfigurationId,
            double? createdAt,
            bool? customerSupportCodeVisibility,
            global::Vercel.CreateProjectResponseCrons? crons,
            global::Vercel.CreateProjectResponseDataCache? dataCache,
            object? delegatedProtection,
            string? devCommand,
            string? installCommand,
            global::System.Collections.Generic.IList<global::Vercel.CreateProjectResponseEnvItem>? env,
            global::System.Collections.Generic.IList<global::Vercel.CreateProjectResponseCustomEnvironment>? customEnvironments,
            global::Vercel.CreateProjectResponseFramework? framework,
            bool? gitForkProtection,
            bool? gitLFS,
            global::System.Collections.Generic.IList<global::Vercel.CreateProjectResponseIpBucket>? ipBuckets,
            global::Vercel.CreateProjectResponseJobs? jobs,
            global::System.Collections.Generic.IList<global::Vercel.CreateProjectResponseLatestDeployment>? latestDeployments,
            global::Vercel.OneOf<global::Vercel.CreateProjectResponseLinkVariant1, global::Vercel.CreateProjectResponseLinkVariant2, global::Vercel.CreateProjectResponseLinkVariant3, global::Vercel.CreateProjectResponseLinkVariant4, global::Vercel.CreateProjectResponseLinkVariant5, global::Vercel.CreateProjectResponseLinkVariant6>? link,
            global::Vercel.OneOf<global::Vercel.CreateProjectResponseMicrofrontendsVariant1, global::Vercel.CreateProjectResponseMicrofrontendsVariant2, global::Vercel.CreateProjectResponseMicrofrontendsVariant3>? microfrontends,
            global::Vercel.CreateProjectResponseOptionsAllowlist? optionsAllowlist,
            string? outputDirectory,
            object? passwordProtection,
            bool? productionDeploymentsFastLane,
            bool? publicSource,
            global::Vercel.CreateProjectResponseRollbackDescription? rollbackDescription,
            global::Vercel.CreateProjectResponseRollingRelease? rollingRelease,
            string? rootDirectory,
            bool? serverlessFunctionZeroConfigFailover,
            double? skewProtectionBoundaryAt,
            double? skewProtectionMaxAge,
            global::System.Collections.Generic.IList<string>? skewProtectionAllowedDomains,
            bool? skipGitConnectDuringLink,
            global::Vercel.CreateProjectResponseStaticIps? staticIps,
            bool? sourceFilesOutsideRootDirectory,
            bool? enableAffectedProjectsDeployments,
            bool? enableExternalRewriteCaching,
            global::Vercel.CreateProjectResponseSsoProtection? ssoProtection,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.CreateProjectResponseTargets2?>? targets,
            double? transferCompletedAt,
            double? transferStartedAt,
            string? transferToAccountId,
            string? transferredFromAccountId,
            double? updatedAt,
            bool? live,
            bool? enablePreviewFeedback,
            bool? enableProductionFeedback,
            global::Vercel.CreateProjectResponsePermissions? permissions,
            object? lastRollbackTarget,
            global::Vercel.CreateProjectResponseLastAliasRequest? lastAliasRequest,
            object? protectionBypass,
            bool? hasActiveBranches,
            global::Vercel.OneOf<global::Vercel.CreateProjectResponseTrustedIpsVariant1, global::Vercel.CreateProjectResponseTrustedIpsVariant2>? trustedIps,
            global::Vercel.CreateProjectResponseGitComments? gitComments,
            global::Vercel.CreateProjectResponseGitProviderOptions? gitProviderOptions,
            bool? paused,
            string? concurrencyBucketName,
            global::Vercel.CreateProjectResponseWebAnalytics? webAnalytics,
            global::Vercel.CreateProjectResponseSecurity? security,
            global::Vercel.CreateProjectResponseOidcTokenConfig? oidcTokenConfig,
            string? tier,
            global::Vercel.CreateProjectResponseFlatRateTier? flatRateTier,
            global::Vercel.CreateProjectResponseUsageStatus? usageStatus,
            global::Vercel.CreateProjectResponseFeatures? features,
            bool? v0,
            bool? v0Created,
            global::Vercel.CreateProjectResponseAbuse? abuse,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.CreateProjectResponseInternalRouteVariant1, global::Vercel.CreateProjectResponseInternalRouteVariant2>>? internalRoutes,
            bool? hasDeployments,
            global::System.Collections.Generic.IList<global::Vercel.CreateProjectResponseDismissedToast>? dismissedToasts,
            bool? protectedSourcemaps,
            global::Vercel.CreateProjectResponseTracing? tracing)
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
        /// Initializes a new instance of the <see cref="CreateProjectResponse" /> class.
        /// </summary>
        public CreateProjectResponse()
        {
        }
    }
}