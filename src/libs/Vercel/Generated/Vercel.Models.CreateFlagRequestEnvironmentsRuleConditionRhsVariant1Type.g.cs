
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateFlagRequestEnvironmentsRuleConditionRhsVariant1Type
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
    public static class CreateFlagRequestEnvironmentsRuleConditionRhsVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateFlagRequestEnvironmentsRuleConditionRhsVariant1Type value)
        {
            return value switch
            {
                CreateFlagRequestEnvironmentsRuleConditionRhsVariant1Type.List => "list",
                CreateFlagRequestEnvironmentsRuleConditionRhsVariant1Type.ListInline => "list/inline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFlagRequestEnvironmentsRuleConditionRhsVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "list" => CreateFlagRequestEnvironmentsRuleConditionRhsVariant1Type.List,
                "list/inline" => CreateFlagRequestEnvironmentsRuleConditionRhsVariant1Type.ListInline,
                _ => null,
            };
        }
    }
}