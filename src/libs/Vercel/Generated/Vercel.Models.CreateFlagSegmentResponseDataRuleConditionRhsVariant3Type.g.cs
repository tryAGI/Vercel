
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateFlagSegmentResponseDataRuleConditionRhsVariant3Type
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
    public static class CreateFlagSegmentResponseDataRuleConditionRhsVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateFlagSegmentResponseDataRuleConditionRhsVariant3Type value)
        {
            return value switch
            {
                CreateFlagSegmentResponseDataRuleConditionRhsVariant3Type.List => "list",
                CreateFlagSegmentResponseDataRuleConditionRhsVariant3Type.ListInline => "list/inline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFlagSegmentResponseDataRuleConditionRhsVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "list" => CreateFlagSegmentResponseDataRuleConditionRhsVariant3Type.List,
                "list/inline" => CreateFlagSegmentResponseDataRuleConditionRhsVariant3Type.ListInline,
                _ => null,
            };
        }
    }
}