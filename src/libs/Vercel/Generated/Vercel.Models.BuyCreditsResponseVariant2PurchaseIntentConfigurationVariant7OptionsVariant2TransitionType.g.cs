
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant2TransitionType
    {
        /// <summary>
        ///
        /// </summary>
        PreserveSourceCycle,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant2TransitionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant2TransitionType value)
        {
            return value switch
            {
                BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant2TransitionType.PreserveSourceCycle => "preserve_source_cycle",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant2TransitionType? ToEnum(string value)
        {
            return value switch
            {
                "preserve_source_cycle" => BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant7OptionsVariant2TransitionType.PreserveSourceCycle,
                _ => null,
            };
        }
    }
}