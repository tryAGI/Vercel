
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConnectConnectorCreateDataTypeGithub
    {
        /// <summary>
        /// GitHub App numeric ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AppId { get; set; }

        /// <summary>
        /// GitHub App slug.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appSlug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AppSlug { get; set; }

        /// <summary>
        /// GitHub App display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AppName { get; set; }

        /// <summary>
        /// OAuth client ID assigned by GitHub.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientId { get; set; }

        /// <summary>
        /// GitHub App owner.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        public global::Vercel.ConnectConnectorCreateDataTypeGithubOwner? Owner { get; set; }

        /// <summary>
        /// GitHub App OAuth client secret.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientSecret")]
        public string? ClientSecret { get; set; }

        /// <summary>
        /// GitHub App private key in PEM format.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("privateKeyPem")]
        public string? PrivateKeyPem { get; set; }

        /// <summary>
        /// GitHub App webhook secret.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhookSecret")]
        public string? WebhookSecret { get; set; }

        /// <summary>
        /// Additional provider metadata stored with the connector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extras")]
        public object? Extras { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorCreateDataTypeGithub" /> class.
        /// </summary>
        /// <param name="appId">
        /// GitHub App numeric ID.
        /// </param>
        /// <param name="appSlug">
        /// GitHub App slug.
        /// </param>
        /// <param name="appName">
        /// GitHub App display name.
        /// </param>
        /// <param name="clientId">
        /// OAuth client ID assigned by GitHub.
        /// </param>
        /// <param name="owner">
        /// GitHub App owner.
        /// </param>
        /// <param name="clientSecret">
        /// GitHub App OAuth client secret.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="privateKeyPem">
        /// GitHub App private key in PEM format.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="webhookSecret">
        /// GitHub App webhook secret.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="extras">
        /// Additional provider metadata stored with the connector.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectConnectorCreateDataTypeGithub(
            int appId,
            string appSlug,
            string appName,
            string clientId,
            global::Vercel.ConnectConnectorCreateDataTypeGithubOwner? owner,
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
        /// Initializes a new instance of the <see cref="ConnectConnectorCreateDataTypeGithub" /> class.
        /// </summary>
        public ConnectConnectorCreateDataTypeGithub()
        {
        }

    }
}