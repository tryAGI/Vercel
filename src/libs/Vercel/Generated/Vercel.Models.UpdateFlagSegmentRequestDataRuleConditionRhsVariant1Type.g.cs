
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFlagSegmentRequestDataRuleConditionRhsVariant1Type
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
    public static class UpdateFlagSegmentRequestDataRuleConditionRhsVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFlagSegmentRequestDataRuleConditionRhsVariant1Type value)
        {
            return value switch
            {
                UpdateFlagSegmentRequestDataRuleConditionRhsVariant1Type.List => "list",
                UpdateFlagSegmentRequestDataRuleConditionRhsVariant1Type.ListInline => "list/inline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFlagSegmentRequestDataRuleConditionRhsVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "list" => UpdateFlagSegmentRequestDataRuleConditionRhsVariant1Type.List,
                "list/inline" => UpdateFlagSegmentRequestDataRuleConditionRhsVariant1Type.ListInline,
                _ => null,
            };
        }
    }
}