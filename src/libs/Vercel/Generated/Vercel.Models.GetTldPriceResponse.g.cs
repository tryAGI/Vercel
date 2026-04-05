
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTldPriceResponse
    {
        /// <summary>
        /// The number of years the returned price is for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("years")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Years { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purchasePrice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AnyOf<double?, string> PurchasePrice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("renewalPrice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AnyOf<double?, string> RenewalPrice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transferPrice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AnyOf<double?, string> TransferPrice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTldPriceResponse" /> class.
        /// </summary>
        /// <param name="years">
        /// The number of years the returned price is for.
        /// </param>
        /// <param name="purchasePrice"></param>
        /// <param name="renewalPrice"></param>
        /// <param name="transferPrice"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTldPriceResponse(
            double years,
            global::Vercel.AnyOf<double?, string> purchasePrice,
            global::Vercel.AnyOf<double?, string> renewalPrice,
            global::Vercel.AnyOf<double?, string> transferPrice)
        {
            this.Years = years;
            this.PurchasePrice = purchasePrice;
            this.RenewalPrice = renewalPrice;
            this.TransferPrice = transferPrice;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTldPriceResponse" /> class.
        /// </summary>
        public GetTldPriceResponse()
        {
        }
    }
}