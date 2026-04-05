
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFlagResponseEnvironmentsRuleOutcomeVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Split,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateFlagResponseEnvironmentsRuleOutcomeVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFlagResponseEnvironmentsRuleOutcomeVariant2Type value)
        {
            return value switch
            {
                UpdateFlagResponseEnvironmentsRuleOutcomeVariant2Type.Split => "split",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFlagResponseEnvironmentsRuleOutcomeVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "split" => UpdateFlagResponseEnvironmentsRuleOutcomeVariant2Type.Split,
                _ => null,
            };
        }
    }
}