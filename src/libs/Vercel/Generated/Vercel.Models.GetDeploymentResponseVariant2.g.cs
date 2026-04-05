
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The deployment including only public information
    /// </summary>
    public sealed partial class GetDeploymentResponseVariant2
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
        public required global::Vercel.GetDeploymentResponseVariant2Creator Creator { get; set; }

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
        public global::System.Collections.Generic.IList<global::Vercel.GetDeploymentResponseVariant2Lambda>? Lambdas { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentResponseVariant2StatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetDeploymentResponseVariant2Status Status { get; set; }

        /// <summary>
        /// The team that owns the deployment if any
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team")]
        public global::Vercel.GetDeploymentResponseVariant2Team? Team { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.GetDeploymentResponseVariant2CustomEnvironmentVariant1, global::Vercel.GetDeploymentResponseVariant2CustomEnvironmentVariant2>))]
        public global::Vercel.OneOf<global::Vercel.GetDeploymentResponseVariant2CustomEnvironmentVariant1, global::Vercel.GetDeploymentResponseVariant2CustomEnvironmentVariant2>? CustomEnvironment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oomReport")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentResponseVariant2OomReportJsonConverter))]
        public global::Vercel.GetDeploymentResponseVariant2OomReport? OomReport { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readyStateReason")]
        public string? ReadyStateReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliasWarning")]
        public global::Vercel.GetDeploymentResponseVariant2AliasWarning? AliasWarning { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentResponseVariant2ReadyStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetDeploymentResponseVariant2ReadyState ReadyState { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentResponseVariant2TypeJsonConverter))]
        public global::Vercel.GetDeploymentResponseVariant2Type Type { get; set; }

        /// <summary>
        /// An object that will contain a `code` and a `message` when the aliasing fails, otherwise the value will be `null`<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliasError")]
        public global::Vercel.GetDeploymentResponseVariant2AliasError? AliasError { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentResponseVariant2ChecksStateJsonConverter))]
        public global::Vercel.GetDeploymentResponseVariant2ChecksState? ChecksState { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checksConclusion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentResponseVariant2ChecksConclusionJsonConverter))]
        public global::Vercel.GetDeploymentResponseVariant2ChecksConclusion? ChecksConclusion { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.GetDeploymentResponseVariant2GitSourceVariant1, global::Vercel.GetDeploymentResponseVariant2GitSourceVariant2, global::Vercel.GetDeploymentResponseVariant2GitSourceVariant3, global::Vercel.GetDeploymentResponseVariant2GitSourceVariant4, global::Vercel.GetDeploymentResponseVariant2GitSourceVariant5, global::Vercel.GetDeploymentResponseVariant2GitSourceVariant6, global::Vercel.GetDeploymentResponseVariant2GitSourceVariant7, global::Vercel.GetDeploymentResponseVariant2GitSourceVariant8, global::Vercel.GetDeploymentResponseVariant2GitSourceVariant9, global::Vercel.GetDeploymentResponseVariant2GitSourceVariant10, global::Vercel.GetDeploymentResponseVariant2GitSourceVariant11, global::Vercel.GetDeploymentResponseVariant2GitSourceVariant12, global::Vercel.GetDeploymentResponseVariant2GitSourceVariant13, global::Vercel.GetDeploymentResponseVariant2GitSourceVariant14, global::Vercel.GetDeploymentResponseVariant2GitSourceVariant15, global::Vercel.GetDeploymentResponseVariant2GitSourceVariant16, global::Vercel.GetDeploymentResponseVariant2GitSourceVariant17>))]
        public global::Vercel.OneOf<global::Vercel.GetDeploymentResponseVariant2GitSourceVariant1, global::Vercel.GetDeploymentResponseVariant2GitSourceVariant2, global::Vercel.GetDeploymentResponseVariant2GitSourceVariant3, global::Vercel.GetDeploymentResponseVariant2GitSourceVariant4, global::Vercel.GetDeploymentResponseVariant2GitSourceVariant5, global::Vercel.GetDeploymentResponseVariant2GitSourceVariant6, global::Vercel.GetDeploymentResponseVariant2GitSourceVariant7, global::Vercel.GetDeploymentResponseVariant2GitSourceVariant8, global::Vercel.GetDeploymentResponseVariant2GitSourceVariant9, global::Vercel.GetDeploymentResponseVariant2GitSourceVariant10, global::Vercel.GetDeploymentResponseVariant2GitSourceVariant11, global::Vercel.GetDeploymentResponseVariant2GitSourceVariant12, global::Vercel.GetDeploymentResponseVariant2GitSourceVariant13, global::Vercel.GetDeploymentResponseVariant2GitSourceVariant14, global::Vercel.GetDeploymentResponseVariant2GitSourceVariant15, global::Vercel.GetDeploymentResponseVariant2GitSourceVariant16, global::Vercel.GetDeploymentResponseVariant2GitSourceVariant17>? GitSource { get; set; }

        /// <summary>
        /// Present when deployment was created with VERCEL_MANUAL_PROVISIONING=true. The deployment stays in INITIALIZING until /continue is called.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manualProvisioning")]
        public global::Vercel.GetDeploymentResponseVariant2ManualProvisioning? ManualProvisioning { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentResponseVariant2NodeVersionJsonConverter))]
        public global::Vercel.GetDeploymentResponseVariant2NodeVersion? NodeVersion { get; set; }

        /// <summary>
        /// The public project information associated with the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        public global::Vercel.GetDeploymentResponseVariant2Project? Project { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prebuilt")]
        public bool? Prebuilt { get; set; }

        /// <summary>
        /// Substate of deployment when readyState is 'READY' Tracks whether or not deployment has seen production traffic: - STAGED: never seen production traffic - ROLLING: in the process of having production traffic gradually transitioned. - PROMOTED: has seen production traffic
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readySubstate")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentResponseVariant2ReadySubstateJsonConverter))]
        public global::Vercel.GetDeploymentResponseVariant2ReadySubstate? ReadySubstate { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentResponseVariant2SourceJsonConverter))]
        public global::Vercel.GetDeploymentResponseVariant2Source? Source { get; set; }

        /// <summary>
        /// If defined, either `staging` if a staging alias in the format `&lt;project&gt;.&lt;team&gt;.now.sh` was assigned upon creation, or `production` if the aliases from `alias` were assigned. `null` value indicates the "preview" deployment.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentResponseVariant2TargetJsonConverter))]
        public global::Vercel.GetDeploymentResponseVariant2Target? Target { get; set; }

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
        public global::Vercel.GetDeploymentResponseVariant2OidcTokenClaims? OidcTokenClaims { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant2" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDeploymentResponseVariant2(
            bool aliasAssigned,
            double bootedAt,
            double buildingAt,
            bool buildSkipped,
            global::Vercel.GetDeploymentResponseVariant2Creator creator,
            bool @public,
            global::Vercel.GetDeploymentResponseVariant2Status status,
            string id,
            double createdAt,
            global::Vercel.GetDeploymentResponseVariant2ReadyState readyState,
            string name,
            global::System.Collections.Generic.Dictionary<string, string> meta,
            global::System.Collections.Generic.IList<string> regions,
            string url,
            double version,
            global::System.Collections.Generic.IList<string>? alias,
            double? buildContainerFinishedAt,
            double? initReadyAt,
            bool? isFirstBranchDeployment,
            global::System.Collections.Generic.IList<global::Vercel.GetDeploymentResponseVariant2Lambda>? lambdas,
            double? ready,
            global::Vercel.GetDeploymentResponseVariant2Team? team,
            global::System.Collections.Generic.IList<string>? userAliases,
            bool? previewCommentsEnabled,
            bool? ttyBuildLogs,
            global::Vercel.OneOf<global::Vercel.GetDeploymentResponseVariant2CustomEnvironmentVariant1, global::Vercel.GetDeploymentResponseVariant2CustomEnvironmentVariant2>? customEnvironment,
            global::Vercel.GetDeploymentResponseVariant2OomReport? oomReport,
            string? readyStateReason,
            global::Vercel.GetDeploymentResponseVariant2AliasWarning? aliasWarning,
            global::Vercel.GetDeploymentResponseVariant2Type type,
            global::Vercel.GetDeploymentResponseVariant2AliasError? aliasError,
            string? aliasFinal,
            bool? autoAssignCustomDomains,
            global::System.Collections.Generic.IList<string>? automaticAliases,
            double? buildErrorAt,
            global::Vercel.GetDeploymentResponseVariant2ChecksState? checksState,
            global::Vercel.GetDeploymentResponseVariant2ChecksConclusion? checksConclusion,
            double? deletedAt,
            string? defaultRoute,
            double? canceledAt,
            string? errorCode,
            string? errorLink,
            string? errorMessage,
            string? errorStep,
            global::System.Collections.Generic.IList<string>? passiveRegions,
            global::Vercel.OneOf<global::Vercel.GetDeploymentResponseVariant2GitSourceVariant1, global::Vercel.GetDeploymentResponseVariant2GitSourceVariant2, global::Vercel.GetDeploymentResponseVariant2GitSourceVariant3, global::Vercel.GetDeploymentResponseVariant2GitSourceVariant4, global::Vercel.GetDeploymentResponseVariant2GitSourceVariant5, global::Vercel.GetDeploymentResponseVariant2GitSourceVariant6, global::Vercel.GetDeploymentResponseVariant2GitSourceVariant7, global::Vercel.GetDeploymentResponseVariant2GitSourceVariant8, global::Vercel.GetDeploymentResponseVariant2GitSourceVariant9, global::Vercel.GetDeploymentResponseVariant2GitSourceVariant10, global::Vercel.GetDeploymentResponseVariant2GitSourceVariant11, global::Vercel.GetDeploymentResponseVariant2GitSourceVariant12, global::Vercel.GetDeploymentResponseVariant2GitSourceVariant13, global::Vercel.GetDeploymentResponseVariant2GitSourceVariant14, global::Vercel.GetDeploymentResponseVariant2GitSourceVariant15, global::Vercel.GetDeploymentResponseVariant2GitSourceVariant16, global::Vercel.GetDeploymentResponseVariant2GitSourceVariant17>? gitSource,
            global::Vercel.GetDeploymentResponseVariant2ManualProvisioning? manualProvisioning,
            string? originCacheRegion,
            global::Vercel.GetDeploymentResponseVariant2NodeVersion? nodeVersion,
            global::Vercel.GetDeploymentResponseVariant2Project? project,
            bool? prebuilt,
            global::Vercel.GetDeploymentResponseVariant2ReadySubstate? readySubstate,
            bool? softDeletedByRetention,
            global::Vercel.GetDeploymentResponseVariant2Source? source,
            global::Vercel.GetDeploymentResponseVariant2Target? target,
            double? undeletedAt,
            string? userConfiguredDeploymentId,
            global::Vercel.GetDeploymentResponseVariant2OidcTokenClaims? oidcTokenClaims)
        {
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
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant2" /> class.
        /// </summary>
        public GetDeploymentResponseVariant2()
        {
        }
    }
}