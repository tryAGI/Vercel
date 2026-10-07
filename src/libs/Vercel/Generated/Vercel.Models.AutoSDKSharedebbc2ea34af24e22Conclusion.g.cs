
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedebbc2ea34af24e22Conclusion
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
    public static class AutoSDKSharedebbc2ea34af24e22ConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedebbc2ea34af24e22Conclusion value)
        {
            return value switch
            {
                AutoSDKSharedebbc2ea34af24e22Conclusion.Canceled => "canceled",
                AutoSDKSharedebbc2ea34af24e22Conclusion.Failed => "failed",
                AutoSDKSharedebbc2ea34af24e22Conclusion.Neutral => "neutral",
                AutoSDKSharedebbc2ea34af24e22Conclusion.Skipped => "skipped",
                AutoSDKSharedebbc2ea34af24e22Conclusion.Succeeded => "succeeded",
                AutoSDKSharedebbc2ea34af24e22Conclusion.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedebbc2ea34af24e22Conclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => AutoSDKSharedebbc2ea34af24e22Conclusion.Canceled,
                "failed" => AutoSDKSharedebbc2ea34af24e22Conclusion.Failed,
                "neutral" => AutoSDKSharedebbc2ea34af24e22Conclusion.Neutral,
                "skipped" => AutoSDKSharedebbc2ea34af24e22Conclusion.Skipped,
                "succeeded" => AutoSDKSharedebbc2ea34af24e22Conclusion.Succeeded,
                "timeout" => AutoSDKSharedebbc2ea34af24e22Conclusion.Timeout,
                _ => null,
            };
        }
    }
}