
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateFlagResponseEnvironmentsRuleConditionRhsVariant3Type
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
    public static class CreateFlagResponseEnvironmentsRuleConditionRhsVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateFlagResponseEnvironmentsRuleConditionRhsVariant3Type value)
        {
            return value switch
            {
                CreateFlagResponseEnvironmentsRuleConditionRhsVariant3Type.List => "list",
                CreateFlagResponseEnvironmentsRuleConditionRhsVariant3Type.ListInline => "list/inline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFlagResponseEnvironmentsRuleConditionRhsVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "list" => CreateFlagResponseEnvironmentsRuleConditionRhsVariant3Type.List,
                "list/inline" => CreateFlagResponseEnvironmentsRuleConditionRhsVariant3Type.ListInline,
                _ => null,
            };
        }
    }
}