
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedc396e89a7a8d84fbSourceVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalResourceId")]
        public string? ExternalResourceId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationConfigurationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IntegrationConfigurationId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IntegrationId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedc396e89a7a8d84fbSourceVariant2KindJsonConverter))]
        public global::Vercel.AutoSDKSharedc396e89a7a8d84fbSourceVariant2Kind Kind { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceId")]
        public string? ResourceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedc396e89a7a8d84fbSourceVariant2" /> class.
        /// </summary>
        /// <param name="integrationConfigurationId"></param>
        /// <param name="integrationId"></param>
        /// <param name="externalResourceId"></param>
        /// <param name="kind"></param>
        /// <param name="resourceId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedc396e89a7a8d84fbSourceVariant2(
            string integrationConfigurationId,
            string integrationId,
            string? externalResourceId,
            global::Vercel.AutoSDKSharedc396e89a7a8d84fbSourceVariant2Kind kind,
            string? resourceId)
        {
            this.ExternalResourceId = externalResourceId;
            this.IntegrationConfigurationId = integrationConfigurationId ?? throw new global::System.ArgumentNullException(nameof(integrationConfigurationId));
            this.IntegrationId = integrationId ?? throw new global::System.ArgumentNullException(nameof(integrationId));
            this.Kind = kind;
            this.ResourceId = resourceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedc396e89a7a8d84fbSourceVariant2" /> class.
        /// </summary>
        public AutoSDKSharedc396e89a7a8d84fbSourceVariant2()
        {
        }

    }
}