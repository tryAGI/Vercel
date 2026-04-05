
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The created purchase intent
    /// </summary>
    public sealed partial class BuyCreditsResponseVariant2PurchaseIntent
    {
        /// <summary>
        /// The unique ID of a Purchase Intent. Uses the format `pur_*`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant1, global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant2, global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant3, global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant4, global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant5, global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant6>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant1, global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant2, global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant3, global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant4, global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant5, global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant6> Configuration { get; set; }

        /// <summary>
        /// The datetime when the Purchase Intent was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// The currency for the purchase intent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currency")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.BuyCreditsResponseVariant2PurchaseIntentCurrencyJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.BuyCreditsResponseVariant2PurchaseIntentCurrency Currency { get; set; }

        /// <summary>
        /// The ID of the owner of the Purchase Intent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.BuyCreditsResponseVariant2PurchaseIntentProvider Provider { get; set; }

        /// <summary>
        /// The status of the Purchase Intent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.BuyCreditsResponseVariant2PurchaseIntentStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.BuyCreditsResponseVariant2PurchaseIntentStatus Status { get; set; }

        /// <summary>
        /// The subtotal of the Purchase Intent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subtotal")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Subtotal { get; set; }

        /// <summary>
        /// The tax due on the Purchase Intent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tax")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Tax { get; set; }

        /// <summary>
        /// The total balance due on the Purchase Intent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Total { get; set; }

        /// <summary>
        /// The datetime when the Purchase Intent was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// The dispute details, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dispute")]
        public global::Vercel.BuyCreditsResponseVariant2PurchaseIntentDispute? Dispute { get; set; }

        /// <summary>
        /// The line items that make up the Purchase Intent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lineItems")]
        public global::System.Collections.Generic.IList<global::Vercel.BuyCreditsResponseVariant2PurchaseIntentLineItem>? LineItems { get; set; }

        /// <summary>
        /// Optional metadata associated with the purchase intent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// The amount of the purchase intent that has been refunded
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refund")]
        public string? Refund { get; set; }

        /// <summary>
        /// The URL to redirect to after the purchase is complete
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("returnUrl")]
        public string? ReturnUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant2PurchaseIntent" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of a Purchase Intent. Uses the format `pur_*`
        /// </param>
        /// <param name="configuration"></param>
        /// <param name="createdAt">
        /// The datetime when the Purchase Intent was created.
        /// </param>
        /// <param name="currency">
        /// The currency for the purchase intent
        /// </param>
        /// <param name="ownerId">
        /// The ID of the owner of the Purchase Intent.
        /// </param>
        /// <param name="provider"></param>
        /// <param name="status">
        /// The status of the Purchase Intent.
        /// </param>
        /// <param name="subtotal">
        /// The subtotal of the Purchase Intent.
        /// </param>
        /// <param name="tax">
        /// The tax due on the Purchase Intent.
        /// </param>
        /// <param name="total">
        /// The total balance due on the Purchase Intent.
        /// </param>
        /// <param name="updatedAt">
        /// The datetime when the Purchase Intent was last updated.
        /// </param>
        /// <param name="dispute">
        /// The dispute details, if any.
        /// </param>
        /// <param name="lineItems">
        /// The line items that make up the Purchase Intent.
        /// </param>
        /// <param name="metadata">
        /// Optional metadata associated with the purchase intent
        /// </param>
        /// <param name="refund">
        /// The amount of the purchase intent that has been refunded
        /// </param>
        /// <param name="returnUrl">
        /// The URL to redirect to after the purchase is complete
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuyCreditsResponseVariant2PurchaseIntent(
            string id,
            global::Vercel.OneOf<global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant1, global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant2, global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant3, global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant4, global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant5, global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant6> configuration,
            string createdAt,
            global::Vercel.BuyCreditsResponseVariant2PurchaseIntentCurrency currency,
            string ownerId,
            global::Vercel.BuyCreditsResponseVariant2PurchaseIntentProvider provider,
            global::Vercel.BuyCreditsResponseVariant2PurchaseIntentStatus status,
            string subtotal,
            string tax,
            string total,
            string updatedAt,
            global::Vercel.BuyCreditsResponseVariant2PurchaseIntentDispute? dispute,
            global::System.Collections.Generic.IList<global::Vercel.BuyCreditsResponseVariant2PurchaseIntentLineItem>? lineItems,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            string? refund,
            string? returnUrl)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Configuration = configuration;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Currency = currency;
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Status = status;
            this.Subtotal = subtotal ?? throw new global::System.ArgumentNullException(nameof(subtotal));
            this.Tax = tax ?? throw new global::System.ArgumentNullException(nameof(tax));
            this.Total = total ?? throw new global::System.ArgumentNullException(nameof(total));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.Dispute = dispute;
            this.LineItems = lineItems;
            this.Metadata = metadata;
            this.Refund = refund;
            this.ReturnUrl = returnUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant2PurchaseIntent" /> class.
        /// </summary>
        public BuyCreditsResponseVariant2PurchaseIntent()
        {
        }
    }
}