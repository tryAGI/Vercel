
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The private deployment representation of a Deployment.
    /// </summary>
    public sealed partial class CancelDeploymentResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliasAssignedAt")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>))]
        public global::Vercel.OneOf<double?, bool?>? AliasAssignedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alwaysRefuseToBuild")]
        public bool? AlwaysRefuseToBuild { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("build")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CancelDeploymentResponseBuild Build { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildArtifactUrls")]
        public global::System.Collections.Generic.IList<string>? BuildArtifactUrls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("builds")]
        public global::System.Collections.Generic.IList<global::Vercel.CancelDeploymentResponseBuild2>? Builds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Env { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inspectorUrl")]
        public string? InspectorUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isInConcurrentBuildsQueue")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsInConcurrentBuildsQueue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isInSystemBuildsQueue")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsInSystemBuildsQueue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectSettings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CancelDeploymentResponseProjectSettings ProjectSettings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrations")]
        public global::Vercel.CancelDeploymentResponseIntegrations? Integrations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::Vercel.CancelDeploymentResponseImages? Images { get; set; }

        /// <summary>
        /// A list of all the aliases (default aliases, staging aliases and production aliases) that were assigned upon deployment creation<br/>
        /// Example: []
        /// </summary>
        /// <example>[]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        public global::System.Collections.Generic.IList<string>? Alias { get; set; }

        /// <summary>
        /// A boolean that will be true when the aliases from the alias property were assigned successfully<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliasAssigned")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AliasAssigned { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bootedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double BootedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildingAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double BuildingAt { get; set; }

        /// <summary>
        /// Since April 2025 it necessary for On-Demand Concurrency Minutes calculation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildContainerFinishedAt")]
        public double? BuildContainerFinishedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildSkipped")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool BuildSkipped { get; set; }

        /// <summary>
        /// Information about the deployment creator
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CancelDeploymentResponseCreator Creator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initReadyAt")]
        public double? InitReadyAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isFirstBranchDeployment")]
        public bool? IsFirstBranchDeployment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lambdas")]
        public global::System.Collections.Generic.IList<global::Vercel.CancelDeploymentResponseLambda>? Lambdas { get; set; }

        /// <summary>
        /// A boolean representing if the deployment is public or not. By default this is `false`<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("public")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Public { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ready")]
        public double? Ready { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CancelDeploymentResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CancelDeploymentResponseStatus Status { get; set; }

        /// <summary>
        /// The team that owns the deployment if any
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team")]
        public global::Vercel.CancelDeploymentResponseTeam? Team { get; set; }

        /// <summary>
        /// An array of domains that were provided by the user when creating the Deployment.<br/>
        /// Example: [sub1.example.com, sub2.example.com]
        /// </summary>
        /// <example>[sub1.example.com, sub2.example.com]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("userAliases")]
        public global::System.Collections.Generic.IList<string>? UserAliases { get; set; }

        /// <summary>
        /// Whether or not preview comments are enabled for the deployment<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("previewCommentsEnabled")]
        public bool? PreviewCommentsEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttyBuildLogs")]
        public bool? TtyBuildLogs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customEnvironment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.CancelDeploymentResponseCustomEnvironmentVariant1, global::Vercel.CancelDeploymentResponseCustomEnvironmentVariant2>))]
        public global::Vercel.OneOf<global::Vercel.CancelDeploymentResponseCustomEnvironmentVariant1, global::Vercel.CancelDeploymentResponseCustomEnvironmentVariant2>? CustomEnvironment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oomReport")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CancelDeploymentResponseOomReportJsonConverter))]
        public global::Vercel.CancelDeploymentResponseOomReport? OomReport { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readyStateReason")]
        public string? ReadyStateReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliasWarning")]
        public global::Vercel.CancelDeploymentResponseAliasWarning? AliasWarning { get; set; }

        /// <summary>
        /// A string holding the unique ID of the deployment<br/>
        /// Example: dpl_89qyp1cskzkLrVicDaZoDbjyHuDJ
        /// </summary>
        /// <example>dpl_89qyp1cskzkLrVicDaZoDbjyHuDJ</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// A number containing the date when the deployment was created in milliseconds<br/>
        /// Example: 1540257589405L
        /// </summary>
        /// <example>1540257589405L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// The state of the deployment depending on the process of deploying, or if it is ready or in an error state<br/>
        /// Example: READY
        /// </summary>
        /// <example>READY</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("readyState")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CancelDeploymentResponseReadyStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CancelDeploymentResponseReadyState ReadyState { get; set; }

        /// <summary>
        /// The name of the project associated with the deployment at the time that the deployment was created<br/>
        /// Example: my-project
        /// </summary>
        /// <example>my-project</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CancelDeploymentResponseTypeJsonConverter))]
        public global::Vercel.CancelDeploymentResponseType Type { get; set; }

        /// <summary>
        /// An object that will contain a `code` and a `message` when the aliasing fails, otherwise the value will be `null`<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliasError")]
        public global::Vercel.CancelDeploymentResponseAliasError? AliasError { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliasFinal")]
        public string? AliasFinal { get; set; }

        /// <summary>
        /// applies to custom domains only, defaults to `true`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoAssignCustomDomains")]
        public bool? AutoAssignCustomDomains { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("automaticAliases")]
        public global::System.Collections.Generic.IList<string>? AutomaticAliases { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildErrorAt")]
        public double? BuildErrorAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checksState")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CancelDeploymentResponseChecksStateJsonConverter))]
        public global::Vercel.CancelDeploymentResponseChecksState? ChecksState { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checksConclusion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CancelDeploymentResponseChecksConclusionJsonConverter))]
        public global::Vercel.CancelDeploymentResponseChecksConclusion? ChecksConclusion { get; set; }

        /// <summary>
        /// A number containing the date when the deployment was deleted at milliseconds<br/>
        /// Example: 1540257589405L
        /// </summary>
        /// <example>1540257589405L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deletedAt")]
        public double? DeletedAt { get; set; }

        /// <summary>
        /// Computed field that is only available for deployments with a microfrontend configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultRoute")]
        public string? DefaultRoute { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canceledAt")]
        public double? CanceledAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorCode")]
        public string? ErrorCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorLink")]
        public string? ErrorLink { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorMessage")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorStep")]
        public string? ErrorStep { get; set; }

        /// <summary>
        /// Since November 2023 this field defines a set of regions that we will deploy the lambda to passively Lambdas will be deployed to these regions but only invoked if all of the primary `regions` are marked as out of service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passiveRegions")]
        public global::System.Collections.Generic.IList<string>? PassiveRegions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitSource")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.CancelDeploymentResponseGitSourceVariant1, global::Vercel.CancelDeploymentResponseGitSourceVariant2, global::Vercel.CancelDeploymentResponseGitSourceVariant3, global::Vercel.CancelDeploymentResponseGitSourceVariant4, global::Vercel.CancelDeploymentResponseGitSourceVariant5, global::Vercel.CancelDeploymentResponseGitSourceVariant6, global::Vercel.CancelDeploymentResponseGitSourceVariant7, global::Vercel.CancelDeploymentResponseGitSourceVariant8, global::Vercel.CancelDeploymentResponseGitSourceVariant9, global::Vercel.CancelDeploymentResponseGitSourceVariant10, global::Vercel.CancelDeploymentResponseGitSourceVariant11, global::Vercel.CancelDeploymentResponseGitSourceVariant12, global::Vercel.CancelDeploymentResponseGitSourceVariant13, global::Vercel.CancelDeploymentResponseGitSourceVariant14, global::Vercel.CancelDeploymentResponseGitSourceVariant15, global::Vercel.CancelDeploymentResponseGitSourceVariant16, global::Vercel.CancelDeploymentResponseGitSourceVariant17>))]
        public global::Vercel.OneOf<global::Vercel.CancelDeploymentResponseGitSourceVariant1, global::Vercel.CancelDeploymentResponseGitSourceVariant2, global::Vercel.CancelDeploymentResponseGitSourceVariant3, global::Vercel.CancelDeploymentResponseGitSourceVariant4, global::Vercel.CancelDeploymentResponseGitSourceVariant5, global::Vercel.CancelDeploymentResponseGitSourceVariant6, global::Vercel.CancelDeploymentResponseGitSourceVariant7, global::Vercel.CancelDeploymentResponseGitSourceVariant8, global::Vercel.CancelDeploymentResponseGitSourceVariant9, global::Vercel.CancelDeploymentResponseGitSourceVariant10, global::Vercel.CancelDeploymentResponseGitSourceVariant11, global::Vercel.CancelDeploymentResponseGitSourceVariant12, global::Vercel.CancelDeploymentResponseGitSourceVariant13, global::Vercel.CancelDeploymentResponseGitSourceVariant14, global::Vercel.CancelDeploymentResponseGitSourceVariant15, global::Vercel.CancelDeploymentResponseGitSourceVariant16, global::Vercel.CancelDeploymentResponseGitSourceVariant17>? GitSource { get; set; }

        /// <summary>
        /// Present when deployment was created with VERCEL_MANUAL_PROVISIONING=true. The deployment stays in INITIALIZING until /continue is called.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manualProvisioning")]
        public global::Vercel.CancelDeploymentResponseManualProvisioning? ManualProvisioning { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Meta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("originCacheRegion")]
        public string? OriginCacheRegion { get; set; }

        /// <summary>
        /// If set it overrides the `projectSettings.nodeVersion` for this deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodeVersion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CancelDeploymentResponseNodeVersionJsonConverter))]
        public global::Vercel.CancelDeploymentResponseNodeVersion? NodeVersion { get; set; }

        /// <summary>
        /// The public project information associated with the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        public global::Vercel.CancelDeploymentResponseProject? Project { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prebuilt")]
        public bool? Prebuilt { get; set; }

        /// <summary>
        /// Substate of deployment when readyState is 'READY' Tracks whether or not deployment has seen production traffic: - STAGED: never seen production traffic - ROLLING: in the process of having production traffic gradually transitioned. - PROMOTED: has seen production traffic
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readySubstate")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CancelDeploymentResponseReadySubstateJsonConverter))]
        public global::Vercel.CancelDeploymentResponseReadySubstate? ReadySubstate { get; set; }

        /// <summary>
        /// The regions the deployment exists in<br/>
        /// Example: [sfo1]
        /// </summary>
        /// <example>[sfo1]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("regions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Regions { get; set; }

        /// <summary>
        /// flag to indicate if the deployment was deleted by retention policy<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("softDeletedByRetention")]
        public bool? SoftDeletedByRetention { get; set; }

        /// <summary>
        /// Where was the deployment created from<br/>
        /// Example: cli
        /// </summary>
        /// <example>cli</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CancelDeploymentResponseSourceJsonConverter))]
        public global::Vercel.CancelDeploymentResponseSource? Source { get; set; }

        /// <summary>
        /// If defined, either `staging` if a staging alias in the format `&lt;project&gt;.&lt;team&gt;.now.sh` was assigned upon creation, or `production` if the aliases from `alias` were assigned. `null` value indicates the "preview" deployment.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CancelDeploymentResponseTargetJsonConverter))]
        public global::Vercel.CancelDeploymentResponseTarget? Target { get; set; }

        /// <summary>
        /// A number containing the date when the deployment was undeleted at milliseconds<br/>
        /// Example: 1540257589405L
        /// </summary>
        /// <example>1540257589405L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("undeletedAt")]
        public double? UndeletedAt { get; set; }

        /// <summary>
        /// A string with the unique URL of the deployment<br/>
        /// Example: my-instant-deployment-3ij3cxz9qr.now.sh
        /// </summary>
        /// <example>my-instant-deployment-3ij3cxz9qr.now.sh</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Since January 2025 User-configured deployment ID for skew protection with pre-built deployments. This is set when users configure a custom deploymentId in their next.config.js file. This allows Next.js to use skew protection even when deployments are pre-built outside of Vercel's build system.<br/>
        /// Example: abc123
        /// </summary>
        /// <example>abc123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("userConfiguredDeploymentId")]
        public string? UserConfiguredDeploymentId { get; set; }

        /// <summary>
        /// The platform version that was used to create the deployment.<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oidcTokenClaims")]
        public global::Vercel.CancelDeploymentResponseOidcTokenClaims? OidcTokenClaims { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CancelDeploymentResponsePlanJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CancelDeploymentResponsePlan Plan { get; set; }

        /// <summary>
        /// Metadata about the source platform that triggered the deployment. Allows us to map a deployment back to a platform (e.g. the chat that created it)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform")]
        public global::Vercel.CancelDeploymentResponsePlatform? Platform { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("createdIn")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedIn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crons")]
        public global::System.Collections.Generic.IList<global::Vercel.CancelDeploymentResponseCron>? Crons { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functions")]
        public global::System.Collections.Generic.Dictionary<string, global::Vercel.CancelDeploymentResponseFunctions2>? Functions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monorepoManager")]
        public string? MonorepoManager { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerId { get; set; }

        /// <summary>
        /// Since November 2023 this field defines a Secure Compute network that will only be used to deploy passive lambdas to (as in passiveRegions)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passiveConnectConfigurationId")]
        public string? PassiveConnectConfigurationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("routes")]
        public global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.CancelDeploymentResponseRouteVariant1, global::Vercel.CancelDeploymentResponseRouteVariant2, global::Vercel.CancelDeploymentResponseRouteVariant3>>? Routes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitRepo")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.CancelDeploymentResponseGitRepoVariant1, global::Vercel.CancelDeploymentResponseGitRepoVariant2, global::Vercel.CancelDeploymentResponseGitRepoVariant3, global::Vercel.CancelDeploymentResponseGitRepoVariant4>))]
        public global::Vercel.OneOf<global::Vercel.CancelDeploymentResponseGitRepoVariant1, global::Vercel.CancelDeploymentResponseGitRepoVariant2, global::Vercel.CancelDeploymentResponseGitRepoVariant3, global::Vercel.CancelDeploymentResponseGitRepoVariant4>? GitRepo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flags")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.CancelDeploymentResponseFlags, global::System.Collections.Generic.IList<object>>))]
        public global::Vercel.OneOf<global::Vercel.CancelDeploymentResponseFlags, global::System.Collections.Generic.IList<object>>? Flags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microfrontends")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.CancelDeploymentResponseMicrofrontendsVariant1, global::Vercel.CancelDeploymentResponseMicrofrontendsVariant2>))]
        public global::Vercel.OneOf<global::Vercel.CancelDeploymentResponseMicrofrontendsVariant1, global::Vercel.CancelDeploymentResponseMicrofrontendsVariant2>? Microfrontends { get; set; }

        /// <summary>
        /// Since February 2025 the configuration must include snapshot data at the time of deployment creation to capture properties for the /deployments/:id/config endpoint utilized for displaying Deployment Configuration on the frontend This is optional because older deployments may not have this data captured
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::Vercel.CancelDeploymentResponseConfig? Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checks")]
        public global::Vercel.CancelDeploymentResponseChecks? Checks { get; set; }

        /// <summary>
        /// NSNB Blocked metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seatBlock")]
        public global::Vercel.CancelDeploymentResponseSeatBlock? SeatBlock { get; set; }

        /// <summary>
        /// Attribution metadata for the deployment, linking commit author to git and Vercel users. Only populated when the `enable-deployment-attribution` flag is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attribution")]
        public global::Vercel.CancelDeploymentResponseAttribution? Attribution { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponse" /> class.
        /// </summary>
        /// <param name="build"></param>
        /// <param name="env"></param>
        /// <param name="isInConcurrentBuildsQueue"></param>
        /// <param name="isInSystemBuildsQueue"></param>
        /// <param name="projectSettings"></param>
        /// <param name="aliasAssigned">
        /// A boolean that will be true when the aliases from the alias property were assigned successfully<br/>
        /// Example: true
        /// </param>
        /// <param name="bootedAt"></param>
        /// <param name="buildingAt"></param>
        /// <param name="buildSkipped"></param>
        /// <param name="creator">
        /// Information about the deployment creator
        /// </param>
        /// <param name="public">
        /// A boolean representing if the deployment is public or not. By default this is `false`<br/>
        /// Example: false
        /// </param>
        /// <param name="status"></param>
        /// <param name="id">
        /// A string holding the unique ID of the deployment<br/>
        /// Example: dpl_89qyp1cskzkLrVicDaZoDbjyHuDJ
        /// </param>
        /// <param name="createdAt">
        /// A number containing the date when the deployment was created in milliseconds<br/>
        /// Example: 1540257589405L
        /// </param>
        /// <param name="readyState">
        /// The state of the deployment depending on the process of deploying, or if it is ready or in an error state<br/>
        /// Example: READY
        /// </param>
        /// <param name="name">
        /// The name of the project associated with the deployment at the time that the deployment was created<br/>
        /// Example: my-project
        /// </param>
        /// <param name="meta"></param>
        /// <param name="regions">
        /// The regions the deployment exists in<br/>
        /// Example: [sfo1]
        /// </param>
        /// <param name="url">
        /// A string with the unique URL of the deployment<br/>
        /// Example: my-instant-deployment-3ij3cxz9qr.now.sh
        /// </param>
        /// <param name="version">
        /// The platform version that was used to create the deployment.<br/>
        /// Example: 2
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="plan"></param>
        /// <param name="createdIn"></param>
        /// <param name="ownerId"></param>
        /// <param name="aliasAssignedAt"></param>
        /// <param name="alwaysRefuseToBuild"></param>
        /// <param name="buildArtifactUrls"></param>
        /// <param name="builds"></param>
        /// <param name="inspectorUrl"></param>
        /// <param name="integrations"></param>
        /// <param name="images"></param>
        /// <param name="alias">
        /// A list of all the aliases (default aliases, staging aliases and production aliases) that were assigned upon deployment creation<br/>
        /// Example: []
        /// </param>
        /// <param name="buildContainerFinishedAt">
        /// Since April 2025 it necessary for On-Demand Concurrency Minutes calculation
        /// </param>
        /// <param name="initReadyAt"></param>
        /// <param name="isFirstBranchDeployment"></param>
        /// <param name="lambdas"></param>
        /// <param name="ready"></param>
        /// <param name="team">
        /// The team that owns the deployment if any
        /// </param>
        /// <param name="userAliases">
        /// An array of domains that were provided by the user when creating the Deployment.<br/>
        /// Example: [sub1.example.com, sub2.example.com]
        /// </param>
        /// <param name="previewCommentsEnabled">
        /// Whether or not preview comments are enabled for the deployment<br/>
        /// Example: false
        /// </param>
        /// <param name="ttyBuildLogs"></param>
        /// <param name="customEnvironment"></param>
        /// <param name="oomReport"></param>
        /// <param name="readyStateReason"></param>
        /// <param name="aliasWarning"></param>
        /// <param name="type"></param>
        /// <param name="aliasError">
        /// An object that will contain a `code` and a `message` when the aliasing fails, otherwise the value will be `null`<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="aliasFinal"></param>
        /// <param name="autoAssignCustomDomains">
        /// applies to custom domains only, defaults to `true`
        /// </param>
        /// <param name="automaticAliases"></param>
        /// <param name="buildErrorAt"></param>
        /// <param name="checksState"></param>
        /// <param name="checksConclusion"></param>
        /// <param name="deletedAt">
        /// A number containing the date when the deployment was deleted at milliseconds<br/>
        /// Example: 1540257589405L
        /// </param>
        /// <param name="defaultRoute">
        /// Computed field that is only available for deployments with a microfrontend configuration.
        /// </param>
        /// <param name="canceledAt"></param>
        /// <param name="errorCode"></param>
        /// <param name="errorLink"></param>
        /// <param name="errorMessage"></param>
        /// <param name="errorStep"></param>
        /// <param name="passiveRegions">
        /// Since November 2023 this field defines a set of regions that we will deploy the lambda to passively Lambdas will be deployed to these regions but only invoked if all of the primary `regions` are marked as out of service
        /// </param>
        /// <param name="gitSource"></param>
        /// <param name="manualProvisioning">
        /// Present when deployment was created with VERCEL_MANUAL_PROVISIONING=true. The deployment stays in INITIALIZING until /continue is called.
        /// </param>
        /// <param name="originCacheRegion"></param>
        /// <param name="nodeVersion">
        /// If set it overrides the `projectSettings.nodeVersion` for this deployment.
        /// </param>
        /// <param name="project">
        /// The public project information associated with the deployment.
        /// </param>
        /// <param name="prebuilt"></param>
        /// <param name="readySubstate">
        /// Substate of deployment when readyState is 'READY' Tracks whether or not deployment has seen production traffic: - STAGED: never seen production traffic - ROLLING: in the process of having production traffic gradually transitioned. - PROMOTED: has seen production traffic
        /// </param>
        /// <param name="softDeletedByRetention">
        /// flag to indicate if the deployment was deleted by retention policy<br/>
        /// Example: true
        /// </param>
        /// <param name="source">
        /// Where was the deployment created from<br/>
        /// Example: cli
        /// </param>
        /// <param name="target">
        /// If defined, either `staging` if a staging alias in the format `&lt;project&gt;.&lt;team&gt;.now.sh` was assigned upon creation, or `production` if the aliases from `alias` were assigned. `null` value indicates the "preview" deployment.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="undeletedAt">
        /// A number containing the date when the deployment was undeleted at milliseconds<br/>
        /// Example: 1540257589405L
        /// </param>
        /// <param name="userConfiguredDeploymentId">
        /// Since January 2025 User-configured deployment ID for skew protection with pre-built deployments. This is set when users configure a custom deploymentId in their next.config.js file. This allows Next.js to use skew protection even when deployments are pre-built outside of Vercel's build system.<br/>
        /// Example: abc123
        /// </param>
        /// <param name="oidcTokenClaims"></param>
        /// <param name="platform">
        /// Metadata about the source platform that triggered the deployment. Allows us to map a deployment back to a platform (e.g. the chat that created it)
        /// </param>
        /// <param name="connectBuildsEnabled"></param>
        /// <param name="connectConfigurationId"></param>
        /// <param name="crons"></param>
        /// <param name="functions"></param>
        /// <param name="monorepoManager"></param>
        /// <param name="passiveConnectConfigurationId">
        /// Since November 2023 this field defines a Secure Compute network that will only be used to deploy passive lambdas to (as in passiveRegions)
        /// </param>
        /// <param name="routes"></param>
        /// <param name="gitRepo"></param>
        /// <param name="flags"></param>
        /// <param name="microfrontends"></param>
        /// <param name="config">
        /// Since February 2025 the configuration must include snapshot data at the time of deployment creation to capture properties for the /deployments/:id/config endpoint utilized for displaying Deployment Configuration on the frontend This is optional because older deployments may not have this data captured
        /// </param>
        /// <param name="checks"></param>
        /// <param name="seatBlock">
        /// NSNB Blocked metadata
        /// </param>
        /// <param name="attribution">
        /// Attribution metadata for the deployment, linking commit author to git and Vercel users. Only populated when the `enable-deployment-attribution` flag is enabled.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CancelDeploymentResponse(
            global::Vercel.CancelDeploymentResponseBuild build,
            global::System.Collections.Generic.IList<string> env,
            bool isInConcurrentBuildsQueue,
            bool isInSystemBuildsQueue,
            global::Vercel.CancelDeploymentResponseProjectSettings projectSettings,
            bool aliasAssigned,
            double bootedAt,
            double buildingAt,
            bool buildSkipped,
            global::Vercel.CancelDeploymentResponseCreator creator,
            bool @public,
            global::Vercel.CancelDeploymentResponseStatus status,
            string id,
            double createdAt,
            global::Vercel.CancelDeploymentResponseReadyState readyState,
            string name,
            global::System.Collections.Generic.Dictionary<string, string> meta,
            global::System.Collections.Generic.IList<string> regions,
            string url,
            double version,
            string projectId,
            global::Vercel.CancelDeploymentResponsePlan plan,
            string createdIn,
            string ownerId,
            global::Vercel.OneOf<double?, bool?>? aliasAssignedAt,
            bool? alwaysRefuseToBuild,
            global::System.Collections.Generic.IList<string>? buildArtifactUrls,
            global::System.Collections.Generic.IList<global::Vercel.CancelDeploymentResponseBuild2>? builds,
            string? inspectorUrl,
            global::Vercel.CancelDeploymentResponseIntegrations? integrations,
            global::Vercel.CancelDeploymentResponseImages? images,
            global::System.Collections.Generic.IList<string>? alias,
            double? buildContainerFinishedAt,
            double? initReadyAt,
            bool? isFirstBranchDeployment,
            global::System.Collections.Generic.IList<global::Vercel.CancelDeploymentResponseLambda>? lambdas,
            double? ready,
            global::Vercel.CancelDeploymentResponseTeam? team,
            global::System.Collections.Generic.IList<string>? userAliases,
            bool? previewCommentsEnabled,
            bool? ttyBuildLogs,
            global::Vercel.OneOf<global::Vercel.CancelDeploymentResponseCustomEnvironmentVariant1, global::Vercel.CancelDeploymentResponseCustomEnvironmentVariant2>? customEnvironment,
            global::Vercel.CancelDeploymentResponseOomReport? oomReport,
            string? readyStateReason,
            global::Vercel.CancelDeploymentResponseAliasWarning? aliasWarning,
            global::Vercel.CancelDeploymentResponseType type,
            global::Vercel.CancelDeploymentResponseAliasError? aliasError,
            string? aliasFinal,
            bool? autoAssignCustomDomains,
            global::System.Collections.Generic.IList<string>? automaticAliases,
            double? buildErrorAt,
            global::Vercel.CancelDeploymentResponseChecksState? checksState,
            global::Vercel.CancelDeploymentResponseChecksConclusion? checksConclusion,
            double? deletedAt,
            string? defaultRoute,
            double? canceledAt,
            string? errorCode,
            string? errorLink,
            string? errorMessage,
            string? errorStep,
            global::System.Collections.Generic.IList<string>? passiveRegions,
            global::Vercel.OneOf<global::Vercel.CancelDeploymentResponseGitSourceVariant1, global::Vercel.CancelDeploymentResponseGitSourceVariant2, global::Vercel.CancelDeploymentResponseGitSourceVariant3, global::Vercel.CancelDeploymentResponseGitSourceVariant4, global::Vercel.CancelDeploymentResponseGitSourceVariant5, global::Vercel.CancelDeploymentResponseGitSourceVariant6, global::Vercel.CancelDeploymentResponseGitSourceVariant7, global::Vercel.CancelDeploymentResponseGitSourceVariant8, global::Vercel.CancelDeploymentResponseGitSourceVariant9, global::Vercel.CancelDeploymentResponseGitSourceVariant10, global::Vercel.CancelDeploymentResponseGitSourceVariant11, global::Vercel.CancelDeploymentResponseGitSourceVariant12, global::Vercel.CancelDeploymentResponseGitSourceVariant13, global::Vercel.CancelDeploymentResponseGitSourceVariant14, global::Vercel.CancelDeploymentResponseGitSourceVariant15, global::Vercel.CancelDeploymentResponseGitSourceVariant16, global::Vercel.CancelDeploymentResponseGitSourceVariant17>? gitSource,
            global::Vercel.CancelDeploymentResponseManualProvisioning? manualProvisioning,
            string? originCacheRegion,
            global::Vercel.CancelDeploymentResponseNodeVersion? nodeVersion,
            global::Vercel.CancelDeploymentResponseProject? project,
            bool? prebuilt,
            global::Vercel.CancelDeploymentResponseReadySubstate? readySubstate,
            bool? softDeletedByRetention,
            global::Vercel.CancelDeploymentResponseSource? source,
            global::Vercel.CancelDeploymentResponseTarget? target,
            double? undeletedAt,
            string? userConfiguredDeploymentId,
            global::Vercel.CancelDeploymentResponseOidcTokenClaims? oidcTokenClaims,
            global::Vercel.CancelDeploymentResponsePlatform? platform,
            bool? connectBuildsEnabled,
            string? connectConfigurationId,
            global::System.Collections.Generic.IList<global::Vercel.CancelDeploymentResponseCron>? crons,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.CancelDeploymentResponseFunctions2>? functions,
            string? monorepoManager,
            string? passiveConnectConfigurationId,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.CancelDeploymentResponseRouteVariant1, global::Vercel.CancelDeploymentResponseRouteVariant2, global::Vercel.CancelDeploymentResponseRouteVariant3>>? routes,
            global::Vercel.OneOf<global::Vercel.CancelDeploymentResponseGitRepoVariant1, global::Vercel.CancelDeploymentResponseGitRepoVariant2, global::Vercel.CancelDeploymentResponseGitRepoVariant3, global::Vercel.CancelDeploymentResponseGitRepoVariant4>? gitRepo,
            global::Vercel.OneOf<global::Vercel.CancelDeploymentResponseFlags, global::System.Collections.Generic.IList<object>>? flags,
            global::Vercel.OneOf<global::Vercel.CancelDeploymentResponseMicrofrontendsVariant1, global::Vercel.CancelDeploymentResponseMicrofrontendsVariant2>? microfrontends,
            global::Vercel.CancelDeploymentResponseConfig? config,
            global::Vercel.CancelDeploymentResponseChecks? checks,
            global::Vercel.CancelDeploymentResponseSeatBlock? seatBlock,
            global::Vercel.CancelDeploymentResponseAttribution? attribution)
        {
            this.AliasAssignedAt = aliasAssignedAt;
            this.AlwaysRefuseToBuild = alwaysRefuseToBuild;
            this.Build = build ?? throw new global::System.ArgumentNullException(nameof(build));
            this.BuildArtifactUrls = buildArtifactUrls;
            this.Builds = builds;
            this.Env = env ?? throw new global::System.ArgumentNullException(nameof(env));
            this.InspectorUrl = inspectorUrl;
            this.IsInConcurrentBuildsQueue = isInConcurrentBuildsQueue;
            this.IsInSystemBuildsQueue = isInSystemBuildsQueue;
            this.ProjectSettings = projectSettings ?? throw new global::System.ArgumentNullException(nameof(projectSettings));
            this.Integrations = integrations;
            this.Images = images;
            this.Alias = alias;
            this.AliasAssigned = aliasAssigned;
            this.BootedAt = bootedAt;
            this.BuildingAt = buildingAt;
            this.BuildContainerFinishedAt = buildContainerFinishedAt;
            this.BuildSkipped = buildSkipped;
            this.Creator = creator ?? throw new global::System.ArgumentNullException(nameof(creator));
            this.InitReadyAt = initReadyAt;
            this.IsFirstBranchDeployment = isFirstBranchDeployment;
            this.Lambdas = lambdas;
            this.Public = @public;
            this.Ready = ready;
            this.Status = status;
            this.Team = team;
            this.UserAliases = userAliases;
            this.PreviewCommentsEnabled = previewCommentsEnabled;
            this.TtyBuildLogs = ttyBuildLogs;
            this.CustomEnvironment = customEnvironment;
            this.OomReport = oomReport;
            this.ReadyStateReason = readyStateReason;
            this.AliasWarning = aliasWarning;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.ReadyState = readyState;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.AliasError = aliasError;
            this.AliasFinal = aliasFinal;
            this.AutoAssignCustomDomains = autoAssignCustomDomains;
            this.AutomaticAliases = automaticAliases;
            this.BuildErrorAt = buildErrorAt;
            this.ChecksState = checksState;
            this.ChecksConclusion = checksConclusion;
            this.DeletedAt = deletedAt;
            this.DefaultRoute = defaultRoute;
            this.CanceledAt = canceledAt;
            this.ErrorCode = errorCode;
            this.ErrorLink = errorLink;
            this.ErrorMessage = errorMessage;
            this.ErrorStep = errorStep;
            this.PassiveRegions = passiveRegions;
            this.GitSource = gitSource;
            this.ManualProvisioning = manualProvisioning;
            this.Meta = meta ?? throw new global::System.ArgumentNullException(nameof(meta));
            this.OriginCacheRegion = originCacheRegion;
            this.NodeVersion = nodeVersion;
            this.Project = project;
            this.Prebuilt = prebuilt;
            this.ReadySubstate = readySubstate;
            this.Regions = regions ?? throw new global::System.ArgumentNullException(nameof(regions));
            this.SoftDeletedByRetention = softDeletedByRetention;
            this.Source = source;
            this.Target = target;
            this.UndeletedAt = undeletedAt;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.UserConfiguredDeploymentId = userConfiguredDeploymentId;
            this.Version = version;
            this.OidcTokenClaims = oidcTokenClaims;
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Plan = plan;
            this.Platform = platform;
            this.ConnectBuildsEnabled = connectBuildsEnabled;
            this.ConnectConfigurationId = connectConfigurationId;
            this.CreatedIn = createdIn ?? throw new global::System.ArgumentNullException(nameof(createdIn));
            this.Crons = crons;
            this.Functions = functions;
            this.MonorepoManager = monorepoManager;
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.PassiveConnectConfigurationId = passiveConnectConfigurationId;
            this.Routes = routes;
            this.GitRepo = gitRepo;
            this.Flags = flags;
            this.Microfrontends = microfrontends;
            this.Config = config;
            this.Checks = checks;
            this.SeatBlock = seatBlock;
            this.Attribution = attribution;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponse" /> class.
        /// </summary>
        public CancelDeploymentResponse()
        {
        }
    }
}