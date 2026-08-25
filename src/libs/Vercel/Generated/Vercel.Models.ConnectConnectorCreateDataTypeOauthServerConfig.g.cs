
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Authorization server metadata. Values override discovered metadata. Empty known string fields remove their stored overrides.<br/>
    /// Default Value: {}
    /// </summary>
    public sealed partial class ConnectConnectorCreateDataTypeOauthServerConfig
    {
        /// <summary>
        /// Authorization server issuer URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issuer")]
        public string? Issuer { get; set; }

        /// <summary>
        /// OAuth authorization endpoint URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorization_endpoint")]
        public string? AuthorizationEndpoint { get; set; }

        /// <summary>
        /// OAuth token endpoint URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_endpoint")]
        public string? TokenEndpoint { get; set; }

        /// <summary>
        /// OpenID Connect UserInfo endpoint URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userinfo_endpoint")]
        public string? UserinfoEndpoint { get; set; }

        /// <summary>
        /// URL of the authorization server JSON Web Key Set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jwks_uri")]
        public string? JwksUri { get; set; }

        /// <summary>
        /// Inline authorization server JSON Web Key Set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jwks")]
        public global::Vercel.ConnectConnectorCreateDataTypeOauthServerConfigJwks? Jwks { get; set; }

        /// <summary>
        /// OAuth token revocation endpoint URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revocation_endpoint")]
        public string? RevocationEndpoint { get; set; }

        /// <summary>
        /// OAuth token introspection endpoint URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("introspection_endpoint")]
        public string? IntrospectionEndpoint { get; set; }

        /// <summary>
        /// OpenID Connect session termination endpoint URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_session_endpoint")]
        public string? EndSessionEndpoint { get; set; }

        /// <summary>
        /// OAuth device authorization endpoint URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("device_authorization_endpoint")]
        public string? DeviceAuthorizationEndpoint { get; set; }

        /// <summary>
        /// OAuth dynamic client registration endpoint URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("registration_endpoint")]
        public string? RegistrationEndpoint { get; set; }

        /// <summary>
        /// OAuth response types supported by the server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_types_supported")]
        public global::System.Collections.Generic.IList<string>? ResponseTypesSupported { get; set; }

        /// <summary>
        /// Token endpoint client authentication methods supported by the server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_endpoint_auth_methods_supported")]
        public global::System.Collections.Generic.IList<string>? TokenEndpointAuthMethodsSupported { get; set; }

        /// <summary>
        /// Signing algorithms supported for token endpoint authentication.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_endpoint_auth_signing_alg_values_supported")]
        public global::System.Collections.Generic.IList<string>? TokenEndpointAuthSigningAlgValuesSupported { get; set; }

        /// <summary>
        /// OAuth scopes supported by the server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes_supported")]
        public global::System.Collections.Generic.IList<string>? ScopesSupported { get; set; }

        /// <summary>
        /// OAuth grant types supported by the server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grant_types_supported")]
        public global::System.Collections.Generic.IList<string>? GrantTypesSupported { get; set; }

        /// <summary>
        /// OAuth response modes supported by the server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_modes_supported")]
        public global::System.Collections.Generic.IList<string>? ResponseModesSupported { get; set; }

        /// <summary>
        /// OpenID Connect subject identifier types supported by the server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_types_supported")]
        public global::System.Collections.Generic.IList<string>? SubjectTypesSupported { get; set; }

        /// <summary>
        /// Signing algorithms supported for ID tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id_token_signing_alg_values_supported")]
        public global::System.Collections.Generic.IList<string>? IdTokenSigningAlgValuesSupported { get; set; }

        /// <summary>
        /// Key management algorithms supported for encrypted ID tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id_token_encryption_alg_values_supported")]
        public global::System.Collections.Generic.IList<string>? IdTokenEncryptionAlgValuesSupported { get; set; }

        /// <summary>
        /// Content encryption algorithms supported for encrypted ID tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id_token_encryption_enc_values_supported")]
        public global::System.Collections.Generic.IList<string>? IdTokenEncryptionEncValuesSupported { get; set; }

        /// <summary>
        /// OpenID Connect claim value types supported by the server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("claim_types_supported")]
        public global::System.Collections.Generic.IList<string>? ClaimTypesSupported { get; set; }

        /// <summary>
        /// Claims that the authorization server can return.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("claims_supported")]
        public global::System.Collections.Generic.IList<string>? ClaimsSupported { get; set; }

        /// <summary>
        /// PKCE code challenge methods supported by the server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_challenge_methods_supported")]
        public global::System.Collections.Generic.IList<string>? CodeChallengeMethodsSupported { get; set; }

        /// <summary>
        /// Authorization prompt values supported by the server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_values_supported")]
        public global::System.Collections.Generic.IList<string>? PromptValuesSupported { get; set; }

        /// <summary>
        /// Whether authorization requests can use the claims parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("claims_parameter_supported")]
        public bool? ClaimsParameterSupported { get; set; }

        /// <summary>
        /// Whether authorization requests can use signed request objects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_parameter_supported")]
        public bool? RequestParameterSupported { get; set; }

        /// <summary>
        /// Whether authorization requests can use request_uri.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_uri_parameter_supported")]
        public bool? RequestUriParameterSupported { get; set; }

        /// <summary>
        /// Whether request_uri values must be registered in advance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("require_request_uri_registration")]
        public bool? RequireRequestUriRegistration { get; set; }

        /// <summary>
        /// Authorization server documentation URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_documentation")]
        public string? ServiceDocumentation { get; set; }

        /// <summary>
        /// Authorization server privacy policy URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("op_policy_uri")]
        public string? OpPolicyUri { get; set; }

        /// <summary>
        /// Authorization server terms of service URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("op_tos_uri")]
        public string? OpTosUri { get; set; }

        /// <summary>
        /// Authorization server logo URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logo_uri")]
        public string? LogoUri { get; set; }

        /// <summary>
        /// Whether the server supports OAuth client ID metadata documents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id_metadata_document_supported")]
        public bool? ClientIdMetadataDocumentSupported { get; set; }

        /// <summary>
        /// OAuth authorization-detail types supported by the server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorization_details_types_supported")]
        public global::System.Collections.Generic.IList<string>? AuthorizationDetailsTypesSupported { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorCreateDataTypeOauthServerConfig" /> class.
        /// </summary>
        /// <param name="issuer">
        /// Authorization server issuer URL.
        /// </param>
        /// <param name="authorizationEndpoint">
        /// OAuth authorization endpoint URL.
        /// </param>
        /// <param name="tokenEndpoint">
        /// OAuth token endpoint URL.
        /// </param>
        /// <param name="userinfoEndpoint">
        /// OpenID Connect UserInfo endpoint URL.
        /// </param>
        /// <param name="jwksUri">
        /// URL of the authorization server JSON Web Key Set.
        /// </param>
        /// <param name="jwks">
        /// Inline authorization server JSON Web Key Set.
        /// </param>
        /// <param name="revocationEndpoint">
        /// OAuth token revocation endpoint URL.
        /// </param>
        /// <param name="introspectionEndpoint">
        /// OAuth token introspection endpoint URL.
        /// </param>
        /// <param name="endSessionEndpoint">
        /// OpenID Connect session termination endpoint URL.
        /// </param>
        /// <param name="deviceAuthorizationEndpoint">
        /// OAuth device authorization endpoint URL.
        /// </param>
        /// <param name="registrationEndpoint">
        /// OAuth dynamic client registration endpoint URL.
        /// </param>
        /// <param name="responseTypesSupported">
        /// OAuth response types supported by the server.
        /// </param>
        /// <param name="tokenEndpointAuthMethodsSupported">
        /// Token endpoint client authentication methods supported by the server.
        /// </param>
        /// <param name="tokenEndpointAuthSigningAlgValuesSupported">
        /// Signing algorithms supported for token endpoint authentication.
        /// </param>
        /// <param name="scopesSupported">
        /// OAuth scopes supported by the server.
        /// </param>
        /// <param name="grantTypesSupported">
        /// OAuth grant types supported by the server.
        /// </param>
        /// <param name="responseModesSupported">
        /// OAuth response modes supported by the server.
        /// </param>
        /// <param name="subjectTypesSupported">
        /// OpenID Connect subject identifier types supported by the server.
        /// </param>
        /// <param name="idTokenSigningAlgValuesSupported">
        /// Signing algorithms supported for ID tokens.
        /// </param>
        /// <param name="idTokenEncryptionAlgValuesSupported">
        /// Key management algorithms supported for encrypted ID tokens.
        /// </param>
        /// <param name="idTokenEncryptionEncValuesSupported">
        /// Content encryption algorithms supported for encrypted ID tokens.
        /// </param>
        /// <param name="claimTypesSupported">
        /// OpenID Connect claim value types supported by the server.
        /// </param>
        /// <param name="claimsSupported">
        /// Claims that the authorization server can return.
        /// </param>
        /// <param name="codeChallengeMethodsSupported">
        /// PKCE code challenge methods supported by the server.
        /// </param>
        /// <param name="promptValuesSupported">
        /// Authorization prompt values supported by the server.
        /// </param>
        /// <param name="claimsParameterSupported">
        /// Whether authorization requests can use the claims parameter.
        /// </param>
        /// <param name="requestParameterSupported">
        /// Whether authorization requests can use signed request objects.
        /// </param>
        /// <param name="requestUriParameterSupported">
        /// Whether authorization requests can use request_uri.
        /// </param>
        /// <param name="requireRequestUriRegistration">
        /// Whether request_uri values must be registered in advance.
        /// </param>
        /// <param name="serviceDocumentation">
        /// Authorization server documentation URL.
        /// </param>
        /// <param name="opPolicyUri">
        /// Authorization server privacy policy URL.
        /// </param>
        /// <param name="opTosUri">
        /// Authorization server terms of service URL.
        /// </param>
        /// <param name="logoUri">
        /// Authorization server logo URL.
        /// </param>
        /// <param name="clientIdMetadataDocumentSupported">
        /// Whether the server supports OAuth client ID metadata documents.
        /// </param>
        /// <param name="authorizationDetailsTypesSupported">
        /// OAuth authorization-detail types supported by the server.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectConnectorCreateDataTypeOauthServerConfig(
            string? issuer,
            string? authorizationEndpoint,
            string? tokenEndpoint,
            string? userinfoEndpoint,
            string? jwksUri,
            global::Vercel.ConnectConnectorCreateDataTypeOauthServerConfigJwks? jwks,
            string? revocationEndpoint,
            string? introspectionEndpoint,
            string? endSessionEndpoint,
            string? deviceAuthorizationEndpoint,
            string? registrationEndpoint,
            global::System.Collections.Generic.IList<string>? responseTypesSupported,
            global::System.Collections.Generic.IList<string>? tokenEndpointAuthMethodsSupported,
            global::System.Collections.Generic.IList<string>? tokenEndpointAuthSigningAlgValuesSupported,
            global::System.Collections.Generic.IList<string>? scopesSupported,
            global::System.Collections.Generic.IList<string>? grantTypesSupported,
            global::System.Collections.Generic.IList<string>? responseModesSupported,
            global::System.Collections.Generic.IList<string>? subjectTypesSupported,
            global::System.Collections.Generic.IList<string>? idTokenSigningAlgValuesSupported,
            global::System.Collections.Generic.IList<string>? idTokenEncryptionAlgValuesSupported,
            global::System.Collections.Generic.IList<string>? idTokenEncryptionEncValuesSupported,
            global::System.Collections.Generic.IList<string>? claimTypesSupported,
            global::System.Collections.Generic.IList<string>? claimsSupported,
            global::System.Collections.Generic.IList<string>? codeChallengeMethodsSupported,
            global::System.Collections.Generic.IList<string>? promptValuesSupported,
            bool? claimsParameterSupported,
            bool? requestParameterSupported,
            bool? requestUriParameterSupported,
            bool? requireRequestUriRegistration,
            string? serviceDocumentation,
            string? opPolicyUri,
            string? opTosUri,
            string? logoUri,
            bool? clientIdMetadataDocumentSupported,
            global::System.Collections.Generic.IList<string>? authorizationDetailsTypesSupported)
        {
            this.Issuer = issuer;
            this.AuthorizationEndpoint = authorizationEndpoint;
            this.TokenEndpoint = tokenEndpoint;
            this.UserinfoEndpoint = userinfoEndpoint;
            this.JwksUri = jwksUri;
            this.Jwks = jwks;
            this.RevocationEndpoint = revocationEndpoint;
            this.IntrospectionEndpoint = introspectionEndpoint;
            this.EndSessionEndpoint = endSessionEndpoint;
            this.DeviceAuthorizationEndpoint = deviceAuthorizationEndpoint;
            this.RegistrationEndpoint = registrationEndpoint;
            this.ResponseTypesSupported = responseTypesSupported;
            this.TokenEndpointAuthMethodsSupported = tokenEndpointAuthMethodsSupported;
            this.TokenEndpointAuthSigningAlgValuesSupported = tokenEndpointAuthSigningAlgValuesSupported;
            this.ScopesSupported = scopesSupported;
            this.GrantTypesSupported = grantTypesSupported;
            this.ResponseModesSupported = responseModesSupported;
            this.SubjectTypesSupported = subjectTypesSupported;
            this.IdTokenSigningAlgValuesSupported = idTokenSigningAlgValuesSupported;
            this.IdTokenEncryptionAlgValuesSupported = idTokenEncryptionAlgValuesSupported;
            this.IdTokenEncryptionEncValuesSupported = idTokenEncryptionEncValuesSupported;
            this.ClaimTypesSupported = claimTypesSupported;
            this.ClaimsSupported = claimsSupported;
            this.CodeChallengeMethodsSupported = codeChallengeMethodsSupported;
            this.PromptValuesSupported = promptValuesSupported;
            this.ClaimsParameterSupported = claimsParameterSupported;
            this.RequestParameterSupported = requestParameterSupported;
            this.RequestUriParameterSupported = requestUriParameterSupported;
            this.RequireRequestUriRegistration = requireRequestUriRegistration;
            this.ServiceDocumentation = serviceDocumentation;
            this.OpPolicyUri = opPolicyUri;
            this.OpTosUri = opTosUri;
            this.LogoUri = logoUri;
            this.ClientIdMetadataDocumentSupported = clientIdMetadataDocumentSupported;
            this.AuthorizationDetailsTypesSupported = authorizationDetailsTypesSupported;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorCreateDataTypeOauthServerConfig" /> class.
        /// </summary>
        public ConnectConnectorCreateDataTypeOauthServerConfig()
        {
        }

    }
}