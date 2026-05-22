
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListCheckRunsResponseRunVariant2Conclusion
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
    public static class ListCheckRunsResponseRunVariant2ConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListCheckRunsResponseRunVariant2Conclusion value)
        {
            return value switch
            {
                ListCheckRunsResponseRunVariant2Conclusion.Canceled => "canceled",
                ListCheckRunsResponseRunVariant2Conclusion.Failed => "failed",
                ListCheckRunsResponseRunVariant2Conclusion.Neutral => "neutral",
                ListCheckRunsResponseRunVariant2Conclusion.Skipped => "skipped",
                ListCheckRunsResponseRunVariant2Conclusion.Succeeded => "succeeded",
                ListCheckRunsResponseRunVariant2Conclusion.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListCheckRunsResponseRunVariant2Conclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => ListCheckRunsResponseRunVariant2Conclusion.Canceled,
                "failed" => ListCheckRunsResponseRunVariant2Conclusion.Failed,
                "neutral" => ListCheckRunsResponseRunVariant2Conclusion.Neutral,
                "skipped" => ListCheckRunsResponseRunVariant2Conclusion.Skipped,
                "succeeded" => ListCheckRunsResponseRunVariant2Conclusion.Succeeded,
                "timeout" => ListCheckRunsResponseRunVariant2Conclusion.Timeout,
                _ => null,
            };
        }
    }
}