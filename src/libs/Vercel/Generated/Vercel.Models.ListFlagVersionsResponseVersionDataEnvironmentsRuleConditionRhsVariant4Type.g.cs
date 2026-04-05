
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionRhsVariant4Type
    {
        /// <summary>
        /// 
        /// </summary>
        Regex,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionRhsVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionRhsVariant4Type value)
        {
            return value switch
            {
                ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionRhsVariant4Type.Regex => "regex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionRhsVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "regex" => ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionRhsVariant4Type.Regex,
                _ => null,
            };
        }
    }
}