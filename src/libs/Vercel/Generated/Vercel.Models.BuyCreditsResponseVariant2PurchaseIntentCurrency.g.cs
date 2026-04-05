
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The currency for the purchase intent
    /// </summary>
    public enum BuyCreditsResponseVariant2PurchaseIntentCurrency
    {
        /// <summary>
        /// 
        /// </summary>
        Miu,
        /// <summary>
        /// 
        /// </summary>
        Usd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuyCreditsResponseVariant2PurchaseIntentCurrencyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuyCreditsResponseVariant2PurchaseIntentCurrency value)
        {
            return value switch
            {
                BuyCreditsResponseVariant2PurchaseIntentCurrency.Miu => "miu",
                BuyCreditsResponseVariant2PurchaseIntentCurrency.Usd => "usd",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuyCreditsResponseVariant2PurchaseIntentCurrency? ToEnum(string value)
        {
            return value switch
            {
                "miu" => BuyCreditsResponseVariant2PurchaseIntentCurrency.Miu,
                "usd" => BuyCreditsResponseVariant2PurchaseIntentCurrency.Usd,
                _ => null,
            };
        }
    }
}