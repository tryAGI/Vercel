
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListDeploymentCheckRunsResponseRunVariant1Conclusion
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
    public static class ListDeploymentCheckRunsResponseRunVariant1ConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListDeploymentCheckRunsResponseRunVariant1Conclusion value)
        {
            return value switch
            {
                ListDeploymentCheckRunsResponseRunVariant1Conclusion.Canceled => "canceled",
                ListDeploymentCheckRunsResponseRunVariant1Conclusion.Failed => "failed",
                ListDeploymentCheckRunsResponseRunVariant1Conclusion.Neutral => "neutral",
                ListDeploymentCheckRunsResponseRunVariant1Conclusion.Skipped => "skipped",
                ListDeploymentCheckRunsResponseRunVariant1Conclusion.Succeeded => "succeeded",
                ListDeploymentCheckRunsResponseRunVariant1Conclusion.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListDeploymentCheckRunsResponseRunVariant1Conclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => ListDeploymentCheckRunsResponseRunVariant1Conclusion.Canceled,
                "failed" => ListDeploymentCheckRunsResponseRunVariant1Conclusion.Failed,
                "neutral" => ListDeploymentCheckRunsResponseRunVariant1Conclusion.Neutral,
                "skipped" => ListDeploymentCheckRunsResponseRunVariant1Conclusion.Skipped,
                "succeeded" => ListDeploymentCheckRunsResponseRunVariant1Conclusion.Succeeded,
                "timeout" => ListDeploymentCheckRunsResponseRunVariant1Conclusion.Timeout,
                _ => null,
            };
        }
    }
}