
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Default Value: {}
    /// </summary>
    public sealed partial class CreateConnectorRequestDataTypeOauthServerConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issuer")]
        public string? Issuer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorization_endpoint")]
        public string? AuthorizationEndpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_endpoint")]
        public string? TokenEndpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userinfo_endpoint")]
        public string? UserinfoEndpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jwks_uri")]
        public string? JwksUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jwks")]
        public global::Vercel.CreateConnectorRequestDataTypeOauthServerConfigJwks? Jwks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revocation_endpoint")]
        public string? RevocationEndpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("introspection_endpoint")]
        public string? IntrospectionEndpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_session_endpoint")]
        public string? EndSessionEndpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("device_authorization_endpoint")]
        public string? DeviceAuthorizationEndpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("registration_endpoint")]
        public string? RegistrationEndpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_types_supported")]
        public global::System.Collections.Generic.IList<string>? ResponseTypesSupported { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_endpoint_auth_methods_supported")]
        public global::System.Collections.Generic.IList<string>? TokenEndpointAuthMethodsSupported { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_endpoint_auth_signing_alg_values_supported")]
        public global::System.Collections.Generic.IList<string>? TokenEndpointAuthSigningAlgValuesSupported { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes_supported")]
        public global::System.Collections.Generic.IList<string>? ScopesSupported { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grant_types_supported")]
        public global::System.Collections.Generic.IList<string>? GrantTypesSupported { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_modes_supported")]
        public global::System.Collections.Generic.IList<string>? ResponseModesSupported { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_types_supported")]
        public global::System.Collections.Generic.IList<string>? SubjectTypesSupported { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id_token_signing_alg_values_supported")]
        public global::System.Collections.Generic.IList<string>? IdTokenSigningAlgValuesSupported { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id_token_encryption_alg_values_supported")]
        public global::System.Collections.Generic.IList<string>? IdTokenEncryptionAlgValuesSupported { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id_token_encryption_enc_values_supported")]
        public global::System.Collections.Generic.IList<string>? IdTokenEncryptionEncValuesSupported { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("claim_types_supported")]
        public global::System.Collections.Generic.IList<string>? ClaimTypesSupported { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("claims_supported")]
        public global::System.Collections.Generic.IList<string>? ClaimsSupported { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_challenge_methods_supported")]
        public global::System.Collections.Generic.IList<string>? CodeChallengeMethodsSupported { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_values_supported")]
        public global::System.Collections.Generic.IList<string>? PromptValuesSupported { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("claims_parameter_supported")]
        public bool? ClaimsParameterSupported { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_parameter_supported")]
        public bool? RequestParameterSupported { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_uri_parameter_supported")]
        public bool? RequestUriParameterSupported { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("require_request_uri_registration")]
        public bool? RequireRequestUriRegistration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_documentation")]
        public string? ServiceDocumentation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("op_policy_uri")]
        public string? OpPolicyUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("op_tos_uri")]
        public string? OpTosUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logo_uri")]
        public string? LogoUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id_metadata_document_supported")]
        public bool? ClientIdMetadataDocumentSupported { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorization_details_types_supported")]
        public global::System.Collections.Generic.IList<string>? AuthorizationDetailsTypesSupported { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorRequestDataTypeOauthServerConfig" /> class.
        /// </summary>
        /// <param name="issuer"></param>
        /// <param name="authorizationEndpoint"></param>
        /// <param name="tokenEndpoint"></param>
        /// <param name="userinfoEndpoint"></param>
        /// <param name="jwksUri"></param>
        /// <param name="jwks"></param>
        /// <param name="revocationEndpoint"></param>
        /// <param name="introspectionEndpoint"></param>
        /// <param name="endSessionEndpoint"></param>
        /// <param name="deviceAuthorizationEndpoint"></param>
        /// <param name="registrationEndpoint"></param>
        /// <param name="responseTypesSupported"></param>
        /// <param name="tokenEndpointAuthMethodsSupported"></param>
        /// <param name="tokenEndpointAuthSigningAlgValuesSupported"></param>
        /// <param name="scopesSupported"></param>
        /// <param name="grantTypesSupported"></param>
        /// <param name="responseModesSupported"></param>
        /// <param name="subjectTypesSupported"></param>
        /// <param name="idTokenSigningAlgValuesSupported"></param>
        /// <param name="idTokenEncryptionAlgValuesSupported"></param>
        /// <param name="idTokenEncryptionEncValuesSupported"></param>
        /// <param name="claimTypesSupported"></param>
        /// <param name="claimsSupported"></param>
        /// <param name="codeChallengeMethodsSupported"></param>
        /// <param name="promptValuesSupported"></param>
        /// <param name="claimsParameterSupported"></param>
        /// <param name="requestParameterSupported"></param>
        /// <param name="requestUriParameterSupported"></param>
        /// <param name="requireRequestUriRegistration"></param>
        /// <param name="serviceDocumentation"></param>
        /// <param name="opPolicyUri"></param>
        /// <param name="opTosUri"></param>
        /// <param name="logoUri"></param>
        /// <param name="clientIdMetadataDocumentSupported"></param>
        /// <param name="authorizationDetailsTypesSupported"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConnectorRequestDataTypeOauthServerConfig(
            string? issuer,
            string? authorizationEndpoint,
            string? tokenEndpoint,
            string? userinfoEndpoint,
            string? jwksUri,
            global::Vercel.CreateConnectorRequestDataTypeOauthServerConfigJwks? jwks,
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
        /// Initializes a new instance of the <see cref="CreateConnectorRequestDataTypeOauthServerConfig" /> class.
        /// </summary>
        public CreateConnectorRequestDataTypeOauthServerConfig()
        {
        }

    }
}