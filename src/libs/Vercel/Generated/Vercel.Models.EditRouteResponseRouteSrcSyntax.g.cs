
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The syntax type of the source pattern. Determines how the pattern is compiled to regex.
    /// </summary>
    public enum EditRouteResponseRouteSrcSyntax
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
    public static class EditRouteResponseRouteSrcSyntaxExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditRouteResponseRouteSrcSyntax value)
        {
            return value switch
            {
                EditRouteResponseRouteSrcSyntax.Equals => "equals",
                EditRouteResponseRouteSrcSyntax.PathToRegexp => "path-to-regexp",
                EditRouteResponseRouteSrcSyntax.Regex => "regex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditRouteResponseRouteSrcSyntax? ToEnum(string value)
        {
            return value switch
            {
                "equals" => EditRouteResponseRouteSrcSyntax.Equals,
                "path-to-regexp" => EditRouteResponseRouteSrcSyntax.PathToRegexp,
                "regex" => EditRouteResponseRouteSrcSyntax.Regex,
                _ => null,
            };
        }
    }
}