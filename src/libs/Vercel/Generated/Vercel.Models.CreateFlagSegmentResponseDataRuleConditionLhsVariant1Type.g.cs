
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateFlagSegmentResponseDataRuleConditionLhsVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Segment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateFlagSegmentResponseDataRuleConditionLhsVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateFlagSegmentResponseDataRuleConditionLhsVariant1Type value)
        {
            return value switch
            {
                CreateFlagSegmentResponseDataRuleConditionLhsVariant1Type.Segment => "segment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFlagSegmentResponseDataRuleConditionLhsVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "segment" => CreateFlagSegmentResponseDataRuleConditionLhsVariant1Type.Segment,
                _ => null,
            };
        }
    }
}