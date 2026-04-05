
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum AddRouteResponseRouteRouteType
    {
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
        /// <summary>
        /// 
        /// </summary>
        Transform,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AddRouteResponseRouteRouteTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddRouteResponseRouteRouteType value)
        {
            return value switch
            {
                AddRouteResponseRouteRouteType.Redirect => "redirect",
                AddRouteResponseRouteRouteType.Rewrite => "rewrite",
                AddRouteResponseRouteRouteType.SetStatus => "set_status",
                AddRouteResponseRouteRouteType.Transform => "transform",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddRouteResponseRouteRouteType? ToEnum(string value)
        {
            return value switch
            {
                "redirect" => AddRouteResponseRouteRouteType.Redirect,
                "rewrite" => AddRouteResponseRouteRouteType.Rewrite,
                "set_status" => AddRouteResponseRouteRouteType.SetStatus,
                "transform" => AddRouteResponseRouteRouteType.Transform,
                _ => null,
            };
        }
    }
}