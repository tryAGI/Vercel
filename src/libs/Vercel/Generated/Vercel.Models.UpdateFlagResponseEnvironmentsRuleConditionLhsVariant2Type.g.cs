
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFlagResponseEnvironmentsRuleConditionLhsVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Entity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateFlagResponseEnvironmentsRuleConditionLhsVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFlagResponseEnvironmentsRuleConditionLhsVariant2Type value)
        {
            return value switch
            {
                UpdateFlagResponseEnvironmentsRuleConditionLhsVariant2Type.Entity => "entity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFlagResponseEnvironmentsRuleConditionLhsVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "entity" => UpdateFlagResponseEnvironmentsRuleConditionLhsVariant2Type.Entity,
                _ => null,
            };
        }
    }
}