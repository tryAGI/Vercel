
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseAliaDeploymentReadyState
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
    public static class UpdateProjectResponseAliaDeploymentReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseAliaDeploymentReadyState value)
        {
            return value switch
            {
                UpdateProjectResponseAliaDeploymentReadyState.Blocked => "BLOCKED",
                UpdateProjectResponseAliaDeploymentReadyState.Building => "BUILDING",
                UpdateProjectResponseAliaDeploymentReadyState.Canceled => "CANCELED",
                UpdateProjectResponseAliaDeploymentReadyState.Error => "ERROR",
                UpdateProjectResponseAliaDeploymentReadyState.Initializing => "INITIALIZING",
                UpdateProjectResponseAliaDeploymentReadyState.Queued => "QUEUED",
                UpdateProjectResponseAliaDeploymentReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseAliaDeploymentReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BLOCKED" => UpdateProjectResponseAliaDeploymentReadyState.Blocked,
                "BUILDING" => UpdateProjectResponseAliaDeploymentReadyState.Building,
                "CANCELED" => UpdateProjectResponseAliaDeploymentReadyState.Canceled,
                "ERROR" => UpdateProjectResponseAliaDeploymentReadyState.Error,
                "INITIALIZING" => UpdateProjectResponseAliaDeploymentReadyState.Initializing,
                "QUEUED" => UpdateProjectResponseAliaDeploymentReadyState.Queued,
                "READY" => UpdateProjectResponseAliaDeploymentReadyState.Ready,
                _ => null,
            };
        }
    }
}