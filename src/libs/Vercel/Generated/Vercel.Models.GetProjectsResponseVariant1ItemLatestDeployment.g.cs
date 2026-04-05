
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectsResponseVariant1ItemLatestDeployment
    {
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
        [global::System.Text.Json.Serialization.JsonPropertyName("builds")]
        public global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant1ItemLatestDeploymentBuild>? Builds { get; set; }

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
        public global::Vercel.GetProjectsResponseVariant1ItemLatestDeploymentCreator? Creator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentHostname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeploymentHostname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forced")]
        public bool? Forced { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public global::System.Collections.Generic.Dictionary<string, string>? Meta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Plan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Private { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readyState")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReadyState { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

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
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant1ItemLatestDeployment" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="createdIn"></param>
        /// <param name="deploymentHostname"></param>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <param name="plan"></param>
        /// <param name="private"></param>
        /// <param name="readyState"></param>
        /// <param name="type"></param>
        /// <param name="url"></param>
        /// <param name="userId"></param>
        /// <param name="alias"></param>
        /// <param name="aliasAssigned"></param>
        /// <param name="builds"></param>
        /// <param name="creator"></param>
        /// <param name="forced"></param>
        /// <param name="meta"></param>
        /// <param name="requestedAt"></param>
        /// <param name="target"></param>
        /// <param name="teamId"></param>
        /// <param name="withCache"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectsResponseVariant1ItemLatestDeployment(
            double createdAt,
            string createdIn,
            string deploymentHostname,
            string name,
            string id,
            string plan,
            bool @private,
            string readyState,
            string type,
            string url,
            string userId,
            global::System.Collections.Generic.IList<string>? alias,
            global::Vercel.OneOf<double?, bool?>? aliasAssigned,
            global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant1ItemLatestDeploymentBuild>? builds,
            global::Vercel.GetProjectsResponseVariant1ItemLatestDeploymentCreator? creator,
            bool? forced,
            global::System.Collections.Generic.Dictionary<string, string>? meta,
            double? requestedAt,
            string? target,
            string? teamId,
            bool? withCache)
        {
            this.Alias = alias;
            this.AliasAssigned = aliasAssigned;
            this.Builds = builds;
            this.CreatedAt = createdAt;
            this.CreatedIn = createdIn ?? throw new global::System.ArgumentNullException(nameof(createdIn));
            this.Creator = creator;
            this.DeploymentHostname = deploymentHostname ?? throw new global::System.ArgumentNullException(nameof(deploymentHostname));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Forced = forced;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Meta = meta;
            this.Plan = plan ?? throw new global::System.ArgumentNullException(nameof(plan));
            this.Private = @private;
            this.ReadyState = readyState ?? throw new global::System.ArgumentNullException(nameof(readyState));
            this.RequestedAt = requestedAt;
            this.Target = target;
            this.TeamId = teamId;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.WithCache = withCache;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant1ItemLatestDeployment" /> class.
        /// </summary>
        public GetProjectsResponseVariant1ItemLatestDeployment()
        {
        }
    }
}