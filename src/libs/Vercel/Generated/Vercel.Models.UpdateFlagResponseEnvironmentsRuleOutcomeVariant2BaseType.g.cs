
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFlagResponseEnvironmentsRuleOutcomeVariant2BaseType
    {
        /// <summary>
        /// 
        /// </summary>
        Entity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateFlagResponseEnvironmentsRuleOutcomeVariant2BaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFlagResponseEnvironmentsRuleOutcomeVariant2BaseType value)
        {
            return value switch
            {
                UpdateFlagResponseEnvironmentsRuleOutcomeVariant2BaseType.Entity => "entity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFlagResponseEnvironmentsRuleOutcomeVariant2BaseType? ToEnum(string value)
        {
            return value switch
            {
                "entity" => UpdateFlagResponseEnvironmentsRuleOutcomeVariant2BaseType.Entity,
                _ => null,
            };
        }
    }
}