
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Returns a reduced view of the deployment with public information only. Private fields are omitted when the requester is not the deployment owner.
    /// </summary>
    public sealed partial class GetDeploymentResponseVariant3
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
        /// An object that will contain a `code` and a `message` when the aliasing fails, otherwise the value will be `null`<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliasError")]
        public global::Vercel.GetDeploymentResponseVariant3AliasError? AliasError { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliasFinal")]
        public string? AliasFinal { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliasWarning")]
        public global::Vercel.GetDeploymentResponseVariant3AliasWarning? AliasWarning { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("checksConclusion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentResponseVariant3ChecksConclusionJsonConverter))]
        public global::Vercel.GetDeploymentResponseVariant3ChecksConclusion? ChecksConclusion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checksState")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentResponseVariant3ChecksStateJsonConverter))]
        public global::Vercel.GetDeploymentResponseVariant3ChecksState? ChecksState { get; set; }

        /// <summary>
        /// A number containing the date when the deployment was created in milliseconds<br/>
        /// Example: 1540257589405L
        /// </summary>
        /// <example>1540257589405L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// Information about the deployment creator
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetDeploymentResponseVariant3Creator Creator { get; set; }

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
        /// Build timestamps, elapsed durations, and billing measurements. The object is always present, but fields are omitted when their source timestamps are unavailable, such as for running or legacy deployments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetDeploymentResponseVariant3Duration Duration { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("gitSource")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared0dd077d6df470379JsonConverter))]
        public global::Vercel.AutoSDKShared0dd077d6df470379? GitSource { get; set; }

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
        public global::System.Collections.Generic.IList<global::Vercel.GetDeploymentResponseVariant3Lambda>? Lambdas { get; set; }

        /// <summary>
        /// Present when deployment was created with manual provisioning enabled, either explicitly or via the experimental BYOC git flow. The deployment stays in INITIALIZING until /continue is called.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manualProvisioning")]
        public global::Vercel.GetDeploymentResponseVariant3ManualProvisioning? ManualProvisioning { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Meta { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentResponseVariant3NodeVersionJsonConverter))]
        public global::Vercel.GetDeploymentResponseVariant3NodeVersion? NodeVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oidcTokenClaims")]
        public global::Vercel.GetDeploymentResponseVariant3OidcTokenClaims? OidcTokenClaims { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oomReport")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentResponseVariant3OomReportJsonConverter))]
        public global::Vercel.GetDeploymentResponseVariant3OomReport? OomReport { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("originCacheRegion")]
        public string? OriginCacheRegion { get; set; }

        /// <summary>
        /// Since November 2023 this field defines a set of regions that we will deploy the lambda to passively Lambdas will be deployed to these regions but only invoked if all of the primary `regions` are marked as out of service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passiveRegions")]
        public global::System.Collections.Generic.IList<string>? PassiveRegions { get; set; }

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
        public global::Vercel.GetDeploymentResponseVariant3Project? Project { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentResponseVariant3ReadyStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetDeploymentResponseVariant3ReadyState ReadyState { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readyStateReason")]
        public string? ReadyStateReason { get; set; }

        /// <summary>
        /// Substate of deployment when readyState is 'READY' Tracks whether or not deployment has seen production traffic: - STAGED: never seen production traffic - ROLLING: in the process of having production traffic gradually transitioned. - PROMOTED: has seen production traffic
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readySubstate")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentResponseVariant3ReadySubstateJsonConverter))]
        public global::Vercel.GetDeploymentResponseVariant3ReadySubstate? ReadySubstate { get; set; }

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
        /// Where was the deployment created from. Best-effort guess for metrics only — not authoritative; do not gate behavior on it.<br/>
        /// Example: cli
        /// </summary>
        /// <example>cli</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentResponseVariant3SourceJsonConverter))]
        public global::Vercel.GetDeploymentResponseVariant3Source? Source { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentResponseVariant3StatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetDeploymentResponseVariant3Status Status { get; set; }

        /// <summary>
        /// If defined, either `staging` if a staging alias in the format `&lt;project&gt;.&lt;team&gt;.now.sh` was assigned upon creation, or `production` if the aliases from `alias` were assigned. `null` value indicates the "preview" deployment.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentResponseVariant3TargetJsonConverter))]
        public global::Vercel.GetDeploymentResponseVariant3Target? Target { get; set; }

        /// <summary>
        /// The team that owns the deployment if any
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team")]
        public global::Vercel.GetDeploymentResponseVariant3Team? Team { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttyBuildLogs")]
        public bool? TtyBuildLogs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentResponseVariant3TypeJsonConverter))]
        public global::Vercel.GetDeploymentResponseVariant3Type Type { get; set; }

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
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant3" /> class.
        /// </summary>
        /// <param name="aliasAssigned">
        /// A boolean that will be true when the aliases from the alias property were assigned successfully<br/>
        /// Example: true
        /// </param>
        /// <param name="bootedAt"></param>
        /// <param name="buildingAt"></param>
        /// <param name="buildSkipped"></param>
        /// <param name="createdAt">
        /// A number containing the date when the deployment was created in milliseconds<br/>
        /// Example: 1540257589405L
        /// </param>
        /// <param name="creator">
        /// Information about the deployment creator
        /// </param>
        /// <param name="duration">
        /// Build timestamps, elapsed durations, and billing measurements. The object is always present, but fields are omitted when their source timestamps are unavailable, such as for running or legacy deployments.
        /// </param>
        /// <param name="id">
        /// A string holding the unique ID of the deployment<br/>
        /// Example: dpl_89qyp1cskzkLrVicDaZoDbjyHuDJ
        /// </param>
        /// <param name="meta"></param>
        /// <param name="name">
        /// The name of the project associated with the deployment at the time that the deployment was created<br/>
        /// Example: my-project
        /// </param>
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
        /// <param name="aliasError">
        /// An object that will contain a `code` and a `message` when the aliasing fails, otherwise the value will be `null`<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="aliasFinal"></param>
        /// <param name="aliasWarning"></param>
        /// <param name="autoAssignCustomDomains">
        /// applies to custom domains only, defaults to `true`
        /// </param>
        /// <param name="automaticAliases"></param>
        /// <param name="buildContainerFinishedAt">
        /// Since April 2025 it necessary for On-Demand Concurrency Minutes calculation
        /// </param>
        /// <param name="buildErrorAt"></param>
        /// <param name="canceledAt"></param>
        /// <param name="checksConclusion"></param>
        /// <param name="checksState"></param>
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
        /// <param name="gitSource"></param>
        /// <param name="initReadyAt"></param>
        /// <param name="isFirstBranchDeployment"></param>
        /// <param name="lambdas"></param>
        /// <param name="manualProvisioning">
        /// Present when deployment was created with manual provisioning enabled, either explicitly or via the experimental BYOC git flow. The deployment stays in INITIALIZING until /continue is called.
        /// </param>
        /// <param name="nodeVersion">
        /// If set it overrides the `projectSettings.nodeVersion` for this deployment.
        /// </param>
        /// <param name="oidcTokenClaims"></param>
        /// <param name="oomReport"></param>
        /// <param name="originCacheRegion"></param>
        /// <param name="passiveRegions">
        /// Since November 2023 this field defines a set of regions that we will deploy the lambda to passively Lambdas will be deployed to these regions but only invoked if all of the primary `regions` are marked as out of service
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
        public GetDeploymentResponseVariant3(
            bool aliasAssigned,
            double bootedAt,
            double buildingAt,
            bool buildSkipped,
            double createdAt,
            global::Vercel.GetDeploymentResponseVariant3Creator creator,
            global::Vercel.GetDeploymentResponseVariant3Duration duration,
            string id,
            global::System.Collections.Generic.Dictionary<string, string> meta,
            string name,
            bool @public,
            global::Vercel.GetDeploymentResponseVariant3ReadyState readyState,
            global::System.Collections.Generic.IList<string> regions,
            global::Vercel.GetDeploymentResponseVariant3Status status,
            string url,
            double version,
            global::System.Collections.Generic.IList<string>? alias,
            global::Vercel.GetDeploymentResponseVariant3AliasError? aliasError,
            string? aliasFinal,
            global::Vercel.GetDeploymentResponseVariant3AliasWarning? aliasWarning,
            bool? autoAssignCustomDomains,
            global::System.Collections.Generic.IList<string>? automaticAliases,
            double? buildContainerFinishedAt,
            double? buildErrorAt,
            double? canceledAt,
            global::Vercel.GetDeploymentResponseVariant3ChecksConclusion? checksConclusion,
            global::Vercel.GetDeploymentResponseVariant3ChecksState? checksState,
            global::Vercel.AutoSDKShared133a7ec19e4ac4f6? customEnvironment,
            string? defaultRoute,
            double? deletedAt,
            string? errorCode,
            string? errorLink,
            string? errorMessage,
            string? errorStep,
            global::Vercel.AutoSDKShared0dd077d6df470379? gitSource,
            double? initReadyAt,
            bool? isFirstBranchDeployment,
            global::System.Collections.Generic.IList<global::Vercel.GetDeploymentResponseVariant3Lambda>? lambdas,
            global::Vercel.GetDeploymentResponseVariant3ManualProvisioning? manualProvisioning,
            global::Vercel.GetDeploymentResponseVariant3NodeVersion? nodeVersion,
            global::Vercel.GetDeploymentResponseVariant3OidcTokenClaims? oidcTokenClaims,
            global::Vercel.GetDeploymentResponseVariant3OomReport? oomReport,
            string? originCacheRegion,
            global::System.Collections.Generic.IList<string>? passiveRegions,
            bool? prebuilt,
            bool? previewCommentsEnabled,
            global::Vercel.GetDeploymentResponseVariant3Project? project,
            double? ready,
            string? readyStateReason,
            global::Vercel.GetDeploymentResponseVariant3ReadySubstate? readySubstate,
            bool? softDeletedByRetention,
            global::Vercel.GetDeploymentResponseVariant3Source? source,
            global::Vercel.GetDeploymentResponseVariant3Target? target,
            global::Vercel.GetDeploymentResponseVariant3Team? team,
            bool? ttyBuildLogs,
            global::Vercel.GetDeploymentResponseVariant3Type type,
            double? undeletedAt,
            global::System.Collections.Generic.IList<string>? userAliases,
            string? userConfiguredDeploymentId)
        {
            this.Alias = alias;
            this.AliasAssigned = aliasAssigned;
            this.AliasError = aliasError;
            this.AliasFinal = aliasFinal;
            this.AliasWarning = aliasWarning;
            this.AutoAssignCustomDomains = autoAssignCustomDomains;
            this.AutomaticAliases = automaticAliases;
            this.BootedAt = bootedAt;
            this.BuildContainerFinishedAt = buildContainerFinishedAt;
            this.BuildErrorAt = buildErrorAt;
            this.BuildingAt = buildingAt;
            this.BuildSkipped = buildSkipped;
            this.CanceledAt = canceledAt;
            this.ChecksConclusion = checksConclusion;
            this.ChecksState = checksState;
            this.CreatedAt = createdAt;
            this.Creator = creator ?? throw new global::System.ArgumentNullException(nameof(creator));
            this.CustomEnvironment = customEnvironment;
            this.DefaultRoute = defaultRoute;
            this.DeletedAt = deletedAt;
            this.Duration = duration ?? throw new global::System.ArgumentNullException(nameof(duration));
            this.ErrorCode = errorCode;
            this.ErrorLink = errorLink;
            this.ErrorMessage = errorMessage;
            this.ErrorStep = errorStep;
            this.GitSource = gitSource;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.InitReadyAt = initReadyAt;
            this.IsFirstBranchDeployment = isFirstBranchDeployment;
            this.Lambdas = lambdas;
            this.ManualProvisioning = manualProvisioning;
            this.Meta = meta ?? throw new global::System.ArgumentNullException(nameof(meta));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.NodeVersion = nodeVersion;
            this.OidcTokenClaims = oidcTokenClaims;
            this.OomReport = oomReport;
            this.OriginCacheRegion = originCacheRegion;
            this.PassiveRegions = passiveRegions;
            this.Prebuilt = prebuilt;
            this.PreviewCommentsEnabled = previewCommentsEnabled;
            this.Project = project;
            this.Public = @public;
            this.Ready = ready;
            this.ReadyState = readyState;
            this.ReadyStateReason = readyStateReason;
            this.ReadySubstate = readySubstate;
            this.Regions = regions ?? throw new global::System.ArgumentNullException(nameof(regions));
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
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant3" /> class.
        /// </summary>
        public GetDeploymentResponseVariant3()
        {
        }

    }
}