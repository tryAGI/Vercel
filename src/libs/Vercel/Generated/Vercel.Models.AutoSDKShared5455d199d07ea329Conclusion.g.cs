
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared5455d199d07ea329Conclusion
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
    public static class AutoSDKShared5455d199d07ea329ConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared5455d199d07ea329Conclusion value)
        {
            return value switch
            {
                AutoSDKShared5455d199d07ea329Conclusion.Canceled => "canceled",
                AutoSDKShared5455d199d07ea329Conclusion.Failed => "failed",
                AutoSDKShared5455d199d07ea329Conclusion.Neutral => "neutral",
                AutoSDKShared5455d199d07ea329Conclusion.Skipped => "skipped",
                AutoSDKShared5455d199d07ea329Conclusion.Succeeded => "succeeded",
                AutoSDKShared5455d199d07ea329Conclusion.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared5455d199d07ea329Conclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => AutoSDKShared5455d199d07ea329Conclusion.Canceled,
                "failed" => AutoSDKShared5455d199d07ea329Conclusion.Failed,
                "neutral" => AutoSDKShared5455d199d07ea329Conclusion.Neutral,
                "skipped" => AutoSDKShared5455d199d07ea329Conclusion.Skipped,
                "succeeded" => AutoSDKShared5455d199d07ea329Conclusion.Succeeded,
                "timeout" => AutoSDKShared5455d199d07ea329Conclusion.Timeout,
                _ => null,
            };
        }
    }
}