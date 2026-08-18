
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Flattened JWS JSON Serialization Syntax token. Payload is returned as an empty string when JWS Unencoded Payload ({@link https://www.rfc-editor.org/rfc/rfc7797 RFC7797}) is used.
    /// </summary>
    public sealed partial class SignKmsMessageResponseSignature
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Payload { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signature")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Signature { get; set; }

        /// <summary>
        /// The "header" member MUST be present and contain the value JWS Unprotected Header when the JWS Unprotected Header value is non- empty; otherwise, it MUST be absent. This value is represented as an unencoded JSON object, rather than as a string. These Header Parameter values are not integrity protected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("header")]
        public global::Vercel.SignKmsMessageResponseSignatureHeader? Header { get; set; }

        /// <summary>
        /// The "protected" member MUST be present and contain the value BASE64URL(UTF8(JWS Protected Header)) when the JWS Protected Header value is non-empty; otherwise, it MUST be absent. These Header Parameter values are integrity protected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protected")]
        public string? Protected { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SignKmsMessageResponseSignature" /> class.
        /// </summary>
        /// <param name="payload"></param>
        /// <param name="signature"></param>
        /// <param name="header">
        /// The "header" member MUST be present and contain the value JWS Unprotected Header when the JWS Unprotected Header value is non- empty; otherwise, it MUST be absent. This value is represented as an unencoded JSON object, rather than as a string. These Header Parameter values are not integrity protected.
        /// </param>
        /// <param name="protected">
        /// The "protected" member MUST be present and contain the value BASE64URL(UTF8(JWS Protected Header)) when the JWS Protected Header value is non-empty; otherwise, it MUST be absent. These Header Parameter values are integrity protected.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SignKmsMessageResponseSignature(
            string payload,
            string signature,
            global::Vercel.SignKmsMessageResponseSignatureHeader? header,
            string? @protected)
        {
            this.Payload = payload ?? throw new global::System.ArgumentNullException(nameof(payload));
            this.Signature = signature ?? throw new global::System.ArgumentNullException(nameof(signature));
            this.Header = header;
            this.Protected = @protected;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignKmsMessageResponseSignature" /> class.
        /// </summary>
        public SignKmsMessageResponseSignature()
        {
        }

    }
}