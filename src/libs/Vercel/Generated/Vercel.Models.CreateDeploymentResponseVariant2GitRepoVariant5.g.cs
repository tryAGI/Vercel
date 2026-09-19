
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateDeploymentResponseVariant2GitRepoVariant5
    {
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
        /// Owner (namespace) slug.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Owner { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDeploymentResponseVariant2GitRepoVariant5OwnerTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateDeploymentResponseVariant2GitRepoVariant5OwnerType OwnerType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Private { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Repo { get; set; }

        /// <summary>
        /// Origin repository id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repoId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RepoId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDeploymentResponseVariant2GitRepoVariant5TypeJsonConverter))]
        public global::Vercel.CreateDeploymentResponseVariant2GitRepoVariant5Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseVariant2GitRepoVariant5" /> class.
        /// </summary>
        /// <param name="defaultBranch"></param>
        /// <param name="name"></param>
        /// <param name="owner">
        /// Owner (namespace) slug.
        /// </param>
        /// <param name="ownerType"></param>
        /// <param name="path"></param>
        /// <param name="private"></param>
        /// <param name="repo"></param>
        /// <param name="repoId">
        /// Origin repository id.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDeploymentResponseVariant2GitRepoVariant5(
            string defaultBranch,
            string name,
            string owner,
            global::Vercel.CreateDeploymentResponseVariant2GitRepoVariant5OwnerType ownerType,
            string path,
            bool @private,
            string repo,
            string repoId,
            global::Vercel.CreateDeploymentResponseVariant2GitRepoVariant5Type type)
        {
            this.DefaultBranch = defaultBranch ?? throw new global::System.ArgumentNullException(nameof(defaultBranch));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
            this.OwnerType = ownerType;
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Private = @private;
            this.Repo = repo ?? throw new global::System.ArgumentNullException(nameof(repo));
            this.RepoId = repoId ?? throw new global::System.ArgumentNullException(nameof(repoId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseVariant2GitRepoVariant5" /> class.
        /// </summary>
        public CreateDeploymentResponseVariant2GitRepoVariant5()
        {
        }

    }
}