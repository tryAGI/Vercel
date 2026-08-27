
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateKmsIssuerRequest
    {
        /// <summary>
        /// The name of the issuer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A JSON Schema used to validate the resolved token claims when signing tokens for this issuer. Pass null to remove it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("claimsSchema")]
        public object? ClaimsSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateKmsIssuerRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the issuer.
        /// </param>
        /// <param name="claimsSchema">
        /// A JSON Schema used to validate the resolved token claims when signing tokens for this issuer. Pass null to remove it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateKmsIssuerRequest(
            string? name,
            object? claimsSchema)
        {
            this.Name = name;
            this.ClaimsSchema = claimsSchema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateKmsIssuerRequest" /> class.
        /// </summary>
        public UpdateKmsIssuerRequest()
        {
        }

    }
}