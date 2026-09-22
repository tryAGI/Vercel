
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateIntegrationStoreDirectResponseStoreProduct
    {
        /// <summary>
        /// URLs to skills/guides for how AI agents should use this product. Providers can specify these to help agents understand how to interact with their integration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentSkills")]
        public global::System.Collections.Generic.IList<string>? AgentSkills { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capabilities")]
        public global::Vercel.CreateIntegrationStoreDirectResponseStoreProductCapabilities? Capabilities { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disableResourceRenaming")]
        public bool? DisableResourceRenaming { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iconUrl")]
        public string? IconUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadataSchema")]
        public global::Vercel.AutoSDKSharedf9b373cd1ded5c73? MetadataSchema { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectConnectionScopes")]
        public global::System.Collections.Generic.IList<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductProjectConnectionScope>? ProjectConnectionScopes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceLinks")]
        public global::System.Collections.Generic.IList<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductResourceLink>? ResourceLinks { get; set; }

        /// <summary>
        /// Custom resource title to display during installation and configuration. If not provided, defaults to protocol-based defaults.<br/>
        /// Example: Instance
        /// </summary>
        /// <example>Instance</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceTitle")]
        public string? ResourceTitle { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shortDescription")]
        public string? ShortDescription { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("showSSOLinkOnProjectConnection")]
        public bool? ShowSSOLinkOnProjectConnection { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductTag>? Tags { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repl")]
        public global::Vercel.CreateIntegrationStoreDirectResponseStoreProductRepl? Repl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guides")]
        public global::System.Collections.Generic.IList<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductGuide>? Guides { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateIntegrationStoreDirectResponseStoreProductIntegration Integration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationConfigurationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IntegrationConfigurationId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logDrainStatus")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateIntegrationStoreDirectResponseStoreProductLogDrainStatusJsonConverter))]
        public global::Vercel.CreateIntegrationStoreDirectResponseStoreProductLogDrainStatus? LogDrainStatus { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primaryProtocol")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateIntegrationStoreDirectResponseStoreProductPrimaryProtocolJsonConverter))]
        public global::Vercel.CreateIntegrationStoreDirectResponseStoreProductPrimaryProtocol? PrimaryProtocol { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supportedProtocols")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductSupportedProtocol> SupportedProtocols { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIntegrationStoreDirectResponseStoreProduct" /> class.
        /// </summary>
        /// <param name="integration"></param>
        /// <param name="integrationConfigurationId"></param>
        /// <param name="supportedProtocols"></param>
        /// <param name="agentSkills">
        /// URLs to skills/guides for how AI agents should use this product. Providers can specify these to help agents understand how to interact with their integration.
        /// </param>
        /// <param name="capabilities"></param>
        /// <param name="disableResourceRenaming"></param>
        /// <param name="iconUrl"></param>
        /// <param name="id"></param>
        /// <param name="metadataSchema"></param>
        /// <param name="name"></param>
        /// <param name="projectConnectionScopes"></param>
        /// <param name="resourceLinks"></param>
        /// <param name="resourceTitle">
        /// Custom resource title to display during installation and configuration. If not provided, defaults to protocol-based defaults.<br/>
        /// Example: Instance
        /// </param>
        /// <param name="shortDescription"></param>
        /// <param name="showSSOLinkOnProjectConnection"></param>
        /// <param name="slug"></param>
        /// <param name="tags"></param>
        /// <param name="repl"></param>
        /// <param name="guides"></param>
        /// <param name="logDrainStatus"></param>
        /// <param name="primaryProtocol"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateIntegrationStoreDirectResponseStoreProduct(
            global::Vercel.CreateIntegrationStoreDirectResponseStoreProductIntegration integration,
            string integrationConfigurationId,
            global::System.Collections.Generic.IList<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductSupportedProtocol> supportedProtocols,
            global::System.Collections.Generic.IList<string>? agentSkills,
            global::Vercel.CreateIntegrationStoreDirectResponseStoreProductCapabilities? capabilities,
            bool? disableResourceRenaming,
            string? iconUrl,
            string? id,
            global::Vercel.AutoSDKSharedf9b373cd1ded5c73? metadataSchema,
            string? name,
            global::System.Collections.Generic.IList<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductProjectConnectionScope>? projectConnectionScopes,
            global::System.Collections.Generic.IList<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductResourceLink>? resourceLinks,
            string? resourceTitle,
            string? shortDescription,
            bool? showSSOLinkOnProjectConnection,
            string? slug,
            global::System.Collections.Generic.IList<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductTag>? tags,
            global::Vercel.CreateIntegrationStoreDirectResponseStoreProductRepl? repl,
            global::System.Collections.Generic.IList<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductGuide>? guides,
            global::Vercel.CreateIntegrationStoreDirectResponseStoreProductLogDrainStatus? logDrainStatus,
            global::Vercel.CreateIntegrationStoreDirectResponseStoreProductPrimaryProtocol? primaryProtocol)
        {
            this.AgentSkills = agentSkills;
            this.Capabilities = capabilities;
            this.DisableResourceRenaming = disableResourceRenaming;
            this.IconUrl = iconUrl;
            this.Id = id;
            this.MetadataSchema = metadataSchema;
            this.Name = name;
            this.ProjectConnectionScopes = projectConnectionScopes;
            this.ResourceLinks = resourceLinks;
            this.ResourceTitle = resourceTitle;
            this.ShortDescription = shortDescription;
            this.ShowSSOLinkOnProjectConnection = showSSOLinkOnProjectConnection;
            this.Slug = slug;
            this.Tags = tags;
            this.Repl = repl;
            this.Guides = guides;
            this.Integration = integration ?? throw new global::System.ArgumentNullException(nameof(integration));
            this.IntegrationConfigurationId = integrationConfigurationId ?? throw new global::System.ArgumentNullException(nameof(integrationConfigurationId));
            this.LogDrainStatus = logDrainStatus;
            this.PrimaryProtocol = primaryProtocol;
            this.SupportedProtocols = supportedProtocols ?? throw new global::System.ArgumentNullException(nameof(supportedProtocols));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIntegrationStoreDirectResponseStoreProduct" /> class.
        /// </summary>
        public CreateIntegrationStoreDirectResponseStoreProduct()
        {
        }

    }
}