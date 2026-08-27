
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateKmsSigningKeyRequest
    {
        /// <summary>
        /// Whether the new key is activated automatically after its public key has propagated, or manually via the activate endpoint. Defaults to `automatic`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateKmsSigningKeyRequestActivationJsonConverter))]
        public global::Vercel.CreateKmsSigningKeyRequestActivation? Activation { get; set; }

        /// <summary>
        /// For automatic activation, how many hours after activation the previous signing key should stop being used. Defaults to a 1 hour grace period so already-issued tokens keep verifying.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revokePreviousAfterHours")]
        public double? RevokePreviousAfterHours { get; set; }

        /// <summary>
        /// Deprecated. The ISO date string or timestamp when the previous signing key should stop being used. Converted to a relative grace and applied at activation, not creation. Prefer revokePreviousAfterHours.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revokePreviousAt")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>))]
        public global::Vercel.OneOf<string, double?>? RevokePreviousAt { get; set; }

        /// <summary>
        /// The PEM-encoded private key to use for the issuer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("importKey")]
        public string? ImportKey { get; set; }

        /// <summary>
        /// The key id to use as the imported key's JWT/JWKS `kid`. Only allowed when `importKey` is provided. Not required to be unique; the addressable key id is the server-minted `keyId` returned in the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("importKeyId")]
        public string? ImportKeyId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKmsSigningKeyRequest" /> class.
        /// </summary>
        /// <param name="activation">
        /// Whether the new key is activated automatically after its public key has propagated, or manually via the activate endpoint. Defaults to `automatic`.
        /// </param>
        /// <param name="revokePreviousAfterHours">
        /// For automatic activation, how many hours after activation the previous signing key should stop being used. Defaults to a 1 hour grace period so already-issued tokens keep verifying.
        /// </param>
        /// <param name="revokePreviousAt">
        /// Deprecated. The ISO date string or timestamp when the previous signing key should stop being used. Converted to a relative grace and applied at activation, not creation. Prefer revokePreviousAfterHours.
        /// </param>
        /// <param name="importKey">
        /// The PEM-encoded private key to use for the issuer.
        /// </param>
        /// <param name="importKeyId">
        /// The key id to use as the imported key's JWT/JWKS `kid`. Only allowed when `importKey` is provided. Not required to be unique; the addressable key id is the server-minted `keyId` returned in the response.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateKmsSigningKeyRequest(
            global::Vercel.CreateKmsSigningKeyRequestActivation? activation,
            double? revokePreviousAfterHours,
            global::Vercel.OneOf<string, double?>? revokePreviousAt,
            string? importKey,
            string? importKeyId)
        {
            this.Activation = activation;
            this.RevokePreviousAfterHours = revokePreviousAfterHours;
            this.RevokePreviousAt = revokePreviousAt;
            this.ImportKey = importKey;
            this.ImportKeyId = importKeyId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKmsSigningKeyRequest" /> class.
        /// </summary>
        public CreateKmsSigningKeyRequest()
        {
        }

    }
}