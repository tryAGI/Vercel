
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared429cd580a486c43eSourceVariant2Origin
    {
        /// <summary>
        ///
        /// </summary>
        Platform,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared429cd580a486c43eSourceVariant2OriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared429cd580a486c43eSourceVariant2Origin value)
        {
            return value switch
            {
                AutoSDKShared429cd580a486c43eSourceVariant2Origin.Platform => "platform",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared429cd580a486c43eSourceVariant2Origin? ToEnum(string value)
        {
            return value switch
            {
                "platform" => AutoSDKShared429cd580a486c43eSourceVariant2Origin.Platform,
                _ => null,
            };
        }
    }
}