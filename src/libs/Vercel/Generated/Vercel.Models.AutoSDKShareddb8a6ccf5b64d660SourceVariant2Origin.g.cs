
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareddb8a6ccf5b64d660SourceVariant2Origin
    {
        /// <summary>
        ///
        /// </summary>
        Platform,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShareddb8a6ccf5b64d660SourceVariant2OriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareddb8a6ccf5b64d660SourceVariant2Origin value)
        {
            return value switch
            {
                AutoSDKShareddb8a6ccf5b64d660SourceVariant2Origin.Platform => "platform",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareddb8a6ccf5b64d660SourceVariant2Origin? ToEnum(string value)
        {
            return value switch
            {
                "platform" => AutoSDKShareddb8a6ccf5b64d660SourceVariant2Origin.Platform,
                _ => null,
            };
        }
    }
}