
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectsResponseVariant3ProjectLinkVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectsResponseVariant3ProjectLinkVariant2TypeJsonConverter))]
        public global::Vercel.GetProjectsResponseVariant3ProjectLinkVariant2Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repo")]
        public string? Repo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repoId")]
        public double? RepoId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public double? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public double? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Org { get; set; }

        /// <summary>
        /// A new field, should be included in all new project links, is being added just in time when a deployment is created. This is needed for Protected Git scopes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repoOwnerId")]
        public double? RepoOwnerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployHooks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant3ProjectLinkVariant2DeployHook> DeployHooks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitCredentialId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GitCredentialId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceless")]
        public bool? Sourceless { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("productionBranch")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProductionBranch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant3ProjectLinkVariant2" /> class.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="deployHooks"></param>
        /// <param name="gitCredentialId"></param>
        /// <param name="productionBranch"></param>
        /// <param name="type"></param>
        /// <param name="repo"></param>
        /// <param name="repoId"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="repoOwnerId">
        /// A new field, should be included in all new project links, is being added just in time when a deployment is created. This is needed for Protected Git scopes.
        /// </param>
        /// <param name="sourceless"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectsResponseVariant3ProjectLinkVariant2(
            string org,
            global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant3ProjectLinkVariant2DeployHook> deployHooks,
            string gitCredentialId,
            string productionBranch,
            global::Vercel.GetProjectsResponseVariant3ProjectLinkVariant2Type type,
            string? repo,
            double? repoId,
            double? createdAt,
            double? updatedAt,
            double? repoOwnerId,
            bool? sourceless)
        {
            this.Type = type;
            this.Repo = repo;
            this.RepoId = repoId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Org = org ?? throw new global::System.ArgumentNullException(nameof(org));
            this.RepoOwnerId = repoOwnerId;
            this.DeployHooks = deployHooks ?? throw new global::System.ArgumentNullException(nameof(deployHooks));
            this.GitCredentialId = gitCredentialId ?? throw new global::System.ArgumentNullException(nameof(gitCredentialId));
            this.Sourceless = sourceless;
            this.ProductionBranch = productionBranch ?? throw new global::System.ArgumentNullException(nameof(productionBranch));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant3ProjectLinkVariant2" /> class.
        /// </summary>
        public GetProjectsResponseVariant3ProjectLinkVariant2()
        {
        }
    }
}