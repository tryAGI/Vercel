
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Returns the updated deployment object with `readyState` set to `CANCELED`. The build has been stopped and this action is irreversible.
    /// </summary>
    public sealed partial class CancelDeploymentResponse
    {
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
        [global::System.Text.Json.Serialization.JsonPropertyName("aliasAssignedAt")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>))]
        public global::Vercel.OneOf<double?, bool?>? AliasAssignedAt { get; set; }

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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliasWarning")]
        public global::Vercel.CancelDeploymentResponseAliasWarning? AliasWarning { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alwaysRefuseToBuild")]
        public bool? AlwaysRefuseToBuild { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("atproto")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.CancelDeploymentResponseAtprotoVariant1, global::Vercel.CancelDeploymentResponseAtprotoVariant2>))]
        public global::Vercel.OneOf<global::Vercel.CancelDeploymentResponseAtprotoVariant1, global::Vercel.CancelDeploymentResponseAtprotoVariant2>? Atproto { get; set; }

        /// <summary>
        /// Attribution metadata for the deployment, linking commit author to git and Vercel users. Only populated when the `enable-deployment-attribution` flag is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attribution")]
        public global::Vercel.CancelDeploymentResponseAttribution? Attribution { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("bootedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double BootedAt { get; set; }

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
        /// Since April 2025 it necessary for On-Demand Concurrency Minutes calculation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildContainerFinishedAt")]
        public double? BuildContainerFinishedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildErrorAt")]
        public double? BuildErrorAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildingAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double BuildingAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("builds")]
        public global::System.Collections.Generic.IList<global::Vercel.CancelDeploymentResponseBuild2>? Builds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildSkipped")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool BuildSkipped { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canceledAt")]
        public double? CanceledAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checks")]
        public global::Vercel.CancelDeploymentResponseChecks? Checks { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checksConclusion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CancelDeploymentResponseChecksConclusionJsonConverter))]
        public global::Vercel.CancelDeploymentResponseChecksConclusion? ChecksConclusion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checksState")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CancelDeploymentResponseChecksStateJsonConverter))]
        public global::Vercel.CancelDeploymentResponseChecksState? ChecksState { get; set; }

        /// <summary>
        /// Since February 2025 the configuration must include snapshot data at the time of deployment creation to capture properties for the /deployments/:id/config endpoint utilized for displaying Deployment Configuration on the frontend This is optional because older deployments may not have this data captured
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::Vercel.CancelDeploymentResponseConfig? Config { get; set; }

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
        /// A number containing the date when the deployment was created in milliseconds<br/>
        /// Example: 1540257589405L
        /// </summary>
        /// <example>1540257589405L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdIn")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedIn { get; set; }

        /// <summary>
        /// Information about the deployment creator
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CancelDeploymentResponseCreator Creator { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crons")]
        public global::System.Collections.Generic.IList<global::Vercel.CancelDeploymentResponseCron>? Crons { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customEnvironment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared133a7ec19e4ac4f6JsonConverter))]
        public global::Vercel.AutoSDKShared133a7ec19e4ac4f6? CustomEnvironment { get; set; }

        /// <summary>
        /// Computed field that is only available for deployments with a microfrontend configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultRoute")]
        public string? DefaultRoute { get; set; }

        /// <summary>
        /// A number containing the date when the deployment was deleted at milliseconds<br/>
        /// Example: 1540257589405L
        /// </summary>
        /// <example>1540257589405L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deletedAt")]
        public double? DeletedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CancelDeploymentResponseDuration Duration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Env { get; set; }

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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flags")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.CancelDeploymentResponseFlags, global::System.Collections.Generic.IList<object>>))]
        public global::Vercel.OneOf<global::Vercel.CancelDeploymentResponseFlags, global::System.Collections.Generic.IList<object>>? Flags { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functions")]
        public global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared5f7d6053e0f466da>? Functions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitRepo")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared6ed7be4e006b051dJsonConverter))]
        public global::Vercel.AutoSDKShared6ed7be4e006b051d? GitRepo { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitSource")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared4cd5b795d6ac66fcJsonConverter))]
        public global::Vercel.AutoSDKShared4cd5b795d6ac66fc? GitSource { get; set; }

        /// <summary>
        /// A string holding the unique ID of the deployment<br/>
        /// Example: dpl_89qyp1cskzkLrVicDaZoDbjyHuDJ
        /// </summary>
        /// <example>dpl_89qyp1cskzkLrVicDaZoDbjyHuDJ</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::Vercel.CancelDeploymentResponseImages? Images { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initReadyAt")]
        public double? InitReadyAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inspectorUrl")]
        public string? InspectorUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrations")]
        public global::Vercel.CancelDeploymentResponseIntegrations? Integrations { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isFirstBranchDeployment")]
        public bool? IsFirstBranchDeployment { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isInConcurrentBuildsQueue")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsInConcurrentBuildsQueue { get; set; }

        /// <summary>
        /// Whether this deployment completed through the instant static fast path.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isInstantStatic")]
        public bool? IsInstantStatic { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isInSystemBuildsQueue")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsInSystemBuildsQueue { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lambdas")]
        public global::System.Collections.Generic.IList<global::Vercel.CancelDeploymentResponseLambda>? Lambdas { get; set; }

        /// <summary>
        /// Present when deployment was created with manual provisioning enabled, either explicitly or via the experimental BYOC git flow. The deployment stays in INITIALIZING until /continue is called.
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
        [global::System.Text.Json.Serialization.JsonPropertyName("microfrontends")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared78353984d471628dJsonConverter))]
        public global::Vercel.AutoSDKShared78353984d471628d? Microfrontends { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monorepoManager")]
        public string? MonorepoManager { get; set; }

        /// <summary>
        /// The name of the project associated with the deployment at the time that the deployment was created<br/>
        /// Example: my-project
        /// </summary>
        /// <example>my-project</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// If set it overrides the `projectSettings.nodeVersion` for this deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodeVersion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CancelDeploymentResponseNodeVersionJsonConverter))]
        public global::Vercel.CancelDeploymentResponseNodeVersion? NodeVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oidcTokenClaims")]
        public global::Vercel.CancelDeploymentResponseOidcTokenClaims? OidcTokenClaims { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oomReport")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CancelDeploymentResponseOomReportJsonConverter))]
        public global::Vercel.CancelDeploymentResponseOomReport? OomReport { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("originCacheRegion")]
        public string? OriginCacheRegion { get; set; }

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
        /// Since November 2023 this field defines a set of regions that we will deploy the lambda to passively Lambdas will be deployed to these regions but only invoked if all of the primary `regions` are marked as out of service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passiveRegions")]
        public global::System.Collections.Generic.IList<string>? PassiveRegions { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("prebuilt")]
        public bool? Prebuilt { get; set; }

        /// <summary>
        /// Whether or not preview comments are enabled for the deployment<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("previewCommentsEnabled")]
        public bool? PreviewCommentsEnabled { get; set; }

        /// <summary>
        /// The public project information associated with the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        public global::Vercel.CancelDeploymentResponseProject? Project { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectSettings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared682ecbbb5af0af8a ProjectSettings { get; set; }

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
        /// The state of the deployment depending on the process of deploying, or if it is ready or in an error state<br/>
        /// Example: READY
        /// </summary>
        /// <example>READY</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("readyState")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CancelDeploymentResponseReadyStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CancelDeploymentResponseReadyState ReadyState { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readyStateReason")]
        public string? ReadyStateReason { get; set; }

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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceConfig")]
        public global::Vercel.CancelDeploymentResponseResourceConfig? ResourceConfig { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("routes")]
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared34abcb2fd4803b5a>? Routes { get; set; }

        /// <summary>
        /// NSNB Blocked metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seatBlock")]
        public global::Vercel.CancelDeploymentResponseSeatBlock? SeatBlock { get; set; }

        /// <summary>
        /// Services detected during build from vercel.json experimentalServices or auto-detected from project structure. Used to inject service URLs as environment variables at runtime.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("services")]
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedaac8b47176a82eee>? Services { get; set; }

        /// <summary>
        /// flag to indicate if the deployment was deleted by retention policy<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("softDeletedByRetention")]
        public bool? SoftDeletedByRetention { get; set; }

        /// <summary>
        /// Where was the deployment created from. Best-effort guess for metrics only — not authoritative; do not gate behavior on it.<br/>
        /// Example: cli
        /// </summary>
        /// <example>cli</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CancelDeploymentResponseSourceJsonConverter))]
        public global::Vercel.CancelDeploymentResponseSource? Source { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CancelDeploymentResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CancelDeploymentResponseStatus Status { get; set; }

        /// <summary>
        /// If defined, either `staging` if a staging alias in the format `&lt;project&gt;.&lt;team&gt;.now.sh` was assigned upon creation, or `production` if the aliases from `alias` were assigned. `null` value indicates the "preview" deployment.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CancelDeploymentResponseTargetJsonConverter))]
        public global::Vercel.CancelDeploymentResponseTarget? Target { get; set; }

        /// <summary>
        /// The team that owns the deployment if any
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team")]
        public global::Vercel.CancelDeploymentResponseTeam? Team { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttyBuildLogs")]
        public bool? TtyBuildLogs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CancelDeploymentResponseTypeJsonConverter))]
        public global::Vercel.CancelDeploymentResponseType Type { get; set; }

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
        /// An array of domains that were provided by the user when creating the Deployment.<br/>
        /// Example: [sub1.example.com, sub2.example.com]
        /// </summary>
        /// <example>[sub1.example.com, sub2.example.com]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("userAliases")]
        public global::System.Collections.Generic.IList<string>? UserAliases { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponse" /> class.
        /// </summary>
        /// <param name="aliasAssigned">
        /// A boolean that will be true when the aliases from the alias property were assigned successfully<br/>
        /// Example: true
        /// </param>
        /// <param name="bootedAt"></param>
        /// <param name="build"></param>
        /// <param name="buildingAt"></param>
        /// <param name="buildSkipped"></param>
        /// <param name="createdAt">
        /// A number containing the date when the deployment was created in milliseconds<br/>
        /// Example: 1540257589405L
        /// </param>
        /// <param name="createdIn"></param>
        /// <param name="creator">
        /// Information about the deployment creator
        /// </param>
        /// <param name="duration"></param>
        /// <param name="env"></param>
        /// <param name="id">
        /// A string holding the unique ID of the deployment<br/>
        /// Example: dpl_89qyp1cskzkLrVicDaZoDbjyHuDJ
        /// </param>
        /// <param name="isInConcurrentBuildsQueue"></param>
        /// <param name="isInSystemBuildsQueue"></param>
        /// <param name="meta"></param>
        /// <param name="name">
        /// The name of the project associated with the deployment at the time that the deployment was created<br/>
        /// Example: my-project
        /// </param>
        /// <param name="ownerId"></param>
        /// <param name="plan"></param>
        /// <param name="projectId"></param>
        /// <param name="projectSettings"></param>
        /// <param name="public">
        /// A boolean representing if the deployment is public or not. By default this is `false`<br/>
        /// Example: false
        /// </param>
        /// <param name="readyState">
        /// The state of the deployment depending on the process of deploying, or if it is ready or in an error state<br/>
        /// Example: READY
        /// </param>
        /// <param name="regions">
        /// The regions the deployment exists in<br/>
        /// Example: [sfo1]
        /// </param>
        /// <param name="status"></param>
        /// <param name="url">
        /// A string with the unique URL of the deployment<br/>
        /// Example: my-instant-deployment-3ij3cxz9qr.now.sh
        /// </param>
        /// <param name="version">
        /// The platform version that was used to create the deployment.<br/>
        /// Example: 2
        /// </param>
        /// <param name="alias">
        /// A list of all the aliases (default aliases, staging aliases and production aliases) that were assigned upon deployment creation<br/>
        /// Example: []
        /// </param>
        /// <param name="aliasAssignedAt"></param>
        /// <param name="aliasError">
        /// An object that will contain a `code` and a `message` when the aliasing fails, otherwise the value will be `null`<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="aliasFinal"></param>
        /// <param name="aliasWarning"></param>
        /// <param name="alwaysRefuseToBuild"></param>
        /// <param name="atproto"></param>
        /// <param name="attribution">
        /// Attribution metadata for the deployment, linking commit author to git and Vercel users. Only populated when the `enable-deployment-attribution` flag is enabled.
        /// </param>
        /// <param name="autoAssignCustomDomains">
        /// applies to custom domains only, defaults to `true`
        /// </param>
        /// <param name="automaticAliases"></param>
        /// <param name="buildArtifactUrls"></param>
        /// <param name="buildContainerFinishedAt">
        /// Since April 2025 it necessary for On-Demand Concurrency Minutes calculation
        /// </param>
        /// <param name="buildErrorAt"></param>
        /// <param name="builds"></param>
        /// <param name="canceledAt"></param>
        /// <param name="checks"></param>
        /// <param name="checksConclusion"></param>
        /// <param name="checksState"></param>
        /// <param name="config">
        /// Since February 2025 the configuration must include snapshot data at the time of deployment creation to capture properties for the /deployments/:id/config endpoint utilized for displaying Deployment Configuration on the frontend This is optional because older deployments may not have this data captured
        /// </param>
        /// <param name="connectBuildsEnabled"></param>
        /// <param name="connectConfigurationId"></param>
        /// <param name="crons"></param>
        /// <param name="customEnvironment"></param>
        /// <param name="defaultRoute">
        /// Computed field that is only available for deployments with a microfrontend configuration.
        /// </param>
        /// <param name="deletedAt">
        /// A number containing the date when the deployment was deleted at milliseconds<br/>
        /// Example: 1540257589405L
        /// </param>
        /// <param name="errorCode"></param>
        /// <param name="errorLink"></param>
        /// <param name="errorMessage"></param>
        /// <param name="errorStep"></param>
        /// <param name="flags"></param>
        /// <param name="functions"></param>
        /// <param name="gitRepo"></param>
        /// <param name="gitSource"></param>
        /// <param name="images"></param>
        /// <param name="initReadyAt"></param>
        /// <param name="inspectorUrl"></param>
        /// <param name="integrations"></param>
        /// <param name="isFirstBranchDeployment"></param>
        /// <param name="isInstantStatic">
        /// Whether this deployment completed through the instant static fast path.
        /// </param>
        /// <param name="lambdas"></param>
        /// <param name="manualProvisioning">
        /// Present when deployment was created with manual provisioning enabled, either explicitly or via the experimental BYOC git flow. The deployment stays in INITIALIZING until /continue is called.
        /// </param>
        /// <param name="microfrontends"></param>
        /// <param name="monorepoManager"></param>
        /// <param name="nodeVersion">
        /// If set it overrides the `projectSettings.nodeVersion` for this deployment.
        /// </param>
        /// <param name="oidcTokenClaims"></param>
        /// <param name="oomReport"></param>
        /// <param name="originCacheRegion"></param>
        /// <param name="passiveConnectConfigurationId">
        /// Since November 2023 this field defines a Secure Compute network that will only be used to deploy passive lambdas to (as in passiveRegions)
        /// </param>
        /// <param name="passiveRegions">
        /// Since November 2023 this field defines a set of regions that we will deploy the lambda to passively Lambdas will be deployed to these regions but only invoked if all of the primary `regions` are marked as out of service
        /// </param>
        /// <param name="platform">
        /// Metadata about the source platform that triggered the deployment. Allows us to map a deployment back to a platform (e.g. the chat that created it)
        /// </param>
        /// <param name="prebuilt"></param>
        /// <param name="previewCommentsEnabled">
        /// Whether or not preview comments are enabled for the deployment<br/>
        /// Example: false
        /// </param>
        /// <param name="project">
        /// The public project information associated with the deployment.
        /// </param>
        /// <param name="ready"></param>
        /// <param name="readyStateReason"></param>
        /// <param name="readySubstate">
        /// Substate of deployment when readyState is 'READY' Tracks whether or not deployment has seen production traffic: - STAGED: never seen production traffic - ROLLING: in the process of having production traffic gradually transitioned. - PROMOTED: has seen production traffic
        /// </param>
        /// <param name="resourceConfig"></param>
        /// <param name="routes"></param>
        /// <param name="seatBlock">
        /// NSNB Blocked metadata
        /// </param>
        /// <param name="services">
        /// Services detected during build from vercel.json experimentalServices or auto-detected from project structure. Used to inject service URLs as environment variables at runtime.
        /// </param>
        /// <param name="softDeletedByRetention">
        /// flag to indicate if the deployment was deleted by retention policy<br/>
        /// Example: true
        /// </param>
        /// <param name="source">
        /// Where was the deployment created from. Best-effort guess for metrics only — not authoritative; do not gate behavior on it.<br/>
        /// Example: cli
        /// </param>
        /// <param name="target">
        /// If defined, either `staging` if a staging alias in the format `&lt;project&gt;.&lt;team&gt;.now.sh` was assigned upon creation, or `production` if the aliases from `alias` were assigned. `null` value indicates the "preview" deployment.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="team">
        /// The team that owns the deployment if any
        /// </param>
        /// <param name="ttyBuildLogs"></param>
        /// <param name="type"></param>
        /// <param name="undeletedAt">
        /// A number containing the date when the deployment was undeleted at milliseconds<br/>
        /// Example: 1540257589405L
        /// </param>
        /// <param name="userAliases">
        /// An array of domains that were provided by the user when creating the Deployment.<br/>
        /// Example: [sub1.example.com, sub2.example.com]
        /// </param>
        /// <param name="userConfiguredDeploymentId">
        /// Since January 2025 User-configured deployment ID for skew protection with pre-built deployments. This is set when users configure a custom deploymentId in their next.config.js file. This allows Next.js to use skew protection even when deployments are pre-built outside of Vercel's build system.<br/>
        /// Example: abc123
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CancelDeploymentResponse(
            bool aliasAssigned,
            double bootedAt,
            global::Vercel.CancelDeploymentResponseBuild build,
            double buildingAt,
            bool buildSkipped,
            double createdAt,
            string createdIn,
            global::Vercel.CancelDeploymentResponseCreator creator,
            global::Vercel.CancelDeploymentResponseDuration duration,
            global::System.Collections.Generic.IList<string> env,
            string id,
            bool isInConcurrentBuildsQueue,
            bool isInSystemBuildsQueue,
            global::System.Collections.Generic.Dictionary<string, string> meta,
            string name,
            string ownerId,
            global::Vercel.CancelDeploymentResponsePlan plan,
            string projectId,
            global::Vercel.AutoSDKShared682ecbbb5af0af8a projectSettings,
            bool @public,
            global::Vercel.CancelDeploymentResponseReadyState readyState,
            global::System.Collections.Generic.IList<string> regions,
            global::Vercel.CancelDeploymentResponseStatus status,
            string url,
            double version,
            global::System.Collections.Generic.IList<string>? alias,
            global::Vercel.OneOf<double?, bool?>? aliasAssignedAt,
            global::Vercel.CancelDeploymentResponseAliasError? aliasError,
            string? aliasFinal,
            global::Vercel.CancelDeploymentResponseAliasWarning? aliasWarning,
            bool? alwaysRefuseToBuild,
            global::Vercel.OneOf<global::Vercel.CancelDeploymentResponseAtprotoVariant1, global::Vercel.CancelDeploymentResponseAtprotoVariant2>? atproto,
            global::Vercel.CancelDeploymentResponseAttribution? attribution,
            bool? autoAssignCustomDomains,
            global::System.Collections.Generic.IList<string>? automaticAliases,
            global::System.Collections.Generic.IList<string>? buildArtifactUrls,
            double? buildContainerFinishedAt,
            double? buildErrorAt,
            global::System.Collections.Generic.IList<global::Vercel.CancelDeploymentResponseBuild2>? builds,
            double? canceledAt,
            global::Vercel.CancelDeploymentResponseChecks? checks,
            global::Vercel.CancelDeploymentResponseChecksConclusion? checksConclusion,
            global::Vercel.CancelDeploymentResponseChecksState? checksState,
            global::Vercel.CancelDeploymentResponseConfig? config,
            bool? connectBuildsEnabled,
            string? connectConfigurationId,
            global::System.Collections.Generic.IList<global::Vercel.CancelDeploymentResponseCron>? crons,
            global::Vercel.AutoSDKShared133a7ec19e4ac4f6? customEnvironment,
            string? defaultRoute,
            double? deletedAt,
            string? errorCode,
            string? errorLink,
            string? errorMessage,
            string? errorStep,
            global::Vercel.OneOf<global::Vercel.CancelDeploymentResponseFlags, global::System.Collections.Generic.IList<object>>? flags,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.AutoSDKShared5f7d6053e0f466da>? functions,
            global::Vercel.AutoSDKShared6ed7be4e006b051d? gitRepo,
            global::Vercel.AutoSDKShared4cd5b795d6ac66fc? gitSource,
            global::Vercel.CancelDeploymentResponseImages? images,
            double? initReadyAt,
            string? inspectorUrl,
            global::Vercel.CancelDeploymentResponseIntegrations? integrations,
            bool? isFirstBranchDeployment,
            bool? isInstantStatic,
            global::System.Collections.Generic.IList<global::Vercel.CancelDeploymentResponseLambda>? lambdas,
            global::Vercel.CancelDeploymentResponseManualProvisioning? manualProvisioning,
            global::Vercel.AutoSDKShared78353984d471628d? microfrontends,
            string? monorepoManager,
            global::Vercel.CancelDeploymentResponseNodeVersion? nodeVersion,
            global::Vercel.CancelDeploymentResponseOidcTokenClaims? oidcTokenClaims,
            global::Vercel.CancelDeploymentResponseOomReport? oomReport,
            string? originCacheRegion,
            string? passiveConnectConfigurationId,
            global::System.Collections.Generic.IList<string>? passiveRegions,
            global::Vercel.CancelDeploymentResponsePlatform? platform,
            bool? prebuilt,
            bool? previewCommentsEnabled,
            global::Vercel.CancelDeploymentResponseProject? project,
            double? ready,
            string? readyStateReason,
            global::Vercel.CancelDeploymentResponseReadySubstate? readySubstate,
            global::Vercel.CancelDeploymentResponseResourceConfig? resourceConfig,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared34abcb2fd4803b5a>? routes,
            global::Vercel.CancelDeploymentResponseSeatBlock? seatBlock,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedaac8b47176a82eee>? services,
            bool? softDeletedByRetention,
            global::Vercel.CancelDeploymentResponseSource? source,
            global::Vercel.CancelDeploymentResponseTarget? target,
            global::Vercel.CancelDeploymentResponseTeam? team,
            bool? ttyBuildLogs,
            global::Vercel.CancelDeploymentResponseType type,
            double? undeletedAt,
            global::System.Collections.Generic.IList<string>? userAliases,
            string? userConfiguredDeploymentId)
        {
            this.Alias = alias;
            this.AliasAssigned = aliasAssigned;
            this.AliasAssignedAt = aliasAssignedAt;
            this.AliasError = aliasError;
            this.AliasFinal = aliasFinal;
            this.AliasWarning = aliasWarning;
            this.AlwaysRefuseToBuild = alwaysRefuseToBuild;
            this.Atproto = atproto;
            this.Attribution = attribution;
            this.AutoAssignCustomDomains = autoAssignCustomDomains;
            this.AutomaticAliases = automaticAliases;
            this.BootedAt = bootedAt;
            this.Build = build ?? throw new global::System.ArgumentNullException(nameof(build));
            this.BuildArtifactUrls = buildArtifactUrls;
            this.BuildContainerFinishedAt = buildContainerFinishedAt;
            this.BuildErrorAt = buildErrorAt;
            this.BuildingAt = buildingAt;
            this.Builds = builds;
            this.BuildSkipped = buildSkipped;
            this.CanceledAt = canceledAt;
            this.Checks = checks;
            this.ChecksConclusion = checksConclusion;
            this.ChecksState = checksState;
            this.Config = config;
            this.ConnectBuildsEnabled = connectBuildsEnabled;
            this.ConnectConfigurationId = connectConfigurationId;
            this.CreatedAt = createdAt;
            this.CreatedIn = createdIn ?? throw new global::System.ArgumentNullException(nameof(createdIn));
            this.Creator = creator ?? throw new global::System.ArgumentNullException(nameof(creator));
            this.Crons = crons;
            this.CustomEnvironment = customEnvironment;
            this.DefaultRoute = defaultRoute;
            this.DeletedAt = deletedAt;
            this.Duration = duration ?? throw new global::System.ArgumentNullException(nameof(duration));
            this.Env = env ?? throw new global::System.ArgumentNullException(nameof(env));
            this.ErrorCode = errorCode;
            this.ErrorLink = errorLink;
            this.ErrorMessage = errorMessage;
            this.ErrorStep = errorStep;
            this.Flags = flags;
            this.Functions = functions;
            this.GitRepo = gitRepo;
            this.GitSource = gitSource;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Images = images;
            this.InitReadyAt = initReadyAt;
            this.InspectorUrl = inspectorUrl;
            this.Integrations = integrations;
            this.IsFirstBranchDeployment = isFirstBranchDeployment;
            this.IsInConcurrentBuildsQueue = isInConcurrentBuildsQueue;
            this.IsInstantStatic = isInstantStatic;
            this.IsInSystemBuildsQueue = isInSystemBuildsQueue;
            this.Lambdas = lambdas;
            this.ManualProvisioning = manualProvisioning;
            this.Meta = meta ?? throw new global::System.ArgumentNullException(nameof(meta));
            this.Microfrontends = microfrontends;
            this.MonorepoManager = monorepoManager;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.NodeVersion = nodeVersion;
            this.OidcTokenClaims = oidcTokenClaims;
            this.OomReport = oomReport;
            this.OriginCacheRegion = originCacheRegion;
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.PassiveConnectConfigurationId = passiveConnectConfigurationId;
            this.PassiveRegions = passiveRegions;
            this.Plan = plan;
            this.Platform = platform;
            this.Prebuilt = prebuilt;
            this.PreviewCommentsEnabled = previewCommentsEnabled;
            this.Project = project;
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.ProjectSettings = projectSettings ?? throw new global::System.ArgumentNullException(nameof(projectSettings));
            this.Public = @public;
            this.Ready = ready;
            this.ReadyState = readyState;
            this.ReadyStateReason = readyStateReason;
            this.ReadySubstate = readySubstate;
            this.Regions = regions ?? throw new global::System.ArgumentNullException(nameof(regions));
            this.ResourceConfig = resourceConfig;
            this.Routes = routes;
            this.SeatBlock = seatBlock;
            this.Services = services;
            this.SoftDeletedByRetention = softDeletedByRetention;
            this.Source = source;
            this.Status = status;
            this.Target = target;
            this.Team = team;
            this.TtyBuildLogs = ttyBuildLogs;
            this.Type = type;
            this.UndeletedAt = undeletedAt;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.UserAliases = userAliases;
            this.UserConfiguredDeploymentId = userConfiguredDeploymentId;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponse" /> class.
        /// </summary>
        public CancelDeploymentResponse()
        {
        }

    }
}