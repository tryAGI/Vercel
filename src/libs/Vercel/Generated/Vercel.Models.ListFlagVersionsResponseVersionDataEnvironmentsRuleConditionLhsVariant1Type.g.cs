
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionLhsVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Segment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionLhsVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionLhsVariant1Type value)
        {
            return value switch
            {
                ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionLhsVariant1Type.Segment => "segment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionLhsVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "segment" => ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionLhsVariant1Type.Segment,
                _ => null,
            };
        }
    }
}