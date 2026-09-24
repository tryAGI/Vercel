
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared4cd5b795d6ac66fcVariant2
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Repo { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        public string? Sha { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared4cd5b795d6ac66fcVariant2TypeJsonConverter))]
        public global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant2Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared4cd5b795d6ac66fcVariant2" /> class.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="repo"></param>
        /// <param name="prId"></param>
        /// <param name="ref"></param>
        /// <param name="sha"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared4cd5b795d6ac66fcVariant2(
            string org,
            string repo,
            double? prId,
            string? @ref,
            string? sha,
            global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant2Type type)
        {
            this.Org = org ?? throw new global::System.ArgumentNullException(nameof(org));
            this.PrId = prId;
            this.Ref = @ref;
            this.Repo = repo ?? throw new global::System.ArgumentNullException(nameof(repo));
            this.Sha = sha;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared4cd5b795d6ac66fcVariant2" /> class.
        /// </summary>
        public AutoSDKShared4cd5b795d6ac66fcVariant2()
        {
        }

    }
}