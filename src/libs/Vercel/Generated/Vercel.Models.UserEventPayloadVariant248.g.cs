
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant248
    {
        /// <summary>
        /// Automatic code review settings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous")]
        public global::Vercel.UserEventPayloadVariant248Previous? Previous { get; set; }

        /// <summary>
        /// Automatic code review settings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant248Next Next { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant248" /> class.
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
        public UserEventPayloadVariant248(
            global::Vercel.UserEventPayloadVariant248Next next,
            global::Vercel.UserEventPayloadVariant248Previous? previous)
        {
            this.Previous = previous;
            this.Next = next ?? throw new global::System.ArgumentNullException(nameof(next));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant248" /> class.
        /// </summary>
        public UserEventPayloadVariant248()
        {
        }
    }
}