
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListCheckRunsResponseRunConclusion
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
    public static class ListCheckRunsResponseRunConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListCheckRunsResponseRunConclusion value)
        {
            return value switch
            {
                ListCheckRunsResponseRunConclusion.Canceled => "canceled",
                ListCheckRunsResponseRunConclusion.Failed => "failed",
                ListCheckRunsResponseRunConclusion.Neutral => "neutral",
                ListCheckRunsResponseRunConclusion.Skipped => "skipped",
                ListCheckRunsResponseRunConclusion.Succeeded => "succeeded",
                ListCheckRunsResponseRunConclusion.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListCheckRunsResponseRunConclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => ListCheckRunsResponseRunConclusion.Canceled,
                "failed" => ListCheckRunsResponseRunConclusion.Failed,
                "neutral" => ListCheckRunsResponseRunConclusion.Neutral,
                "skipped" => ListCheckRunsResponseRunConclusion.Skipped,
                "succeeded" => ListCheckRunsResponseRunConclusion.Succeeded,
                "timeout" => ListCheckRunsResponseRunConclusion.Timeout,
                _ => null,
            };
        }
    }
}