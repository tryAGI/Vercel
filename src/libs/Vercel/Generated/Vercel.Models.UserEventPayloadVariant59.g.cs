
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant59
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitlabLogin")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GitlabLogin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitlabUserId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double GitlabUserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant59" /> class.
        /// </summary>
        /// <param name="gitlabLogin"></param>
        /// <param name="gitlabUserId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant59(
            string gitlabLogin,
            double gitlabUserId)
        {
            this.GitlabLogin = gitlabLogin ?? throw new global::System.ArgumentNullException(nameof(gitlabLogin));
            this.GitlabUserId = gitlabUserId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant59" /> class.
        /// </summary>
        public UserEventPayloadVariant59()
        {
        }
    }
}