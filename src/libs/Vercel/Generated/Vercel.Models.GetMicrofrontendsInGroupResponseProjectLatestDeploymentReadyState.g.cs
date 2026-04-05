
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectLatestDeploymentReadyState
    {
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
    public static class GetMicrofrontendsInGroupResponseProjectLatestDeploymentReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectLatestDeploymentReadyState value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectLatestDeploymentReadyState.Building => "BUILDING",
                GetMicrofrontendsInGroupResponseProjectLatestDeploymentReadyState.Canceled => "CANCELED",
                GetMicrofrontendsInGroupResponseProjectLatestDeploymentReadyState.Error => "ERROR",
                GetMicrofrontendsInGroupResponseProjectLatestDeploymentReadyState.Initializing => "INITIALIZING",
                GetMicrofrontendsInGroupResponseProjectLatestDeploymentReadyState.Queued => "QUEUED",
                GetMicrofrontendsInGroupResponseProjectLatestDeploymentReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectLatestDeploymentReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BUILDING" => GetMicrofrontendsInGroupResponseProjectLatestDeploymentReadyState.Building,
                "CANCELED" => GetMicrofrontendsInGroupResponseProjectLatestDeploymentReadyState.Canceled,
                "ERROR" => GetMicrofrontendsInGroupResponseProjectLatestDeploymentReadyState.Error,
                "INITIALIZING" => GetMicrofrontendsInGroupResponseProjectLatestDeploymentReadyState.Initializing,
                "QUEUED" => GetMicrofrontendsInGroupResponseProjectLatestDeploymentReadyState.Queued,
                "READY" => GetMicrofrontendsInGroupResponseProjectLatestDeploymentReadyState.Ready,
                _ => null,
            };
        }
    }
}