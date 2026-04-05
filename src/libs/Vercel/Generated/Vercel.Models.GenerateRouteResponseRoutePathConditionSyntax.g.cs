
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GenerateRouteResponseRoutePathConditionSyntax
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
    public static class GenerateRouteResponseRoutePathConditionSyntaxExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateRouteResponseRoutePathConditionSyntax value)
        {
            return value switch
            {
                GenerateRouteResponseRoutePathConditionSyntax.Equals => "equals",
                GenerateRouteResponseRoutePathConditionSyntax.PathToRegexp => "path-to-regexp",
                GenerateRouteResponseRoutePathConditionSyntax.Regex => "regex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateRouteResponseRoutePathConditionSyntax? ToEnum(string value)
        {
            return value switch
            {
                "equals" => GenerateRouteResponseRoutePathConditionSyntax.Equals,
                "path-to-regexp" => GenerateRouteResponseRoutePathConditionSyntax.PathToRegexp,
                "regex" => GenerateRouteResponseRoutePathConditionSyntax.Regex,
                _ => null,
            };
        }
    }
}