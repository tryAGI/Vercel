
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFlagResponseEnvironmentsRuleOutcomeVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Variant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateFlagResponseEnvironmentsRuleOutcomeVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFlagResponseEnvironmentsRuleOutcomeVariant1Type value)
        {
            return value switch
            {
                UpdateFlagResponseEnvironmentsRuleOutcomeVariant1Type.Variant => "variant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFlagResponseEnvironmentsRuleOutcomeVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "variant" => UpdateFlagResponseEnvironmentsRuleOutcomeVariant1Type.Variant,
                _ => null,
            };
        }
    }
}