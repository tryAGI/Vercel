
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant1TransitionType
    {
        /// <summary>
        ///
        /// </summary>
        RestartCycle,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant1TransitionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant1TransitionType value)
        {
            return value switch
            {
                BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant1TransitionType.RestartCycle => "restart_cycle",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant1TransitionType? ToEnum(string value)
        {
            return value switch
            {
                "restart_cycle" => BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant1TransitionType.RestartCycle,
                _ => null,
            };
        }
    }
}