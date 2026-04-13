
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant116
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

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
        public string? IntegrationName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newOwner")]
        public global::Vercel.UserEventPayloadVariant116NewOwner? NewOwner { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant116" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="integrationId"></param>
        /// <param name="configurationId"></param>
        /// <param name="integrationSlug"></param>
        /// <param name="integrationName"></param>
        /// <param name="newOwner"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant116(
            string userId,
            string integrationId,
            string configurationId,
            string integrationSlug,
            string? integrationName,
            global::Vercel.UserEventPayloadVariant116NewOwner? newOwner)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.IntegrationId = integrationId ?? throw new global::System.ArgumentNullException(nameof(integrationId));
            this.ConfigurationId = configurationId ?? throw new global::System.ArgumentNullException(nameof(configurationId));
            this.IntegrationSlug = integrationSlug ?? throw new global::System.ArgumentNullException(nameof(integrationSlug));
            this.IntegrationName = integrationName;
            this.NewOwner = newOwner;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant116" /> class.
        /// </summary>
        public UserEventPayloadVariant116()
        {
        }
    }
}