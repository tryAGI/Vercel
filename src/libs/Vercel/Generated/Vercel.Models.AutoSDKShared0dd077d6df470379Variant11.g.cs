
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared0dd077d6df470379Variant11
    {
        /// <summary>
        /// Owner (namespace) slug.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        public string? Owner { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prId")]
        public double? PrId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        public string? Ref { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repo")]
        public string? Repo { get; set; }

        /// <summary>
        /// Origin repository id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repoId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RepoId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        public string? Sha { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared0dd077d6df470379Variant11TypeJsonConverter))]
        public global::Vercel.AutoSDKShared0dd077d6df470379Variant11Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared0dd077d6df470379Variant11" /> class.
        /// </summary>
        /// <param name="repoId">
        /// Origin repository id.
        /// </param>
        /// <param name="owner">
        /// Owner (namespace) slug.
        /// </param>
        /// <param name="prId"></param>
        /// <param name="ref"></param>
        /// <param name="repo"></param>
        /// <param name="sha"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared0dd077d6df470379Variant11(
            string repoId,
            string? owner,
            double? prId,
            string? @ref,
            string? repo,
            string? sha,
            global::Vercel.AutoSDKShared0dd077d6df470379Variant11Type type)
        {
            this.Owner = owner;
            this.PrId = prId;
            this.Ref = @ref;
            this.Repo = repo;
            this.RepoId = repoId ?? throw new global::System.ArgumentNullException(nameof(repoId));
            this.Sha = sha;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared0dd077d6df470379Variant11" /> class.
        /// </summary>
        public AutoSDKShared0dd077d6df470379Variant11()
        {
        }

    }
}