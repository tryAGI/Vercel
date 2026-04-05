
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateDeploymentCheckRunResponseStatus
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
    public static class UpdateDeploymentCheckRunResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDeploymentCheckRunResponseStatus value)
        {
            return value switch
            {
                UpdateDeploymentCheckRunResponseStatus.Completed => "completed",
                UpdateDeploymentCheckRunResponseStatus.Queued => "queued",
                UpdateDeploymentCheckRunResponseStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDeploymentCheckRunResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => UpdateDeploymentCheckRunResponseStatus.Completed,
                "queued" => UpdateDeploymentCheckRunResponseStatus.Queued,
                "running" => UpdateDeploymentCheckRunResponseStatus.Running,
                _ => null,
            };
        }
    }
}