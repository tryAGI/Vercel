
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateConnectorRequestDataTypeLinearApplication
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("developer")]
        public string? Developer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("developerUrl")]
        public string? DeveloperUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageUrl")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirectUris")]
        public global::System.Collections.Generic.IList<string>? RedirectUris { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distribution")]
        public string? Distribution { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhookResourceTypes")]
        public global::System.Collections.Generic.IList<string>? WebhookResourceTypes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhookUrl")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhookEnabled")]
        public bool? WebhookEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorRequestDataTypeLinearApplication" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="clientId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="developer"></param>
        /// <param name="developerUrl"></param>
        /// <param name="imageUrl"></param>
        /// <param name="redirectUris"></param>
        /// <param name="distribution"></param>
        /// <param name="webhookResourceTypes"></param>
        /// <param name="webhookUrl"></param>
        /// <param name="webhookEnabled"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConnectorRequestDataTypeLinearApplication(
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
        /// Initializes a new instance of the <see cref="CreateConnectorRequestDataTypeLinearApplication" /> class.
        /// </summary>
        public CreateConnectorRequestDataTypeLinearApplication()
        {
        }

    }
}