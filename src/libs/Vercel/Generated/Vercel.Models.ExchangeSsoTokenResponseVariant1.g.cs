
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExchangeSsoTokenResponseVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IdToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_type")]
        public string? TokenType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_in")]
        public double? ExpiresIn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_token")]
        public string? AccessToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refresh_token")]
        public string? RefreshToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeSsoTokenResponseVariant1" /> class.
        /// </summary>
        /// <param name="idToken"></param>
        /// <param name="tokenType"></param>
        /// <param name="expiresIn"></param>
        /// <param name="accessToken"></param>
        /// <param name="refreshToken"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExchangeSsoTokenResponseVariant1(
            string idToken,
            string? tokenType,
            double? expiresIn,
            string? accessToken,
            string? refreshToken)
        {
            this.IdToken = idToken ?? throw new global::System.ArgumentNullException(nameof(idToken));
            this.TokenType = tokenType;
            this.ExpiresIn = expiresIn;
            this.AccessToken = accessToken;
            this.RefreshToken = refreshToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeSsoTokenResponseVariant1" /> class.
        /// </summary>
        public ExchangeSsoTokenResponseVariant1()
        {
        }
    }
}