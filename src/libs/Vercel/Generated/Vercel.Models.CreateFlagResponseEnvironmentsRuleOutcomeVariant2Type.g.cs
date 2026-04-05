
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateFlagResponseEnvironmentsRuleOutcomeVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Split,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateFlagResponseEnvironmentsRuleOutcomeVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateFlagResponseEnvironmentsRuleOutcomeVariant2Type value)
        {
            return value switch
            {
                CreateFlagResponseEnvironmentsRuleOutcomeVariant2Type.Split => "split",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFlagResponseEnvironmentsRuleOutcomeVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "split" => CreateFlagResponseEnvironmentsRuleOutcomeVariant2Type.Split,
                _ => null,
            };
        }
    }
}