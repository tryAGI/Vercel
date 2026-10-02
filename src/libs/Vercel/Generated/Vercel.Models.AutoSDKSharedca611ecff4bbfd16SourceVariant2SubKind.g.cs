
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedca611ecff4bbfd16SourceVariant2SubKind
    {
        /// <summary>
        ///
        /// </summary>
        VercelCiSentinel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedca611ecff4bbfd16SourceVariant2SubKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedca611ecff4bbfd16SourceVariant2SubKind value)
        {
            return value switch
            {
                AutoSDKSharedca611ecff4bbfd16SourceVariant2SubKind.VercelCiSentinel => "vercel-ci-sentinel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedca611ecff4bbfd16SourceVariant2SubKind? ToEnum(string value)
        {
            return value switch
            {
                "vercel-ci-sentinel" => AutoSDKSharedca611ecff4bbfd16SourceVariant2SubKind.VercelCiSentinel,
                _ => null,
            };
        }
    }
}