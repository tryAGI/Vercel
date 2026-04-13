
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant123
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logDrainUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LogDrainUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationName")]
        public string? IntegrationName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant123" /> class.
        /// </summary>
        /// <param name="logDrainUrl"></param>
        /// <param name="integrationName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant123(
            string logDrainUrl,
            string? integrationName)
        {
            this.LogDrainUrl = logDrainUrl ?? throw new global::System.ArgumentNullException(nameof(logDrainUrl));
            this.IntegrationName = integrationName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant123" /> class.
        /// </summary>
        public UserEventPayloadVariant123()
        {
        }
    }
}