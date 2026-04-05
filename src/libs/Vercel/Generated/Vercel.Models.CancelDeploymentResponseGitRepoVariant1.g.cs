
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CancelDeploymentResponseGitRepoVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespace")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Namespace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CancelDeploymentResponseGitRepoVariant1TypeJsonConverter))]
        public global::Vercel.CancelDeploymentResponseGitRepoVariant1Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CancelDeploymentResponseGitRepoVariant1OwnerTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CancelDeploymentResponseGitRepoVariant1OwnerType OwnerType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseGitRepoVariant1" /> class.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="projectId"></param>
        /// <param name="url"></param>
        /// <param name="path"></param>
        /// <param name="defaultBranch"></param>
        /// <param name="name"></param>
        /// <param name="private"></param>
        /// <param name="ownerType"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CancelDeploymentResponseGitRepoVariant1(
            string @namespace,
            double projectId,
            string url,
            string path,
            string defaultBranch,
            string name,
            bool @private,
            global::Vercel.CancelDeploymentResponseGitRepoVariant1OwnerType ownerType,
            global::Vercel.CancelDeploymentResponseGitRepoVariant1Type type)
        {
            this.Namespace = @namespace ?? throw new global::System.ArgumentNullException(nameof(@namespace));
            this.ProjectId = projectId;
            this.Type = type;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.DefaultBranch = defaultBranch ?? throw new global::System.ArgumentNullException(nameof(defaultBranch));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Private = @private;
            this.OwnerType = ownerType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseGitRepoVariant1" /> class.
        /// </summary>
        public CancelDeploymentResponseGitRepoVariant1()
        {
        }
    }
}