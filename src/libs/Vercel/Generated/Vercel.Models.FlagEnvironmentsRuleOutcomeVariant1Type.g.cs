
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum FlagEnvironmentsRuleOutcomeVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Variant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FlagEnvironmentsRuleOutcomeVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FlagEnvironmentsRuleOutcomeVariant1Type value)
        {
            return value switch
            {
                FlagEnvironmentsRuleOutcomeVariant1Type.Variant => "variant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FlagEnvironmentsRuleOutcomeVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "variant" => FlagEnvironmentsRuleOutcomeVariant1Type.Variant,
                _ => null,
            };
        }
    }
}