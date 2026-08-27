
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateProjectResponseLatestDeploymentReadyState
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
    public static class CreateProjectResponseLatestDeploymentReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseLatestDeploymentReadyState value)
        {
            return value switch
            {
                CreateProjectResponseLatestDeploymentReadyState.Blocked => "BLOCKED",
                CreateProjectResponseLatestDeploymentReadyState.Building => "BUILDING",
                CreateProjectResponseLatestDeploymentReadyState.Canceled => "CANCELED",
                CreateProjectResponseLatestDeploymentReadyState.Error => "ERROR",
                CreateProjectResponseLatestDeploymentReadyState.Initializing => "INITIALIZING",
                CreateProjectResponseLatestDeploymentReadyState.Queued => "QUEUED",
                CreateProjectResponseLatestDeploymentReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseLatestDeploymentReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BLOCKED" => CreateProjectResponseLatestDeploymentReadyState.Blocked,
                "BUILDING" => CreateProjectResponseLatestDeploymentReadyState.Building,
                "CANCELED" => CreateProjectResponseLatestDeploymentReadyState.Canceled,
                "ERROR" => CreateProjectResponseLatestDeploymentReadyState.Error,
                "INITIALIZING" => CreateProjectResponseLatestDeploymentReadyState.Initializing,
                "QUEUED" => CreateProjectResponseLatestDeploymentReadyState.Queued,
                "READY" => CreateProjectResponseLatestDeploymentReadyState.Ready,
                _ => null,
            };
        }
    }
}