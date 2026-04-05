
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TransferInDomainRequest
    {
        /// <summary>
        /// The auth code for the domain. You must obtain this code from the losing registrar.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authCode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AuthCode { get; set; }

        /// <summary>
        /// Whether the domain should be auto-renewed before it expires. This can be configured later through the Vercel Dashboard or the [Update auto-renew for a domain](https://vercel.com/docs/rest-api/reference/endpoints/domains-registrar/update-auto-renew-for-a-domain) endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoRenew")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AutoRenew { get; set; }

        /// <summary>
        /// The number of years to renew the domain for once it is transferred in. This must be a valid number of transfer years for the TLD.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("years")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Years { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expectedPrice")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ExpectedPrice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contactInformation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.TransferInDomainRequestContactInformation ContactInformation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferInDomainRequest" /> class.
        /// </summary>
        /// <param name="authCode">
        /// The auth code for the domain. You must obtain this code from the losing registrar.
        /// </param>
        /// <param name="autoRenew">
        /// Whether the domain should be auto-renewed before it expires. This can be configured later through the Vercel Dashboard or the [Update auto-renew for a domain](https://vercel.com/docs/rest-api/reference/endpoints/domains-registrar/update-auto-renew-for-a-domain) endpoint.
        /// </param>
        /// <param name="years">
        /// The number of years to renew the domain for once it is transferred in. This must be a valid number of transfer years for the TLD.
        /// </param>
        /// <param name="expectedPrice"></param>
        /// <param name="contactInformation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TransferInDomainRequest(
            string authCode,
            bool autoRenew,
            double years,
            double expectedPrice,
            global::Vercel.TransferInDomainRequestContactInformation contactInformation)
        {
            this.AuthCode = authCode ?? throw new global::System.ArgumentNullException(nameof(authCode));
            this.AutoRenew = autoRenew;
            this.Years = years;
            this.ExpectedPrice = expectedPrice;
            this.ContactInformation = contactInformation ?? throw new global::System.ArgumentNullException(nameof(contactInformation));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferInDomainRequest" /> class.
        /// </summary>
        public TransferInDomainRequest()
        {
        }
    }
}