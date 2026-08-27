
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SignKmsMessageResponse
    {
        /// <summary>
        /// Flattened JWS JSON Serialization Syntax token. Payload is returned as an empty string when JWS Unencoded Payload ({@link https://www.rfc-editor.org/rfc/rfc7797 RFC7797}) is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signature")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.SignKmsMessageResponseSignature Signature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SignKmsMessageResponse" /> class.
        /// </summary>
        /// <param name="signature">
        /// Flattened JWS JSON Serialization Syntax token. Payload is returned as an empty string when JWS Unencoded Payload ({@link https://www.rfc-editor.org/rfc/rfc7797 RFC7797}) is used.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SignKmsMessageResponse(
            global::Vercel.SignKmsMessageResponseSignature signature)
        {
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