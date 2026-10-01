
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedcd352219f9b13f14Variant4Action
    {
        /// <summary>
        ///
        /// </summary>
        RouteUnblocked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedcd352219f9b13f14Variant4ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedcd352219f9b13f14Variant4Action value)
        {
            return value switch
            {
                AutoSDKSharedcd352219f9b13f14Variant4Action.RouteUnblocked => "route-unblocked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedcd352219f9b13f14Variant4Action? ToEnum(string value)
        {
            return value switch
            {
                "route-unblocked" => AutoSDKSharedcd352219f9b13f14Variant4Action.RouteUnblocked,
                _ => null,
            };
        }
    }
}