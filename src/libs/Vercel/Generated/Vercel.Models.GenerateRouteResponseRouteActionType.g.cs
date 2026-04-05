
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GenerateRouteResponseRouteActionType
    {
        /// <summary>
        /// 
        /// </summary>
        Modify,
        /// <summary>
        /// 
        /// </summary>
        Redirect,
        /// <summary>
        /// 
        /// </summary>
        Rewrite,
        /// <summary>
        /// 
        /// </summary>
        SetStatus,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerateRouteResponseRouteActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateRouteResponseRouteActionType value)
        {
            return value switch
            {
                GenerateRouteResponseRouteActionType.Modify => "modify",
                GenerateRouteResponseRouteActionType.Redirect => "redirect",
                GenerateRouteResponseRouteActionType.Rewrite => "rewrite",
                GenerateRouteResponseRouteActionType.SetStatus => "set-status",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateRouteResponseRouteActionType? ToEnum(string value)
        {
            return value switch
            {
                "modify" => GenerateRouteResponseRouteActionType.Modify,
                "redirect" => GenerateRouteResponseRouteActionType.Redirect,
                "rewrite" => GenerateRouteResponseRouteActionType.Rewrite,
                "set-status" => GenerateRouteResponseRouteActionType.SetStatus,
                _ => null,
            };
        }
    }
}