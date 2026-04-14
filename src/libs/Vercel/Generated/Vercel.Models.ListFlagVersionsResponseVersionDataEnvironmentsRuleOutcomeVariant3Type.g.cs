
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListFlagVersionsResponseVersionDataEnvironmentsRuleOutcomeVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        Rollout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListFlagVersionsResponseVersionDataEnvironmentsRuleOutcomeVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListFlagVersionsResponseVersionDataEnvironmentsRuleOutcomeVariant3Type value)
        {
            return value switch
            {
                ListFlagVersionsResponseVersionDataEnvironmentsRuleOutcomeVariant3Type.Rollout => "rollout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListFlagVersionsResponseVersionDataEnvironmentsRuleOutcomeVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "rollout" => ListFlagVersionsResponseVersionDataEnvironmentsRuleOutcomeVariant3Type.Rollout,
                _ => null,
            };
        }
    }
}