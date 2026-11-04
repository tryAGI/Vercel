
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda5bc732e1681aab5RouteType
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
    public static class AutoSDKShareda5bc732e1681aab5RouteTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda5bc732e1681aab5RouteType value)
        {
            return value switch
            {
                AutoSDKShareda5bc732e1681aab5RouteType.Redirect => "redirect",
                AutoSDKShareda5bc732e1681aab5RouteType.Rewrite => "rewrite",
                AutoSDKShareda5bc732e1681aab5RouteType.SetStatus => "set_status",
                AutoSDKShareda5bc732e1681aab5RouteType.Transform => "transform",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda5bc732e1681aab5RouteType? ToEnum(string value)
        {
            return value switch
            {
                "redirect" => AutoSDKShareda5bc732e1681aab5RouteType.Redirect,
                "rewrite" => AutoSDKShareda5bc732e1681aab5RouteType.Rewrite,
                "set_status" => AutoSDKShareda5bc732e1681aab5RouteType.SetStatus,
                "transform" => AutoSDKShareda5bc732e1681aab5RouteType.Transform,
                _ => null,
            };
        }
    }
}