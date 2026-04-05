
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant2OptionsItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Purchase,
        /// <summary>
        /// 
        /// </summary>
        Renewal,
        /// <summary>
        /// 
        /// </summary>
        Transfer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant2OptionsItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant2OptionsItemType value)
        {
            return value switch
            {
                BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant2OptionsItemType.Purchase => "purchase",
                BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant2OptionsItemType.Renewal => "renewal",
                BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant2OptionsItemType.Transfer => "transfer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant2OptionsItemType? ToEnum(string value)
        {
            return value switch
            {
                "purchase" => BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant2OptionsItemType.Purchase,
                "renewal" => BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant2OptionsItemType.Renewal,
                "transfer" => BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant2OptionsItemType.Transfer,
                _ => null,
            };
        }
    }
}