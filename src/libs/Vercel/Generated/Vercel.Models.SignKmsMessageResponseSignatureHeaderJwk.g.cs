
#nullable enable

namespace Vercel
{
    /// <summary>
    /// "jwk" (JSON Web Key) Header Parameter
    /// </summary>
    public sealed partial class SignKmsMessageResponseSignatureHeaderJwk
    {
        /// <summary>
        /// JWK "kty" (Key Type) Parameter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kty")]
        public string? Kty { get; set; }

        /// <summary>
        /// - EC JWK "crv" (Curve) Parameter - OKP JWK "crv" (The Subtype of Key Pair) Parameter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crv")]
        public string? Crv { get; set; }

        /// <summary>
        /// - EC JWK "x" (X Coordinate) Parameter - OKP JWK "x" (The public key) Parameter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x")]
        public string? X { get; set; }

        /// <summary>
        /// EC JWK "y" (Y Coordinate) Parameter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("y")]
        public string? Y { get; set; }

        /// <summary>
        /// RSA JWK "e" (Exponent) Parameter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("e")]
        public string? E { get; set; }

        /// <summary>
        /// RSA JWK "n" (Modulus) Parameter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n")]
        public string? N { get; set; }

        /// <summary>
        /// JWK "alg" (Algorithm) Parameter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alg")]
        public string? Alg { get; set; }

        /// <summary>
        /// AKP JWK "pub" (Public Key) Parameter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pub")]
        public string? Pub { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SignKmsMessageResponseSignatureHeaderJwk" /> class.
        /// </summary>
        /// <param name="kty">
        /// JWK "kty" (Key Type) Parameter
        /// </param>
        /// <param name="crv">
        /// - EC JWK "crv" (Curve) Parameter - OKP JWK "crv" (The Subtype of Key Pair) Parameter
        /// </param>
        /// <param name="x">
        /// - EC JWK "x" (X Coordinate) Parameter - OKP JWK "x" (The public key) Parameter
        /// </param>
        /// <param name="y">
        /// EC JWK "y" (Y Coordinate) Parameter
        /// </param>
        /// <param name="e">
        /// RSA JWK "e" (Exponent) Parameter
        /// </param>
        /// <param name="n">
        /// RSA JWK "n" (Modulus) Parameter
        /// </param>
        /// <param name="alg">
        /// JWK "alg" (Algorithm) Parameter
        /// </param>
        /// <param name="pub">
        /// AKP JWK "pub" (Public Key) Parameter
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SignKmsMessageResponseSignatureHeaderJwk(
            string? kty,
            string? crv,
            string? x,
            string? y,
            string? e,
            string? n,
            string? alg,
            string? pub)
        {
            this.Kty = kty;
            this.Crv = crv;
            this.X = x;
            this.Y = y;
            this.E = e;
            this.N = n;
            this.Alg = alg;
            this.Pub = pub;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignKmsMessageResponseSignatureHeaderJwk" /> class.
        /// </summary>
        public SignKmsMessageResponseSignatureHeaderJwk()
        {
        }

    }
}