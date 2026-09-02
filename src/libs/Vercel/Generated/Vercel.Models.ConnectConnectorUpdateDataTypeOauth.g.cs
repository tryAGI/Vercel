
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConnectConnectorUpdateDataTypeOauth
    {
        /// <summary>
        /// Authorization server base URL used for discovery.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serverUrl")]
        public string? ServerUrl { get; set; }

        /// <summary>
        /// Authorization server metadata. Values override discovered metadata. Empty known string fields remove their stored overrides.<br/>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serverConfig")]
        public global::Vercel.ConnectConnectorUpdateDataTypeOauthServerConfig? ServerConfig { get; set; }

        /// <summary>
        /// OAuth client ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientId")]
        public string? ClientId { get; set; }

        /// <summary>
        /// OAuth client name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientName")]
        public string? ClientName { get; set; }

        /// <summary>
        /// OAuth client secret.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientSecret")]
        public string? ClientSecret { get; set; }

        /// <summary>
        /// OAuth token endpoint authentication method. Common values are client_secret_post, client_secret_basic, none, and private_key_jwt. If omitted, Vercel selects a supported method from serverConfig and otherwise uses client_secret_post.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenEndpointAuthMethod")]
        public string? TokenEndpointAuthMethod { get; set; }

        /// <summary>
        /// OAuth authorization response type. Defaults to code. Other provider-supported values are accepted. An empty string clears the configured type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("responseType")]
        public string? ResponseType { get; set; }

        /// <summary>
        /// Whether user authorization must use PKCE.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pkceRequired")]
        public bool? PkceRequired { get; set; }

        /// <summary>
        /// PKCE code challenge method. Supported values are S256 and plain. Vercel prefers S256 when the provider supports it. An empty string clears the configured method.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codeChallengeMethod")]
        public string? CodeChallengeMethod { get; set; }

        /// <summary>
        /// User authorization grant settings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userAuthorization")]
        public global::Vercel.ConnectConnectorUpdateDataTypeOauthUserAuthorization? UserAuthorization { get; set; }

        /// <summary>
        /// Refresh token settings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refreshTokens")]
        public global::Vercel.ConnectConnectorUpdateDataTypeOauthRefreshTokens? RefreshTokens { get; set; }

        /// <summary>
        /// Client credentials grant settings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientCredentials")]
        public global::Vercel.ConnectConnectorUpdateDataTypeOauthClientCredentials? ClientCredentials { get; set; }

        /// <summary>
        /// Allow-list of extra claims to propagate, keyed by source (idToken). Only claims named here and present in that source are exposed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forwardedClaims")]
        public global::Vercel.ConnectConnectorUpdateDataTypeOauthForwardedClaims? ForwardedClaims { get; set; }

        /// <summary>
        /// Default audience used when a token request omits one. An empty string clears the default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultAudience")]
        public string? DefaultAudience { get; set; }

        /// <summary>
        /// Default token lifetime in seconds to use when the token response omits expires_in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultTokenExpiresIn")]
        public double? DefaultTokenExpiresIn { get; set; }

        /// <summary>
        /// Extra query parameters added to authorization URLs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorizationUrlParams")]
        public global::System.Collections.Generic.Dictionary<string, string>? AuthorizationUrlParams { get; set; }

        /// <summary>
        /// JWT bearer grant settings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jwtBearer")]
        public global::Vercel.ConnectConnectorUpdateDataTypeOauthJwtBearer? JwtBearer { get; set; }

        /// <summary>
        /// `private_key_jwt` client assertion settings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientAssertion")]
        public global::Vercel.ConnectConnectorUpdateDataTypeOauthClientAssertion? ClientAssertion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorUpdateDataTypeOauth" /> class.
        /// </summary>
        /// <param name="serverUrl">
        /// Authorization server base URL used for discovery.
        /// </param>
        /// <param name="serverConfig">
        /// Authorization server metadata. Values override discovered metadata. Empty known string fields remove their stored overrides.<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="clientId">
        /// OAuth client ID.
        /// </param>
        /// <param name="clientName">
        /// OAuth client name.
        /// </param>
        /// <param name="clientSecret">
        /// OAuth client secret.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="tokenEndpointAuthMethod">
        /// OAuth token endpoint authentication method. Common values are client_secret_post, client_secret_basic, none, and private_key_jwt. If omitted, Vercel selects a supported method from serverConfig and otherwise uses client_secret_post.
        /// </param>
        /// <param name="responseType">
        /// OAuth authorization response type. Defaults to code. Other provider-supported values are accepted. An empty string clears the configured type.
        /// </param>
        /// <param name="pkceRequired">
        /// Whether user authorization must use PKCE.
        /// </param>
        /// <param name="codeChallengeMethod">
        /// PKCE code challenge method. Supported values are S256 and plain. Vercel prefers S256 when the provider supports it. An empty string clears the configured method.
        /// </param>
        /// <param name="userAuthorization">
        /// User authorization grant settings.
        /// </param>
        /// <param name="refreshTokens">
        /// Refresh token settings.
        /// </param>
        /// <param name="clientCredentials">
        /// Client credentials grant settings.
        /// </param>
        /// <param name="forwardedClaims">
        /// Allow-list of extra claims to propagate, keyed by source (idToken). Only claims named here and present in that source are exposed.
        /// </param>
        /// <param name="defaultAudience">
        /// Default audience used when a token request omits one. An empty string clears the default.
        /// </param>
        /// <param name="defaultTokenExpiresIn">
        /// Default token lifetime in seconds to use when the token response omits expires_in.
        /// </param>
        /// <param name="authorizationUrlParams">
        /// Extra query parameters added to authorization URLs.
        /// </param>
        /// <param name="jwtBearer">
        /// JWT bearer grant settings.
        /// </param>
        /// <param name="clientAssertion">
        /// `private_key_jwt` client assertion settings.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectConnectorUpdateDataTypeOauth(
            string? serverUrl,
            global::Vercel.ConnectConnectorUpdateDataTypeOauthServerConfig? serverConfig,
            string? clientId,
            string? clientName,
            string? clientSecret,
            string? tokenEndpointAuthMethod,
            string? responseType,
            bool? pkceRequired,
            string? codeChallengeMethod,
            global::Vercel.ConnectConnectorUpdateDataTypeOauthUserAuthorization? userAuthorization,
            global::Vercel.ConnectConnectorUpdateDataTypeOauthRefreshTokens? refreshTokens,
            global::Vercel.ConnectConnectorUpdateDataTypeOauthClientCredentials? clientCredentials,
            global::Vercel.ConnectConnectorUpdateDataTypeOauthForwardedClaims? forwardedClaims,
            string? defaultAudience,
            double? defaultTokenExpiresIn,
            global::System.Collections.Generic.Dictionary<string, string>? authorizationUrlParams,
            global::Vercel.ConnectConnectorUpdateDataTypeOauthJwtBearer? jwtBearer,
            global::Vercel.ConnectConnectorUpdateDataTypeOauthClientAssertion? clientAssertion)
        {
            this.ServerUrl = serverUrl;
            this.ServerConfig = serverConfig;
            this.ClientId = clientId;
            this.ClientName = clientName;
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
            this.DefaultTokenExpiresIn = defaultTokenExpiresIn;
            this.AuthorizationUrlParams = authorizationUrlParams;
            this.JwtBearer = jwtBearer;
            this.ClientAssertion = clientAssertion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorUpdateDataTypeOauth" /> class.
        /// </summary>
        public ConnectConnectorUpdateDataTypeOauth()
        {
        }

    }
}