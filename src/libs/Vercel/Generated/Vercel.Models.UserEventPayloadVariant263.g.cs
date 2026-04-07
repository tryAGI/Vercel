
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant263
    {
        /// <summary>
        /// Represents configuration for remote caching
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remoteCaching")]
        public global::Vercel.UserEventPayloadVariant263RemoteCaching? RemoteCaching { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant263" /> class.
        /// </summary>
        /// <param name="remoteCaching">
        /// Represents configuration for remote caching
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant263(
            global::Vercel.UserEventPayloadVariant263RemoteCaching? remoteCaching)
        {
            this.RemoteCaching = remoteCaching;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant263" /> class.
        /// </summary>
        public UserEventPayloadVariant263()
        {
        }
    }
}