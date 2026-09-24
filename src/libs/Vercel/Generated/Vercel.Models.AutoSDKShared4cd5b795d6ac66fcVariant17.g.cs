
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared4cd5b795d6ac66fcVariant17
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        public string? Owner { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ref { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repoUuid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RepoUuid { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sha { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared4cd5b795d6ac66fcVariant17TypeJsonConverter))]
        public global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant17Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspaceUuid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkspaceUuid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared4cd5b795d6ac66fcVariant17" /> class.
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="repoUuid"></param>
        /// <param name="sha"></param>
        /// <param name="workspaceUuid"></param>
        /// <param name="owner"></param>
        /// <param name="slug"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared4cd5b795d6ac66fcVariant17(
            string @ref,
            string repoUuid,
            string sha,
            string workspaceUuid,
            string? owner,
            string? slug,
            global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant17Type type)
        {
            this.Owner = owner;
            this.Ref = @ref ?? throw new global::System.ArgumentNullException(nameof(@ref));
            this.RepoUuid = repoUuid ?? throw new global::System.ArgumentNullException(nameof(repoUuid));
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
            this.Slug = slug;
            this.Type = type;
            this.WorkspaceUuid = workspaceUuid ?? throw new global::System.ArgumentNullException(nameof(workspaceUuid));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared4cd5b795d6ac66fcVariant17" /> class.
        /// </summary>
        public AutoSDKShared4cd5b795d6ac66fcVariant17()
        {
        }

    }
}