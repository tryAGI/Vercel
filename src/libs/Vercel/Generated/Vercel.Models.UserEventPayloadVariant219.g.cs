
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant219
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Bio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant219" /> class.
        /// </summary>
        /// <param name="bio"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant219(
            string bio)
        {
            this.Bio = bio ?? throw new global::System.ArgumentNullException(nameof(bio));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant219" /> class.
        /// </summary>
        public UserEventPayloadVariant219()
        {
        }
    }
}