
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConnectConnectorUpdateDataTypeGithub
    {
        /// <summary>
        /// GitHub App numeric ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appId")]
        public int? AppId { get; set; }

        /// <summary>
        /// GitHub App slug.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appSlug")]
        public string? AppSlug { get; set; }

        /// <summary>
        /// GitHub App display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appName")]
        public string? AppName { get; set; }

        /// <summary>
        /// GitHub App OAuth client ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientId")]
        public string? ClientId { get; set; }

        /// <summary>
        /// GitHub App owner.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        public global::Vercel.ConnectConnectorUpdateDataTypeGithubOwner? Owner { get; set; }

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
        /// Initializes a new instance of the <see cref="ConnectConnectorUpdateDataTypeGithub" /> class.
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
        /// GitHub App OAuth client ID.
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
        public ConnectConnectorUpdateDataTypeGithub(
            int? appId,
            string? appSlug,
            string? appName,
            string? clientId,
            global::Vercel.ConnectConnectorUpdateDataTypeGithubOwner? owner,
            string? clientSecret,
            string? privateKeyPem,
            string? webhookSecret,
            object? extras)
        {
            this.AppId = appId;
            this.AppSlug = appSlug;
            this.AppName = appName;
            this.ClientId = clientId;
            this.Owner = owner;
            this.ClientSecret = clientSecret;
            this.PrivateKeyPem = privateKeyPem;
            this.WebhookSecret = webhookSecret;
            this.Extras = extras;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorUpdateDataTypeGithub" /> class.
        /// </summary>
        public ConnectConnectorUpdateDataTypeGithub()
        {
        }

    }
}