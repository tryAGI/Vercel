
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListFlagVersionsResponseVersionDataEnvironmentsRuleOutcomeVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Split,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListFlagVersionsResponseVersionDataEnvironmentsRuleOutcomeVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListFlagVersionsResponseVersionDataEnvironmentsRuleOutcomeVariant2Type value)
        {
            return value switch
            {
                ListFlagVersionsResponseVersionDataEnvironmentsRuleOutcomeVariant2Type.Split => "split",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListFlagVersionsResponseVersionDataEnvironmentsRuleOutcomeVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "split" => ListFlagVersionsResponseVersionDataEnvironmentsRuleOutcomeVariant2Type.Split,
                _ => null,
            };
        }
    }
}