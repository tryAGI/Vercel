
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateFlagSegmentResponseDataRuleConditionLhsVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Entity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateFlagSegmentResponseDataRuleConditionLhsVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateFlagSegmentResponseDataRuleConditionLhsVariant2Type value)
        {
            return value switch
            {
                CreateFlagSegmentResponseDataRuleConditionLhsVariant2Type.Entity => "entity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFlagSegmentResponseDataRuleConditionLhsVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "entity" => CreateFlagSegmentResponseDataRuleConditionLhsVariant2Type.Entity,
                _ => null,
            };
        }
    }
}