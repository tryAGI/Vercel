
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SignKmsTokenResponse
    {
        /// <summary>
        /// Algorithm of the signing key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("algorithm")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Algorithm { get; set; }

        /// <summary>
        /// SHA-256 fingerprint of the signing key's public key (`SHA256:&lt;base64&gt;`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fingerprint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Fingerprint { get; set; }

        /// <summary>
        /// Key id of the signing key. Matches the JWKS `kid` so verifiers can select the key after rotation without trial-verifying every published key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KeyId { get; set; }

        /// <summary>
        /// Compact JWT signed by the issuer's active signing key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SignKmsTokenResponse" /> class.
        /// </summary>
        /// <param name="algorithm">
        /// Algorithm of the signing key.
        /// </param>
        /// <param name="fingerprint">
        /// SHA-256 fingerprint of the signing key's public key (`SHA256:&lt;base64&gt;`).
        /// </param>
        /// <param name="keyId">
        /// Key id of the signing key. Matches the JWKS `kid` so verifiers can select the key after rotation without trial-verifying every published key.
        /// </param>
        /// <param name="token">
        /// Compact JWT signed by the issuer's active signing key.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SignKmsTokenResponse(
            string algorithm,
            string fingerprint,
            string keyId,
            string token)
        {
            this.Algorithm = algorithm ?? throw new global::System.ArgumentNullException(nameof(algorithm));
            this.Fingerprint = fingerprint ?? throw new global::System.ArgumentNullException(nameof(fingerprint));
            this.KeyId = keyId ?? throw new global::System.ArgumentNullException(nameof(keyId));
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignKmsTokenResponse" /> class.
        /// </summary>
        public SignKmsTokenResponse()
        {
        }

    }
}