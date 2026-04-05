
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Represents configuration for remote caching
    /// </summary>
    public sealed partial class UserEventPayloadVariant262RemoteCaching
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant262RemoteCaching" /> class.
        /// </summary>
        /// <param name="enabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant262RemoteCaching(
            bool? enabled)
        {
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant262RemoteCaching" /> class.
        /// </summary>
        public UserEventPayloadVariant262RemoteCaching()
        {
        }
    }
}