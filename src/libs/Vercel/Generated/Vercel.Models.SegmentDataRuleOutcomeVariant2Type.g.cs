
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum SegmentDataRuleOutcomeVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Split,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SegmentDataRuleOutcomeVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SegmentDataRuleOutcomeVariant2Type value)
        {
            return value switch
            {
                SegmentDataRuleOutcomeVariant2Type.Split => "split",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SegmentDataRuleOutcomeVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "split" => SegmentDataRuleOutcomeVariant2Type.Split,
                _ => null,
            };
        }
    }
}