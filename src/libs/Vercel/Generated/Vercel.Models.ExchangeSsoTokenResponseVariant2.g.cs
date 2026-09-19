
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ExchangeSsoTokenResponseVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccessToken { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_in")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ExpiresIn { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IdToken { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refresh_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RefreshToken { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TokenType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeSsoTokenResponseVariant2" /> class.
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="expiresIn"></param>
        /// <param name="idToken"></param>
        /// <param name="refreshToken"></param>
        /// <param name="tokenType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExchangeSsoTokenResponseVariant2(
            string accessToken,
            double expiresIn,
            string idToken,
            string refreshToken,
            string tokenType)
        {
            this.AccessToken = accessToken ?? throw new global::System.ArgumentNullException(nameof(accessToken));
            this.ExpiresIn = expiresIn;
            this.IdToken = idToken ?? throw new global::System.ArgumentNullException(nameof(idToken));
            this.RefreshToken = refreshToken ?? throw new global::System.ArgumentNullException(nameof(refreshToken));
            this.TokenType = tokenType ?? throw new global::System.ArgumentNullException(nameof(tokenType));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeSsoTokenResponseVariant2" /> class.
        /// </summary>
        public ExchangeSsoTokenResponseVariant2()
        {
        }

    }
}