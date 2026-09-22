
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0feeac66613930d1Conclusion
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
    public static class AutoSDKShared0feeac66613930d1ConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0feeac66613930d1Conclusion value)
        {
            return value switch
            {
                AutoSDKShared0feeac66613930d1Conclusion.Canceled => "canceled",
                AutoSDKShared0feeac66613930d1Conclusion.Failed => "failed",
                AutoSDKShared0feeac66613930d1Conclusion.Neutral => "neutral",
                AutoSDKShared0feeac66613930d1Conclusion.Skipped => "skipped",
                AutoSDKShared0feeac66613930d1Conclusion.Succeeded => "succeeded",
                AutoSDKShared0feeac66613930d1Conclusion.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0feeac66613930d1Conclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => AutoSDKShared0feeac66613930d1Conclusion.Canceled,
                "failed" => AutoSDKShared0feeac66613930d1Conclusion.Failed,
                "neutral" => AutoSDKShared0feeac66613930d1Conclusion.Neutral,
                "skipped" => AutoSDKShared0feeac66613930d1Conclusion.Skipped,
                "succeeded" => AutoSDKShared0feeac66613930d1Conclusion.Succeeded,
                "timeout" => AutoSDKShared0feeac66613930d1Conclusion.Timeout,
                _ => null,
            };
        }
    }
}