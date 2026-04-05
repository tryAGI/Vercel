
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum FlagEnvironmentsRuleConditionLhsVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Entity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FlagEnvironmentsRuleConditionLhsVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FlagEnvironmentsRuleConditionLhsVariant2Type value)
        {
            return value switch
            {
                FlagEnvironmentsRuleConditionLhsVariant2Type.Entity => "entity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FlagEnvironmentsRuleConditionLhsVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "entity" => FlagEnvironmentsRuleConditionLhsVariant2Type.Entity,
                _ => null,
            };
        }
    }
}