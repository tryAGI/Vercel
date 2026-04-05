
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum FlagEnvironmentsRuleOutcomeVariant2BaseType
    {
        /// <summary>
        /// 
        /// </summary>
        Entity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FlagEnvironmentsRuleOutcomeVariant2BaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FlagEnvironmentsRuleOutcomeVariant2BaseType value)
        {
            return value switch
            {
                FlagEnvironmentsRuleOutcomeVariant2BaseType.Entity => "entity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FlagEnvironmentsRuleOutcomeVariant2BaseType? ToEnum(string value)
        {
            return value switch
            {
                "entity" => FlagEnvironmentsRuleOutcomeVariant2BaseType.Entity,
                _ => null,
            };
        }
    }
}