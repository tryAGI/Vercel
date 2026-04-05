
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListDeploymentCheckRunsResponseRunStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListDeploymentCheckRunsResponseRunStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListDeploymentCheckRunsResponseRunStatus value)
        {
            return value switch
            {
                ListDeploymentCheckRunsResponseRunStatus.Completed => "completed",
                ListDeploymentCheckRunsResponseRunStatus.Queued => "queued",
                ListDeploymentCheckRunsResponseRunStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListDeploymentCheckRunsResponseRunStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ListDeploymentCheckRunsResponseRunStatus.Completed,
                "queued" => ListDeploymentCheckRunsResponseRunStatus.Queued,
                "running" => ListDeploymentCheckRunsResponseRunStatus.Running,
                _ => null,
            };
        }
    }
}