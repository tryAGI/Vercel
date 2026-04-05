
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum FlagEnvironmentsRuleConditionRhsVariant3Type
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
    public static class FlagEnvironmentsRuleConditionRhsVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FlagEnvironmentsRuleConditionRhsVariant3Type value)
        {
            return value switch
            {
                FlagEnvironmentsRuleConditionRhsVariant3Type.List => "list",
                FlagEnvironmentsRuleConditionRhsVariant3Type.ListInline => "list/inline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FlagEnvironmentsRuleConditionRhsVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "list" => FlagEnvironmentsRuleConditionRhsVariant3Type.List,
                "list/inline" => FlagEnvironmentsRuleConditionRhsVariant3Type.ListInline,
                _ => null,
            };
        }
    }
}