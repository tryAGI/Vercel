
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDeploymentsResponseDeployment
    {
        /// <summary>
        /// The unique identifier of the deployment.<br/>
        /// Example: dpl_2euZBFqxYdDMDG1jTrHFnNZ2eUVa
        /// </summary>
        /// <example>dpl_2euZBFqxYdDMDG1jTrHFnNZ2eUVa</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uid { get; set; }

        /// <summary>
        /// The name of the deployment.<br/>
        /// Example: docs
        /// </summary>
        /// <example>docs</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The project ID of the deployment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// The URL of the deployment.<br/>
        /// Example: docs-9jaeg38me.vercel.app
        /// </summary>
        /// <example>docs-9jaeg38me.vercel.app</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Timestamp of when the deployment got created.<br/>
        /// Example: 1609492210000L
        /// </summary>
        /// <example>1609492210000L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Created { get; set; }

        /// <summary>
        /// The default route that should be used for screenshots and links if configured with microfrontends.<br/>
        /// Example: /docs
        /// </summary>
        /// <example>/docs</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultRoute")]
        public string? DefaultRoute { get; set; }

        /// <summary>
        /// Timestamp of when the deployment got deleted.<br/>
        /// Example: 1609492210000L
        /// </summary>
        /// <example>1609492210000L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        public double? Deleted { get; set; }

        /// <summary>
        /// Timestamp of when the deployment was undeleted.<br/>
        /// Example: 1609492210000L
        /// </summary>
        /// <example>1609492210000L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("undeleted")]
        public double? Undeleted { get; set; }

        /// <summary>
        /// Optional flag to indicate if the deployment was soft deleted by retention policy.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("softDeletedByRetention")]
        public bool? SoftDeletedByRetention { get; set; }

        /// <summary>
        /// The source of the deployment.<br/>
        /// Example: cli
        /// </summary>
        /// <example>cli</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentsResponseDeploymentSourceJsonConverter))]
        public global::Vercel.GetDeploymentsResponseDeploymentSource? Source { get; set; }

        /// <summary>
        /// In which state is the deployment.<br/>
        /// Example: READY
        /// </summary>
        /// <example>READY</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentsResponseDeploymentStateJsonConverter))]
        public global::Vercel.GetDeploymentsResponseDeploymentState? State { get; set; }

        /// <summary>
        /// In which state is the deployment.<br/>
        /// Example: READY
        /// </summary>
        /// <example>READY</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("readyState")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentsResponseDeploymentReadyStateJsonConverter))]
        public global::Vercel.GetDeploymentsResponseDeploymentReadyState? ReadyState { get; set; }

        /// <summary>
        /// The type of the deployment.<br/>
        /// Example: LAMBDAS
        /// </summary>
        /// <example>LAMBDAS</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentsResponseDeploymentTypeJsonConverter))]
        public global::Vercel.GetDeploymentsResponseDeploymentType Type { get; set; }

        /// <summary>
        /// Metadata information of the user who created the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetDeploymentsResponseDeploymentCreator Creator { get; set; }

        /// <summary>
        /// Metadata information from the Git provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public global::System.Collections.Generic.Dictionary<string, string>? Meta { get; set; }

        /// <summary>
        /// On which environment has the deployment been deployed to.<br/>
        /// Example: production
        /// </summary>
        /// <example>production</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentsResponseDeploymentTargetJsonConverter))]
        public global::Vercel.GetDeploymentsResponseDeploymentTarget? Target { get; set; }

        /// <summary>
        /// An error object in case aliasing of the deployment failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliasError")]
        public global::Vercel.GetDeploymentsResponseDeploymentAliasError? AliasError { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliasAssigned")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>))]
        public global::Vercel.OneOf<double?, bool?>? AliasAssigned { get; set; }

        /// <summary>
        /// Timestamp of when the deployment got created.<br/>
        /// Example: 1609492210000L
        /// </summary>
        /// <example>1609492210000L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public double? CreatedAt { get; set; }

        /// <summary>
        /// Timestamp of when the deployment started building at.<br/>
        /// Example: 1609492210000L
        /// </summary>
        /// <example>1609492210000L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildingAt")]
        public double? BuildingAt { get; set; }

        /// <summary>
        /// Timestamp of when the deployment got ready.<br/>
        /// Example: 1609492210000L
        /// </summary>
        /// <example>1609492210000L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ready")]
        public double? Ready { get; set; }

        /// <summary>
        /// Substate of deployment when readyState is 'READY' Tracks whether or not deployment has seen production traffic: - STAGED: never seen production traffic - ROLLING: in the process of gradually transitioning production traffic - PROMOTED: has seen production traffic
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readySubstate")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentsResponseDeploymentReadySubstateJsonConverter))]
        public global::Vercel.GetDeploymentsResponseDeploymentReadySubstate? ReadySubstate { get; set; }

        /// <summary>
        /// State of all registered checks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checksState")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentsResponseDeploymentChecksStateJsonConverter))]
        public global::Vercel.GetDeploymentsResponseDeploymentChecksState? ChecksState { get; set; }

        /// <summary>
        /// Conclusion for checks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checksConclusion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentsResponseDeploymentChecksConclusionJsonConverter))]
        public global::Vercel.GetDeploymentsResponseDeploymentChecksConclusion? ChecksConclusion { get; set; }

        /// <summary>
        /// Detailed information about v2 deployment checks. Includes information about blocked workflows in the deployment lifecycle.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checks")]
        public global::Vercel.GetDeploymentsResponseDeploymentChecks? Checks { get; set; }

        /// <summary>
        /// Vercel URL to inspect the deployment.<br/>
        /// Example: https://vercel.com/acme/nextjs/J1hXN00qjUeoYfpEEf7dnDtpSiVq
        /// </summary>
        /// <example>https://vercel.com/acme/nextjs/J1hXN00qjUeoYfpEEf7dnDtpSiVq</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("inspectorUrl")]
        public string? InspectorUrl { get; set; }

        /// <summary>
        /// Error code when the deployment is in an error state.<br/>
        /// Example: BUILD_FAILED
        /// </summary>
        /// <example>BUILD_FAILED</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorCode")]
        public string? ErrorCode { get; set; }

        /// <summary>
        /// Error message when the deployment is in an canceled or error state.<br/>
        /// Example: The Deployment has been canceled because this project was not affected
        /// </summary>
        /// <example>The Deployment has been canceled because this project was not affected</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorMessage")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Indicates if the deployment encountered an out-of-memory error.<br/>
        /// Example: out-of-memory
        /// </summary>
        /// <example>out-of-memory</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("oomReport")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentsResponseDeploymentOomReportJsonConverter))]
        public global::Vercel.GetDeploymentsResponseDeploymentOomReport? OomReport { get; set; }

        /// <summary>
        /// Deployment can be used for instant rollback
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isRollbackCandidate")]
        public bool? IsRollbackCandidate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prebuilt")]
        public bool? Prebuilt { get; set; }

        /// <summary>
        /// The project settings which was used for this deployment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectSettings")]
        public global::Vercel.GetDeploymentsResponseDeploymentProjectSettings? ProjectSettings { get; set; }

        /// <summary>
        /// The flag saying if Secure Compute network is used for builds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectBuildsEnabled")]
        public bool? ConnectBuildsEnabled { get; set; }

        /// <summary>
        /// The ID of Secure Compute network used for this deployment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectConfigurationId")]
        public string? ConnectConfigurationId { get; set; }

        /// <summary>
        /// The ID of Secure Compute network used for this deployment's passive functions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passiveConnectConfigurationId")]
        public string? PassiveConnectConfigurationId { get; set; }

        /// <summary>
        /// The expiration configured by the project retention policy
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiration")]
        public double? Expiration { get; set; }

        /// <summary>
        /// The expiration proposed to replace the existing expiration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proposedExpiration")]
        public double? ProposedExpiration { get; set; }

        /// <summary>
        /// Metadata about the source platform that triggered the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform")]
        public global::Vercel.GetDeploymentsResponseDeploymentPlatform? Platform { get; set; }

        /// <summary>
        /// The custom environment used for this deployment, if any
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customEnvironment")]
        public global::Vercel.GetDeploymentsResponseDeploymentCustomEnvironment? CustomEnvironment { get; set; }

        /// <summary>
        /// NSNB Blocked metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seatBlock")]
        public global::Vercel.GetDeploymentsResponseDeploymentSeatBlock? SeatBlock { get; set; }

        /// <summary>
        /// Commit attribution metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attribution")]
        public global::Vercel.GetDeploymentsResponseDeploymentAttribution? Attribution { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentsResponseDeployment" /> class.
        /// </summary>
        /// <param name="uid">
        /// The unique identifier of the deployment.<br/>
        /// Example: dpl_2euZBFqxYdDMDG1jTrHFnNZ2eUVa
        /// </param>
        /// <param name="name">
        /// The name of the deployment.<br/>
        /// Example: docs
        /// </param>
        /// <param name="projectId">
        /// The project ID of the deployment
        /// </param>
        /// <param name="url">
        /// The URL of the deployment.<br/>
        /// Example: docs-9jaeg38me.vercel.app
        /// </param>
        /// <param name="created">
        /// Timestamp of when the deployment got created.<br/>
        /// Example: 1609492210000L
        /// </param>
        /// <param name="creator">
        /// Metadata information of the user who created the deployment.
        /// </param>
        /// <param name="defaultRoute">
        /// The default route that should be used for screenshots and links if configured with microfrontends.<br/>
        /// Example: /docs
        /// </param>
        /// <param name="deleted">
        /// Timestamp of when the deployment got deleted.<br/>
        /// Example: 1609492210000L
        /// </param>
        /// <param name="undeleted">
        /// Timestamp of when the deployment was undeleted.<br/>
        /// Example: 1609492210000L
        /// </param>
        /// <param name="softDeletedByRetention">
        /// Optional flag to indicate if the deployment was soft deleted by retention policy.<br/>
        /// Example: true
        /// </param>
        /// <param name="source">
        /// The source of the deployment.<br/>
        /// Example: cli
        /// </param>
        /// <param name="state">
        /// In which state is the deployment.<br/>
        /// Example: READY
        /// </param>
        /// <param name="readyState">
        /// In which state is the deployment.<br/>
        /// Example: READY
        /// </param>
        /// <param name="type">
        /// The type of the deployment.<br/>
        /// Example: LAMBDAS
        /// </param>
        /// <param name="meta">
        /// Metadata information from the Git provider.
        /// </param>
        /// <param name="target">
        /// On which environment has the deployment been deployed to.<br/>
        /// Example: production
        /// </param>
        /// <param name="aliasError">
        /// An error object in case aliasing of the deployment failed.
        /// </param>
        /// <param name="aliasAssigned"></param>
        /// <param name="createdAt">
        /// Timestamp of when the deployment got created.<br/>
        /// Example: 1609492210000L
        /// </param>
        /// <param name="buildingAt">
        /// Timestamp of when the deployment started building at.<br/>
        /// Example: 1609492210000L
        /// </param>
        /// <param name="ready">
        /// Timestamp of when the deployment got ready.<br/>
        /// Example: 1609492210000L
        /// </param>
        /// <param name="readySubstate">
        /// Substate of deployment when readyState is 'READY' Tracks whether or not deployment has seen production traffic: - STAGED: never seen production traffic - ROLLING: in the process of gradually transitioning production traffic - PROMOTED: has seen production traffic
        /// </param>
        /// <param name="checksState">
        /// State of all registered checks
        /// </param>
        /// <param name="checksConclusion">
        /// Conclusion for checks
        /// </param>
        /// <param name="checks">
        /// Detailed information about v2 deployment checks. Includes information about blocked workflows in the deployment lifecycle.
        /// </param>
        /// <param name="inspectorUrl">
        /// Vercel URL to inspect the deployment.<br/>
        /// Example: https://vercel.com/acme/nextjs/J1hXN00qjUeoYfpEEf7dnDtpSiVq
        /// </param>
        /// <param name="errorCode">
        /// Error code when the deployment is in an error state.<br/>
        /// Example: BUILD_FAILED
        /// </param>
        /// <param name="errorMessage">
        /// Error message when the deployment is in an canceled or error state.<br/>
        /// Example: The Deployment has been canceled because this project was not affected
        /// </param>
        /// <param name="oomReport">
        /// Indicates if the deployment encountered an out-of-memory error.<br/>
        /// Example: out-of-memory
        /// </param>
        /// <param name="isRollbackCandidate">
        /// Deployment can be used for instant rollback
        /// </param>
        /// <param name="prebuilt"></param>
        /// <param name="projectSettings">
        /// The project settings which was used for this deployment
        /// </param>
        /// <param name="connectBuildsEnabled">
        /// The flag saying if Secure Compute network is used for builds
        /// </param>
        /// <param name="connectConfigurationId">
        /// The ID of Secure Compute network used for this deployment
        /// </param>
        /// <param name="passiveConnectConfigurationId">
        /// The ID of Secure Compute network used for this deployment's passive functions
        /// </param>
        /// <param name="expiration">
        /// The expiration configured by the project retention policy
        /// </param>
        /// <param name="proposedExpiration">
        /// The expiration proposed to replace the existing expiration
        /// </param>
        /// <param name="platform">
        /// Metadata about the source platform that triggered the deployment.
        /// </param>
        /// <param name="customEnvironment">
        /// The custom environment used for this deployment, if any
        /// </param>
        /// <param name="seatBlock">
        /// NSNB Blocked metadata
        /// </param>
        /// <param name="attribution">
        /// Commit attribution metadata
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDeploymentsResponseDeployment(
            string uid,
            string name,
            string projectId,
            string url,
            double created,
            global::Vercel.GetDeploymentsResponseDeploymentCreator creator,
            string? defaultRoute,
            double? deleted,
            double? undeleted,
            bool? softDeletedByRetention,
            global::Vercel.GetDeploymentsResponseDeploymentSource? source,
            global::Vercel.GetDeploymentsResponseDeploymentState? state,
            global::Vercel.GetDeploymentsResponseDeploymentReadyState? readyState,
            global::Vercel.GetDeploymentsResponseDeploymentType type,
            global::System.Collections.Generic.Dictionary<string, string>? meta,
            global::Vercel.GetDeploymentsResponseDeploymentTarget? target,
            global::Vercel.GetDeploymentsResponseDeploymentAliasError? aliasError,
            global::Vercel.OneOf<double?, bool?>? aliasAssigned,
            double? createdAt,
            double? buildingAt,
            double? ready,
            global::Vercel.GetDeploymentsResponseDeploymentReadySubstate? readySubstate,
            global::Vercel.GetDeploymentsResponseDeploymentChecksState? checksState,
            global::Vercel.GetDeploymentsResponseDeploymentChecksConclusion? checksConclusion,
            global::Vercel.GetDeploymentsResponseDeploymentChecks? checks,
            string? inspectorUrl,
            string? errorCode,
            string? errorMessage,
            global::Vercel.GetDeploymentsResponseDeploymentOomReport? oomReport,
            bool? isRollbackCandidate,
            bool? prebuilt,
            global::Vercel.GetDeploymentsResponseDeploymentProjectSettings? projectSettings,
            bool? connectBuildsEnabled,
            string? connectConfigurationId,
            string? passiveConnectConfigurationId,
            double? expiration,
            double? proposedExpiration,
            global::Vercel.GetDeploymentsResponseDeploymentPlatform? platform,
            global::Vercel.GetDeploymentsResponseDeploymentCustomEnvironment? customEnvironment,
            global::Vercel.GetDeploymentsResponseDeploymentSeatBlock? seatBlock,
            global::Vercel.GetDeploymentsResponseDeploymentAttribution? attribution)
        {
            this.Uid = uid ?? throw new global::System.ArgumentNullException(nameof(uid));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Created = created;
            this.DefaultRoute = defaultRoute;
            this.Deleted = deleted;
            this.Undeleted = undeleted;
            this.SoftDeletedByRetention = softDeletedByRetention;
            this.Source = source;
            this.State = state;
            this.ReadyState = readyState;
            this.Type = type;
            this.Creator = creator ?? throw new global::System.ArgumentNullException(nameof(creator));
            this.Meta = meta;
            this.Target = target;
            this.AliasError = aliasError;
            this.AliasAssigned = aliasAssigned;
            this.CreatedAt = createdAt;
            this.BuildingAt = buildingAt;
            this.Ready = ready;
            this.ReadySubstate = readySubstate;
            this.ChecksState = checksState;
            this.ChecksConclusion = checksConclusion;
            this.Checks = checks;
            this.InspectorUrl = inspectorUrl;
            this.ErrorCode = errorCode;
            this.ErrorMessage = errorMessage;
            this.OomReport = oomReport;
            this.IsRollbackCandidate = isRollbackCandidate;
            this.Prebuilt = prebuilt;
            this.ProjectSettings = projectSettings;
            this.ConnectBuildsEnabled = connectBuildsEnabled;
            this.ConnectConfigurationId = connectConfigurationId;
            this.PassiveConnectConfigurationId = passiveConnectConfigurationId;
            this.Expiration = expiration;
            this.ProposedExpiration = proposedExpiration;
            this.Platform = platform;
            this.CustomEnvironment = customEnvironment;
            this.SeatBlock = seatBlock;
            this.Attribution = attribution;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentsResponseDeployment" /> class.
        /// </summary>
        public GetDeploymentsResponseDeployment()
        {
        }
    }
}