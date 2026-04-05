
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFlagSegmentResponseDataRuleConditionRhsVariant3Type
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
    public static class UpdateFlagSegmentResponseDataRuleConditionRhsVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFlagSegmentResponseDataRuleConditionRhsVariant3Type value)
        {
            return value switch
            {
                UpdateFlagSegmentResponseDataRuleConditionRhsVariant3Type.List => "list",
                UpdateFlagSegmentResponseDataRuleConditionRhsVariant3Type.ListInline => "list/inline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFlagSegmentResponseDataRuleConditionRhsVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "list" => UpdateFlagSegmentResponseDataRuleConditionRhsVariant3Type.List,
                "list/inline" => UpdateFlagSegmentResponseDataRuleConditionRhsVariant3Type.ListInline,
                _ => null,
            };
        }
    }
}