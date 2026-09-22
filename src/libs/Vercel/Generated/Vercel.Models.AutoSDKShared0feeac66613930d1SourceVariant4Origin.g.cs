
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0feeac66613930d1SourceVariant4Origin
    {
        /// <summary>
        ///
        /// </summary>
        Api,
        /// <summary>
        ///
        /// </summary>
        Platform,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared0feeac66613930d1SourceVariant4OriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0feeac66613930d1SourceVariant4Origin value)
        {
            return value switch
            {
                AutoSDKShared0feeac66613930d1SourceVariant4Origin.Api => "api",
                AutoSDKShared0feeac66613930d1SourceVariant4Origin.Platform => "platform",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0feeac66613930d1SourceVariant4Origin? ToEnum(string value)
        {
            return value switch
            {
                "api" => AutoSDKShared0feeac66613930d1SourceVariant4Origin.Api,
                "platform" => AutoSDKShared0feeac66613930d1SourceVariant4Origin.Platform,
                _ => null,
            };
        }
    }
}