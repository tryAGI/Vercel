
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Purchase configuration specific options
    /// </summary>
    public sealed partial class BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant1Options
    {
        /// <summary>
        /// The amount of currency to buy
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Amount { get; set; }

        /// <summary>
        /// The currency being purchased
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currency")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant1OptionsCurrencyJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant1OptionsCurrency Currency { get; set; }

        /// <summary>
        /// The expiration date of the credits being purchased
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expirationDate")]
        public string? ExpirationDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant1Options" /> class.
        /// </summary>
        /// <param name="amount">
        /// The amount of currency to buy
        /// </param>
        /// <param name="currency">
        /// The currency being purchased
        /// </param>
        /// <param name="expirationDate">
        /// The expiration date of the credits being purchased
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant1Options(
            string amount,
            global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant1OptionsCurrency currency,
            string? expirationDate)
        {
            this.Amount = amount ?? throw new global::System.ArgumentNullException(nameof(amount));
            this.Currency = currency;
            this.ExpirationDate = expirationDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant1Options" /> class.
        /// </summary>
        public BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant1Options()
        {
        }
    }
}