
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant184
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requireVerifiedCommits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool RequireVerifiedCommits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant184" /> class.
        /// </summary>
        /// <param name="requireVerifiedCommits"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant184(
            bool requireVerifiedCommits)
        {
            this.RequireVerifiedCommits = requireVerifiedCommits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant184" /> class.
        /// </summary>
        public UserEventPayloadVariant184()
        {
        }
    }
}