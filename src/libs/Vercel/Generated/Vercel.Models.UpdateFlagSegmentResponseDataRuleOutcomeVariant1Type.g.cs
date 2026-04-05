
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFlagSegmentResponseDataRuleOutcomeVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateFlagSegmentResponseDataRuleOutcomeVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFlagSegmentResponseDataRuleOutcomeVariant1Type value)
        {
            return value switch
            {
                UpdateFlagSegmentResponseDataRuleOutcomeVariant1Type.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFlagSegmentResponseDataRuleOutcomeVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "all" => UpdateFlagSegmentResponseDataRuleOutcomeVariant1Type.All,
                _ => null,
            };
        }
    }
}