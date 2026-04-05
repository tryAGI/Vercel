
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListDeploymentCheckRunsResponseRunConclusion
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
    public static class ListDeploymentCheckRunsResponseRunConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListDeploymentCheckRunsResponseRunConclusion value)
        {
            return value switch
            {
                ListDeploymentCheckRunsResponseRunConclusion.Canceled => "canceled",
                ListDeploymentCheckRunsResponseRunConclusion.Failed => "failed",
                ListDeploymentCheckRunsResponseRunConclusion.Neutral => "neutral",
                ListDeploymentCheckRunsResponseRunConclusion.Skipped => "skipped",
                ListDeploymentCheckRunsResponseRunConclusion.Succeeded => "succeeded",
                ListDeploymentCheckRunsResponseRunConclusion.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListDeploymentCheckRunsResponseRunConclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => ListDeploymentCheckRunsResponseRunConclusion.Canceled,
                "failed" => ListDeploymentCheckRunsResponseRunConclusion.Failed,
                "neutral" => ListDeploymentCheckRunsResponseRunConclusion.Neutral,
                "skipped" => ListDeploymentCheckRunsResponseRunConclusion.Skipped,
                "succeeded" => ListDeploymentCheckRunsResponseRunConclusion.Succeeded,
                "timeout" => ListDeploymentCheckRunsResponseRunConclusion.Timeout,
                _ => null,
            };
        }
    }
}