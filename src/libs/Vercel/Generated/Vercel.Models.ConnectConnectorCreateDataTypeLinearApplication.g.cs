
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Linear OAuth application metadata.
    /// </summary>
    public sealed partial class ConnectConnectorCreateDataTypeLinearApplication
    {
        /// <summary>
        /// Linear OAuth application ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Linear OAuth client ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientId { get; set; }

        /// <summary>
        /// Linear OAuth application name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Linear OAuth application description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Linear OAuth application developer name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("developer")]
        public string? Developer { get; set; }

        /// <summary>
        /// Linear OAuth application developer URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("developerUrl")]
        public string? DeveloperUrl { get; set; }

        /// <summary>
        /// Linear OAuth application image URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageUrl")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Registered redirect URIs for the Linear OAuth application.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirectUris")]
        public global::System.Collections.Generic.IList<string>? RedirectUris { get; set; }

        /// <summary>
        /// Linear OAuth application distribution mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distribution")]
        public string? Distribution { get; set; }

        /// <summary>
        /// Linear resource types delivered to the webhook.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhookResourceTypes")]
        public global::System.Collections.Generic.IList<string>? WebhookResourceTypes { get; set; }

        /// <summary>
        /// Linear webhook URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhookUrl")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Whether the Linear webhook is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhookEnabled")]
        public bool? WebhookEnabled { get; set; }

        /// <summary>
        /// Linear OAuth application creation timestamp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// Linear OAuth application update timestamp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorCreateDataTypeLinearApplication" /> class.
        /// </summary>
        /// <param name="id">
        /// Linear OAuth application ID.
        /// </param>
        /// <param name="clientId">
        /// Linear OAuth client ID.
        /// </param>
        /// <param name="name">
        /// Linear OAuth application name.
        /// </param>
        /// <param name="description">
        /// Linear OAuth application description.
        /// </param>
        /// <param name="developer">
        /// Linear OAuth application developer name.
        /// </param>
        /// <param name="developerUrl">
        /// Linear OAuth application developer URL.
        /// </param>
        /// <param name="imageUrl">
        /// Linear OAuth application image URL.
        /// </param>
        /// <param name="redirectUris">
        /// Registered redirect URIs for the Linear OAuth application.
        /// </param>
        /// <param name="distribution">
        /// Linear OAuth application distribution mode.
        /// </param>
        /// <param name="webhookResourceTypes">
        /// Linear resource types delivered to the webhook.
        /// </param>
        /// <param name="webhookUrl">
        /// Linear webhook URL.
        /// </param>
        /// <param name="webhookEnabled">
        /// Whether the Linear webhook is enabled.
        /// </param>
        /// <param name="createdAt">
        /// Linear OAuth application creation timestamp.
        /// </param>
        /// <param name="updatedAt">
        /// Linear OAuth application update timestamp.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectConnectorCreateDataTypeLinearApplication(
            string id,
            string clientId,
            string name,
            string? description,
            string? developer,
            string? developerUrl,
            string? imageUrl,
            global::System.Collections.Generic.IList<string>? redirectUris,
            string? distribution,
            global::System.Collections.Generic.IList<string>? webhookResourceTypes,
            string? webhookUrl,
            bool? webhookEnabled,
            string? createdAt,
            string? updatedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Developer = developer;
            this.DeveloperUrl = developerUrl;
            this.ImageUrl = imageUrl;
            this.RedirectUris = redirectUris;
            this.Distribution = distribution;
            this.WebhookResourceTypes = webhookResourceTypes;
            this.WebhookUrl = webhookUrl;
            this.WebhookEnabled = webhookEnabled;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorCreateDataTypeLinearApplication" /> class.
        /// </summary>
        public ConnectConnectorCreateDataTypeLinearApplication()
        {
        }

    }
}