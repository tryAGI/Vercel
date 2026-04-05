
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum SegmentDataRuleConditionLhsVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Entity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SegmentDataRuleConditionLhsVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SegmentDataRuleConditionLhsVariant2Type value)
        {
            return value switch
            {
                SegmentDataRuleConditionLhsVariant2Type.Entity => "entity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SegmentDataRuleConditionLhsVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "entity" => SegmentDataRuleConditionLhsVariant2Type.Entity,
                _ => null,
            };
        }
    }
}