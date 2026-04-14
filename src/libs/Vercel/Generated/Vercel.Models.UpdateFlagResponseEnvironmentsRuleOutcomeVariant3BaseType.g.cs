
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFlagResponseEnvironmentsRuleOutcomeVariant3BaseType
    {
        /// <summary>
        /// 
        /// </summary>
        Entity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateFlagResponseEnvironmentsRuleOutcomeVariant3BaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFlagResponseEnvironmentsRuleOutcomeVariant3BaseType value)
        {
            return value switch
            {
                UpdateFlagResponseEnvironmentsRuleOutcomeVariant3BaseType.Entity => "entity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFlagResponseEnvironmentsRuleOutcomeVariant3BaseType? ToEnum(string value)
        {
            return value switch
            {
                "entity" => UpdateFlagResponseEnvironmentsRuleOutcomeVariant3BaseType.Entity,
                _ => null,
            };
        }
    }
}