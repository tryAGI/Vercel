
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared3cefeabeb1d55c64Variant2LogHeaders
    {
        /// <summary>
        ///
        /// </summary>
        Multiply,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared3cefeabeb1d55c64Variant2LogHeadersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared3cefeabeb1d55c64Variant2LogHeaders value)
        {
            return value switch
            {
                AutoSDKShared3cefeabeb1d55c64Variant2LogHeaders.Multiply => "*",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared3cefeabeb1d55c64Variant2LogHeaders? ToEnum(string value)
        {
            return value switch
            {
                "*" => AutoSDKShared3cefeabeb1d55c64Variant2LogHeaders.Multiply,
                _ => null,
            };
        }
    }
}