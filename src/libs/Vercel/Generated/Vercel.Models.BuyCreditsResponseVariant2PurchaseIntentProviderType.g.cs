
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of the purchase provider
    /// </summary>
    public enum BuyCreditsResponseVariant2PurchaseIntentProviderType
    {
        /// <summary>
        /// 
        /// </summary>
        AppleInAppPurchase,
        /// <summary>
        /// 
        /// </summary>
        OrbLedger,
        /// <summary>
        /// 
        /// </summary>
        StripeElements,
        /// <summary>
        /// 
        /// </summary>
        StripeHosted,
        /// <summary>
        /// 
        /// </summary>
        StripeInvoiceDeferred,
        /// <summary>
        /// 
        /// </summary>
        StripeInvoiceElements,
        /// <summary>
        /// 
        /// </summary>
        StripeInvoiceImmediate,
        /// <summary>
        /// 
        /// </summary>
        TackleAwsMarketplace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuyCreditsResponseVariant2PurchaseIntentProviderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuyCreditsResponseVariant2PurchaseIntentProviderType value)
        {
            return value switch
            {
                BuyCreditsResponseVariant2PurchaseIntentProviderType.AppleInAppPurchase => "apple_in_app_purchase",
                BuyCreditsResponseVariant2PurchaseIntentProviderType.OrbLedger => "orb_ledger",
                BuyCreditsResponseVariant2PurchaseIntentProviderType.StripeElements => "stripe_elements",
                BuyCreditsResponseVariant2PurchaseIntentProviderType.StripeHosted => "stripe_hosted",
                BuyCreditsResponseVariant2PurchaseIntentProviderType.StripeInvoiceDeferred => "stripe_invoice_deferred",
                BuyCreditsResponseVariant2PurchaseIntentProviderType.StripeInvoiceElements => "stripe_invoice_elements",
                BuyCreditsResponseVariant2PurchaseIntentProviderType.StripeInvoiceImmediate => "stripe_invoice_immediate",
                BuyCreditsResponseVariant2PurchaseIntentProviderType.TackleAwsMarketplace => "tackle_aws_marketplace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuyCreditsResponseVariant2PurchaseIntentProviderType? ToEnum(string value)
        {
            return value switch
            {
                "apple_in_app_purchase" => BuyCreditsResponseVariant2PurchaseIntentProviderType.AppleInAppPurchase,
                "orb_ledger" => BuyCreditsResponseVariant2PurchaseIntentProviderType.OrbLedger,
                "stripe_elements" => BuyCreditsResponseVariant2PurchaseIntentProviderType.StripeElements,
                "stripe_hosted" => BuyCreditsResponseVariant2PurchaseIntentProviderType.StripeHosted,
                "stripe_invoice_deferred" => BuyCreditsResponseVariant2PurchaseIntentProviderType.StripeInvoiceDeferred,
                "stripe_invoice_elements" => BuyCreditsResponseVariant2PurchaseIntentProviderType.StripeInvoiceElements,
                "stripe_invoice_immediate" => BuyCreditsResponseVariant2PurchaseIntentProviderType.StripeInvoiceImmediate,
                "tackle_aws_marketplace" => BuyCreditsResponseVariant2PurchaseIntentProviderType.TackleAwsMarketplace,
                _ => null,
            };
        }
    }
}