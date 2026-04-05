
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant5Options
    {
        /// <summary>
        /// The external plan ID of the Orb plan to subscribe to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalPlanId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExternalPlanId { get; set; }

        /// <summary>
        /// The prices to add to the subscription
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("addPrices")]
        public global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant5OptionsAddPriceVariant1, object>>? AddPrices { get; set; }

        /// <summary>
        /// Whether to align the subscription start date with the billing subscription start date
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alignBillingWithSubscriptionStartDate")]
        public bool? AlignBillingWithSubscriptionStartDate { get; set; }

        /// <summary>
        /// The coupon redemption code to apply to the subscription
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("couponRedemptionCode")]
        public string? CouponRedemptionCode { get; set; }

        /// <summary>
        /// The initial phase order to use for the subscription
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initialPhaseOrder")]
        public double? InitialPhaseOrder { get; set; }

        /// <summary>
        /// Optional metadata to associate with the subscription
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string?>? Metadata { get; set; }

        /// <summary>
        /// The prices to remove in the subscription
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removePrices")]
        public global::System.Collections.Generic.IList<global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant5OptionsRemovePrice>? RemovePrices { get; set; }

        /// <summary>
        /// The prices to replace in the subscription
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replacePrices")]
        public global::System.Collections.Generic.IList<global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant5OptionsReplacePrice>? ReplacePrices { get; set; }

        /// <summary>
        /// The start date of the subscription
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startDate")]
        public string? StartDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant5Options" /> class.
        /// </summary>
        /// <param name="externalPlanId">
        /// The external plan ID of the Orb plan to subscribe to
        /// </param>
        /// <param name="addPrices">
        /// The prices to add to the subscription
        /// </param>
        /// <param name="alignBillingWithSubscriptionStartDate">
        /// Whether to align the subscription start date with the billing subscription start date
        /// </param>
        /// <param name="couponRedemptionCode">
        /// The coupon redemption code to apply to the subscription
        /// </param>
        /// <param name="initialPhaseOrder">
        /// The initial phase order to use for the subscription
        /// </param>
        /// <param name="metadata">
        /// Optional metadata to associate with the subscription
        /// </param>
        /// <param name="removePrices">
        /// The prices to remove in the subscription
        /// </param>
        /// <param name="replacePrices">
        /// The prices to replace in the subscription
        /// </param>
        /// <param name="startDate">
        /// The start date of the subscription
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant5Options(
            string externalPlanId,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant5OptionsAddPriceVariant1, object>>? addPrices,
            bool? alignBillingWithSubscriptionStartDate,
            string? couponRedemptionCode,
            double? initialPhaseOrder,
            global::System.Collections.Generic.Dictionary<string, string?>? metadata,
            global::System.Collections.Generic.IList<global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant5OptionsRemovePrice>? removePrices,
            global::System.Collections.Generic.IList<global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant5OptionsReplacePrice>? replacePrices,
            string? startDate)
        {
            this.ExternalPlanId = externalPlanId ?? throw new global::System.ArgumentNullException(nameof(externalPlanId));
            this.AddPrices = addPrices;
            this.AlignBillingWithSubscriptionStartDate = alignBillingWithSubscriptionStartDate;
            this.CouponRedemptionCode = couponRedemptionCode;
            this.InitialPhaseOrder = initialPhaseOrder;
            this.Metadata = metadata;
            this.RemovePrices = removePrices;
            this.ReplacePrices = replacePrices;
            this.StartDate = startDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant5Options" /> class.
        /// </summary>
        public BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant5Options()
        {
        }
    }
}