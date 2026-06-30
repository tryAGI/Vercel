
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectAliaDeploymentReadyState
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
    public static class GetProjectsResponseVariant2ProjectAliaDeploymentReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectAliaDeploymentReadyState value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectAliaDeploymentReadyState.Blocked => "BLOCKED",
                GetProjectsResponseVariant2ProjectAliaDeploymentReadyState.Building => "BUILDING",
                GetProjectsResponseVariant2ProjectAliaDeploymentReadyState.Canceled => "CANCELED",
                GetProjectsResponseVariant2ProjectAliaDeploymentReadyState.Error => "ERROR",
                GetProjectsResponseVariant2ProjectAliaDeploymentReadyState.Initializing => "INITIALIZING",
                GetProjectsResponseVariant2ProjectAliaDeploymentReadyState.Queued => "QUEUED",
                GetProjectsResponseVariant2ProjectAliaDeploymentReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectAliaDeploymentReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BLOCKED" => GetProjectsResponseVariant2ProjectAliaDeploymentReadyState.Blocked,
                "BUILDING" => GetProjectsResponseVariant2ProjectAliaDeploymentReadyState.Building,
                "CANCELED" => GetProjectsResponseVariant2ProjectAliaDeploymentReadyState.Canceled,
                "ERROR" => GetProjectsResponseVariant2ProjectAliaDeploymentReadyState.Error,
                "INITIALIZING" => GetProjectsResponseVariant2ProjectAliaDeploymentReadyState.Initializing,
                "QUEUED" => GetProjectsResponseVariant2ProjectAliaDeploymentReadyState.Queued,
                "READY" => GetProjectsResponseVariant2ProjectAliaDeploymentReadyState.Ready,
                _ => null,
            };
        }
    }
}