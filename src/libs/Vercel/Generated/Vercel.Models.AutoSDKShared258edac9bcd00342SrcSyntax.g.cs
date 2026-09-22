
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The syntax type of the source pattern. Determines how the pattern is compiled to regex.
    /// </summary>
    public enum AutoSDKShared258edac9bcd00342SrcSyntax
    {
        /// <summary>
        ///
        /// </summary>
        Equals,
        /// <summary>
        ///
        /// </summary>
        PathToRegexp,
        /// <summary>
        ///
        /// </summary>
        Regex,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared258edac9bcd00342SrcSyntaxExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared258edac9bcd00342SrcSyntax value)
        {
            return value switch
            {
                AutoSDKShared258edac9bcd00342SrcSyntax.Equals => "equals",
                AutoSDKShared258edac9bcd00342SrcSyntax.PathToRegexp => "path-to-regexp",
                AutoSDKShared258edac9bcd00342SrcSyntax.Regex => "regex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared258edac9bcd00342SrcSyntax? ToEnum(string value)
        {
            return value switch
            {
                "equals" => AutoSDKShared258edac9bcd00342SrcSyntax.Equals,
                "path-to-regexp" => AutoSDKShared258edac9bcd00342SrcSyntax.PathToRegexp,
                "regex" => AutoSDKShared258edac9bcd00342SrcSyntax.Regex,
                _ => null,
            };
        }
    }
}