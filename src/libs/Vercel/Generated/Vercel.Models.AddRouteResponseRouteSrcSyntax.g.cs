
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The syntax type of the source pattern. Determines how the pattern is compiled to regex.
    /// </summary>
    public enum AddRouteResponseRouteSrcSyntax
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
    public static class AddRouteResponseRouteSrcSyntaxExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddRouteResponseRouteSrcSyntax value)
        {
            return value switch
            {
                AddRouteResponseRouteSrcSyntax.Equals => "equals",
                AddRouteResponseRouteSrcSyntax.PathToRegexp => "path-to-regexp",
                AddRouteResponseRouteSrcSyntax.Regex => "regex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddRouteResponseRouteSrcSyntax? ToEnum(string value)
        {
            return value switch
            {
                "equals" => AddRouteResponseRouteSrcSyntax.Equals,
                "path-to-regexp" => AddRouteResponseRouteSrcSyntax.PathToRegexp,
                "regex" => AddRouteResponseRouteSrcSyntax.Regex,
                _ => null,
            };
        }
    }
}