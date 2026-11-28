
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared2eb5520e92a3b839
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
        public global::Vercel.AutoSDKShared2eb5520e92a3b839Analytics? Analytics { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar")]
        public string? Avatar { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatarDarkMode")]
        public string? AvatarDarkMode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blobs")]
        public global::Vercel.AutoSDKShared2eb5520e92a3b839Blobs? Blobs { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrencyBucketName")]
        public string? ConcurrencyBucketName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectBuildsEnabled")]
        public bool? ConnectBuildsEnabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectConfigurationId")]
        public string? ConnectConfigurationId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectConfigurations")]
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared2eb5520e92a3b839ConnectConfiguration>? ConnectConfigurations { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public double? CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared58ffef5c4d095b17JsonConverter))]
        public global::Vercel.AutoSDKShared58ffef5c4d095b17? Creator { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crons")]
        public global::Vercel.AutoSDKShared2eb5520e92a3b839Crons? Crons { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customEnvironments")]
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared7d4f4f5cff68219a>? CustomEnvironments { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customerSupportCodeVisibility")]
        public bool? CustomerSupportCodeVisibility { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataCache")]
        public global::Vercel.AutoSDKShared2eb5520e92a3b839DataCache? DataCache { get; set; }

        /// <summary>
        /// Project resource config returned by the API. `buildMachineType` is a fixed machine type or `elastic`; the active Elastic machine is reported through `elasticBuildMachine`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultResourceConfig")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedd67d8d405d3f0000 DefaultResourceConfig { get; set; }

        /// <summary>
        /// Retention policies for deployments. These are enforced at the project level, but we also maintain an instance of this at the team level as a default policy that gets applied to new projects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentExpiration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared2eb5520e92a3b839DeploymentExpiration DeploymentExpiration { get; set; }

        /// <summary>
        /// Project shape. `null` on a rule list clears the project's override for that rule type (fall back to team for every env); omitting is equivalent. Setting `deploymentPolicy` itself to `null` clears every override at once. Kept structurally distinct from {@link TeamDeploymentPolicy} so the two storage locations don't share a type by accident.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentPolicy")]
        public global::Vercel.AutoSDKShared803d328dcef47295? DeploymentPolicy { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissedToasts")]
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared2eb5520e92a3b839DismissedToast>? DismissedToasts { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared470bc56668090392>? Env { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKShared2eb5520e92a3b839ExpirationVariant1, global::Vercel.AutoSDKShared2eb5520e92a3b839ExpirationVariant2>))]
        public global::Vercel.OneOf<global::Vercel.AutoSDKShared2eb5520e92a3b839ExpirationVariant1, global::Vercel.AutoSDKShared2eb5520e92a3b839ExpirationVariant2>? Expiration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("features")]
        public global::Vercel.AutoSDKShared2eb5520e92a3b839Features? Features { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("framework")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared2eb5520e92a3b839FrameworkJsonConverter))]
        public global::Vercel.AutoSDKShared2eb5520e92a3b839Framework? Framework { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitComments")]
        public global::Vercel.AutoSDKShared2eb5520e92a3b839GitComments? GitComments { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("hasDeployments")]
        public bool? HasDeployments { get; set; }

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
        public global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.AutoSDKShared2eb5520e92a3b839InternalRouteVariant1, global::Vercel.AutoSDKShared2eb5520e92a3b839InternalRouteVariant2>>? InternalRoutes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ipBuckets")]
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared2eb5520e92a3b839IpBucket>? IpBuckets { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobs")]
        public global::Vercel.AutoSDKShared2eb5520e92a3b839Jobs? Jobs { get; set; }

        /// <summary>
        /// The last promote or rollback request for the project and its job status. Only populated by `GET /v9/projects/{idOrName}` when called with `rollbackInfo=true`; `null` in every other response, even if a request exists.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastAliasRequest")]
        public global::Vercel.AutoSDKShared2eb5520e92a3b839LastAliasRequest? LastAliasRequest { get; set; }

        /// <summary>
        /// Legacy mirror of `lastAliasRequest` without `type`, kept for CLI compatibility. Only populated by `GET /v9/projects/{idOrName}` when called with `rollbackInfo=true`; `null` in every other response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastRollbackTarget")]
        public object? LastRollbackTarget { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("microfrontends")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedea673b94227226faJsonConverter))]
        public global::Vercel.AutoSDKSharedea673b94227226fa? Microfrontends { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared2eb5520e92a3b839NodeVersionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared2eb5520e92a3b839NodeVersion NodeVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oidcTokenConfig")]
        public global::Vercel.AutoSDKShared2eb5520e92a3b839OidcTokenConfig? OidcTokenConfig { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("optionsAllowlist")]
        public global::Vercel.AutoSDKShared2eb5520e92a3b839OptionsAllowlist? OptionsAllowlist { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputDirectory")]
        public string? OutputDirectory { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passiveConnectConfigurationId")]
        public string? PassiveConnectConfigurationId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passport")]
        public global::Vercel.AutoSDKShared2eb5520e92a3b839Passport? Passport { get; set; }

        /// <summary>
        /// Password protection settings returned without the secret password hash.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passwordProtection")]
        public global::Vercel.AutoSDKShared2eb5520e92a3b839PasswordProtection? PasswordProtection { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paused")]
        public bool? Paused { get; set; }

        /// <summary>
        /// Requested and authorized operations when `checkPermissions` is used. Legacy `includePermissions` responses contain a broader, non-authoritative permission summary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        public global::Vercel.AutoSDKShared8cb75454f348bbe8? Permissions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("productionDeploymentsFastLane")]
        public bool? ProductionDeploymentsFastLane { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protectedSourcemaps")]
        public bool? ProtectedSourcemaps { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protectionBypass")]
        public object? ProtectionBypass { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protectionConfig")]
        public global::Vercel.AutoSDKShared2eb5520e92a3b839ProtectionConfig? ProtectionConfig { get; set; }

        /// <summary>
        /// Project resource config returned by the API. `buildMachineType` is a fixed machine type or `elastic`; the active Elastic machine is reported through `elasticBuildMachine`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceConfig")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedd67d8d405d3f0000 ResourceConfig { get; set; }

        /// <summary>
        /// Description of why a project was rolled back, and by whom. Note that lastAliasRequest contains the from/to details of the rollback.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rollbackDescription")]
        public global::Vercel.AutoSDKShared15ac57d28c37cbda? RollbackDescription { get; set; }

        /// <summary>
        /// Project-level rolling release configuration that defines how deployments should be gradually rolled out
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rollingRelease")]
        public global::Vercel.AutoSDKShared2eb5520e92a3b839RollingRelease? RollingRelease { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rootDirectory")]
        public string? RootDirectory { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandbox")]
        public global::Vercel.AutoSDKShared2eb5520e92a3b839Sandbox? Sandbox { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security")]
        public global::Vercel.AutoSDKShared25e1e81cf9eecd30? Security { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serverlessFunctionZeroConfigFailover")]
        public bool? ServerlessFunctionZeroConfigFailover { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("services")]
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared2eb5520e92a3b839Service>? Services { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skewProtectionAllowedDomains")]
        public global::System.Collections.Generic.IList<string>? SkewProtectionAllowedDomains { get; set; }

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
        public global::Vercel.AutoSDKShared2eb5520e92a3b839SpeedInsights? SpeedInsights { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ssoProtection")]
        public global::Vercel.AutoSDKShared2eb5520e92a3b839SsoProtection? SsoProtection { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("staticIps")]
        public global::Vercel.AutoSDKShared2eb5520e92a3b839StaticIps? StaticIps { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targets")]
        public global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared8422af433e1bf486?>? Targets { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared2eb5520e92a3b839TierJsonConverter))]
        public global::Vercel.AutoSDKShared2eb5520e92a3b839Tier? Tier { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracing")]
        public global::Vercel.AutoSDKShared2eb5520e92a3b839Tracing? Tracing { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("trustedIps")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKShared2eb5520e92a3b839TrustedIpsVariant1, global::Vercel.AutoSDKShared2eb5520e92a3b839TrustedIpsVariant2>))]
        public global::Vercel.OneOf<global::Vercel.AutoSDKShared2eb5520e92a3b839TrustedIpsVariant1, global::Vercel.AutoSDKShared2eb5520e92a3b839TrustedIpsVariant2>? TrustedIps { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("usageStatus")]
        public global::Vercel.AutoSDKShared2eb5520e92a3b839UsageStatus? UsageStatus { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("vercelFlags")]
        public global::Vercel.AutoSDKShared2eb5520e92a3b839VercelFlags? VercelFlags { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webAnalytics")]
        public global::Vercel.AutoSDKShared2eb5520e92a3b839WebAnalytics? WebAnalytics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared2eb5520e92a3b839" /> class.
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="alias"></param>
        /// <param name="defaultResourceConfig">
        /// Project resource config returned by the API. `buildMachineType` is a fixed machine type or `elastic`; the active Elastic machine is reported through `elasticBuildMachine`.
        /// </param>
        /// <param name="deploymentExpiration">
        /// Retention policies for deployments. These are enforced at the project level, but we also maintain an instance of this at the team level as a default policy that gets applied to new projects.
        /// </param>
        /// <param name="directoryListing"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="nodeVersion"></param>
        /// <param name="resourceConfig">
        /// Project resource config returned by the API. `buildMachineType` is a fixed machine type or `elastic`; the active Elastic machine is reported through `elasticBuildMachine`.
        /// </param>
        /// <param name="analytics"></param>
        /// <param name="appliedCve55182Migration"></param>
        /// <param name="autoAssignCustomDomains"></param>
        /// <param name="autoAssignCustomDomainsUpdatedBy"></param>
        /// <param name="autoExposeSystemEnvs"></param>
        /// <param name="avatar"></param>
        /// <param name="avatarDarkMode"></param>
        /// <param name="blobs"></param>
        /// <param name="buildCommand"></param>
        /// <param name="commandForIgnoringBuildStep"></param>
        /// <param name="concurrencyBucketName"></param>
        /// <param name="connectBuildsEnabled"></param>
        /// <param name="connectConfigurationId"></param>
        /// <param name="connectConfigurations"></param>
        /// <param name="createdAt"></param>
        /// <param name="creator"></param>
        /// <param name="crons"></param>
        /// <param name="customEnvironments"></param>
        /// <param name="customerSupportCodeVisibility"></param>
        /// <param name="dataCache"></param>
        /// <param name="deploymentPolicy">
        /// Project shape. `null` on a rule list clears the project's override for that rule type (fall back to team for every env); omitting is equivalent. Setting `deploymentPolicy` itself to `null` clears every override at once. Kept structurally distinct from {@link TeamDeploymentPolicy} so the two storage locations don't share a type by accident.
        /// </param>
        /// <param name="devCommand"></param>
        /// <param name="dismissedToasts"></param>
        /// <param name="enableAffectedProjectsDeployments"></param>
        /// <param name="enableExternalRewriteCaching"></param>
        /// <param name="enablePreviewFeedback"></param>
        /// <param name="enableProductionFeedback"></param>
        /// <param name="env"></param>
        /// <param name="expiration"></param>
        /// <param name="features"></param>
        /// <param name="framework"></param>
        /// <param name="gitComments"></param>
        /// <param name="gitForkProtection"></param>
        /// <param name="gitLFS"></param>
        /// <param name="gitProviderOptions"></param>
        /// <param name="hasActiveBranches"></param>
        /// <param name="hasDeployments"></param>
        /// <param name="installCommand"></param>
        /// <param name="internalRoutes"></param>
        /// <param name="ipBuckets"></param>
        /// <param name="jobs"></param>
        /// <param name="lastAliasRequest">
        /// The last promote or rollback request for the project and its job status. Only populated by `GET /v9/projects/{idOrName}` when called with `rollbackInfo=true`; `null` in every other response, even if a request exists.
        /// </param>
        /// <param name="lastRollbackTarget">
        /// Legacy mirror of `lastAliasRequest` without `type`, kept for CLI compatibility. Only populated by `GET /v9/projects/{idOrName}` when called with `rollbackInfo=true`; `null` in every other response.
        /// </param>
        /// <param name="latestDeployments"></param>
        /// <param name="link"></param>
        /// <param name="live"></param>
        /// <param name="microfrontends"></param>
        /// <param name="oidcTokenConfig"></param>
        /// <param name="optionsAllowlist"></param>
        /// <param name="outputDirectory"></param>
        /// <param name="passiveConnectConfigurationId"></param>
        /// <param name="passport"></param>
        /// <param name="passwordProtection">
        /// Password protection settings returned without the secret password hash.
        /// </param>
        /// <param name="paused"></param>
        /// <param name="permissions">
        /// Requested and authorized operations when `checkPermissions` is used. Legacy `includePermissions` responses contain a broader, non-authoritative permission summary.
        /// </param>
        /// <param name="productionDeploymentsFastLane"></param>
        /// <param name="protectedSourcemaps"></param>
        /// <param name="protectionBypass"></param>
        /// <param name="protectionConfig"></param>
        /// <param name="rollbackDescription">
        /// Description of why a project was rolled back, and by whom. Note that lastAliasRequest contains the from/to details of the rollback.
        /// </param>
        /// <param name="rollingRelease">
        /// Project-level rolling release configuration that defines how deployments should be gradually rolled out
        /// </param>
        /// <param name="rootDirectory"></param>
        /// <param name="sandbox"></param>
        /// <param name="security"></param>
        /// <param name="serverlessFunctionZeroConfigFailover"></param>
        /// <param name="services"></param>
        /// <param name="skewProtectionAllowedDomains"></param>
        /// <param name="skewProtectionBoundaryAt"></param>
        /// <param name="skewProtectionMaxAge"></param>
        /// <param name="skipGitConnectDuringLink"></param>
        /// <param name="sourceFilesOutsideRootDirectory"></param>
        /// <param name="speedInsights"></param>
        /// <param name="ssoProtection"></param>
        /// <param name="staticIps"></param>
        /// <param name="targets"></param>
        /// <param name="tier"></param>
        /// <param name="tracing"></param>
        /// <param name="transferCompletedAt"></param>
        /// <param name="transferredFromAccountId"></param>
        /// <param name="transferStartedAt"></param>
        /// <param name="transferToAccountId"></param>
        /// <param name="trustedIps"></param>
        /// <param name="trustedSources"></param>
        /// <param name="updatedAt"></param>
        /// <param name="usageStatus"></param>
        /// <param name="v0"></param>
        /// <param name="v0Created"></param>
        /// <param name="vercelFlags"></param>
        /// <param name="webAnalytics"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared2eb5520e92a3b839(
            string accountId,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared29b35dda7b3e47c4> alias,
            global::Vercel.AutoSDKSharedd67d8d405d3f0000 defaultResourceConfig,
            global::Vercel.AutoSDKShared2eb5520e92a3b839DeploymentExpiration deploymentExpiration,
            bool directoryListing,
            string id,
            string name,
            global::Vercel.AutoSDKShared2eb5520e92a3b839NodeVersion nodeVersion,
            global::Vercel.AutoSDKSharedd67d8d405d3f0000 resourceConfig,
            global::Vercel.AutoSDKShared2eb5520e92a3b839Analytics? analytics,
            bool? appliedCve55182Migration,
            bool? autoAssignCustomDomains,
            string? autoAssignCustomDomainsUpdatedBy,
            bool? autoExposeSystemEnvs,
            string? avatar,
            string? avatarDarkMode,
            global::Vercel.AutoSDKShared2eb5520e92a3b839Blobs? blobs,
            string? buildCommand,
            string? commandForIgnoringBuildStep,
            string? concurrencyBucketName,
            bool? connectBuildsEnabled,
            string? connectConfigurationId,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared2eb5520e92a3b839ConnectConfiguration>? connectConfigurations,
            double? createdAt,
            global::Vercel.AutoSDKShared58ffef5c4d095b17? creator,
            global::Vercel.AutoSDKShared2eb5520e92a3b839Crons? crons,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared7d4f4f5cff68219a>? customEnvironments,
            bool? customerSupportCodeVisibility,
            global::Vercel.AutoSDKShared2eb5520e92a3b839DataCache? dataCache,
            global::Vercel.AutoSDKShared803d328dcef47295? deploymentPolicy,
            string? devCommand,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared2eb5520e92a3b839DismissedToast>? dismissedToasts,
            bool? enableAffectedProjectsDeployments,
            bool? enableExternalRewriteCaching,
            bool? enablePreviewFeedback,
            bool? enableProductionFeedback,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared470bc56668090392>? env,
            global::Vercel.OneOf<global::Vercel.AutoSDKShared2eb5520e92a3b839ExpirationVariant1, global::Vercel.AutoSDKShared2eb5520e92a3b839ExpirationVariant2>? expiration,
            global::Vercel.AutoSDKShared2eb5520e92a3b839Features? features,
            global::Vercel.AutoSDKShared2eb5520e92a3b839Framework? framework,
            global::Vercel.AutoSDKShared2eb5520e92a3b839GitComments? gitComments,
            bool? gitForkProtection,
            bool? gitLFS,
            global::Vercel.AutoSDKSharedc12640b06f1c9105? gitProviderOptions,
            bool? hasActiveBranches,
            bool? hasDeployments,
            string? installCommand,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.AutoSDKShared2eb5520e92a3b839InternalRouteVariant1, global::Vercel.AutoSDKShared2eb5520e92a3b839InternalRouteVariant2>>? internalRoutes,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared2eb5520e92a3b839IpBucket>? ipBuckets,
            global::Vercel.AutoSDKShared2eb5520e92a3b839Jobs? jobs,
            global::Vercel.AutoSDKShared2eb5520e92a3b839LastAliasRequest? lastAliasRequest,
            object? lastRollbackTarget,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedbca3e7a986162538>? latestDeployments,
            global::Vercel.AutoSDKSharede0f9d68fc63cf31d? link,
            bool? live,
            global::Vercel.AutoSDKSharedea673b94227226fa? microfrontends,
            global::Vercel.AutoSDKShared2eb5520e92a3b839OidcTokenConfig? oidcTokenConfig,
            global::Vercel.AutoSDKShared2eb5520e92a3b839OptionsAllowlist? optionsAllowlist,
            string? outputDirectory,
            string? passiveConnectConfigurationId,
            global::Vercel.AutoSDKShared2eb5520e92a3b839Passport? passport,
            global::Vercel.AutoSDKShared2eb5520e92a3b839PasswordProtection? passwordProtection,
            bool? paused,
            global::Vercel.AutoSDKShared8cb75454f348bbe8? permissions,
            bool? productionDeploymentsFastLane,
            bool? protectedSourcemaps,
            object? protectionBypass,
            global::Vercel.AutoSDKShared2eb5520e92a3b839ProtectionConfig? protectionConfig,
            global::Vercel.AutoSDKShared15ac57d28c37cbda? rollbackDescription,
            global::Vercel.AutoSDKShared2eb5520e92a3b839RollingRelease? rollingRelease,
            string? rootDirectory,
            global::Vercel.AutoSDKShared2eb5520e92a3b839Sandbox? sandbox,
            global::Vercel.AutoSDKShared25e1e81cf9eecd30? security,
            bool? serverlessFunctionZeroConfigFailover,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared2eb5520e92a3b839Service>? services,
            global::System.Collections.Generic.IList<string>? skewProtectionAllowedDomains,
            double? skewProtectionBoundaryAt,
            double? skewProtectionMaxAge,
            bool? skipGitConnectDuringLink,
            bool? sourceFilesOutsideRootDirectory,
            global::Vercel.AutoSDKShared2eb5520e92a3b839SpeedInsights? speedInsights,
            global::Vercel.AutoSDKShared2eb5520e92a3b839SsoProtection? ssoProtection,
            global::Vercel.AutoSDKShared2eb5520e92a3b839StaticIps? staticIps,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared8422af433e1bf486?>? targets,
            global::Vercel.AutoSDKShared2eb5520e92a3b839Tier? tier,
            global::Vercel.AutoSDKShared2eb5520e92a3b839Tracing? tracing,
            double? transferCompletedAt,
            string? transferredFromAccountId,
            double? transferStartedAt,
            string? transferToAccountId,
            global::Vercel.OneOf<global::Vercel.AutoSDKShared2eb5520e92a3b839TrustedIpsVariant1, global::Vercel.AutoSDKShared2eb5520e92a3b839TrustedIpsVariant2>? trustedIps,
            global::Vercel.AutoSDKShared94938587734e5f57? trustedSources,
            double? updatedAt,
            global::Vercel.AutoSDKShared2eb5520e92a3b839UsageStatus? usageStatus,
            bool? v0,
            bool? v0Created,
            global::Vercel.AutoSDKShared2eb5520e92a3b839VercelFlags? vercelFlags,
            global::Vercel.AutoSDKShared2eb5520e92a3b839WebAnalytics? webAnalytics)
        {
            this.AccountId = accountId ?? throw new global::System.ArgumentNullException(nameof(accountId));
            this.Alias = alias ?? throw new global::System.ArgumentNullException(nameof(alias));
            this.Analytics = analytics;
            this.AppliedCve55182Migration = appliedCve55182Migration;
            this.AutoAssignCustomDomains = autoAssignCustomDomains;
            this.AutoAssignCustomDomainsUpdatedBy = autoAssignCustomDomainsUpdatedBy;
            this.AutoExposeSystemEnvs = autoExposeSystemEnvs;
            this.Avatar = avatar;
            this.AvatarDarkMode = avatarDarkMode;
            this.Blobs = blobs;
            this.BuildCommand = buildCommand;
            this.CommandForIgnoringBuildStep = commandForIgnoringBuildStep;
            this.ConcurrencyBucketName = concurrencyBucketName;
            this.ConnectBuildsEnabled = connectBuildsEnabled;
            this.ConnectConfigurationId = connectConfigurationId;
            this.ConnectConfigurations = connectConfigurations;
            this.CreatedAt = createdAt;
            this.Creator = creator;
            this.Crons = crons;
            this.CustomEnvironments = customEnvironments;
            this.CustomerSupportCodeVisibility = customerSupportCodeVisibility;
            this.DataCache = dataCache;
            this.DefaultResourceConfig = defaultResourceConfig ?? throw new global::System.ArgumentNullException(nameof(defaultResourceConfig));
            this.DeploymentExpiration = deploymentExpiration ?? throw new global::System.ArgumentNullException(nameof(deploymentExpiration));
            this.DeploymentPolicy = deploymentPolicy;
            this.DevCommand = devCommand;
            this.DirectoryListing = directoryListing;
            this.DismissedToasts = dismissedToasts;
            this.EnableAffectedProjectsDeployments = enableAffectedProjectsDeployments;
            this.EnableExternalRewriteCaching = enableExternalRewriteCaching;
            this.EnablePreviewFeedback = enablePreviewFeedback;
            this.EnableProductionFeedback = enableProductionFeedback;
            this.Env = env;
            this.Expiration = expiration;
            this.Features = features;
            this.Framework = framework;
            this.GitComments = gitComments;
            this.GitForkProtection = gitForkProtection;
            this.GitLFS = gitLFS;
            this.GitProviderOptions = gitProviderOptions;
            this.HasActiveBranches = hasActiveBranches;
            this.HasDeployments = hasDeployments;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.InstallCommand = installCommand;
            this.InternalRoutes = internalRoutes;
            this.IpBuckets = ipBuckets;
            this.Jobs = jobs;
            this.LastAliasRequest = lastAliasRequest;
            this.LastRollbackTarget = lastRollbackTarget;
            this.LatestDeployments = latestDeployments;
            this.Link = link;
            this.Live = live;
            this.Microfrontends = microfrontends;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.NodeVersion = nodeVersion;
            this.OidcTokenConfig = oidcTokenConfig;
            this.OptionsAllowlist = optionsAllowlist;
            this.OutputDirectory = outputDirectory;
            this.PassiveConnectConfigurationId = passiveConnectConfigurationId;
            this.Passport = passport;
            this.PasswordProtection = passwordProtection;
            this.Paused = paused;
            this.Permissions = permissions;
            this.ProductionDeploymentsFastLane = productionDeploymentsFastLane;
            this.ProtectedSourcemaps = protectedSourcemaps;
            this.ProtectionBypass = protectionBypass;
            this.ProtectionConfig = protectionConfig;
            this.ResourceConfig = resourceConfig ?? throw new global::System.ArgumentNullException(nameof(resourceConfig));
            this.RollbackDescription = rollbackDescription;
            this.RollingRelease = rollingRelease;
            this.RootDirectory = rootDirectory;
            this.Sandbox = sandbox;
            this.Security = security;
            this.ServerlessFunctionZeroConfigFailover = serverlessFunctionZeroConfigFailover;
            this.Services = services;
            this.SkewProtectionAllowedDomains = skewProtectionAllowedDomains;
            this.SkewProtectionBoundaryAt = skewProtectionBoundaryAt;
            this.SkewProtectionMaxAge = skewProtectionMaxAge;
            this.SkipGitConnectDuringLink = skipGitConnectDuringLink;
            this.SourceFilesOutsideRootDirectory = sourceFilesOutsideRootDirectory;
            this.SpeedInsights = speedInsights;
            this.SsoProtection = ssoProtection;
            this.StaticIps = staticIps;
            this.Targets = targets;
            this.Tier = tier;
            this.Tracing = tracing;
            this.TransferCompletedAt = transferCompletedAt;
            this.TransferredFromAccountId = transferredFromAccountId;
            this.TransferStartedAt = transferStartedAt;
            this.TransferToAccountId = transferToAccountId;
            this.TrustedIps = trustedIps;
            this.TrustedSources = trustedSources;
            this.UpdatedAt = updatedAt;
            this.UsageStatus = usageStatus;
            this.V0 = v0;
            this.V0Created = v0Created;
            this.VercelFlags = vercelFlags;
            this.WebAnalytics = webAnalytics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared2eb5520e92a3b839" /> class.
        /// </summary>
        public AutoSDKShared2eb5520e92a3b839()
        {
        }

    }
}