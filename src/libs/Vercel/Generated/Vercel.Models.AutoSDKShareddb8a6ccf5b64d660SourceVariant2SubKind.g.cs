
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareddb8a6ccf5b64d660SourceVariant2SubKind
    {
        /// <summary>
        ///
        /// </summary>
        VercelCiSentinel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShareddb8a6ccf5b64d660SourceVariant2SubKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareddb8a6ccf5b64d660SourceVariant2SubKind value)
        {
            return value switch
            {
                AutoSDKShareddb8a6ccf5b64d660SourceVariant2SubKind.VercelCiSentinel => "vercel-ci-sentinel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareddb8a6ccf5b64d660SourceVariant2SubKind? ToEnum(string value)
        {
            return value switch
            {
                "vercel-ci-sentinel" => AutoSDKShareddb8a6ccf5b64d660SourceVariant2SubKind.VercelCiSentinel,
                _ => null,
            };
        }
    }
}