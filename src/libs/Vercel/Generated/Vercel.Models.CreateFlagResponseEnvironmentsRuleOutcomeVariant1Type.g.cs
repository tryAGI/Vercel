
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateFlagResponseEnvironmentsRuleOutcomeVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Variant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateFlagResponseEnvironmentsRuleOutcomeVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateFlagResponseEnvironmentsRuleOutcomeVariant1Type value)
        {
            return value switch
            {
                CreateFlagResponseEnvironmentsRuleOutcomeVariant1Type.Variant => "variant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFlagResponseEnvironmentsRuleOutcomeVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "variant" => CreateFlagResponseEnvironmentsRuleOutcomeVariant1Type.Variant,
                _ => null,
            };
        }
    }
}