
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConfigurableLogDrainResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdFrom")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedFrom { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientId")]
        public string? ClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configurationId")]
        public string? ConfigurationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectsMetadata")]
        public global::System.Collections.Generic.IList<global::Vercel.GetConfigurableLogDrainResponseProjectsMetadataItem>? ProjectsMetadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationIcon")]
        public string? IntegrationIcon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationConfigurationUri")]
        public string? IntegrationConfigurationUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationWebsite")]
        public string? IntegrationWebsite { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConfigurableLogDrainResponse" /> class.
        /// </summary>
        /// <param name="createdFrom"></param>
        /// <param name="clientId"></param>
        /// <param name="configurationId"></param>
        /// <param name="projectsMetadata"></param>
        /// <param name="integrationIcon"></param>
        /// <param name="integrationConfigurationUri"></param>
        /// <param name="integrationWebsite"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConfigurableLogDrainResponse(
            string createdFrom,
            string? clientId,
            string? configurationId,
            global::System.Collections.Generic.IList<global::Vercel.GetConfigurableLogDrainResponseProjectsMetadataItem>? projectsMetadata,
            string? integrationIcon,
            string? integrationConfigurationUri,
            string? integrationWebsite)
        {
            this.CreatedFrom = createdFrom ?? throw new global::System.ArgumentNullException(nameof(createdFrom));
            this.ClientId = clientId;
            this.ConfigurationId = configurationId;
            this.ProjectsMetadata = projectsMetadata;
            this.IntegrationIcon = integrationIcon;
            this.IntegrationConfigurationUri = integrationConfigurationUri;
            this.IntegrationWebsite = integrationWebsite;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConfigurableLogDrainResponse" /> class.
        /// </summary>
        public GetConfigurableLogDrainResponse()
        {
        }
    }
}