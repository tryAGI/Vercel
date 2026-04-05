
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Pattern syntax type. If not provided, inferred from pattern.
    /// </summary>
    public enum EditRouteRequestRouteSrcSyntax
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
    public static class EditRouteRequestRouteSrcSyntaxExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditRouteRequestRouteSrcSyntax value)
        {
            return value switch
            {
                EditRouteRequestRouteSrcSyntax.Equals => "equals",
                EditRouteRequestRouteSrcSyntax.PathToRegexp => "path-to-regexp",
                EditRouteRequestRouteSrcSyntax.Regex => "regex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditRouteRequestRouteSrcSyntax? ToEnum(string value)
        {
            return value switch
            {
                "equals" => EditRouteRequestRouteSrcSyntax.Equals,
                "path-to-regexp" => EditRouteRequestRouteSrcSyntax.PathToRegexp,
                "regex" => EditRouteRequestRouteSrcSyntax.Regex,
                _ => null,
            };
        }
    }
}