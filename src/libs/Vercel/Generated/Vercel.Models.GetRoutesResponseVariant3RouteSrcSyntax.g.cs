
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The syntax type of the source pattern. Determines how the pattern is compiled to regex.
    /// </summary>
    public enum GetRoutesResponseVariant3RouteSrcSyntax
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
    public static class GetRoutesResponseVariant3RouteSrcSyntaxExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRoutesResponseVariant3RouteSrcSyntax value)
        {
            return value switch
            {
                GetRoutesResponseVariant3RouteSrcSyntax.Equals => "equals",
                GetRoutesResponseVariant3RouteSrcSyntax.PathToRegexp => "path-to-regexp",
                GetRoutesResponseVariant3RouteSrcSyntax.Regex => "regex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRoutesResponseVariant3RouteSrcSyntax? ToEnum(string value)
        {
            return value switch
            {
                "equals" => GetRoutesResponseVariant3RouteSrcSyntax.Equals,
                "path-to-regexp" => GetRoutesResponseVariant3RouteSrcSyntax.PathToRegexp,
                "regex" => GetRoutesResponseVariant3RouteSrcSyntax.Regex,
                _ => null,
            };
        }
    }
}