
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Since June 2023 Determines if comments should be posted to the git host. Replaces `github.silent` in the vercel.json.
    /// </summary>
    public sealed partial class UserEventPayloadVariant69JobVariant3GitComments
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("onPullRequest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool OnPullRequest { get; set; }

        /// <summary>
        /// 
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
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant69JobVariant3GitComments" /> class.
        /// </summary>
        /// <param name="onPullRequest"></param>
        /// <param name="onCommit"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant69JobVariant3GitComments(
            bool onPullRequest,
            bool onCommit)
        {
            this.OnPullRequest = onPullRequest;
            this.OnCommit = onCommit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant69JobVariant3GitComments" /> class.
        /// </summary>
        public UserEventPayloadVariant69JobVariant3GitComments()
        {
        }
    }
}