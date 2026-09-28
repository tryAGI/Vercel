
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedd60af9eb328d9316RoutePrefixSource
    {
        /// <summary>
        ///
        /// </summary>
        Configured,
        /// <summary>
        ///
        /// </summary>
        Generated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedd60af9eb328d9316RoutePrefixSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd60af9eb328d9316RoutePrefixSource value)
        {
            return value switch
            {
                AutoSDKSharedd60af9eb328d9316RoutePrefixSource.Configured => "configured",
                AutoSDKSharedd60af9eb328d9316RoutePrefixSource.Generated => "generated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd60af9eb328d9316RoutePrefixSource? ToEnum(string value)
        {
            return value switch
            {
                "configured" => AutoSDKSharedd60af9eb328d9316RoutePrefixSource.Configured,
                "generated" => AutoSDKSharedd60af9eb328d9316RoutePrefixSource.Generated,
                _ => null,
            };
        }
    }
}