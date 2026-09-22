
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SignKmsMessageResponse
    {
        /// <summary>
        /// Algorithm of the signing key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("algorithm")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Algorithm { get; set; }

        /// <summary>
        /// Key id of the signing key. Matches the JWKS `kid` so verifiers can select the key after rotation without trial-verifying every published key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KeyId { get; set; }

        /// <summary>
        /// Standard-base64 encoding of the raw signature over the decoded message bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signature")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Signature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SignKmsMessageResponse" /> class.
        /// </summary>
        /// <param name="algorithm">
        /// Algorithm of the signing key.
        /// </param>
        /// <param name="keyId">
        /// Key id of the signing key. Matches the JWKS `kid` so verifiers can select the key after rotation without trial-verifying every published key.
        /// </param>
        /// <param name="signature">
        /// Standard-base64 encoding of the raw signature over the decoded message bytes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SignKmsMessageResponse(
            string algorithm,
            string keyId,
            string signature)
        {
            this.Algorithm = algorithm ?? throw new global::System.ArgumentNullException(nameof(algorithm));
            this.KeyId = keyId ?? throw new global::System.ArgumentNullException(nameof(keyId));
            this.Signature = signature ?? throw new global::System.ArgumentNullException(nameof(signature));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignKmsMessageResponse" /> class.
        /// </summary>
        public SignKmsMessageResponse()
        {
        }

    }
}