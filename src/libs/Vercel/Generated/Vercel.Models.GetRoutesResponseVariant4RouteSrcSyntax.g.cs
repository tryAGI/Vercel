
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The syntax type of the source pattern. Determines how the pattern is compiled to regex.
    /// </summary>
    public enum GetRoutesResponseVariant4RouteSrcSyntax
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
    public static class GetRoutesResponseVariant4RouteSrcSyntaxExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRoutesResponseVariant4RouteSrcSyntax value)
        {
            return value switch
            {
                GetRoutesResponseVariant4RouteSrcSyntax.Equals => "equals",
                GetRoutesResponseVariant4RouteSrcSyntax.PathToRegexp => "path-to-regexp",
                GetRoutesResponseVariant4RouteSrcSyntax.Regex => "regex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRoutesResponseVariant4RouteSrcSyntax? ToEnum(string value)
        {
            return value switch
            {
                "equals" => GetRoutesResponseVariant4RouteSrcSyntax.Equals,
                "path-to-regexp" => GetRoutesResponseVariant4RouteSrcSyntax.PathToRegexp,
                "regex" => GetRoutesResponseVariant4RouteSrcSyntax.Regex,
                _ => null,
            };
        }
    }
}