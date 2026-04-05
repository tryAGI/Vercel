
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateFlagSegmentRequestDataRuleConditionRhsVariant1Type
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
    public static class CreateFlagSegmentRequestDataRuleConditionRhsVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateFlagSegmentRequestDataRuleConditionRhsVariant1Type value)
        {
            return value switch
            {
                CreateFlagSegmentRequestDataRuleConditionRhsVariant1Type.List => "list",
                CreateFlagSegmentRequestDataRuleConditionRhsVariant1Type.ListInline => "list/inline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFlagSegmentRequestDataRuleConditionRhsVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "list" => CreateFlagSegmentRequestDataRuleConditionRhsVariant1Type.List,
                "list/inline" => CreateFlagSegmentRequestDataRuleConditionRhsVariant1Type.ListInline,
                _ => null,
            };
        }
    }
}