
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum SegmentDataRuleConditionRhsVariant4Type
    {
        /// <summary>
        /// 
        /// </summary>
        Regex,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SegmentDataRuleConditionRhsVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SegmentDataRuleConditionRhsVariant4Type value)
        {
            return value switch
            {
                SegmentDataRuleConditionRhsVariant4Type.Regex => "regex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SegmentDataRuleConditionRhsVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "regex" => SegmentDataRuleConditionRhsVariant4Type.Regex,
                _ => null,
            };
        }
    }
}