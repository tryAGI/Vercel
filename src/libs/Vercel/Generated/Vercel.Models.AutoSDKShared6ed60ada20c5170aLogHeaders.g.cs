
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6ed60ada20c5170aLogHeaders
    {
        /// <summary>
        ///
        /// </summary>
        Multiply,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared6ed60ada20c5170aLogHeadersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6ed60ada20c5170aLogHeaders value)
        {
            return value switch
            {
                AutoSDKShared6ed60ada20c5170aLogHeaders.Multiply => "*",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6ed60ada20c5170aLogHeaders? ToEnum(string value)
        {
            return value switch
            {
                "*" => AutoSDKShared6ed60ada20c5170aLogHeaders.Multiply,
                _ => null,
            };
        }
    }
}