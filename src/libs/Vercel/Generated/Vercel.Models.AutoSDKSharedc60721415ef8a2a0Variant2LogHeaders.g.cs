
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc60721415ef8a2a0Variant2LogHeaders
    {
        /// <summary>
        ///
        /// </summary>
        Multiply,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedc60721415ef8a2a0Variant2LogHeadersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc60721415ef8a2a0Variant2LogHeaders value)
        {
            return value switch
            {
                AutoSDKSharedc60721415ef8a2a0Variant2LogHeaders.Multiply => "*",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc60721415ef8a2a0Variant2LogHeaders? ToEnum(string value)
        {
            return value switch
            {
                "*" => AutoSDKSharedc60721415ef8a2a0Variant2LogHeaders.Multiply,
                _ => null,
            };
        }
    }
}