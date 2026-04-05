
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListFlagVersionsResponseVersionDataEnvironmentsRuleOutcomeVariant2BaseType
    {
        /// <summary>
        /// 
        /// </summary>
        Entity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListFlagVersionsResponseVersionDataEnvironmentsRuleOutcomeVariant2BaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListFlagVersionsResponseVersionDataEnvironmentsRuleOutcomeVariant2BaseType value)
        {
            return value switch
            {
                ListFlagVersionsResponseVersionDataEnvironmentsRuleOutcomeVariant2BaseType.Entity => "entity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListFlagVersionsResponseVersionDataEnvironmentsRuleOutcomeVariant2BaseType? ToEnum(string value)
        {
            return value switch
            {
                "entity" => ListFlagVersionsResponseVersionDataEnvironmentsRuleOutcomeVariant2BaseType.Entity,
                _ => null,
            };
        }
    }
}