
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BuyDomainsRequestDomain
    {
        /// <summary>
        /// A valid domain name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domainName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DomainName { get; set; }

        /// <summary>
        /// Whether the domain should be auto-renewed before it expires. This can be configured later through the Vercel Dashboard or the [Update auto-renew for a domain](https://vercel.com/docs/rest-api/reference/endpoints/domains-registrar/update-auto-renew-for-a-domain) endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoRenew")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AutoRenew { get; set; }

        /// <summary>
        /// The number of years to purchase the domain for.
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
        /// The language code for the domain. For punycode domains, this must be provided. The list of supported language codes for a TLD can be retrieved from the [Get TLD](https://vercel.com/docs/rest-api/reference/endpoints/domains-registrar/get-tld) endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languageCode")]
        public string? LanguageCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyDomainsRequestDomain" /> class.
        /// </summary>
        /// <param name="domainName">
        /// A valid domain name
        /// </param>
        /// <param name="autoRenew">
        /// Whether the domain should be auto-renewed before it expires. This can be configured later through the Vercel Dashboard or the [Update auto-renew for a domain](https://vercel.com/docs/rest-api/reference/endpoints/domains-registrar/update-auto-renew-for-a-domain) endpoint.
        /// </param>
        /// <param name="years">
        /// The number of years to purchase the domain for.
        /// </param>
        /// <param name="expectedPrice"></param>
        /// <param name="languageCode">
        /// The language code for the domain. For punycode domains, this must be provided. The list of supported language codes for a TLD can be retrieved from the [Get TLD](https://vercel.com/docs/rest-api/reference/endpoints/domains-registrar/get-tld) endpoint.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuyDomainsRequestDomain(
            string domainName,
            bool autoRenew,
            double years,
            double expectedPrice,
            string? languageCode)
        {
            this.DomainName = domainName ?? throw new global::System.ArgumentNullException(nameof(domainName));
            this.AutoRenew = autoRenew;
            this.Years = years;
            this.ExpectedPrice = expectedPrice;
            this.LanguageCode = languageCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyDomainsRequestDomain" /> class.
        /// </summary>
        public BuyDomainsRequestDomain()
        {
        }
    }
}