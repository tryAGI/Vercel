
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateProjectResponseLinkVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectNameWithNamespace")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectNameWithNamespace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectNamespace")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectNamespace { get; set; }

        /// <summary>
        /// A new field, should be included in all new project links, is being added just in time when a deployment is created. This is needed for Protected Git scopes. This is the id of the top level group that a namespace belongs to. Gitlab supports group nesting (up to 20 levels).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectOwnerId")]
        public double? ProjectOwnerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateProjectResponseLinkVariant4TypeJsonConverter))]
        public global::Vercel.UpdateProjectResponseLinkVariant4Type Type { get; set; }

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
        public required global::System.Collections.Generic.IList<global::Vercel.UpdateProjectResponseLinkVariant4DeployHook> DeployHooks { get; set; }

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
        /// Initializes a new instance of the <see cref="UpdateProjectResponseLinkVariant4" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="projectName"></param>
        /// <param name="projectNameWithNamespace"></param>
        /// <param name="projectNamespace"></param>
        /// <param name="projectUrl"></param>
        /// <param name="deployHooks"></param>
        /// <param name="gitCredentialId"></param>
        /// <param name="productionBranch"></param>
        /// <param name="projectOwnerId">
        /// A new field, should be included in all new project links, is being added just in time when a deployment is created. This is needed for Protected Git scopes. This is the id of the top level group that a namespace belongs to. Gitlab supports group nesting (up to 20 levels).
        /// </param>
        /// <param name="type"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="sourceless"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectResponseLinkVariant4(
            string projectId,
            string projectName,
            string projectNameWithNamespace,
            string projectNamespace,
            string projectUrl,
            global::System.Collections.Generic.IList<global::Vercel.UpdateProjectResponseLinkVariant4DeployHook> deployHooks,
            string gitCredentialId,
            string productionBranch,
            double? projectOwnerId,
            global::Vercel.UpdateProjectResponseLinkVariant4Type type,
            double? createdAt,
            double? updatedAt,
            bool? sourceless)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.ProjectName = projectName ?? throw new global::System.ArgumentNullException(nameof(projectName));
            this.ProjectNameWithNamespace = projectNameWithNamespace ?? throw new global::System.ArgumentNullException(nameof(projectNameWithNamespace));
            this.ProjectNamespace = projectNamespace ?? throw new global::System.ArgumentNullException(nameof(projectNamespace));
            this.ProjectOwnerId = projectOwnerId;
            this.ProjectUrl = projectUrl ?? throw new global::System.ArgumentNullException(nameof(projectUrl));
            this.Type = type;
            this.CreatedAt = createdAt;
            this.DeployHooks = deployHooks ?? throw new global::System.ArgumentNullException(nameof(deployHooks));
            this.GitCredentialId = gitCredentialId ?? throw new global::System.ArgumentNullException(nameof(gitCredentialId));
            this.UpdatedAt = updatedAt;
            this.Sourceless = sourceless;
            this.ProductionBranch = productionBranch ?? throw new global::System.ArgumentNullException(nameof(productionBranch));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectResponseLinkVariant4" /> class.
        /// </summary>
        public UpdateProjectResponseLinkVariant4()
        {
        }
    }
}