
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedacb9976f956c2a3bVariant4Action
    {
        /// <summary>
        ///
        /// </summary>
        RouteUnblocked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedacb9976f956c2a3bVariant4ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedacb9976f956c2a3bVariant4Action value)
        {
            return value switch
            {
                AutoSDKSharedacb9976f956c2a3bVariant4Action.RouteUnblocked => "route-unblocked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedacb9976f956c2a3bVariant4Action? ToEnum(string value)
        {
            return value switch
            {
                "route-unblocked" => AutoSDKSharedacb9976f956c2a3bVariant4Action.RouteUnblocked,
                _ => null,
            };
        }
    }
}