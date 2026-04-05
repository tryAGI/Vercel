
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateProjectProtectionBypassResponseProtectionBypassVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateProjectProtectionBypassResponseProtectionBypassVariant1ScopeJsonConverter))]
        public global::Vercel.UpdateProjectProtectionBypassResponseProtectionBypassVariant1Scope Scope { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectProtectionBypassResponseProtectionBypassVariant1" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="createdBy"></param>
        /// <param name="integrationId"></param>
        /// <param name="configurationId"></param>
        /// <param name="scope"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectProtectionBypassResponseProtectionBypassVariant1(
            double createdAt,
            string createdBy,
            string integrationId,
            string configurationId,
            global::Vercel.UpdateProjectProtectionBypassResponseProtectionBypassVariant1Scope scope)
        {
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy ?? throw new global::System.ArgumentNullException(nameof(createdBy));
            this.Scope = scope;
            this.IntegrationId = integrationId ?? throw new global::System.ArgumentNullException(nameof(integrationId));
            this.ConfigurationId = configurationId ?? throw new global::System.ArgumentNullException(nameof(configurationId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectProtectionBypassResponseProtectionBypassVariant1" /> class.
        /// </summary>
        public UpdateProjectProtectionBypassResponseProtectionBypassVariant1()
        {
        }
    }
}