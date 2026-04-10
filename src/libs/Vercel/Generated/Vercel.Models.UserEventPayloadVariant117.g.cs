
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant117
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configurations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant117Configuration> Configurations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant117" /> class.
        /// </summary>
        /// <param name="configurations"></param>
        /// <param name="ownerId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant117(
            global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant117Configuration> configurations,
            string ownerId)
        {
            this.Configurations = configurations ?? throw new global::System.ArgumentNullException(nameof(configurations));
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant117" /> class.
        /// </summary>
        public UserEventPayloadVariant117()
        {
        }
    }
}