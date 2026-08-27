
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetDomainVerificationRecordResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("txtRecord")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TxtRecord { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verificationDomain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VerificationDomain { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDomainVerificationRecordResponse" /> class.
        /// </summary>
        /// <param name="txtRecord"></param>
        /// <param name="verificationDomain"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDomainVerificationRecordResponse(
            string txtRecord,
            string verificationDomain)
        {
            this.TxtRecord = txtRecord ?? throw new global::System.ArgumentNullException(nameof(txtRecord));
            this.VerificationDomain = verificationDomain ?? throw new global::System.ArgumentNullException(nameof(verificationDomain));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDomainVerificationRecordResponse" /> class.
        /// </summary>
        public GetDomainVerificationRecordResponse()
        {
        }

    }
}