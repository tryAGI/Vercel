
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant1ItemLatestDeploymentReadyState
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
    public static class GetProjectsResponseVariant1ItemLatestDeploymentReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemLatestDeploymentReadyState value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemLatestDeploymentReadyState.Blocked => "BLOCKED",
                GetProjectsResponseVariant1ItemLatestDeploymentReadyState.Building => "BUILDING",
                GetProjectsResponseVariant1ItemLatestDeploymentReadyState.Canceled => "CANCELED",
                GetProjectsResponseVariant1ItemLatestDeploymentReadyState.Error => "ERROR",
                GetProjectsResponseVariant1ItemLatestDeploymentReadyState.Initializing => "INITIALIZING",
                GetProjectsResponseVariant1ItemLatestDeploymentReadyState.Queued => "QUEUED",
                GetProjectsResponseVariant1ItemLatestDeploymentReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemLatestDeploymentReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BLOCKED" => GetProjectsResponseVariant1ItemLatestDeploymentReadyState.Blocked,
                "BUILDING" => GetProjectsResponseVariant1ItemLatestDeploymentReadyState.Building,
                "CANCELED" => GetProjectsResponseVariant1ItemLatestDeploymentReadyState.Canceled,
                "ERROR" => GetProjectsResponseVariant1ItemLatestDeploymentReadyState.Error,
                "INITIALIZING" => GetProjectsResponseVariant1ItemLatestDeploymentReadyState.Initializing,
                "QUEUED" => GetProjectsResponseVariant1ItemLatestDeploymentReadyState.Queued,
                "READY" => GetProjectsResponseVariant1ItemLatestDeploymentReadyState.Ready,
                _ => null,
            };
        }
    }
}