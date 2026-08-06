
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchRepoResponseVariant3Repo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.SearchRepoResponseVariant3RepoProviderJsonConverter))]
        public global::Vercel.SearchRepoResponseVariant3RepoProvider Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespace")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Namespace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.SearchRepoResponseVariant3RepoOwnerTypeJsonConverter))]
        public global::Vercel.SearchRepoResponseVariant3RepoOwnerType OwnerType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.SearchRepoResponseVariant3RepoOwner Owner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Private { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultBranch")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DefaultBranch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRepoResponseVariant3Repo" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="url"></param>
        /// <param name="name"></param>
        /// <param name="slug"></param>
        /// <param name="namespace"></param>
        /// <param name="owner"></param>
        /// <param name="private"></param>
        /// <param name="defaultBranch"></param>
        /// <param name="updatedAt"></param>
        /// <param name="provider"></param>
        /// <param name="ownerType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchRepoResponseVariant3Repo(
            string id,
            string url,
            string name,
            string slug,
            string @namespace,
            global::Vercel.SearchRepoResponseVariant3RepoOwner owner,
            bool @private,
            string defaultBranch,
            double updatedAt,
            global::Vercel.SearchRepoResponseVariant3RepoProvider provider,
            global::Vercel.SearchRepoResponseVariant3RepoOwnerType ownerType)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Provider = provider;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Namespace = @namespace ?? throw new global::System.ArgumentNullException(nameof(@namespace));
            this.OwnerType = ownerType;
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
            this.Private = @private;
            this.DefaultBranch = defaultBranch ?? throw new global::System.ArgumentNullException(nameof(defaultBranch));
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRepoResponseVariant3Repo" /> class.
        /// </summary>
        public SearchRepoResponseVariant3Repo()
        {
        }

    }
}