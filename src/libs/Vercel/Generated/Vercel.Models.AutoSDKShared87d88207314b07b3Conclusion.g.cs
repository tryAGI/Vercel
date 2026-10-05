
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared87d88207314b07b3Conclusion
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
    public static class AutoSDKShared87d88207314b07b3ConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared87d88207314b07b3Conclusion value)
        {
            return value switch
            {
                AutoSDKShared87d88207314b07b3Conclusion.Canceled => "canceled",
                AutoSDKShared87d88207314b07b3Conclusion.Failed => "failed",
                AutoSDKShared87d88207314b07b3Conclusion.Neutral => "neutral",
                AutoSDKShared87d88207314b07b3Conclusion.Skipped => "skipped",
                AutoSDKShared87d88207314b07b3Conclusion.Succeeded => "succeeded",
                AutoSDKShared87d88207314b07b3Conclusion.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared87d88207314b07b3Conclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => AutoSDKShared87d88207314b07b3Conclusion.Canceled,
                "failed" => AutoSDKShared87d88207314b07b3Conclusion.Failed,
                "neutral" => AutoSDKShared87d88207314b07b3Conclusion.Neutral,
                "skipped" => AutoSDKShared87d88207314b07b3Conclusion.Skipped,
                "succeeded" => AutoSDKShared87d88207314b07b3Conclusion.Succeeded,
                "timeout" => AutoSDKShared87d88207314b07b3Conclusion.Timeout,
                _ => null,
            };
        }
    }
}