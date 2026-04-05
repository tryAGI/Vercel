
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrderResponseDomainVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purchaseType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetOrderResponseDomainVariant1PurchaseTypeJsonConverter))]
        public global::Vercel.GetOrderResponseDomainVariant1PurchaseType PurchaseType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoRenew")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AutoRenew { get; set; }

        /// <summary>
        /// The number of years the domain is being purchased for.
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetOrderResponseDomainVariant1StatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetOrderResponseDomainVariant1Status Status { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.AnyOf<global::Vercel.GetOrderResponseDomainVariant1ErrorVariant1, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant2, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant3, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant4, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant5, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant6, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant7, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant8, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant9, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant10>?, global::Vercel.GetOrderResponseDomainVariant1Error>))]
        public global::Vercel.AnyOf<global::Vercel.AnyOf<global::Vercel.GetOrderResponseDomainVariant1ErrorVariant1, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant2, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant3, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant4, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant5, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant6, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant7, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant8, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant9, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant10>?, global::Vercel.GetOrderResponseDomainVariant1Error>? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrderResponseDomainVariant1" /> class.
        /// </summary>
        /// <param name="autoRenew"></param>
        /// <param name="years">
        /// The number of years the domain is being purchased for.
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
        public GetOrderResponseDomainVariant1(
            bool autoRenew,
            double years,
            string domainName,
            global::Vercel.GetOrderResponseDomainVariant1Status status,
            double price,
            global::Vercel.GetOrderResponseDomainVariant1PurchaseType purchaseType,
            global::Vercel.AnyOf<global::Vercel.AnyOf<global::Vercel.GetOrderResponseDomainVariant1ErrorVariant1, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant2, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant3, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant4, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant5, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant6, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant7, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant8, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant9, global::Vercel.GetOrderResponseDomainVariant1ErrorVariant10>?, global::Vercel.GetOrderResponseDomainVariant1Error>? error)
        {
            this.PurchaseType = purchaseType;
            this.AutoRenew = autoRenew;
            this.Years = years;
            this.DomainName = domainName ?? throw new global::System.ArgumentNullException(nameof(domainName));
            this.Status = status;
            this.Price = price;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrderResponseDomainVariant1" /> class.
        /// </summary>
        public GetOrderResponseDomainVariant1()
        {
        }
    }
}