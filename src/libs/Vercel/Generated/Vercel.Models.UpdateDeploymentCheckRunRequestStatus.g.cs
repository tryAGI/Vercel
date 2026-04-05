
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateDeploymentCheckRunRequestStatus
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
    public static class UpdateDeploymentCheckRunRequestStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDeploymentCheckRunRequestStatus value)
        {
            return value switch
            {
                UpdateDeploymentCheckRunRequestStatus.Completed => "completed",
                UpdateDeploymentCheckRunRequestStatus.Queued => "queued",
                UpdateDeploymentCheckRunRequestStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDeploymentCheckRunRequestStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => UpdateDeploymentCheckRunRequestStatus.Completed,
                "queued" => UpdateDeploymentCheckRunRequestStatus.Queued,
                "running" => UpdateDeploymentCheckRunRequestStatus.Running,
                _ => null,
            };
        }
    }
}