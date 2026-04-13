
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant240
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant240Store Store { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerId")]
        public string? OwnerId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant240" /> class.
        /// </summary>
        /// <param name="store"></param>
        /// <param name="ownerId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant240(
            global::Vercel.UserEventPayloadVariant240Store store,
            string? ownerId)
        {
            this.Store = store ?? throw new global::System.ArgumentNullException(nameof(store));
            this.OwnerId = ownerId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant240" /> class.
        /// </summary>
        public UserEventPayloadVariant240()
        {
        }
    }
}