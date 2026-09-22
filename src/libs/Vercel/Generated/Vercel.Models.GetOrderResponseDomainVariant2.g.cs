
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetOrderResponseDomainVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purchaseType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetOrderResponseDomainVariant2PurchaseTypeJsonConverter))]
        public global::Vercel.GetOrderResponseDomainVariant2PurchaseType PurchaseType { get; set; }

        /// <summary>
        /// The number of years the domain is being renewed for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("years")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Years { get; set; }

        /// <summary>
        /// A valid domain name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domainName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DomainName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetOrderResponseDomainVariant2StatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetOrderResponseDomainVariant2Status Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Price { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared43b4aa57cd7998fdJsonConverter))]
        public global::Vercel.AutoSDKShared43b4aa57cd7998fd? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrderResponseDomainVariant2" /> class.
        /// </summary>
        /// <param name="years">
        /// The number of years the domain is being renewed for.
        /// </param>
        /// <param name="domainName">
        /// A valid domain name
        /// </param>
        /// <param name="status"></param>
        /// <param name="price"></param>
        /// <param name="purchaseType"></param>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrderResponseDomainVariant2(
            double years,
            string domainName,
            global::Vercel.GetOrderResponseDomainVariant2Status status,
            double price,
            global::Vercel.GetOrderResponseDomainVariant2PurchaseType purchaseType,
            global::Vercel.AutoSDKShared43b4aa57cd7998fd? error)
        {
            this.PurchaseType = purchaseType;
            this.Years = years;
            this.DomainName = domainName ?? throw new global::System.ArgumentNullException(nameof(domainName));
            this.Status = status;
            this.Price = price;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrderResponseDomainVariant2" /> class.
        /// </summary>
        public GetOrderResponseDomainVariant2()
        {
        }

    }
}