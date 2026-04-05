
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFlagSegmentResponseDataRuleConditionLhsVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Entity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateFlagSegmentResponseDataRuleConditionLhsVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFlagSegmentResponseDataRuleConditionLhsVariant2Type value)
        {
            return value switch
            {
                UpdateFlagSegmentResponseDataRuleConditionLhsVariant2Type.Entity => "entity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFlagSegmentResponseDataRuleConditionLhsVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "entity" => UpdateFlagSegmentResponseDataRuleConditionLhsVariant2Type.Entity,
                _ => null,
            };
        }
    }
}