
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetConnectorTokenResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TokenId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ExpiresAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connector")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetConnectorTokenResponseConnector Connector { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installationId")]
        public string? InstallationId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenantId")]
        public string? TenantId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalSubject")]
        public string? ExternalSubject { get; set; }

        /// <summary>
        /// Stable id correlating all tokens (including refreshes) back to the original authorization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorizationId")]
        public string? AuthorizationId { get; set; }

        /// <summary>
        /// Stable id that groups all tokens with the same parameters across refreshes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenGroupId")]
        public string? TokenGroupId { get; set; }

        /// <summary>
        /// Claims extracted from the provider's tokens per the connector's `ForwardedClaims` allow-list. Currently sourced from the OIDC id_token only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("claims")]
        public object? Claims { get; set; }

        /// <summary>
        /// Driver-specific metadata (e.g., botUserId for Slack).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectorTokenResponse" /> class.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="tokenId"></param>
        /// <param name="expiresAt"></param>
        /// <param name="connector"></param>
        /// <param name="name"></param>
        /// <param name="installationId"></param>
        /// <param name="tenantId"></param>
        /// <param name="externalSubject"></param>
        /// <param name="authorizationId">
        /// Stable id correlating all tokens (including refreshes) back to the original authorization.
        /// </param>
        /// <param name="tokenGroupId">
        /// Stable id that groups all tokens with the same parameters across refreshes.
        /// </param>
        /// <param name="claims">
        /// Claims extracted from the provider's tokens per the connector's `ForwardedClaims` allow-list. Currently sourced from the OIDC id_token only.
        /// </param>
        /// <param name="metadata">
        /// Driver-specific metadata (e.g., botUserId for Slack).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConnectorTokenResponse(
            string token,
            string tokenId,
            double expiresAt,
            global::Vercel.GetConnectorTokenResponseConnector connector,
            string? name,
            string? installationId,
            string? tenantId,
            string? externalSubject,
            string? authorizationId,
            string? tokenGroupId,
            object? claims,
            object? metadata)
        {
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.TokenId = tokenId ?? throw new global::System.ArgumentNullException(nameof(tokenId));
            this.ExpiresAt = expiresAt;
            this.Connector = connector ?? throw new global::System.ArgumentNullException(nameof(connector));
            this.Name = name;
            this.InstallationId = installationId;
            this.TenantId = tenantId;
            this.ExternalSubject = externalSubject;
            this.AuthorizationId = authorizationId;
            this.TokenGroupId = tokenGroupId;
            this.Claims = claims;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectorTokenResponse" /> class.
        /// </summary>
        public GetConnectorTokenResponse()
        {
        }

    }
}