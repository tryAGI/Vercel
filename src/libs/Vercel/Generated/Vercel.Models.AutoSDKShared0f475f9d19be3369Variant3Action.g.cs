
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0f475f9d19be3369Variant3Action
    {
        /// <summary>
        ///
        /// </summary>
        RouteBlocked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared0f475f9d19be3369Variant3ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0f475f9d19be3369Variant3Action value)
        {
            return value switch
            {
                AutoSDKShared0f475f9d19be3369Variant3Action.RouteBlocked => "route-blocked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0f475f9d19be3369Variant3Action? ToEnum(string value)
        {
            return value switch
            {
                "route-blocked" => AutoSDKShared0f475f9d19be3369Variant3Action.RouteBlocked,
                _ => null,
            };
        }
    }
}