
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The "header" member MUST be present and contain the value JWS Unprotected Header when the JWS Unprotected Header value is non- empty; otherwise, it MUST be absent. This value is represented as an unencoded JSON object, rather than as a string. These Header Parameter values are not integrity protected.
    /// </summary>
    public sealed partial class SignKmsMessageResponseSignatureHeader
    {
        /// <summary>
        /// JWS "alg" (Algorithm) Header Parameter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alg")]
        public string? Alg { get; set; }

        /// <summary>
        /// This JWS Extension Header Parameter modifies the JWS Payload representation and the JWS Signing Input computation as per {@link https://www.rfc-editor.org/rfc/rfc7797 RFC7797}.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("b64")]
        public bool? B64 { get; set; }

        /// <summary>
        /// JWS "crit" (Critical) Header Parameter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crit")]
        public global::System.Collections.Generic.IList<string>? Crit { get; set; }

        /// <summary>
        /// "kid" (Key ID) Header Parameter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kid")]
        public string? Kid { get; set; }

        /// <summary>
        /// "x5t" (X.509 Certificate SHA-1 Thumbprint) Header Parameter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x5t")]
        public string? X5t { get; set; }

        /// <summary>
        /// "x5c" (X.509 Certificate Chain) Header Parameter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x5c")]
        public global::System.Collections.Generic.IList<string>? X5c { get; set; }

        /// <summary>
        /// "x5u" (X.509 URL) Header Parameter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x5u")]
        public string? X5u { get; set; }

        /// <summary>
        /// "jku" (JWK Set URL) Header Parameter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jku")]
        public string? Jku { get; set; }

        /// <summary>
        /// "jwk" (JSON Web Key) Header Parameter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jwk")]
        public global::Vercel.SignKmsMessageResponseSignatureHeaderJwk? Jwk { get; set; }

        /// <summary>
        /// "typ" (Type) Header Parameter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("typ")]
        public string? Typ { get; set; }

        /// <summary>
        /// "cty" (Content Type) Header Parameter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cty")]
        public string? Cty { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SignKmsMessageResponseSignatureHeader" /> class.
        /// </summary>
        /// <param name="alg">
        /// JWS "alg" (Algorithm) Header Parameter
        /// </param>
        /// <param name="b64">
        /// This JWS Extension Header Parameter modifies the JWS Payload representation and the JWS Signing Input computation as per {@link https://www.rfc-editor.org/rfc/rfc7797 RFC7797}.
        /// </param>
        /// <param name="crit">
        /// JWS "crit" (Critical) Header Parameter
        /// </param>
        /// <param name="kid">
        /// "kid" (Key ID) Header Parameter
        /// </param>
        /// <param name="x5t">
        /// "x5t" (X.509 Certificate SHA-1 Thumbprint) Header Parameter
        /// </param>
        /// <param name="x5c">
        /// "x5c" (X.509 Certificate Chain) Header Parameter
        /// </param>
        /// <param name="x5u">
        /// "x5u" (X.509 URL) Header Parameter
        /// </param>
        /// <param name="jku">
        /// "jku" (JWK Set URL) Header Parameter
        /// </param>
        /// <param name="jwk">
        /// "jwk" (JSON Web Key) Header Parameter
        /// </param>
        /// <param name="typ">
        /// "typ" (Type) Header Parameter
        /// </param>
        /// <param name="cty">
        /// "cty" (Content Type) Header Parameter
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SignKmsMessageResponseSignatureHeader(
            string? alg,
            bool? b64,
            global::System.Collections.Generic.IList<string>? crit,
            string? kid,
            string? x5t,
            global::System.Collections.Generic.IList<string>? x5c,
            string? x5u,
            string? jku,
            global::Vercel.SignKmsMessageResponseSignatureHeaderJwk? jwk,
            string? typ,
            string? cty)
        {
            this.Alg = alg;
            this.B64 = b64;
            this.Crit = crit;
            this.Kid = kid;
            this.X5t = x5t;
            this.X5c = x5c;
            this.X5u = x5u;
            this.Jku = jku;
            this.Jwk = jwk;
            this.Typ = typ;
            this.Cty = cty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignKmsMessageResponseSignatureHeader" /> class.
        /// </summary>
        public SignKmsMessageResponseSignatureHeader()
        {
        }

    }
}