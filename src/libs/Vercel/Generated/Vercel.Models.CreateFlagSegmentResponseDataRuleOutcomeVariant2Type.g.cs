
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateFlagSegmentResponseDataRuleOutcomeVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Split,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateFlagSegmentResponseDataRuleOutcomeVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateFlagSegmentResponseDataRuleOutcomeVariant2Type value)
        {
            return value switch
            {
                CreateFlagSegmentResponseDataRuleOutcomeVariant2Type.Split => "split",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFlagSegmentResponseDataRuleOutcomeVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "split" => CreateFlagSegmentResponseDataRuleOutcomeVariant2Type.Split,
                _ => null,
            };
        }
    }
}