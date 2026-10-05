
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateProjectCheckRequestSourceVariant1
    {
        /// <summary>
        /// Default Value: integration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        public string? Kind { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationId")]
        public string? IntegrationId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationConfigurationId")]
        public string? IntegrationConfigurationId { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectCheckRequestSourceVariant1" /> class.
        /// </summary>
        /// <param name="kind">
        /// Default Value: integration
        /// </param>
        /// <param name="integrationId"></param>
        /// <param name="integrationConfigurationId"></param>
        /// <param name="resourceId"></param>
        /// <param name="externalResourceId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateProjectCheckRequestSourceVariant1(
            string? kind,
            string? integrationId,
            string? integrationConfigurationId,
            string? resourceId,
            string? externalResourceId)
        {
            this.Kind = kind;
            this.IntegrationId = integrationId;
            this.IntegrationConfigurationId = integrationConfigurationId;
            this.ResourceId = resourceId;
            this.ExternalResourceId = externalResourceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectCheckRequestSourceVariant1" /> class.
        /// </summary>
        public CreateProjectCheckRequestSourceVariant1()
        {
        }

    }
}