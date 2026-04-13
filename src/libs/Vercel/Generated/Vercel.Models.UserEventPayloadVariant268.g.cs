
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant268
    {
        /// <summary>
        /// Represents configuration for remote caching
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remoteCaching")]
        public global::Vercel.UserEventPayloadVariant268RemoteCaching? RemoteCaching { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant268" /> class.
        /// </summary>
        /// <param name="remoteCaching">
        /// Represents configuration for remote caching
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant268(
            global::Vercel.UserEventPayloadVariant268RemoteCaching? remoteCaching)
        {
            this.RemoteCaching = remoteCaching;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant268" /> class.
        /// </summary>
        public UserEventPayloadVariant268()
        {
        }
    }
}