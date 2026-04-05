
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFlagSegmentResponseDataRuleConditionLhsVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Segment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateFlagSegmentResponseDataRuleConditionLhsVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFlagSegmentResponseDataRuleConditionLhsVariant1Type value)
        {
            return value switch
            {
                UpdateFlagSegmentResponseDataRuleConditionLhsVariant1Type.Segment => "segment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFlagSegmentResponseDataRuleConditionLhsVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "segment" => UpdateFlagSegmentResponseDataRuleConditionLhsVariant1Type.Segment,
                _ => null,
            };
        }
    }
}