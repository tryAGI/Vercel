
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImportConnectorTokensResponseToken
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public object? Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installationId")]
        public string? InstallationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audience")]
        public global::System.Collections.Generic.IList<string>? Audience { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resources")]
        public global::System.Collections.Generic.IList<string>? Resources { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorizationDetails")]
        public global::System.Collections.Generic.IList<global::Vercel.ImportConnectorTokensResponseTokenAuthorizationDetail>? AuthorizationDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refreshTokenExpiresAt")]
        public double? RefreshTokenExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalSubject")]
        public string? ExternalSubject { get; set; }

        /// <summary>
        /// Claims extracted from the provider's tokens per the connector's `ForwardedClaims` allow-list. Currently sourced from the OIDC id_token only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("claims")]
        public object? Claims { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installation")]
        public global::Vercel.ImportConnectorTokensResponseTokenInstallation? Installation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant")]
        public global::Vercel.ImportConnectorTokensResponseTokenTenant? Tenant { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.ImportConnectorTokensResponseTokenSubjectVariant1, global::Vercel.ImportConnectorTokensResponseTokenSubjectVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.ImportConnectorTokensResponseTokenSubjectVariant1, global::Vercel.ImportConnectorTokensResponseTokenSubjectVariant2> Subject { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.ImportConnectorTokensConnectEnvironment?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<string, global::Vercel.ImportConnectorTokensConnectEnvironment?> Environment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("succeeded")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Succeeded { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportConnectorTokensResponseToken" /> class.
        /// </summary>
        /// <param name="expiresAt"></param>
        /// <param name="subject"></param>
        /// <param name="environment"></param>
        /// <param name="succeeded"></param>
        /// <param name="name"></param>
        /// <param name="data"></param>
        /// <param name="installationId"></param>
        /// <param name="audience"></param>
        /// <param name="scopes"></param>
        /// <param name="resources"></param>
        /// <param name="authorizationDetails"></param>
        /// <param name="refreshTokenExpiresAt"></param>
        /// <param name="externalSubject"></param>
        /// <param name="claims">
        /// Claims extracted from the provider's tokens per the connector's `ForwardedClaims` allow-list. Currently sourced from the OIDC id_token only.
        /// </param>
        /// <param name="installation"></param>
        /// <param name="tenant"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImportConnectorTokensResponseToken(
            double expiresAt,
            global::Vercel.OneOf<global::Vercel.ImportConnectorTokensResponseTokenSubjectVariant1, global::Vercel.ImportConnectorTokensResponseTokenSubjectVariant2> subject,
            global::Vercel.OneOf<string, global::Vercel.ImportConnectorTokensConnectEnvironment?> environment,
            bool succeeded,
            string? name,
            object? data,
            string? installationId,
            global::System.Collections.Generic.IList<string>? audience,
            global::System.Collections.Generic.IList<string>? scopes,
            global::System.Collections.Generic.IList<string>? resources,
            global::System.Collections.Generic.IList<global::Vercel.ImportConnectorTokensResponseTokenAuthorizationDetail>? authorizationDetails,
            double? refreshTokenExpiresAt,
            string? externalSubject,
            object? claims,
            global::Vercel.ImportConnectorTokensResponseTokenInstallation? installation,
            global::Vercel.ImportConnectorTokensResponseTokenTenant? tenant)
        {
            this.Name = name;
            this.Data = data;
            this.InstallationId = installationId;
            this.Audience = audience;
            this.Scopes = scopes;
            this.Resources = resources;
            this.AuthorizationDetails = authorizationDetails;
            this.ExpiresAt = expiresAt;
            this.RefreshTokenExpiresAt = refreshTokenExpiresAt;
            this.ExternalSubject = externalSubject;
            this.Claims = claims;
            this.Installation = installation;
            this.Tenant = tenant;
            this.Subject = subject;
            this.Environment = environment;
            this.Succeeded = succeeded;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportConnectorTokensResponseToken" /> class.
        /// </summary>
        public ImportConnectorTokensResponseToken()
        {
        }

    }
}