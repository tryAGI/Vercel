
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Opt-in to Git pull request and commit comments on the project level. Replaces `github.silent`.
    /// </summary>
    public sealed partial class UpdateProjectRequestGitComments
    {
        /// <summary>
        /// Whether or not Vercel should comment on pull requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("onPullRequest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool OnPullRequest { get; set; }

        /// <summary>
        /// Whether or not Vercel should comment on commits
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("onCommit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool OnCommit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequestGitComments" /> class.
        /// </summary>
        /// <param name="onPullRequest">
        /// Whether or not Vercel should comment on pull requests
        /// </param>
        /// <param name="onCommit">
        /// Whether or not Vercel should comment on commits
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectRequestGitComments(
            bool onPullRequest,
            bool onCommit)
        {
            this.OnPullRequest = onPullRequest;
            this.OnCommit = onCommit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequestGitComments" /> class.
        /// </summary>
        public UpdateProjectRequestGitComments()
        {
        }

    }
}