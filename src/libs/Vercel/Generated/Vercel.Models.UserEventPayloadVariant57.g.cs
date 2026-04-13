
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant57
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("githubLogin")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GithubLogin { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant57" /> class.
        /// </summary>
        /// <param name="githubLogin"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant57(
            string githubLogin)
        {
            this.GithubLogin = githubLogin ?? throw new global::System.ArgumentNullException(nameof(githubLogin));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant57" /> class.
        /// </summary>
        public UserEventPayloadVariant57()
        {
        }
    }
}