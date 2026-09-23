
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared8422af433e1bf486ChecksConclusion
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
    public static class AutoSDKShared8422af433e1bf486ChecksConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8422af433e1bf486ChecksConclusion value)
        {
            return value switch
            {
                AutoSDKShared8422af433e1bf486ChecksConclusion.Canceled => "canceled",
                AutoSDKShared8422af433e1bf486ChecksConclusion.Failed => "failed",
                AutoSDKShared8422af433e1bf486ChecksConclusion.Skipped => "skipped",
                AutoSDKShared8422af433e1bf486ChecksConclusion.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8422af433e1bf486ChecksConclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => AutoSDKShared8422af433e1bf486ChecksConclusion.Canceled,
                "failed" => AutoSDKShared8422af433e1bf486ChecksConclusion.Failed,
                "skipped" => AutoSDKShared8422af433e1bf486ChecksConclusion.Skipped,
                "succeeded" => AutoSDKShared8422af433e1bf486ChecksConclusion.Succeeded,
                _ => null,
            };
        }
    }
}