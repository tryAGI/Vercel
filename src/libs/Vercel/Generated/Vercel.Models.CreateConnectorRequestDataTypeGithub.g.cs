
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateConnectorRequestDataTypeGithub
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AppId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appSlug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AppSlug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AppName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        public global::Vercel.CreateConnectorRequestDataTypeGithubOwner? Owner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientSecret")]
        public string? ClientSecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("privateKeyPem")]
        public string? PrivateKeyPem { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhookSecret")]
        public string? WebhookSecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extras")]
        public object? Extras { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorRequestDataTypeGithub" /> class.
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="appSlug"></param>
        /// <param name="appName"></param>
        /// <param name="clientId"></param>
        /// <param name="owner"></param>
        /// <param name="clientSecret"></param>
        /// <param name="privateKeyPem"></param>
        /// <param name="webhookSecret"></param>
        /// <param name="extras"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConnectorRequestDataTypeGithub(
            int appId,
            string appSlug,
            string appName,
            string clientId,
            global::Vercel.CreateConnectorRequestDataTypeGithubOwner? owner,
            string? clientSecret,
            string? privateKeyPem,
            string? webhookSecret,
            object? extras)
        {
            this.AppId = appId;
            this.AppSlug = appSlug ?? throw new global::System.ArgumentNullException(nameof(appSlug));
            this.AppName = appName ?? throw new global::System.ArgumentNullException(nameof(appName));
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.Owner = owner;
            this.ClientSecret = clientSecret;
            this.PrivateKeyPem = privateKeyPem;
            this.WebhookSecret = webhookSecret;
            this.Extras = extras;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorRequestDataTypeGithub" /> class.
        /// </summary>
        public CreateConnectorRequestDataTypeGithub()
        {
        }

    }
}