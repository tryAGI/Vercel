
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateFlagSegmentResponseDataRuleOutcomeVariant2BaseType
    {
        /// <summary>
        /// 
        /// </summary>
        Entity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateFlagSegmentResponseDataRuleOutcomeVariant2BaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateFlagSegmentResponseDataRuleOutcomeVariant2BaseType value)
        {
            return value switch
            {
                CreateFlagSegmentResponseDataRuleOutcomeVariant2BaseType.Entity => "entity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFlagSegmentResponseDataRuleOutcomeVariant2BaseType? ToEnum(string value)
        {
            return value switch
            {
                "entity" => CreateFlagSegmentResponseDataRuleOutcomeVariant2BaseType.Entity,
                _ => null,
            };
        }
    }
}