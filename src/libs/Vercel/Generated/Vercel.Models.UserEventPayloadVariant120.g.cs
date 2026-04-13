
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant120
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
        [global::System.Text.Json.Serialization.JsonPropertyName("configurationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConfigurationId { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectIds")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, global::Vercel.UserEventPayloadVariant120ProjectIds?>))]
        public global::Vercel.OneOf<global::System.Collections.Generic.IList<string>, global::Vercel.UserEventPayloadVariant120ProjectIds?>? ProjectIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant120" /> class.
        /// </summary>
        /// <param name="integrationId"></param>
        /// <param name="configurationId"></param>
        /// <param name="integrationSlug"></param>
        /// <param name="integrationName"></param>
        /// <param name="ownerId"></param>
        /// <param name="projectIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant120(
            string integrationId,
            string configurationId,
            string integrationSlug,
            string integrationName,
            string ownerId,
            global::Vercel.OneOf<global::System.Collections.Generic.IList<string>, global::Vercel.UserEventPayloadVariant120ProjectIds?>? projectIds)
        {
            this.IntegrationId = integrationId ?? throw new global::System.ArgumentNullException(nameof(integrationId));
            this.ConfigurationId = configurationId ?? throw new global::System.ArgumentNullException(nameof(configurationId));
            this.IntegrationSlug = integrationSlug ?? throw new global::System.ArgumentNullException(nameof(integrationSlug));
            this.IntegrationName = integrationName ?? throw new global::System.ArgumentNullException(nameof(integrationName));
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.ProjectIds = projectIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant120" /> class.
        /// </summary>
        public UserEventPayloadVariant120()
        {
        }
    }
}