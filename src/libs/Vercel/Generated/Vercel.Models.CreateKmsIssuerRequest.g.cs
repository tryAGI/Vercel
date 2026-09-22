
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateKmsIssuerRequest
    {
        /// <summary>
        /// The name of the issuer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The signing algorithm to use for the issuer.<br/>
        /// Default Value: RS512
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("algorithm")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateKmsIssuerRequestAlgorithmJsonConverter))]
        public global::Vercel.CreateKmsIssuerRequestAlgorithm? Algorithm { get; set; }

        /// <summary>
        /// A JSON Schema used to validate the resolved token claims when signing tokens for this issuer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("claimsSchema")]
        public object? ClaimsSchema { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.CreateKmsIssuerRequestPolicyVariant1, global::Vercel.CreateKmsIssuerRequestPolicyVariant2>))]
        public global::Vercel.OneOf<global::Vercel.CreateKmsIssuerRequestPolicyVariant1, global::Vercel.CreateKmsIssuerRequestPolicyVariant2>? Policy { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateKmsIssuerRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the issuer.
        /// </param>
        /// <param name="algorithm">
        /// The signing algorithm to use for the issuer.<br/>
        /// Default Value: RS512
        /// </param>
        /// <param name="claimsSchema">
        /// A JSON Schema used to validate the resolved token claims when signing tokens for this issuer.
        /// </param>
        /// <param name="policy"></param>
        /// <param name="importKey">
        /// The PEM-encoded private key to use for the issuer.
        /// </param>
        /// <param name="importKeyId">
        /// The key id to use as the imported key's JWT/JWKS `kid`. Only allowed when `importKey` is provided. Not required to be unique; the addressable key id is the server-minted `keyId` returned in the response.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateKmsIssuerRequest(
            string name,
            global::Vercel.CreateKmsIssuerRequestAlgorithm? algorithm,
            object? claimsSchema,
            global::Vercel.OneOf<global::Vercel.CreateKmsIssuerRequestPolicyVariant1, global::Vercel.CreateKmsIssuerRequestPolicyVariant2>? policy,
            string? importKey,
            string? importKeyId)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Algorithm = algorithm;
            this.ClaimsSchema = claimsSchema;
            this.Policy = policy;
            this.ImportKey = importKey;
            this.ImportKeyId = importKeyId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKmsIssuerRequest" /> class.
        /// </summary>
        public CreateKmsIssuerRequest()
        {
        }

    }
}