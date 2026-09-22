
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The syntax type of the source pattern. Determines how the pattern is compiled to regex.
    /// </summary>
    public enum AutoSDKShared6ce7a2d665426cb4SrcSyntax
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
    public static class AutoSDKShared6ce7a2d665426cb4SrcSyntaxExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6ce7a2d665426cb4SrcSyntax value)
        {
            return value switch
            {
                AutoSDKShared6ce7a2d665426cb4SrcSyntax.Equals => "equals",
                AutoSDKShared6ce7a2d665426cb4SrcSyntax.PathToRegexp => "path-to-regexp",
                AutoSDKShared6ce7a2d665426cb4SrcSyntax.Regex => "regex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6ce7a2d665426cb4SrcSyntax? ToEnum(string value)
        {
            return value switch
            {
                "equals" => AutoSDKShared6ce7a2d665426cb4SrcSyntax.Equals,
                "path-to-regexp" => AutoSDKShared6ce7a2d665426cb4SrcSyntax.PathToRegexp,
                "regex" => AutoSDKShared6ce7a2d665426cb4SrcSyntax.Regex,
                _ => null,
            };
        }
    }
}