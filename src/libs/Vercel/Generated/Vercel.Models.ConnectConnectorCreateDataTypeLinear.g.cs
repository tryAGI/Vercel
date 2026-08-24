
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConnectConnectorCreateDataTypeLinear
    {
        /// <summary>
        /// Linear application ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appId")]
        public string? AppId { get; set; }

        /// <summary>
        /// Linear application name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appName")]
        public string? AppName { get; set; }

        /// <summary>
        /// OAuth client ID assigned by Linear.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientId { get; set; }

        /// <summary>
        /// Linear OAuth client secret.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientSecret")]
        public string? ClientSecret { get; set; }

        /// <summary>
        /// Linear webhook verification secret.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhookSecret")]
        public string? WebhookSecret { get; set; }

        /// <summary>
        /// OAuth scopes requested for Linear application tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appScopes")]
        public global::System.Collections.Generic.IList<string>? AppScopes { get; set; }

        /// <summary>
        /// OAuth scopes requested for Linear user tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userScopes")]
        public global::System.Collections.Generic.IList<string>? UserScopes { get; set; }

        /// <summary>
        /// Linear organization that owns the OAuth application.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerOrganization")]
        public global::Vercel.ConnectConnectorCreateDataTypeLinearOwnerOrganization? OwnerOrganization { get; set; }

        /// <summary>
        /// Linear OAuth application metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("application")]
        public global::Vercel.ConnectConnectorCreateDataTypeLinearApplication? Application { get; set; }

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
        /// Initializes a new instance of the <see cref="ConnectConnectorCreateDataTypeLinear" /> class.
        /// </summary>
        /// <param name="clientId">
        /// OAuth client ID assigned by Linear.
        /// </param>
        /// <param name="appId">
        /// Linear application ID.
        /// </param>
        /// <param name="appName">
        /// Linear application name.
        /// </param>
        /// <param name="clientSecret">
        /// Linear OAuth client secret.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="webhookSecret">
        /// Linear webhook verification secret.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="appScopes">
        /// OAuth scopes requested for Linear application tokens.
        /// </param>
        /// <param name="userScopes">
        /// OAuth scopes requested for Linear user tokens.
        /// </param>
        /// <param name="ownerOrganization">
        /// Linear organization that owns the OAuth application.
        /// </param>
        /// <param name="application">
        /// Linear OAuth application metadata.
        /// </param>
        /// <param name="extras">
        /// Additional provider metadata stored with the connector.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectConnectorCreateDataTypeLinear(
            string clientId,
            string? appId,
            string? appName,
            string? clientSecret,
            string? webhookSecret,
            global::System.Collections.Generic.IList<string>? appScopes,
            global::System.Collections.Generic.IList<string>? userScopes,
            global::Vercel.ConnectConnectorCreateDataTypeLinearOwnerOrganization? ownerOrganization,
            global::Vercel.ConnectConnectorCreateDataTypeLinearApplication? application,
            object? extras)
        {
            this.AppId = appId;
            this.AppName = appName;
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.ClientSecret = clientSecret;
            this.WebhookSecret = webhookSecret;
            this.AppScopes = appScopes;
            this.UserScopes = userScopes;
            this.OwnerOrganization = ownerOrganization;
            this.Application = application;
            this.Extras = extras;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorCreateDataTypeLinear" /> class.
        /// </summary>
        public ConnectConnectorCreateDataTypeLinear()
        {
        }

    }
}