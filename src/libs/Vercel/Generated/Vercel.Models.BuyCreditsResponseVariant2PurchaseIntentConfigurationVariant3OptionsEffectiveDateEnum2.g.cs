
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant3OptionsEffectiveDateEnum2
    {
        /// <summary>
        /// 
        /// </summary>
        EndOfSubscriptionTerm,
        /// <summary>
        /// 
        /// </summary>
        Immediate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant3OptionsEffectiveDateEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant3OptionsEffectiveDateEnum2 value)
        {
            return value switch
            {
                BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant3OptionsEffectiveDateEnum2.EndOfSubscriptionTerm => "end_of_subscription_term",
                BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant3OptionsEffectiveDateEnum2.Immediate => "immediate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant3OptionsEffectiveDateEnum2? ToEnum(string value)
        {
            return value switch
            {
                "end_of_subscription_term" => BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant3OptionsEffectiveDateEnum2.EndOfSubscriptionTerm,
                "immediate" => BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant3OptionsEffectiveDateEnum2.Immediate,
                _ => null,
            };
        }
    }
}