
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum EditRouteResponseRouteRouteType
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
    public static class EditRouteResponseRouteRouteTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditRouteResponseRouteRouteType value)
        {
            return value switch
            {
                EditRouteResponseRouteRouteType.Redirect => "redirect",
                EditRouteResponseRouteRouteType.Rewrite => "rewrite",
                EditRouteResponseRouteRouteType.SetStatus => "set_status",
                EditRouteResponseRouteRouteType.Transform => "transform",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditRouteResponseRouteRouteType? ToEnum(string value)
        {
            return value switch
            {
                "redirect" => EditRouteResponseRouteRouteType.Redirect,
                "rewrite" => EditRouteResponseRouteRouteType.Rewrite,
                "set_status" => EditRouteResponseRouteRouteType.SetStatus,
                "transform" => EditRouteResponseRouteRouteType.Transform,
                _ => null,
            };
        }
    }
}