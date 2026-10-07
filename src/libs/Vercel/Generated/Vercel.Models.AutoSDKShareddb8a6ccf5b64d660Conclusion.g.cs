
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareddb8a6ccf5b64d660Conclusion
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
        Neutral,
        /// <summary>
        ///
        /// </summary>
        Skipped,
        /// <summary>
        ///
        /// </summary>
        Succeeded,
        /// <summary>
        ///
        /// </summary>
        Timeout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShareddb8a6ccf5b64d660ConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareddb8a6ccf5b64d660Conclusion value)
        {
            return value switch
            {
                AutoSDKShareddb8a6ccf5b64d660Conclusion.Canceled => "canceled",
                AutoSDKShareddb8a6ccf5b64d660Conclusion.Failed => "failed",
                AutoSDKShareddb8a6ccf5b64d660Conclusion.Neutral => "neutral",
                AutoSDKShareddb8a6ccf5b64d660Conclusion.Skipped => "skipped",
                AutoSDKShareddb8a6ccf5b64d660Conclusion.Succeeded => "succeeded",
                AutoSDKShareddb8a6ccf5b64d660Conclusion.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareddb8a6ccf5b64d660Conclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => AutoSDKShareddb8a6ccf5b64d660Conclusion.Canceled,
                "failed" => AutoSDKShareddb8a6ccf5b64d660Conclusion.Failed,
                "neutral" => AutoSDKShareddb8a6ccf5b64d660Conclusion.Neutral,
                "skipped" => AutoSDKShareddb8a6ccf5b64d660Conclusion.Skipped,
                "succeeded" => AutoSDKShareddb8a6ccf5b64d660Conclusion.Succeeded,
                "timeout" => AutoSDKShareddb8a6ccf5b64d660Conclusion.Timeout,
                _ => null,
            };
        }
    }
}