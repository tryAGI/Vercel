
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared223443184387411fGitComments
    {
        /// <summary>
        /// Whether the Vercel bot should comment on commits
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("onCommit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool OnCommit { get; set; }

        /// <summary>
        /// Whether the Vercel bot should comment on PRs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("onPullRequest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool OnPullRequest { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared223443184387411fGitComments" /> class.
        /// </summary>
        /// <param name="onCommit">
        /// Whether the Vercel bot should comment on commits
        /// </param>
        /// <param name="onPullRequest">
        /// Whether the Vercel bot should comment on PRs
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared223443184387411fGitComments(
            bool onCommit,
            bool onPullRequest)
        {
            this.OnCommit = onCommit;
            this.OnPullRequest = onPullRequest;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared223443184387411fGitComments" /> class.
        /// </summary>
        public AutoSDKShared223443184387411fGitComments()
        {
        }

    }
}