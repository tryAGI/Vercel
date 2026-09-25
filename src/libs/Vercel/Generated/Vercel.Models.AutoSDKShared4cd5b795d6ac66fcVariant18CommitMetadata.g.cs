
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared4cd5b795d6ac66fcVariant18CommitMetadata
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant18CommitMetadataAuthor Author { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("committer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant18CommitMetadataCommitter Committer { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared4cd5b795d6ac66fcVariant18CommitMetadata" /> class.
        /// </summary>
        /// <param name="author"></param>
        /// <param name="committer"></param>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared4cd5b795d6ac66fcVariant18CommitMetadata(
            global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant18CommitMetadataAuthor author,
            global::Vercel.AutoSDKShared4cd5b795d6ac66fcVariant18CommitMetadataCommitter committer,
            string message)
        {
            this.Author = author ?? throw new global::System.ArgumentNullException(nameof(author));
            this.Committer = committer ?? throw new global::System.ArgumentNullException(nameof(committer));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared4cd5b795d6ac66fcVariant18CommitMetadata" /> class.
        /// </summary>
        public AutoSDKShared4cd5b795d6ac66fcVariant18CommitMetadata()
        {
        }

    }
}