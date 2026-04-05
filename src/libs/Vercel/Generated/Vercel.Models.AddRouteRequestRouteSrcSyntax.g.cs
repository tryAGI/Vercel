
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Pattern syntax type. If not provided, inferred from pattern.
    /// </summary>
    public enum AddRouteRequestRouteSrcSyntax
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
    public static class AddRouteRequestRouteSrcSyntaxExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddRouteRequestRouteSrcSyntax value)
        {
            return value switch
            {
                AddRouteRequestRouteSrcSyntax.Equals => "equals",
                AddRouteRequestRouteSrcSyntax.PathToRegexp => "path-to-regexp",
                AddRouteRequestRouteSrcSyntax.Regex => "regex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddRouteRequestRouteSrcSyntax? ToEnum(string value)
        {
            return value switch
            {
                "equals" => AddRouteRequestRouteSrcSyntax.Equals,
                "path-to-regexp" => AddRouteRequestRouteSrcSyntax.PathToRegexp,
                "regex" => AddRouteRequestRouteSrcSyntax.Regex,
                _ => null,
            };
        }
    }
}