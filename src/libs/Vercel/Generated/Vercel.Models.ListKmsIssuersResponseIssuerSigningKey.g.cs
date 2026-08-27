
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListKmsIssuersResponseIssuerSigningKey
    {
        /// <summary>
        /// The server-minted, unique record identifier. Use this to address the key on the activate / certificate endpoints.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KeyId { get; set; }

        /// <summary>
        /// The caller-supplied key id (imported keys only), used as the JWT/JWKS `kid`. Not unique across an issuer's keys; omitted for generated keys.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("importKeyId")]
        public string? ImportKeyId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issuerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IssuerId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("algorithm")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Algorithm { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ListKmsIssuersResponseIssuerSigningKeyStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.ListKmsIssuersResponseIssuerSigningKeyStatus Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publicKey")]
        public global::Vercel.ListKmsIssuersResponseIssuerSigningKeyPublicKey? PublicKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publicKeyFingerprint")]
        public string? PublicKeyFingerprint { get; set; }

        /// <summary>
        /// The public key in SPKI PEM form, ready to render. Present whenever the key has public key material. Derived from `publicKey`; the embedded certificate members (`x5c`/`x5t#S256`) do not affect it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publicKeyPem")]
        public string? PublicKeyPem { get; set; }

        /// <summary>
        /// The stored X.509 certificate (from `publicKey.x5c[0]`) in PEM form, ready to render. Present only for keys created with a stored certificate; omitted for keys created before certificates were stored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("certificatePem")]
        public string? CertificatePem { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revokeAt")]
        public string? RevokeAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activateAt")]
        public string? ActivateAt { get; set; }

        /// <summary>
        /// When the key became the active signer. Present for active and revoking keys (and absent for pending keys and rows predating this field).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activatedAt")]
        public string? ActivatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListKmsIssuersResponseIssuerSigningKey" /> class.
        /// </summary>
        /// <param name="keyId">
        /// The server-minted, unique record identifier. Use this to address the key on the activate / certificate endpoints.
        /// </param>
        /// <param name="issuerId"></param>
        /// <param name="algorithm"></param>
        /// <param name="status"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="importKeyId">
        /// The caller-supplied key id (imported keys only), used as the JWT/JWKS `kid`. Not unique across an issuer's keys; omitted for generated keys.
        /// </param>
        /// <param name="publicKey"></param>
        /// <param name="publicKeyFingerprint"></param>
        /// <param name="publicKeyPem">
        /// The public key in SPKI PEM form, ready to render. Present whenever the key has public key material. Derived from `publicKey`; the embedded certificate members (`x5c`/`x5t#S256`) do not affect it.
        /// </param>
        /// <param name="certificatePem">
        /// The stored X.509 certificate (from `publicKey.x5c[0]`) in PEM form, ready to render. Present only for keys created with a stored certificate; omitted for keys created before certificates were stored.
        /// </param>
        /// <param name="revokeAt"></param>
        /// <param name="activateAt"></param>
        /// <param name="activatedAt">
        /// When the key became the active signer. Present for active and revoking keys (and absent for pending keys and rows predating this field).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListKmsIssuersResponseIssuerSigningKey(
            string keyId,
            string issuerId,
            string algorithm,
            global::Vercel.ListKmsIssuersResponseIssuerSigningKeyStatus status,
            string createdAt,
            string updatedAt,
            string? importKeyId,
            global::Vercel.ListKmsIssuersResponseIssuerSigningKeyPublicKey? publicKey,
            string? publicKeyFingerprint,
            string? publicKeyPem,
            string? certificatePem,
            string? revokeAt,
            string? activateAt,
            string? activatedAt)
        {
            this.KeyId = keyId ?? throw new global::System.ArgumentNullException(nameof(keyId));
            this.ImportKeyId = importKeyId;
            this.IssuerId = issuerId ?? throw new global::System.ArgumentNullException(nameof(issuerId));
            this.Algorithm = algorithm ?? throw new global::System.ArgumentNullException(nameof(algorithm));
            this.Status = status;
            this.PublicKey = publicKey;
            this.PublicKeyFingerprint = publicKeyFingerprint;
            this.PublicKeyPem = publicKeyPem;
            this.CertificatePem = certificatePem;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.RevokeAt = revokeAt;
            this.ActivateAt = activateAt;
            this.ActivatedAt = activatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListKmsIssuersResponseIssuerSigningKey" /> class.
        /// </summary>
        public ListKmsIssuersResponseIssuerSigningKey()
        {
        }

    }
}