
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant250
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant250PreviousJsonConverter))]
        public global::Vercel.UserEventPayloadVariant250Previous? Previous { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant250NextJsonConverter))]
        public global::Vercel.UserEventPayloadVariant250Next? Next { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant250" /> class.
        /// </summary>
        /// <param name="previous"></param>
        /// <param name="next"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant250(
            global::Vercel.UserEventPayloadVariant250Previous? previous,
            global::Vercel.UserEventPayloadVariant250Next? next)
        {
            this.Previous = previous;
            this.Next = next;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant250" /> class.
        /// </summary>
        public UserEventPayloadVariant250()
        {
        }
    }
}