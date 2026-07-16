
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateConnectorRequestDataTypeOauth
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serverUrl")]
        public string? ServerUrl { get; set; }

        /// <summary>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serverConfig")]
        public global::Vercel.CreateConnectorRequestDataTypeOauthServerConfig? ServerConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientSecret")]
        public string? ClientSecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenEndpointAuthMethod")]
        public string? TokenEndpointAuthMethod { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("responseType")]
        public string? ResponseType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pkceRequired")]
        public bool? PkceRequired { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codeChallengeMethod")]
        public string? CodeChallengeMethod { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userAuthorization")]
        public global::Vercel.CreateConnectorRequestDataTypeOauthUserAuthorization? UserAuthorization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refreshTokens")]
        public global::Vercel.CreateConnectorRequestDataTypeOauthRefreshTokens? RefreshTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientCredentials")]
        public global::Vercel.CreateConnectorRequestDataTypeOauthClientCredentials? ClientCredentials { get; set; }

        /// <summary>
        /// Allow-list of extra claims to propagate, keyed by source (idToken). Only claims named here and present in that source are exposed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forwardedClaims")]
        public global::Vercel.CreateConnectorRequestDataTypeOauthForwardedClaims? ForwardedClaims { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultAudience")]
        public string? DefaultAudience { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorizationUrlParams")]
        public global::System.Collections.Generic.Dictionary<string, string>? AuthorizationUrlParams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jwtBearer")]
        public global::Vercel.CreateConnectorRequestDataTypeOauthJwtBearer? JwtBearer { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorRequestDataTypeOauth" /> class.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="serverUrl"></param>
        /// <param name="serverConfig">
        /// Default Value: {}
        /// </param>
        /// <param name="clientSecret"></param>
        /// <param name="tokenEndpointAuthMethod"></param>
        /// <param name="responseType"></param>
        /// <param name="pkceRequired"></param>
        /// <param name="codeChallengeMethod"></param>
        /// <param name="userAuthorization"></param>
        /// <param name="refreshTokens"></param>
        /// <param name="clientCredentials"></param>
        /// <param name="forwardedClaims">
        /// Allow-list of extra claims to propagate, keyed by source (idToken). Only claims named here and present in that source are exposed.
        /// </param>
        /// <param name="defaultAudience"></param>
        /// <param name="authorizationUrlParams"></param>
        /// <param name="jwtBearer"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConnectorRequestDataTypeOauth(
            string clientId,
            string? serverUrl,
            global::Vercel.CreateConnectorRequestDataTypeOauthServerConfig? serverConfig,
            string? clientSecret,
            string? tokenEndpointAuthMethod,
            string? responseType,
            bool? pkceRequired,
            string? codeChallengeMethod,
            global::Vercel.CreateConnectorRequestDataTypeOauthUserAuthorization? userAuthorization,
            global::Vercel.CreateConnectorRequestDataTypeOauthRefreshTokens? refreshTokens,
            global::Vercel.CreateConnectorRequestDataTypeOauthClientCredentials? clientCredentials,
            global::Vercel.CreateConnectorRequestDataTypeOauthForwardedClaims? forwardedClaims,
            string? defaultAudience,
            global::System.Collections.Generic.Dictionary<string, string>? authorizationUrlParams,
            global::Vercel.CreateConnectorRequestDataTypeOauthJwtBearer? jwtBearer)
        {
            this.ServerUrl = serverUrl;
            this.ServerConfig = serverConfig;
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.ClientSecret = clientSecret;
            this.TokenEndpointAuthMethod = tokenEndpointAuthMethod;
            this.ResponseType = responseType;
            this.PkceRequired = pkceRequired;
            this.CodeChallengeMethod = codeChallengeMethod;
            this.UserAuthorization = userAuthorization;
            this.RefreshTokens = refreshTokens;
            this.ClientCredentials = clientCredentials;
            this.ForwardedClaims = forwardedClaims;
            this.DefaultAudience = defaultAudience;
            this.AuthorizationUrlParams = authorizationUrlParams;
            this.JwtBearer = jwtBearer;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorRequestDataTypeOauth" /> class.
        /// </summary>
        public CreateConnectorRequestDataTypeOauth()
        {
        }

    }
}