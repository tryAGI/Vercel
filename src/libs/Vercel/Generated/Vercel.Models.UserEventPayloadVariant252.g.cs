
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant252
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant252PreviousJsonConverter))]
        public global::Vercel.UserEventPayloadVariant252Previous? Previous { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant252NextJsonConverter))]
        public global::Vercel.UserEventPayloadVariant252Next? Next { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant252" /> class.
        /// </summary>
        /// <param name="previous"></param>
        /// <param name="next"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant252(
            global::Vercel.UserEventPayloadVariant252Previous? previous,
            global::Vercel.UserEventPayloadVariant252Next? next)
        {
            this.Previous = previous;
            this.Next = next;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant252" /> class.
        /// </summary>
        public UserEventPayloadVariant252()
        {
        }
    }
}