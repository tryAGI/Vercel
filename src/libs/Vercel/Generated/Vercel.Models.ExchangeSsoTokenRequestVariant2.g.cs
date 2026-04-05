
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExchangeSsoTokenRequestVariant2
    {
        /// <summary>
        /// The refresh token received from previous token exchange
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refresh_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RefreshToken { get; set; }

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
        /// The grant type, when using x-www-form-urlencoded content type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grant_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ExchangeSsoTokenRequestVariant2GrantTypeJsonConverter))]
        public global::Vercel.ExchangeSsoTokenRequestVariant2GrantType GrantType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeSsoTokenRequestVariant2" /> class.
        /// </summary>
        /// <param name="refreshToken">
        /// The refresh token received from previous token exchange
        /// </param>
        /// <param name="clientId">
        /// The integration client id
        /// </param>
        /// <param name="clientSecret">
        /// The integration client secret
        /// </param>
        /// <param name="grantType">
        /// The grant type, when using x-www-form-urlencoded content type
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExchangeSsoTokenRequestVariant2(
            string refreshToken,
            string clientId,
            string clientSecret,
            global::Vercel.ExchangeSsoTokenRequestVariant2GrantType grantType)
        {
            this.RefreshToken = refreshToken ?? throw new global::System.ArgumentNullException(nameof(refreshToken));
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.ClientSecret = clientSecret ?? throw new global::System.ArgumentNullException(nameof(clientSecret));
            this.GrantType = grantType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeSsoTokenRequestVariant2" /> class.
        /// </summary>
        public ExchangeSsoTokenRequestVariant2()
        {
        }
    }
}