
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant257
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforced")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enforced { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant257" /> class.
        /// </summary>
        /// <param name="enforced"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant257(
            bool enforced)
        {
            this.Enforced = enforced;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant257" /> class.
        /// </summary>
        public UserEventPayloadVariant257()
        {
        }
    }
}