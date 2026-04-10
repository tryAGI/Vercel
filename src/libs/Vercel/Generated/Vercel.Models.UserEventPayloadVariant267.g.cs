
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant267
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant267ScopeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant267Scope Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant267" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="scope"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant267(
            bool enabled,
            global::Vercel.UserEventPayloadVariant267Scope scope)
        {
            this.Enabled = enabled;
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant267" /> class.
        /// </summary>
        public UserEventPayloadVariant267()
        {
        }
    }
}