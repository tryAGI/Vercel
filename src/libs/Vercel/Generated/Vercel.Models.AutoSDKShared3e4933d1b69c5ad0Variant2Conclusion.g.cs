
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared3e4933d1b69c5ad0Variant2Conclusion
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
    public static class AutoSDKShared3e4933d1b69c5ad0Variant2ConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared3e4933d1b69c5ad0Variant2Conclusion value)
        {
            return value switch
            {
                AutoSDKShared3e4933d1b69c5ad0Variant2Conclusion.Canceled => "canceled",
                AutoSDKShared3e4933d1b69c5ad0Variant2Conclusion.Failed => "failed",
                AutoSDKShared3e4933d1b69c5ad0Variant2Conclusion.Neutral => "neutral",
                AutoSDKShared3e4933d1b69c5ad0Variant2Conclusion.Skipped => "skipped",
                AutoSDKShared3e4933d1b69c5ad0Variant2Conclusion.Succeeded => "succeeded",
                AutoSDKShared3e4933d1b69c5ad0Variant2Conclusion.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared3e4933d1b69c5ad0Variant2Conclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => AutoSDKShared3e4933d1b69c5ad0Variant2Conclusion.Canceled,
                "failed" => AutoSDKShared3e4933d1b69c5ad0Variant2Conclusion.Failed,
                "neutral" => AutoSDKShared3e4933d1b69c5ad0Variant2Conclusion.Neutral,
                "skipped" => AutoSDKShared3e4933d1b69c5ad0Variant2Conclusion.Skipped,
                "succeeded" => AutoSDKShared3e4933d1b69c5ad0Variant2Conclusion.Succeeded,
                "timeout" => AutoSDKShared3e4933d1b69c5ad0Variant2Conclusion.Timeout,
                _ => null,
            };
        }
    }
}