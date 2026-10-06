
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared12773eaec07789a9Conclusion
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
    public static class AutoSDKShared12773eaec07789a9ConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared12773eaec07789a9Conclusion value)
        {
            return value switch
            {
                AutoSDKShared12773eaec07789a9Conclusion.Canceled => "canceled",
                AutoSDKShared12773eaec07789a9Conclusion.Failed => "failed",
                AutoSDKShared12773eaec07789a9Conclusion.Neutral => "neutral",
                AutoSDKShared12773eaec07789a9Conclusion.Skipped => "skipped",
                AutoSDKShared12773eaec07789a9Conclusion.Succeeded => "succeeded",
                AutoSDKShared12773eaec07789a9Conclusion.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared12773eaec07789a9Conclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => AutoSDKShared12773eaec07789a9Conclusion.Canceled,
                "failed" => AutoSDKShared12773eaec07789a9Conclusion.Failed,
                "neutral" => AutoSDKShared12773eaec07789a9Conclusion.Neutral,
                "skipped" => AutoSDKShared12773eaec07789a9Conclusion.Skipped,
                "succeeded" => AutoSDKShared12773eaec07789a9Conclusion.Succeeded,
                "timeout" => AutoSDKShared12773eaec07789a9Conclusion.Timeout,
                _ => null,
            };
        }
    }
}