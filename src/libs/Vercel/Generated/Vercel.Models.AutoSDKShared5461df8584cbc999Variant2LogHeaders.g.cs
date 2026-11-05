
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared5461df8584cbc999Variant2LogHeaders
    {
        /// <summary>
        ///
        /// </summary>
        Multiply,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared5461df8584cbc999Variant2LogHeadersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared5461df8584cbc999Variant2LogHeaders value)
        {
            return value switch
            {
                AutoSDKShared5461df8584cbc999Variant2LogHeaders.Multiply => "*",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared5461df8584cbc999Variant2LogHeaders? ToEnum(string value)
        {
            return value switch
            {
                "*" => AutoSDKShared5461df8584cbc999Variant2LogHeaders.Multiply,
                _ => null,
            };
        }
    }
}