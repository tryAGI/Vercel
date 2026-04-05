
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionRhsVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        List,
        /// <summary>
        /// 
        /// </summary>
        ListInline,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionRhsVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionRhsVariant3Type value)
        {
            return value switch
            {
                ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionRhsVariant3Type.List => "list",
                ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionRhsVariant3Type.ListInline => "list/inline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionRhsVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "list" => ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionRhsVariant3Type.List,
                "list/inline" => ListFlagVersionsResponseVersionDataEnvironmentsRuleConditionRhsVariant3Type.ListInline,
                _ => null,
            };
        }
    }
}