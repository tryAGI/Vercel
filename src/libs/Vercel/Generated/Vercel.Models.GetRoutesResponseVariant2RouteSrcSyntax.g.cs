
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The syntax type of the source pattern. Determines how the pattern is compiled to regex.
    /// </summary>
    public enum GetRoutesResponseVariant2RouteSrcSyntax
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
    public static class GetRoutesResponseVariant2RouteSrcSyntaxExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRoutesResponseVariant2RouteSrcSyntax value)
        {
            return value switch
            {
                GetRoutesResponseVariant2RouteSrcSyntax.Equals => "equals",
                GetRoutesResponseVariant2RouteSrcSyntax.PathToRegexp => "path-to-regexp",
                GetRoutesResponseVariant2RouteSrcSyntax.Regex => "regex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRoutesResponseVariant2RouteSrcSyntax? ToEnum(string value)
        {
            return value switch
            {
                "equals" => GetRoutesResponseVariant2RouteSrcSyntax.Equals,
                "path-to-regexp" => GetRoutesResponseVariant2RouteSrcSyntax.PathToRegexp,
                "regex" => GetRoutesResponseVariant2RouteSrcSyntax.Regex,
                _ => null,
            };
        }
    }
}