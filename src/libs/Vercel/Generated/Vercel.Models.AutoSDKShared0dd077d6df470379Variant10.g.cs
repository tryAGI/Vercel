
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared0dd077d6df470379Variant10
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commitMetadata")]
        public global::Vercel.AutoSDKShared0dd077d6df470379Variant10CommitMetadata? CommitMetadata { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org")]
        public string? Org { get; set; }

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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repoPushedAt")]
        public double? RepoPushedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sha { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared0dd077d6df470379Variant10TypeJsonConverter))]
        public global::Vercel.AutoSDKShared0dd077d6df470379Variant10Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared0dd077d6df470379Variant10" /> class.
        /// </summary>
        /// <param name="sha"></param>
        /// <param name="commitMetadata"></param>
        /// <param name="org"></param>
        /// <param name="prId"></param>
        /// <param name="ref"></param>
        /// <param name="repo"></param>
        /// <param name="repoPushedAt"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared0dd077d6df470379Variant10(
            string sha,
            global::Vercel.AutoSDKShared0dd077d6df470379Variant10CommitMetadata? commitMetadata,
            string? org,
            double? prId,
            string? @ref,
            string? repo,
            double? repoPushedAt,
            global::Vercel.AutoSDKShared0dd077d6df470379Variant10Type type)
        {
            this.CommitMetadata = commitMetadata;
            this.Org = org;
            this.PrId = prId;
            this.Ref = @ref;
            this.Repo = repo;
            this.RepoPushedAt = repoPushedAt;
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared0dd077d6df470379Variant10" /> class.
        /// </summary>
        public AutoSDKShared0dd077d6df470379Variant10()
        {
        }

    }
}