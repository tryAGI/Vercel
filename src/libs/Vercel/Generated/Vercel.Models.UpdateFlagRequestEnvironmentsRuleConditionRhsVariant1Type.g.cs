
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFlagRequestEnvironmentsRuleConditionRhsVariant1Type
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
    public static class UpdateFlagRequestEnvironmentsRuleConditionRhsVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFlagRequestEnvironmentsRuleConditionRhsVariant1Type value)
        {
            return value switch
            {
                UpdateFlagRequestEnvironmentsRuleConditionRhsVariant1Type.List => "list",
                UpdateFlagRequestEnvironmentsRuleConditionRhsVariant1Type.ListInline => "list/inline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFlagRequestEnvironmentsRuleConditionRhsVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "list" => UpdateFlagRequestEnvironmentsRuleConditionRhsVariant1Type.List,
                "list/inline" => UpdateFlagRequestEnvironmentsRuleConditionRhsVariant1Type.ListInline,
                _ => null,
            };
        }
    }
}