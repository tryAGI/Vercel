
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateProjectResponseLatestDeploymentReadyState
    {
        /// <summary>
        ///
        /// </summary>
        Blocked,
        /// <summary>
        ///
        /// </summary>
        Building,
        /// <summary>
        ///
        /// </summary>
        Canceled,
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        Initializing,
        /// <summary>
        ///
        /// </summary>
        Queued,
        /// <summary>
        ///
        /// </summary>
        Ready,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectResponseLatestDeploymentReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseLatestDeploymentReadyState value)
        {
            return value switch
            {
                UpdateProjectResponseLatestDeploymentReadyState.Blocked => "BLOCKED",
                UpdateProjectResponseLatestDeploymentReadyState.Building => "BUILDING",
                UpdateProjectResponseLatestDeploymentReadyState.Canceled => "CANCELED",
                UpdateProjectResponseLatestDeploymentReadyState.Error => "ERROR",
                UpdateProjectResponseLatestDeploymentReadyState.Initializing => "INITIALIZING",
                UpdateProjectResponseLatestDeploymentReadyState.Queued => "QUEUED",
                UpdateProjectResponseLatestDeploymentReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseLatestDeploymentReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BLOCKED" => UpdateProjectResponseLatestDeploymentReadyState.Blocked,
                "BUILDING" => UpdateProjectResponseLatestDeploymentReadyState.Building,
                "CANCELED" => UpdateProjectResponseLatestDeploymentReadyState.Canceled,
                "ERROR" => UpdateProjectResponseLatestDeploymentReadyState.Error,
                "INITIALIZING" => UpdateProjectResponseLatestDeploymentReadyState.Initializing,
                "QUEUED" => UpdateProjectResponseLatestDeploymentReadyState.Queued,
                "READY" => UpdateProjectResponseLatestDeploymentReadyState.Ready,
                _ => null,
            };
        }
    }
}