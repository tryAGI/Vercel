
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum SegmentDataRuleConditionRhsVariant3Type
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
    public static class SegmentDataRuleConditionRhsVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SegmentDataRuleConditionRhsVariant3Type value)
        {
            return value switch
            {
                SegmentDataRuleConditionRhsVariant3Type.List => "list",
                SegmentDataRuleConditionRhsVariant3Type.ListInline => "list/inline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SegmentDataRuleConditionRhsVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "list" => SegmentDataRuleConditionRhsVariant3Type.List,
                "list/inline" => SegmentDataRuleConditionRhsVariant3Type.ListInline,
                _ => null,
            };
        }
    }
}