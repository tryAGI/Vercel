
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The syntax type of the source pattern. Determines how the pattern is compiled to regex.
    /// </summary>
    public enum AutoSDKSharedb49e2a5785c6f473SrcSyntax
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
    public static class AutoSDKSharedb49e2a5785c6f473SrcSyntaxExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedb49e2a5785c6f473SrcSyntax value)
        {
            return value switch
            {
                AutoSDKSharedb49e2a5785c6f473SrcSyntax.Equals => "equals",
                AutoSDKSharedb49e2a5785c6f473SrcSyntax.PathToRegexp => "path-to-regexp",
                AutoSDKSharedb49e2a5785c6f473SrcSyntax.Regex => "regex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedb49e2a5785c6f473SrcSyntax? ToEnum(string value)
        {
            return value switch
            {
                "equals" => AutoSDKSharedb49e2a5785c6f473SrcSyntax.Equals,
                "path-to-regexp" => AutoSDKSharedb49e2a5785c6f473SrcSyntax.PathToRegexp,
                "regex" => AutoSDKSharedb49e2a5785c6f473SrcSyntax.Regex,
                _ => null,
            };
        }
    }
}