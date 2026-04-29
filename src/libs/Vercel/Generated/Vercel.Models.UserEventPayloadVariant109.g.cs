
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant109
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant109Team Team { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previousRule")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant109PreviousRule PreviousRule { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant109" /> class.
        /// </summary>
        /// <param name="team"></param>
        /// <param name="previousRule"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant109(
            global::Vercel.UserEventPayloadVariant109Team team,
            global::Vercel.UserEventPayloadVariant109PreviousRule previousRule)
        {
            this.Team = team ?? throw new global::System.ArgumentNullException(nameof(team));
            this.PreviousRule = previousRule ?? throw new global::System.ArgumentNullException(nameof(previousRule));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant109" /> class.
        /// </summary>
        public UserEventPayloadVariant109()
        {
        }
    }
}