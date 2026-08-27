
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum ListDeploymentCheckRunsResponseRunVariant2Status
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
    public static class ListDeploymentCheckRunsResponseRunVariant2StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListDeploymentCheckRunsResponseRunVariant2Status value)
        {
            return value switch
            {
                ListDeploymentCheckRunsResponseRunVariant2Status.Completed => "completed",
                ListDeploymentCheckRunsResponseRunVariant2Status.Queued => "queued",
                ListDeploymentCheckRunsResponseRunVariant2Status.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListDeploymentCheckRunsResponseRunVariant2Status? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ListDeploymentCheckRunsResponseRunVariant2Status.Completed,
                "queued" => ListDeploymentCheckRunsResponseRunVariant2Status.Queued,
                "running" => ListDeploymentCheckRunsResponseRunVariant2Status.Running,
                _ => null,
            };
        }
    }
}