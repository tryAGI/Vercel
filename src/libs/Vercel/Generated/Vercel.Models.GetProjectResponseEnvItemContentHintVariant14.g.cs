
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectResponseEnvItemContentHintVariant14
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectResponseEnvItemContentHintVariant14TypeJsonConverter))]
        public global::Vercel.GetProjectResponseEnvItemContentHintVariant14Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storeId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StoreId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IntegrationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationProductId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IntegrationProductId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationConfigurationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IntegrationConfigurationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectResponseEnvItemContentHintVariant14" /> class.
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="integrationId"></param>
        /// <param name="integrationProductId"></param>
        /// <param name="integrationConfigurationId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectResponseEnvItemContentHintVariant14(
            string storeId,
            string integrationId,
            string integrationProductId,
            string integrationConfigurationId,
            global::Vercel.GetProjectResponseEnvItemContentHintVariant14Type type)
        {
            this.Type = type;
            this.StoreId = storeId ?? throw new global::System.ArgumentNullException(nameof(storeId));
            this.IntegrationId = integrationId ?? throw new global::System.ArgumentNullException(nameof(integrationId));
            this.IntegrationProductId = integrationProductId ?? throw new global::System.ArgumentNullException(nameof(integrationProductId));
            this.IntegrationConfigurationId = integrationConfigurationId ?? throw new global::System.ArgumentNullException(nameof(integrationConfigurationId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectResponseEnvItemContentHintVariant14" /> class.
        /// </summary>
        public GetProjectResponseEnvItemContentHintVariant14()
        {
        }
    }
}