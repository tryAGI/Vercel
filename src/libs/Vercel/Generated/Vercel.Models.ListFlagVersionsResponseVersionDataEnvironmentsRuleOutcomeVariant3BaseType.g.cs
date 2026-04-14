
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListFlagVersionsResponseVersionDataEnvironmentsRuleOutcomeVariant3BaseType
    {
        /// <summary>
        /// 
        /// </summary>
        Entity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListFlagVersionsResponseVersionDataEnvironmentsRuleOutcomeVariant3BaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListFlagVersionsResponseVersionDataEnvironmentsRuleOutcomeVariant3BaseType value)
        {
            return value switch
            {
                ListFlagVersionsResponseVersionDataEnvironmentsRuleOutcomeVariant3BaseType.Entity => "entity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListFlagVersionsResponseVersionDataEnvironmentsRuleOutcomeVariant3BaseType? ToEnum(string value)
        {
            return value switch
            {
                "entity" => ListFlagVersionsResponseVersionDataEnvironmentsRuleOutcomeVariant3BaseType.Entity,
                _ => null,
            };
        }
    }
}