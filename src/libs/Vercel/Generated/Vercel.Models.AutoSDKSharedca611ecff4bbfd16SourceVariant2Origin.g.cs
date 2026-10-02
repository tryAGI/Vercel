
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedca611ecff4bbfd16SourceVariant2Origin
    {
        /// <summary>
        ///
        /// </summary>
        Platform,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedca611ecff4bbfd16SourceVariant2OriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedca611ecff4bbfd16SourceVariant2Origin value)
        {
            return value switch
            {
                AutoSDKSharedca611ecff4bbfd16SourceVariant2Origin.Platform => "platform",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedca611ecff4bbfd16SourceVariant2Origin? ToEnum(string value)
        {
            return value switch
            {
                "platform" => AutoSDKSharedca611ecff4bbfd16SourceVariant2Origin.Platform,
                _ => null,
            };
        }
    }
}