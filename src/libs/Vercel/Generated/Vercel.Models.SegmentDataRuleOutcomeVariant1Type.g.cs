
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum SegmentDataRuleOutcomeVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SegmentDataRuleOutcomeVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SegmentDataRuleOutcomeVariant1Type value)
        {
            return value switch
            {
                SegmentDataRuleOutcomeVariant1Type.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SegmentDataRuleOutcomeVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "all" => SegmentDataRuleOutcomeVariant1Type.All,
                _ => null,
            };
        }
    }
}