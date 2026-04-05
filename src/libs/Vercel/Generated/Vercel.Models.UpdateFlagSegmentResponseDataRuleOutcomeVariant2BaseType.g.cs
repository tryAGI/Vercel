
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFlagSegmentResponseDataRuleOutcomeVariant2BaseType
    {
        /// <summary>
        /// 
        /// </summary>
        Entity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateFlagSegmentResponseDataRuleOutcomeVariant2BaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFlagSegmentResponseDataRuleOutcomeVariant2BaseType value)
        {
            return value switch
            {
                UpdateFlagSegmentResponseDataRuleOutcomeVariant2BaseType.Entity => "entity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFlagSegmentResponseDataRuleOutcomeVariant2BaseType? ToEnum(string value)
        {
            return value switch
            {
                "entity" => UpdateFlagSegmentResponseDataRuleOutcomeVariant2BaseType.Entity,
                _ => null,
            };
        }
    }
}