
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectsResponseVariant2ProjectLinkVariant6
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Org { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Repo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectsResponseVariant2ProjectLinkVariant6TypeJsonConverter))]
        public global::Vercel.GetProjectsResponseVariant2ProjectLinkVariant6Type Type { get; set; }

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
        public required global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant2ProjectLinkVariant6DeployHook> DeployHooks { get; set; }

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
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant2ProjectLinkVariant6" /> class.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="repo"></param>
        /// <param name="deployHooks"></param>
        /// <param name="gitCredentialId"></param>
        /// <param name="productionBranch"></param>
        /// <param name="type"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="sourceless"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectsResponseVariant2ProjectLinkVariant6(
            string org,
            string repo,
            global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant2ProjectLinkVariant6DeployHook> deployHooks,
            string gitCredentialId,
            string productionBranch,
            global::Vercel.GetProjectsResponseVariant2ProjectLinkVariant6Type type,
            double? createdAt,
            double? updatedAt,
            bool? sourceless)
        {
            this.Org = org ?? throw new global::System.ArgumentNullException(nameof(org));
            this.Repo = repo ?? throw new global::System.ArgumentNullException(nameof(repo));
            this.Type = type;
            this.CreatedAt = createdAt;
            this.DeployHooks = deployHooks ?? throw new global::System.ArgumentNullException(nameof(deployHooks));
            this.GitCredentialId = gitCredentialId ?? throw new global::System.ArgumentNullException(nameof(gitCredentialId));
            this.UpdatedAt = updatedAt;
            this.Sourceless = sourceless;
            this.ProductionBranch = productionBranch ?? throw new global::System.ArgumentNullException(nameof(productionBranch));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant2ProjectLinkVariant6" /> class.
        /// </summary>
        public GetProjectsResponseVariant2ProjectLinkVariant6()
        {
        }
    }
}