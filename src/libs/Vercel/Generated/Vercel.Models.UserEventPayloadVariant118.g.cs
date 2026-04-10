
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant118
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
        [global::System.Text.Json.Serialization.JsonPropertyName("billingPlanId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BillingPlanId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billingPlanName")]
        public string? BillingPlanName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant118" /> class.
        /// </summary>
        /// <param name="integrationId"></param>
        /// <param name="configurationId"></param>
        /// <param name="integrationSlug"></param>
        /// <param name="integrationName"></param>
        /// <param name="ownerId"></param>
        /// <param name="billingPlanId"></param>
        /// <param name="billingPlanName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant118(
            string integrationId,
            string configurationId,
            string integrationSlug,
            string integrationName,
            string ownerId,
            string billingPlanId,
            string? billingPlanName)
        {
            this.IntegrationId = integrationId ?? throw new global::System.ArgumentNullException(nameof(integrationId));
            this.ConfigurationId = configurationId ?? throw new global::System.ArgumentNullException(nameof(configurationId));
            this.IntegrationSlug = integrationSlug ?? throw new global::System.ArgumentNullException(nameof(integrationSlug));
            this.IntegrationName = integrationName ?? throw new global::System.ArgumentNullException(nameof(integrationName));
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.BillingPlanId = billingPlanId ?? throw new global::System.ArgumentNullException(nameof(billingPlanId));
            this.BillingPlanName = billingPlanName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant118" /> class.
        /// </summary>
        public UserEventPayloadVariant118()
        {
        }
    }
}