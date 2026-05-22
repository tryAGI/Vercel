
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListDeploymentCheckRunsResponseRunVariant1Status
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
    public static class ListDeploymentCheckRunsResponseRunVariant1StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListDeploymentCheckRunsResponseRunVariant1Status value)
        {
            return value switch
            {
                ListDeploymentCheckRunsResponseRunVariant1Status.Completed => "completed",
                ListDeploymentCheckRunsResponseRunVariant1Status.Queued => "queued",
                ListDeploymentCheckRunsResponseRunVariant1Status.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListDeploymentCheckRunsResponseRunVariant1Status? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ListDeploymentCheckRunsResponseRunVariant1Status.Completed,
                "queued" => ListDeploymentCheckRunsResponseRunVariant1Status.Queued,
                "running" => ListDeploymentCheckRunsResponseRunVariant1Status.Running,
                _ => null,
            };
        }
    }
}