
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAllLogDrainsResponseDrainsVariant1ItemSourceVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetAllLogDrainsResponseDrainsVariant1ItemSourceVariant2KindJsonConverter))]
        public global::Vercel.GetAllLogDrainsResponseDrainsVariant1ItemSourceVariant2Kind Kind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceId")]
        public string? ResourceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalResourceId")]
        public string? ExternalResourceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IntegrationId { get; set; }

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
        /// Initializes a new instance of the <see cref="GetAllLogDrainsResponseDrainsVariant1ItemSourceVariant2" /> class.
        /// </summary>
        /// <param name="integrationId"></param>
        /// <param name="integrationConfigurationId"></param>
        /// <param name="kind"></param>
        /// <param name="resourceId"></param>
        /// <param name="externalResourceId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAllLogDrainsResponseDrainsVariant1ItemSourceVariant2(
            string integrationId,
            string integrationConfigurationId,
            global::Vercel.GetAllLogDrainsResponseDrainsVariant1ItemSourceVariant2Kind kind,
            string? resourceId,
            string? externalResourceId)
        {
            this.Kind = kind;
            this.ResourceId = resourceId;
            this.ExternalResourceId = externalResourceId;
            this.IntegrationId = integrationId ?? throw new global::System.ArgumentNullException(nameof(integrationId));
            this.IntegrationConfigurationId = integrationConfigurationId ?? throw new global::System.ArgumentNullException(nameof(integrationConfigurationId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllLogDrainsResponseDrainsVariant1ItemSourceVariant2" /> class.
        /// </summary>
        public GetAllLogDrainsResponseDrainsVariant1ItemSourceVariant2()
        {
        }
    }
}