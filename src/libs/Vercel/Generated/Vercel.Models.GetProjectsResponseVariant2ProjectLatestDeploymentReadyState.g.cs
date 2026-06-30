
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectLatestDeploymentReadyState
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
    public static class GetProjectsResponseVariant2ProjectLatestDeploymentReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectLatestDeploymentReadyState value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectLatestDeploymentReadyState.Blocked => "BLOCKED",
                GetProjectsResponseVariant2ProjectLatestDeploymentReadyState.Building => "BUILDING",
                GetProjectsResponseVariant2ProjectLatestDeploymentReadyState.Canceled => "CANCELED",
                GetProjectsResponseVariant2ProjectLatestDeploymentReadyState.Error => "ERROR",
                GetProjectsResponseVariant2ProjectLatestDeploymentReadyState.Initializing => "INITIALIZING",
                GetProjectsResponseVariant2ProjectLatestDeploymentReadyState.Queued => "QUEUED",
                GetProjectsResponseVariant2ProjectLatestDeploymentReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectLatestDeploymentReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BLOCKED" => GetProjectsResponseVariant2ProjectLatestDeploymentReadyState.Blocked,
                "BUILDING" => GetProjectsResponseVariant2ProjectLatestDeploymentReadyState.Building,
                "CANCELED" => GetProjectsResponseVariant2ProjectLatestDeploymentReadyState.Canceled,
                "ERROR" => GetProjectsResponseVariant2ProjectLatestDeploymentReadyState.Error,
                "INITIALIZING" => GetProjectsResponseVariant2ProjectLatestDeploymentReadyState.Initializing,
                "QUEUED" => GetProjectsResponseVariant2ProjectLatestDeploymentReadyState.Queued,
                "READY" => GetProjectsResponseVariant2ProjectLatestDeploymentReadyState.Ready,
                _ => null,
            };
        }
    }
}