
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BuyDomainsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domains")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.BuyDomainsRequestDomain> Domains { get; set; }

        /// <summary>
        /// The contact information for the domain. Some TLDs require additional contact information. Use the [Get contact info schema](https://vercel.com/docs/rest-api/reference/endpoints/domains-registrar/get-contact-info-schema) endpoint to retrieve the required fields.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contactInformation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.BuyDomainsRequestContactInformation ContactInformation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyDomainsRequest" /> class.
        /// </summary>
        /// <param name="domains"></param>
        /// <param name="contactInformation">
        /// The contact information for the domain. Some TLDs require additional contact information. Use the [Get contact info schema](https://vercel.com/docs/rest-api/reference/endpoints/domains-registrar/get-contact-info-schema) endpoint to retrieve the required fields.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuyDomainsRequest(
            global::System.Collections.Generic.IList<global::Vercel.BuyDomainsRequestDomain> domains,
            global::Vercel.BuyDomainsRequestContactInformation contactInformation)
        {
            this.Domains = domains ?? throw new global::System.ArgumentNullException(nameof(domains));
            this.ContactInformation = contactInformation ?? throw new global::System.ArgumentNullException(nameof(contactInformation));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyDomainsRequest" /> class.
        /// </summary>
        public BuyDomainsRequest()
        {
        }
    }
}