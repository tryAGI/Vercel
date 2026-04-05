
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFlagResponseEnvironmentsRuleConditionRhsVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        List,
        /// <summary>
        /// 
        /// </summary>
        ListInline,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateFlagResponseEnvironmentsRuleConditionRhsVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFlagResponseEnvironmentsRuleConditionRhsVariant3Type value)
        {
            return value switch
            {
                UpdateFlagResponseEnvironmentsRuleConditionRhsVariant3Type.List => "list",
                UpdateFlagResponseEnvironmentsRuleConditionRhsVariant3Type.ListInline => "list/inline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFlagResponseEnvironmentsRuleConditionRhsVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "list" => UpdateFlagResponseEnvironmentsRuleConditionRhsVariant3Type.List,
                "list/inline" => UpdateFlagResponseEnvironmentsRuleConditionRhsVariant3Type.ListInline,
                _ => null,
            };
        }
    }
}