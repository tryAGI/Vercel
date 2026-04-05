
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The state of the deployment depending on the process of deploying, or if it is ready or in an error state<br/>
    /// Example: READY
    /// </summary>
    public enum GetRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState
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
    public static class GetRollingReleaseResponseRollingReleaseCurrentDeploymentReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState value)
        {
            return value switch
            {
                GetRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState.Building => "BUILDING",
                GetRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState.Canceled => "CANCELED",
                GetRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState.Error => "ERROR",
                GetRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState.Initializing => "INITIALIZING",
                GetRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState.Queued => "QUEUED",
                GetRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BUILDING" => GetRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState.Building,
                "CANCELED" => GetRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState.Canceled,
                "ERROR" => GetRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState.Error,
                "INITIALIZING" => GetRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState.Initializing,
                "QUEUED" => GetRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState.Queued,
                "READY" => GetRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState.Ready,
                _ => null,
            };
        }
    }
}