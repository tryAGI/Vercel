
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The syntax type of the source pattern. Determines how the pattern is compiled to regex.
    /// </summary>
    public enum AutoSDKShareda5bc732e1681aab5SrcSyntax
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
    public static class AutoSDKShareda5bc732e1681aab5SrcSyntaxExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda5bc732e1681aab5SrcSyntax value)
        {
            return value switch
            {
                AutoSDKShareda5bc732e1681aab5SrcSyntax.Equals => "equals",
                AutoSDKShareda5bc732e1681aab5SrcSyntax.PathToRegexp => "path-to-regexp",
                AutoSDKShareda5bc732e1681aab5SrcSyntax.Regex => "regex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda5bc732e1681aab5SrcSyntax? ToEnum(string value)
        {
            return value switch
            {
                "equals" => AutoSDKShareda5bc732e1681aab5SrcSyntax.Equals,
                "path-to-regexp" => AutoSDKShareda5bc732e1681aab5SrcSyntax.PathToRegexp,
                "regex" => AutoSDKShareda5bc732e1681aab5SrcSyntax.Regex,
                _ => null,
            };
        }
    }
}