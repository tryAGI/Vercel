
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RotateInstallationCredentialResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Scope { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_in")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ExpiresIn { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccessToken { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.RotateInstallationCredentialResponseTokenTypeJsonConverter))]
        public global::Vercel.RotateInstallationCredentialResponseTokenType TokenType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RotateInstallationCredentialResponse" /> class.
        /// </summary>
        /// <param name="scope"></param>
        /// <param name="expiresIn"></param>
        /// <param name="accessToken"></param>
        /// <param name="tokenType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RotateInstallationCredentialResponse(
            string scope,
            double expiresIn,
            string accessToken,
            global::Vercel.RotateInstallationCredentialResponseTokenType tokenType)
        {
            this.Scope = scope ?? throw new global::System.ArgumentNullException(nameof(scope));
            this.ExpiresIn = expiresIn;
            this.AccessToken = accessToken ?? throw new global::System.ArgumentNullException(nameof(accessToken));
            this.TokenType = tokenType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RotateInstallationCredentialResponse" /> class.
        /// </summary>
        public RotateInstallationCredentialResponse()
        {
        }

    }
}