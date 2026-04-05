
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExchangeSsoTokenRequestVariant1
    {
        /// <summary>
        /// The sensitive code received from Vercel
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// The state received from the initialization request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        public string? State { get; set; }

        /// <summary>
        /// The integration client id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientId { get; set; }

        /// <summary>
        /// The integration client secret
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_secret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientSecret { get; set; }

        /// <summary>
        /// The integration redirect URI
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect_uri")]
        public string? RedirectUri { get; set; }

        /// <summary>
        /// The grant type, when using x-www-form-urlencoded content type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grant_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ExchangeSsoTokenRequestVariant1GrantTypeJsonConverter))]
        public global::Vercel.ExchangeSsoTokenRequestVariant1GrantType GrantType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeSsoTokenRequestVariant1" /> class.
        /// </summary>
        /// <param name="code">
        /// The sensitive code received from Vercel
        /// </param>
        /// <param name="clientId">
        /// The integration client id
        /// </param>
        /// <param name="clientSecret">
        /// The integration client secret
        /// </param>
        /// <param name="state">
        /// The state received from the initialization request
        /// </param>
        /// <param name="redirectUri">
        /// The integration redirect URI
        /// </param>
        /// <param name="grantType">
        /// The grant type, when using x-www-form-urlencoded content type
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExchangeSsoTokenRequestVariant1(
            string code,
            string clientId,
            string clientSecret,
            string? state,
            string? redirectUri,
            global::Vercel.ExchangeSsoTokenRequestVariant1GrantType grantType)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.State = state;
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.ClientSecret = clientSecret ?? throw new global::System.ArgumentNullException(nameof(clientSecret));
            this.RedirectUri = redirectUri;
            this.GrantType = grantType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeSsoTokenRequestVariant1" /> class.
        /// </summary>
        public ExchangeSsoTokenRequestVariant1()
        {
        }
    }
}