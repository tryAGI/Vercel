
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseLatestDeploymentReadyState
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
    public static class GetProjectResponseLatestDeploymentReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseLatestDeploymentReadyState value)
        {
            return value switch
            {
                GetProjectResponseLatestDeploymentReadyState.Blocked => "BLOCKED",
                GetProjectResponseLatestDeploymentReadyState.Building => "BUILDING",
                GetProjectResponseLatestDeploymentReadyState.Canceled => "CANCELED",
                GetProjectResponseLatestDeploymentReadyState.Error => "ERROR",
                GetProjectResponseLatestDeploymentReadyState.Initializing => "INITIALIZING",
                GetProjectResponseLatestDeploymentReadyState.Queued => "QUEUED",
                GetProjectResponseLatestDeploymentReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseLatestDeploymentReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BLOCKED" => GetProjectResponseLatestDeploymentReadyState.Blocked,
                "BUILDING" => GetProjectResponseLatestDeploymentReadyState.Building,
                "CANCELED" => GetProjectResponseLatestDeploymentReadyState.Canceled,
                "ERROR" => GetProjectResponseLatestDeploymentReadyState.Error,
                "INITIALIZING" => GetProjectResponseLatestDeploymentReadyState.Initializing,
                "QUEUED" => GetProjectResponseLatestDeploymentReadyState.Queued,
                "READY" => GetProjectResponseLatestDeploymentReadyState.Ready,
                _ => null,
            };
        }
    }
}