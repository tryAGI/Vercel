
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum FlagEnvironmentsRuleConditionLhsVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Segment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FlagEnvironmentsRuleConditionLhsVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FlagEnvironmentsRuleConditionLhsVariant1Type value)
        {
            return value switch
            {
                FlagEnvironmentsRuleConditionLhsVariant1Type.Segment => "segment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FlagEnvironmentsRuleConditionLhsVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "segment" => FlagEnvironmentsRuleConditionLhsVariant1Type.Segment,
                _ => null,
            };
        }
    }
}