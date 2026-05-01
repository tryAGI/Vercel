
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant134
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
        [global::System.Text.Json.Serialization.JsonPropertyName("allowedIntegrationCount")]
        public double? AllowedIntegrationCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowedIntegrationIds")]
        public global::System.Collections.Generic.IList<string>? AllowedIntegrationIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant134" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="allowedIntegrationCount"></param>
        /// <param name="allowedIntegrationIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant134(
            bool enabled,
            double? allowedIntegrationCount,
            global::System.Collections.Generic.IList<string>? allowedIntegrationIds)
        {
            this.Enabled = enabled;
            this.AllowedIntegrationCount = allowedIntegrationCount;
            this.AllowedIntegrationIds = allowedIntegrationIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant134" /> class.
        /// </summary>
        public UserEventPayloadVariant134()
        {
        }
    }
}