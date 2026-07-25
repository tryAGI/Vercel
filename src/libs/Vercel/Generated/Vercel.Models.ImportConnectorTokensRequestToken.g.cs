
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImportConnectorTokensRequestToken
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessToken")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccessToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refreshToken")]
        public string? RefreshToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refreshTokenExpiresAt")]
        public double? RefreshTokenExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.ImportConnectorTokensRequestTokenSubjectTypeApp, global::Vercel.ImportConnectorTokensRequestTokenSubjectTypeUser>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AnyOf<global::Vercel.ImportConnectorTokensRequestTokenSubjectTypeApp, global::Vercel.ImportConnectorTokensRequestTokenSubjectTypeUser> Subject { get; set; }

        /// <summary>
        /// A built-in environment name or the stable env_* ID of a custom environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.ImportConnectorTokensEnvironment?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AnyOf<global::Vercel.ImportConnectorTokensEnvironment?, string> Environment { get; set; }

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
        public global::System.Collections.Generic.IList<global::Vercel.ImportConnectorTokensRequestTokenAuthorizationDetail>? AuthorizationDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalSubject")]
        public string? ExternalSubject { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installation")]
        public global::Vercel.ImportConnectorTokensRequestTokenInstallation? Installation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant")]
        public global::Vercel.ImportConnectorTokensRequestTokenTenant? Tenant { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public object? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportConnectorTokensRequestToken" /> class.
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="expiresAt"></param>
        /// <param name="subject"></param>
        /// <param name="environment">
        /// A built-in environment name or the stable env_* ID of a custom environment.
        /// </param>
        /// <param name="refreshToken"></param>
        /// <param name="refreshTokenExpiresAt"></param>
        /// <param name="installationId"></param>
        /// <param name="audience"></param>
        /// <param name="scopes"></param>
        /// <param name="resources"></param>
        /// <param name="authorizationDetails"></param>
        /// <param name="name"></param>
        /// <param name="externalSubject"></param>
        /// <param name="installation"></param>
        /// <param name="tenant"></param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImportConnectorTokensRequestToken(
            string accessToken,
            double expiresAt,
            global::Vercel.AnyOf<global::Vercel.ImportConnectorTokensRequestTokenSubjectTypeApp, global::Vercel.ImportConnectorTokensRequestTokenSubjectTypeUser> subject,
            global::Vercel.AnyOf<global::Vercel.ImportConnectorTokensEnvironment?, string> environment,
            string? refreshToken,
            double? refreshTokenExpiresAt,
            string? installationId,
            global::System.Collections.Generic.IList<string>? audience,
            global::System.Collections.Generic.IList<string>? scopes,
            global::System.Collections.Generic.IList<string>? resources,
            global::System.Collections.Generic.IList<global::Vercel.ImportConnectorTokensRequestTokenAuthorizationDetail>? authorizationDetails,
            string? name,
            string? externalSubject,
            global::Vercel.ImportConnectorTokensRequestTokenInstallation? installation,
            global::Vercel.ImportConnectorTokensRequestTokenTenant? tenant,
            object? data)
        {
            this.AccessToken = accessToken ?? throw new global::System.ArgumentNullException(nameof(accessToken));
            this.ExpiresAt = expiresAt;
            this.RefreshToken = refreshToken;
            this.RefreshTokenExpiresAt = refreshTokenExpiresAt;
            this.Subject = subject;
            this.Environment = environment;
            this.InstallationId = installationId;
            this.Audience = audience;
            this.Scopes = scopes;
            this.Resources = resources;
            this.AuthorizationDetails = authorizationDetails;
            this.Name = name;
            this.ExternalSubject = externalSubject;
            this.Installation = installation;
            this.Tenant = tenant;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportConnectorTokensRequestToken" /> class.
        /// </summary>
        public ImportConnectorTokensRequestToken()
        {
        }

    }
}