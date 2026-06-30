
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectLatestDeploymentReadyState
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
    public static class GetProjectsResponseVariant3ProjectLatestDeploymentReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectLatestDeploymentReadyState value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectLatestDeploymentReadyState.Blocked => "BLOCKED",
                GetProjectsResponseVariant3ProjectLatestDeploymentReadyState.Building => "BUILDING",
                GetProjectsResponseVariant3ProjectLatestDeploymentReadyState.Canceled => "CANCELED",
                GetProjectsResponseVariant3ProjectLatestDeploymentReadyState.Error => "ERROR",
                GetProjectsResponseVariant3ProjectLatestDeploymentReadyState.Initializing => "INITIALIZING",
                GetProjectsResponseVariant3ProjectLatestDeploymentReadyState.Queued => "QUEUED",
                GetProjectsResponseVariant3ProjectLatestDeploymentReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectLatestDeploymentReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BLOCKED" => GetProjectsResponseVariant3ProjectLatestDeploymentReadyState.Blocked,
                "BUILDING" => GetProjectsResponseVariant3ProjectLatestDeploymentReadyState.Building,
                "CANCELED" => GetProjectsResponseVariant3ProjectLatestDeploymentReadyState.Canceled,
                "ERROR" => GetProjectsResponseVariant3ProjectLatestDeploymentReadyState.Error,
                "INITIALIZING" => GetProjectsResponseVariant3ProjectLatestDeploymentReadyState.Initializing,
                "QUEUED" => GetProjectsResponseVariant3ProjectLatestDeploymentReadyState.Queued,
                "READY" => GetProjectsResponseVariant3ProjectLatestDeploymentReadyState.Ready,
                _ => null,
            };
        }
    }
}