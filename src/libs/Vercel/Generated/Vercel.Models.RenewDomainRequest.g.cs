
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RenewDomainRequest
    {
        /// <summary>
        /// The number of years to renew the domain for.
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
        public global::Vercel.RenewDomainRequestContactInformation? ContactInformation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RenewDomainRequest" /> class.
        /// </summary>
        /// <param name="years">
        /// The number of years to renew the domain for.
        /// </param>
        /// <param name="expectedPrice"></param>
        /// <param name="contactInformation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RenewDomainRequest(
            double years,
            double expectedPrice,
            global::Vercel.RenewDomainRequestContactInformation? contactInformation)
        {
            this.Years = years;
            this.ExpectedPrice = expectedPrice;
            this.ContactInformation = contactInformation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RenewDomainRequest" /> class.
        /// </summary>
        public RenewDomainRequest()
        {
        }
    }
}