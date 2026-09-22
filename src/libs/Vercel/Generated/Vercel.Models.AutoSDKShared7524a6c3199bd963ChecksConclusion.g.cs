
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared7524a6c3199bd963ChecksConclusion
    {
        /// <summary>
        ///
        /// </summary>
        Canceled,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Skipped,
        /// <summary>
        ///
        /// </summary>
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared7524a6c3199bd963ChecksConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared7524a6c3199bd963ChecksConclusion value)
        {
            return value switch
            {
                AutoSDKShared7524a6c3199bd963ChecksConclusion.Canceled => "canceled",
                AutoSDKShared7524a6c3199bd963ChecksConclusion.Failed => "failed",
                AutoSDKShared7524a6c3199bd963ChecksConclusion.Skipped => "skipped",
                AutoSDKShared7524a6c3199bd963ChecksConclusion.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared7524a6c3199bd963ChecksConclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => AutoSDKShared7524a6c3199bd963ChecksConclusion.Canceled,
                "failed" => AutoSDKShared7524a6c3199bd963ChecksConclusion.Failed,
                "skipped" => AutoSDKShared7524a6c3199bd963ChecksConclusion.Skipped,
                "succeeded" => AutoSDKShared7524a6c3199bd963ChecksConclusion.Succeeded,
                _ => null,
            };
        }
    }
}