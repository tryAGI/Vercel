
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant119
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IntegrationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationSlug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IntegrationSlug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IntegrationName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant119" /> class.
        /// </summary>
        /// <param name="integrationId"></param>
        /// <param name="integrationSlug"></param>
        /// <param name="integrationName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant119(
            string integrationId,
            string integrationSlug,
            string integrationName)
        {
            this.IntegrationId = integrationId ?? throw new global::System.ArgumentNullException(nameof(integrationId));
            this.IntegrationSlug = integrationSlug ?? throw new global::System.ArgumentNullException(nameof(integrationSlug));
            this.IntegrationName = integrationName ?? throw new global::System.ArgumentNullException(nameof(integrationName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant119" /> class.
        /// </summary>
        public UserEventPayloadVariant119()
        {
        }
    }
}