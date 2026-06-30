
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectsResponseVariant3ProjectTargets2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        public global::System.Collections.Generic.IList<string>? Alias { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliasAssigned")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>))]
        public global::Vercel.OneOf<double?, bool?>? AliasAssigned { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliasError")]
        public global::Vercel.GetProjectsResponseVariant3ProjectTargetsAliasError? AliasError { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliasFinal")]
        public string? AliasFinal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("automaticAliases")]
        public global::System.Collections.Generic.IList<string>? AutomaticAliases { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branchMatcher")]
        public global::Vercel.GetProjectsResponseVariant3ProjectTargetsBranchMatcher? BranchMatcher { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildingAt")]
        public double? BuildingAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("builds")]
        public global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant3ProjectTargetsBuild>? Builds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checksConclusion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectsResponseVariant3ProjectTargetsChecksConclusionJsonConverter))]
        public global::Vercel.GetProjectsResponseVariant3ProjectTargetsChecksConclusion? ChecksConclusion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checksState")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectsResponseVariant3ProjectTargetsChecksStateJsonConverter))]
        public global::Vercel.GetProjectsResponseVariant3ProjectTargetsChecksState? ChecksState { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        public global::Vercel.GetProjectsResponseVariant3ProjectTargetsCreator? Creator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deletedAt")]
        public double? DeletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentHostname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeploymentHostname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forced")]
        public bool? Forced { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public global::System.Collections.Generic.Dictionary<string, string>? Meta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monorepoManager")]
        public string? MonorepoManager { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oidcTokenClaims")]
        public global::Vercel.GetProjectsResponseVariant3ProjectTargetsOidcTokenClaims? OidcTokenClaims { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectsResponseVariant3ProjectTargetsPlanJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetProjectsResponseVariant3ProjectTargetsPlan Plan { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Private { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readyAt")]
        public double? ReadyAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readyState")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectsResponseVariant3ProjectTargetsReadyStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetProjectsResponseVariant3ProjectTargetsReadyState ReadyState { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readySubstate")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectsResponseVariant3ProjectTargetsReadySubstateJsonConverter))]
        public global::Vercel.GetProjectsResponseVariant3ProjectTargetsReadySubstate? ReadySubstate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestedAt")]
        public double? RequestedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        public string? Target { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamId")]
        public string? TeamId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectsResponseVariant3ProjectTargetsTypeJsonConverter))]
        public global::Vercel.GetProjectsResponseVariant3ProjectTargetsType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("withCache")]
        public bool? WithCache { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant3ProjectTargets2" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="createdAt"></param>
        /// <param name="createdIn"></param>
        /// <param name="deploymentHostname"></param>
        /// <param name="name"></param>
        /// <param name="plan"></param>
        /// <param name="private"></param>
        /// <param name="readyState"></param>
        /// <param name="url"></param>
        /// <param name="userId"></param>
        /// <param name="alias"></param>
        /// <param name="aliasAssigned"></param>
        /// <param name="aliasError"></param>
        /// <param name="aliasFinal"></param>
        /// <param name="automaticAliases"></param>
        /// <param name="branchMatcher"></param>
        /// <param name="buildingAt"></param>
        /// <param name="builds"></param>
        /// <param name="checksConclusion"></param>
        /// <param name="checksState"></param>
        /// <param name="connectBuildsEnabled"></param>
        /// <param name="connectConfigurationId"></param>
        /// <param name="creator"></param>
        /// <param name="deletedAt"></param>
        /// <param name="forced"></param>
        /// <param name="meta"></param>
        /// <param name="monorepoManager"></param>
        /// <param name="oidcTokenClaims"></param>
        /// <param name="previewCommentsEnabled">
        /// Whether or not preview comments are enabled for the deployment<br/>
        /// Example: false
        /// </param>
        /// <param name="readyAt"></param>
        /// <param name="readySubstate"></param>
        /// <param name="requestedAt"></param>
        /// <param name="target"></param>
        /// <param name="teamId"></param>
        /// <param name="type"></param>
        /// <param name="withCache"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectsResponseVariant3ProjectTargets2(
            string id,
            double createdAt,
            string createdIn,
            string deploymentHostname,
            string name,
            global::Vercel.GetProjectsResponseVariant3ProjectTargetsPlan plan,
            bool @private,
            global::Vercel.GetProjectsResponseVariant3ProjectTargetsReadyState readyState,
            string url,
            string userId,
            global::System.Collections.Generic.IList<string>? alias,
            global::Vercel.OneOf<double?, bool?>? aliasAssigned,
            global::Vercel.GetProjectsResponseVariant3ProjectTargetsAliasError? aliasError,
            string? aliasFinal,
            global::System.Collections.Generic.IList<string>? automaticAliases,
            global::Vercel.GetProjectsResponseVariant3ProjectTargetsBranchMatcher? branchMatcher,
            double? buildingAt,
            global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant3ProjectTargetsBuild>? builds,
            global::Vercel.GetProjectsResponseVariant3ProjectTargetsChecksConclusion? checksConclusion,
            global::Vercel.GetProjectsResponseVariant3ProjectTargetsChecksState? checksState,
            bool? connectBuildsEnabled,
            string? connectConfigurationId,
            global::Vercel.GetProjectsResponseVariant3ProjectTargetsCreator? creator,
            double? deletedAt,
            bool? forced,
            global::System.Collections.Generic.Dictionary<string, string>? meta,
            string? monorepoManager,
            global::Vercel.GetProjectsResponseVariant3ProjectTargetsOidcTokenClaims? oidcTokenClaims,
            bool? previewCommentsEnabled,
            double? readyAt,
            global::Vercel.GetProjectsResponseVariant3ProjectTargetsReadySubstate? readySubstate,
            double? requestedAt,
            string? target,
            string? teamId,
            global::Vercel.GetProjectsResponseVariant3ProjectTargetsType type,
            bool? withCache)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Alias = alias;
            this.AliasAssigned = aliasAssigned;
            this.AliasError = aliasError;
            this.AliasFinal = aliasFinal;
            this.AutomaticAliases = automaticAliases;
            this.BranchMatcher = branchMatcher;
            this.BuildingAt = buildingAt;
            this.Builds = builds;
            this.ChecksConclusion = checksConclusion;
            this.ChecksState = checksState;
            this.ConnectBuildsEnabled = connectBuildsEnabled;
            this.ConnectConfigurationId = connectConfigurationId;
            this.CreatedAt = createdAt;
            this.CreatedIn = createdIn ?? throw new global::System.ArgumentNullException(nameof(createdIn));
            this.Creator = creator;
            this.DeletedAt = deletedAt;
            this.DeploymentHostname = deploymentHostname ?? throw new global::System.ArgumentNullException(nameof(deploymentHostname));
            this.Forced = forced;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Meta = meta;
            this.MonorepoManager = monorepoManager;
            this.OidcTokenClaims = oidcTokenClaims;
            this.Plan = plan;
            this.PreviewCommentsEnabled = previewCommentsEnabled;
            this.Private = @private;
            this.ReadyAt = readyAt;
            this.ReadyState = readyState;
            this.ReadySubstate = readySubstate;
            this.RequestedAt = requestedAt;
            this.Target = target;
            this.TeamId = teamId;
            this.Type = type;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.WithCache = withCache;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant3ProjectTargets2" /> class.
        /// </summary>
        public GetProjectsResponseVariant3ProjectTargets2()
        {
        }

    }
}