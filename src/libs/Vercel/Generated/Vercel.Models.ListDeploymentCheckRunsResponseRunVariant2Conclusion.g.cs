
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListDeploymentCheckRunsResponseRunVariant2Conclusion
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
    public static class ListDeploymentCheckRunsResponseRunVariant2ConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListDeploymentCheckRunsResponseRunVariant2Conclusion value)
        {
            return value switch
            {
                ListDeploymentCheckRunsResponseRunVariant2Conclusion.Canceled => "canceled",
                ListDeploymentCheckRunsResponseRunVariant2Conclusion.Failed => "failed",
                ListDeploymentCheckRunsResponseRunVariant2Conclusion.Neutral => "neutral",
                ListDeploymentCheckRunsResponseRunVariant2Conclusion.Skipped => "skipped",
                ListDeploymentCheckRunsResponseRunVariant2Conclusion.Succeeded => "succeeded",
                ListDeploymentCheckRunsResponseRunVariant2Conclusion.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListDeploymentCheckRunsResponseRunVariant2Conclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => ListDeploymentCheckRunsResponseRunVariant2Conclusion.Canceled,
                "failed" => ListDeploymentCheckRunsResponseRunVariant2Conclusion.Failed,
                "neutral" => ListDeploymentCheckRunsResponseRunVariant2Conclusion.Neutral,
                "skipped" => ListDeploymentCheckRunsResponseRunVariant2Conclusion.Skipped,
                "succeeded" => ListDeploymentCheckRunsResponseRunVariant2Conclusion.Succeeded,
                "timeout" => ListDeploymentCheckRunsResponseRunVariant2Conclusion.Timeout,
                _ => null,
            };
        }
    }
}