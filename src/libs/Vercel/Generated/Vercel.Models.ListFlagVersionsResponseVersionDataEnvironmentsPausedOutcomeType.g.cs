
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListFlagVersionsResponseVersionDataEnvironmentsPausedOutcomeType
    {
        /// <summary>
        /// 
        /// </summary>
        Variant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListFlagVersionsResponseVersionDataEnvironmentsPausedOutcomeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListFlagVersionsResponseVersionDataEnvironmentsPausedOutcomeType value)
        {
            return value switch
            {
                ListFlagVersionsResponseVersionDataEnvironmentsPausedOutcomeType.Variant => "variant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListFlagVersionsResponseVersionDataEnvironmentsPausedOutcomeType? ToEnum(string value)
        {
            return value switch
            {
                "variant" => ListFlagVersionsResponseVersionDataEnvironmentsPausedOutcomeType.Variant,
                _ => null,
            };
        }
    }
}