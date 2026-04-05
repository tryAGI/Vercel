
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateFlagResponseEnvironmentsRuleConditionLhsVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Segment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateFlagResponseEnvironmentsRuleConditionLhsVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateFlagResponseEnvironmentsRuleConditionLhsVariant1Type value)
        {
            return value switch
            {
                CreateFlagResponseEnvironmentsRuleConditionLhsVariant1Type.Segment => "segment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFlagResponseEnvironmentsRuleConditionLhsVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "segment" => CreateFlagResponseEnvironmentsRuleConditionLhsVariant1Type.Segment,
                _ => null,
            };
        }
    }
}