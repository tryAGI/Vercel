
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectsResponseVariant1ItemLinkVariant1
    {
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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectsResponseVariant1ItemLinkVariant1TypeJsonConverter))]
        public global::Vercel.GetProjectsResponseVariant1ItemLinkVariant1Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public double? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployHooks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant1ItemLinkVariant1DeployHook> DeployHooks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitCredentialId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GitCredentialId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public double? UpdatedAt { get; set; }

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
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant1ItemLinkVariant1" /> class.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="deployHooks"></param>
        /// <param name="gitCredentialId"></param>
        /// <param name="productionBranch"></param>
        /// <param name="repoOwnerId">
        /// A new field, should be included in all new project links, is being added just in time when a deployment is created. This is needed for Protected Git scopes.
        /// </param>
        /// <param name="repo"></param>
        /// <param name="repoId"></param>
        /// <param name="type"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="sourceless"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectsResponseVariant1ItemLinkVariant1(
            string org,
            global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant1ItemLinkVariant1DeployHook> deployHooks,
            string gitCredentialId,
            string productionBranch,
            double? repoOwnerId,
            string? repo,
            double? repoId,
            global::Vercel.GetProjectsResponseVariant1ItemLinkVariant1Type type,
            double? createdAt,
            double? updatedAt,
            bool? sourceless)
        {
            this.Org = org ?? throw new global::System.ArgumentNullException(nameof(org));
            this.RepoOwnerId = repoOwnerId;
            this.Repo = repo;
            this.RepoId = repoId;
            this.Type = type;
            this.CreatedAt = createdAt;
            this.DeployHooks = deployHooks ?? throw new global::System.ArgumentNullException(nameof(deployHooks));
            this.GitCredentialId = gitCredentialId ?? throw new global::System.ArgumentNullException(nameof(gitCredentialId));
            this.UpdatedAt = updatedAt;
            this.Sourceless = sourceless;
            this.ProductionBranch = productionBranch ?? throw new global::System.ArgumentNullException(nameof(productionBranch));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant1ItemLinkVariant1" /> class.
        /// </summary>
        public GetProjectsResponseVariant1ItemLinkVariant1()
        {
        }
    }
}