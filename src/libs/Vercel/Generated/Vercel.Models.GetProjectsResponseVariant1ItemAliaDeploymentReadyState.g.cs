
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant1ItemAliaDeploymentReadyState
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
    public static class GetProjectsResponseVariant1ItemAliaDeploymentReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemAliaDeploymentReadyState value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemAliaDeploymentReadyState.Blocked => "BLOCKED",
                GetProjectsResponseVariant1ItemAliaDeploymentReadyState.Building => "BUILDING",
                GetProjectsResponseVariant1ItemAliaDeploymentReadyState.Canceled => "CANCELED",
                GetProjectsResponseVariant1ItemAliaDeploymentReadyState.Error => "ERROR",
                GetProjectsResponseVariant1ItemAliaDeploymentReadyState.Initializing => "INITIALIZING",
                GetProjectsResponseVariant1ItemAliaDeploymentReadyState.Queued => "QUEUED",
                GetProjectsResponseVariant1ItemAliaDeploymentReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemAliaDeploymentReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BLOCKED" => GetProjectsResponseVariant1ItemAliaDeploymentReadyState.Blocked,
                "BUILDING" => GetProjectsResponseVariant1ItemAliaDeploymentReadyState.Building,
                "CANCELED" => GetProjectsResponseVariant1ItemAliaDeploymentReadyState.Canceled,
                "ERROR" => GetProjectsResponseVariant1ItemAliaDeploymentReadyState.Error,
                "INITIALIZING" => GetProjectsResponseVariant1ItemAliaDeploymentReadyState.Initializing,
                "QUEUED" => GetProjectsResponseVariant1ItemAliaDeploymentReadyState.Queued,
                "READY" => GetProjectsResponseVariant1ItemAliaDeploymentReadyState.Ready,
                _ => null,
            };
        }
    }
}