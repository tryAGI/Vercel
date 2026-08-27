
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetKmsIssuerResponseSigningKeyPublicKey
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kty")]
        public string? Kty { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kid")]
        public string? Kid { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alg")]
        public string? Alg { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use")]
        public string? Use { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_ops")]
        public global::System.Collections.Generic.IList<string>? KeyOps { get; set; }

        /// <summary>
        /// The X.509 certificate chain (RFC 7517 §4.7). Each entry is the base64 DER (not base64url) of a certificate. For keys minted with a stored certificate this holds the single self-signed cert as `[x5c]`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x5c")]
        public global::System.Collections.Generic.IList<string>? X5c { get; set; }

        /// <summary>
        /// The base64url SHA-256 thumbprint of the DER certificate in `x5c[0]` (RFC 7517 §4.9).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x5t#S256")]
        public string? X5t_S256 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetKmsIssuerResponseSigningKeyPublicKey" /> class.
        /// </summary>
        /// <param name="kty"></param>
        /// <param name="kid"></param>
        /// <param name="alg"></param>
        /// <param name="use"></param>
        /// <param name="keyOps"></param>
        /// <param name="x5c">
        /// The X.509 certificate chain (RFC 7517 §4.7). Each entry is the base64 DER (not base64url) of a certificate. For keys minted with a stored certificate this holds the single self-signed cert as `[x5c]`.
        /// </param>
        /// <param name="x5t_S256">
        /// The base64url SHA-256 thumbprint of the DER certificate in `x5c[0]` (RFC 7517 §4.9).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetKmsIssuerResponseSigningKeyPublicKey(
            string? kty,
            string? kid,
            string? alg,
            string? use,
            global::System.Collections.Generic.IList<string>? keyOps,
            global::System.Collections.Generic.IList<string>? x5c,
            string? x5t_S256)
        {
            this.Kty = kty;
            this.Kid = kid;
            this.Alg = alg;
            this.Use = use;
            this.KeyOps = keyOps;
            this.X5c = x5c;
            this.X5t_S256 = x5t_S256;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetKmsIssuerResponseSigningKeyPublicKey" /> class.
        /// </summary>
        public GetKmsIssuerResponseSigningKeyPublicKey()
        {
        }

    }
}