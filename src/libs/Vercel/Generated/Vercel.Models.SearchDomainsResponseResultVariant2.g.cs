
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SearchDomainsResponseResultVariant2
    {
        /// <summary>
        /// A valid domain name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Domain { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("available")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Available { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("years")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Years { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Price { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("renewalPrice")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RenewalPrice { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("premium")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Premium { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchDomainsResponseResultVariant2" /> class.
        /// </summary>
        /// <param name="domain">
        /// A valid domain name
        /// </param>
        /// <param name="available"></param>
        /// <param name="years"></param>
        /// <param name="price"></param>
        /// <param name="renewalPrice"></param>
        /// <param name="premium"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchDomainsResponseResultVariant2(
            string domain,
            bool available,
            double years,
            double price,
            double renewalPrice,
            bool premium)
        {
            this.Domain = domain ?? throw new global::System.ArgumentNullException(nameof(domain));
            this.Available = available;
            this.Years = years;
            this.Price = price;
            this.RenewalPrice = renewalPrice;
            this.Premium = premium;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchDomainsResponseResultVariant2" /> class.
        /// </summary>
        public SearchDomainsResponseResultVariant2()
        {
        }

    }
}