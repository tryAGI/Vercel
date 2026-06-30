
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectAliaDeploymentReadyState
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
    public static class GetMicrofrontendsInGroupResponseProjectAliaDeploymentReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectAliaDeploymentReadyState value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectAliaDeploymentReadyState.Blocked => "BLOCKED",
                GetMicrofrontendsInGroupResponseProjectAliaDeploymentReadyState.Building => "BUILDING",
                GetMicrofrontendsInGroupResponseProjectAliaDeploymentReadyState.Canceled => "CANCELED",
                GetMicrofrontendsInGroupResponseProjectAliaDeploymentReadyState.Error => "ERROR",
                GetMicrofrontendsInGroupResponseProjectAliaDeploymentReadyState.Initializing => "INITIALIZING",
                GetMicrofrontendsInGroupResponseProjectAliaDeploymentReadyState.Queued => "QUEUED",
                GetMicrofrontendsInGroupResponseProjectAliaDeploymentReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectAliaDeploymentReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BLOCKED" => GetMicrofrontendsInGroupResponseProjectAliaDeploymentReadyState.Blocked,
                "BUILDING" => GetMicrofrontendsInGroupResponseProjectAliaDeploymentReadyState.Building,
                "CANCELED" => GetMicrofrontendsInGroupResponseProjectAliaDeploymentReadyState.Canceled,
                "ERROR" => GetMicrofrontendsInGroupResponseProjectAliaDeploymentReadyState.Error,
                "INITIALIZING" => GetMicrofrontendsInGroupResponseProjectAliaDeploymentReadyState.Initializing,
                "QUEUED" => GetMicrofrontendsInGroupResponseProjectAliaDeploymentReadyState.Queued,
                "READY" => GetMicrofrontendsInGroupResponseProjectAliaDeploymentReadyState.Ready,
                _ => null,
            };
        }
    }
}