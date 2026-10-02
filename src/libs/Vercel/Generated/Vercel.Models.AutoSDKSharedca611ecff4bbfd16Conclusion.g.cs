
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedca611ecff4bbfd16Conclusion
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
    public static class AutoSDKSharedca611ecff4bbfd16ConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedca611ecff4bbfd16Conclusion value)
        {
            return value switch
            {
                AutoSDKSharedca611ecff4bbfd16Conclusion.Canceled => "canceled",
                AutoSDKSharedca611ecff4bbfd16Conclusion.Failed => "failed",
                AutoSDKSharedca611ecff4bbfd16Conclusion.Neutral => "neutral",
                AutoSDKSharedca611ecff4bbfd16Conclusion.Skipped => "skipped",
                AutoSDKSharedca611ecff4bbfd16Conclusion.Succeeded => "succeeded",
                AutoSDKSharedca611ecff4bbfd16Conclusion.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedca611ecff4bbfd16Conclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => AutoSDKSharedca611ecff4bbfd16Conclusion.Canceled,
                "failed" => AutoSDKSharedca611ecff4bbfd16Conclusion.Failed,
                "neutral" => AutoSDKSharedca611ecff4bbfd16Conclusion.Neutral,
                "skipped" => AutoSDKSharedca611ecff4bbfd16Conclusion.Skipped,
                "succeeded" => AutoSDKSharedca611ecff4bbfd16Conclusion.Succeeded,
                "timeout" => AutoSDKSharedca611ecff4bbfd16Conclusion.Timeout,
                _ => null,
            };
        }
    }
}