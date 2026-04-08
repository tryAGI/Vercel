
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant238
    {
        /// <summary>
        /// Automatic code review settings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous")]
        public global::Vercel.UserEventPayloadVariant238Previous? Previous { get; set; }

        /// <summary>
        /// Automatic code review settings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant238Next Next { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant238" /> class.
        /// </summary>
        /// <param name="next">
        /// Automatic code review settings
        /// </param>
        /// <param name="previous">
        /// Automatic code review settings
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant238(
            global::Vercel.UserEventPayloadVariant238Next next,
            global::Vercel.UserEventPayloadVariant238Previous? previous)
        {
            this.Previous = previous;
            this.Next = next ?? throw new global::System.ArgumentNullException(nameof(next));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant238" /> class.
        /// </summary>
        public UserEventPayloadVariant238()
        {
        }
    }
}