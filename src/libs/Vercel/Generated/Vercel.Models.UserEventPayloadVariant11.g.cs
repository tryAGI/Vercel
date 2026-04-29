
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant11
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant11ApiKey ApiKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant11" /> class.
        /// </summary>
        /// <param name="apiKey"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant11(
            global::Vercel.UserEventPayloadVariant11ApiKey apiKey)
        {
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant11" /> class.
        /// </summary>
        public UserEventPayloadVariant11()
        {
        }
    }
}