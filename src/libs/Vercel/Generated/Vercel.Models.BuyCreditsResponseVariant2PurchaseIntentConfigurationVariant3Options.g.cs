
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant3Options
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effectiveDate")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<object, global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant3OptionsEffectiveDateEnum2?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<object, global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant3OptionsEffectiveDateEnum2?> EffectiveDate { get; set; }

        /// <summary>
        /// The ID of the Orb subscription to change
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orbSubscriptionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrbSubscriptionId { get; set; }

        /// <summary>
        /// Whether or not to reset the billing cycle
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alignBillingWithPlanChangeDate")]
        public bool? AlignBillingWithPlanChangeDate { get; set; }

        /// <summary>
        /// The coupon redemption code to apply to the plan change
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("couponRedemptionCode")]
        public string? CouponRedemptionCode { get; set; }

        /// <summary>
        /// The ID of the external plan to change to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalPlanId")]
        public string? ExternalPlanId { get; set; }

        /// <summary>
        /// The prices to replace in the subscription
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replacePrices")]
        public global::System.Collections.Generic.IList<global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant3OptionsReplacePrice>? ReplacePrices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant3Options" /> class.
        /// </summary>
        /// <param name="effectiveDate"></param>
        /// <param name="orbSubscriptionId">
        /// The ID of the Orb subscription to change
        /// </param>
        /// <param name="alignBillingWithPlanChangeDate">
        /// Whether or not to reset the billing cycle
        /// </param>
        /// <param name="couponRedemptionCode">
        /// The coupon redemption code to apply to the plan change
        /// </param>
        /// <param name="externalPlanId">
        /// The ID of the external plan to change to
        /// </param>
        /// <param name="replacePrices">
        /// The prices to replace in the subscription
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant3Options(
            global::Vercel.OneOf<object, global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant3OptionsEffectiveDateEnum2?> effectiveDate,
            string orbSubscriptionId,
            bool? alignBillingWithPlanChangeDate,
            string? couponRedemptionCode,
            string? externalPlanId,
            global::System.Collections.Generic.IList<global::Vercel.BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant3OptionsReplacePrice>? replacePrices)
        {
            this.EffectiveDate = effectiveDate;
            this.OrbSubscriptionId = orbSubscriptionId ?? throw new global::System.ArgumentNullException(nameof(orbSubscriptionId));
            this.AlignBillingWithPlanChangeDate = alignBillingWithPlanChangeDate;
            this.CouponRedemptionCode = couponRedemptionCode;
            this.ExternalPlanId = externalPlanId;
            this.ReplacePrices = replacePrices;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant3Options" /> class.
        /// </summary>
        public BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant3Options()
        {
        }
    }
}