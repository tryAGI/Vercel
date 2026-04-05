
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDeploymentResponseGitRepoVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Owner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repoUuid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RepoUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDeploymentResponseGitRepoVariant3TypeJsonConverter))]
        public global::Vercel.CreateDeploymentResponseGitRepoVariant3Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspaceUuid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkspaceUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultBranch")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DefaultBranch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Private { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDeploymentResponseGitRepoVariant3OwnerTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateDeploymentResponseGitRepoVariant3OwnerType OwnerType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseGitRepoVariant3" /> class.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repoUuid"></param>
        /// <param name="slug"></param>
        /// <param name="workspaceUuid"></param>
        /// <param name="path"></param>
        /// <param name="defaultBranch"></param>
        /// <param name="name"></param>
        /// <param name="private"></param>
        /// <param name="ownerType"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDeploymentResponseGitRepoVariant3(
            string owner,
            string repoUuid,
            string slug,
            string workspaceUuid,
            string path,
            string defaultBranch,
            string name,
            bool @private,
            global::Vercel.CreateDeploymentResponseGitRepoVariant3OwnerType ownerType,
            global::Vercel.CreateDeploymentResponseGitRepoVariant3Type type)
        {
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
            this.RepoUuid = repoUuid ?? throw new global::System.ArgumentNullException(nameof(repoUuid));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Type = type;
            this.WorkspaceUuid = workspaceUuid ?? throw new global::System.ArgumentNullException(nameof(workspaceUuid));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.DefaultBranch = defaultBranch ?? throw new global::System.ArgumentNullException(nameof(defaultBranch));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Private = @private;
            this.OwnerType = ownerType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseGitRepoVariant3" /> class.
        /// </summary>
        public CreateDeploymentResponseGitRepoVariant3()
        {
        }
    }
}