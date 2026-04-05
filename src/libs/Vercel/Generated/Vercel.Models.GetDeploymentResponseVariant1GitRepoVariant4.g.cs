
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDeploymentResponseVariant1GitRepoVariant4
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentResponseVariant1GitRepoVariant4TypeJsonConverter))]
        public global::Vercel.GetDeploymentResponseVariant1GitRepoVariant4Type Type { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentResponseVariant1GitRepoVariant4OwnerTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetDeploymentResponseVariant1GitRepoVariant4OwnerType OwnerType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant1GitRepoVariant4" /> class.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="repo"></param>
        /// <param name="path"></param>
        /// <param name="defaultBranch"></param>
        /// <param name="name"></param>
        /// <param name="private"></param>
        /// <param name="ownerType"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDeploymentResponseVariant1GitRepoVariant4(
            string org,
            string repo,
            string path,
            string defaultBranch,
            string name,
            bool @private,
            global::Vercel.GetDeploymentResponseVariant1GitRepoVariant4OwnerType ownerType,
            global::Vercel.GetDeploymentResponseVariant1GitRepoVariant4Type type)
        {
            this.Org = org ?? throw new global::System.ArgumentNullException(nameof(org));
            this.Repo = repo ?? throw new global::System.ArgumentNullException(nameof(repo));
            this.Type = type;
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.DefaultBranch = defaultBranch ?? throw new global::System.ArgumentNullException(nameof(defaultBranch));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Private = @private;
            this.OwnerType = ownerType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant1GitRepoVariant4" /> class.
        /// </summary>
        public GetDeploymentResponseVariant1GitRepoVariant4()
        {
        }
    }
}