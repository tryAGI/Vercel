
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListCheckRunsResponseRunVariant1Conclusion
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
    public static class ListCheckRunsResponseRunVariant1ConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListCheckRunsResponseRunVariant1Conclusion value)
        {
            return value switch
            {
                ListCheckRunsResponseRunVariant1Conclusion.Canceled => "canceled",
                ListCheckRunsResponseRunVariant1Conclusion.Failed => "failed",
                ListCheckRunsResponseRunVariant1Conclusion.Neutral => "neutral",
                ListCheckRunsResponseRunVariant1Conclusion.Skipped => "skipped",
                ListCheckRunsResponseRunVariant1Conclusion.Succeeded => "succeeded",
                ListCheckRunsResponseRunVariant1Conclusion.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListCheckRunsResponseRunVariant1Conclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => ListCheckRunsResponseRunVariant1Conclusion.Canceled,
                "failed" => ListCheckRunsResponseRunVariant1Conclusion.Failed,
                "neutral" => ListCheckRunsResponseRunVariant1Conclusion.Neutral,
                "skipped" => ListCheckRunsResponseRunVariant1Conclusion.Skipped,
                "succeeded" => ListCheckRunsResponseRunVariant1Conclusion.Succeeded,
                "timeout" => ListCheckRunsResponseRunVariant1Conclusion.Timeout,
                _ => null,
            };
        }
    }
}