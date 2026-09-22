
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared6ed7be4e006b051dVariant2
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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Org { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared6ed7be4e006b051dVariant2OwnerTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared6ed7be4e006b051dVariant2OwnerType OwnerType { get; set; }

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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repoId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RepoId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repoOwnerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RepoOwnerId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared6ed7be4e006b051dVariant2TypeJsonConverter))]
        public global::Vercel.AutoSDKShared6ed7be4e006b051dVariant2Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared6ed7be4e006b051dVariant2" /> class.
        /// </summary>
        /// <param name="defaultBranch"></param>
        /// <param name="name"></param>
        /// <param name="org"></param>
        /// <param name="ownerType"></param>
        /// <param name="path"></param>
        /// <param name="private"></param>
        /// <param name="repo"></param>
        /// <param name="repoId"></param>
        /// <param name="repoOwnerId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared6ed7be4e006b051dVariant2(
            string defaultBranch,
            string name,
            string org,
            global::Vercel.AutoSDKShared6ed7be4e006b051dVariant2OwnerType ownerType,
            string path,
            bool @private,
            string repo,
            double repoId,
            double repoOwnerId,
            global::Vercel.AutoSDKShared6ed7be4e006b051dVariant2Type type)
        {
            this.DefaultBranch = defaultBranch ?? throw new global::System.ArgumentNullException(nameof(defaultBranch));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Org = org ?? throw new global::System.ArgumentNullException(nameof(org));
            this.OwnerType = ownerType;
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Private = @private;
            this.Repo = repo ?? throw new global::System.ArgumentNullException(nameof(repo));
            this.RepoId = repoId;
            this.RepoOwnerId = repoOwnerId;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared6ed7be4e006b051dVariant2" /> class.
        /// </summary>
        public AutoSDKShared6ed7be4e006b051dVariant2()
        {
        }

    }
}