
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The state of the deployment depending on the process of deploying, or if it is ready or in an error state<br/>
    /// Example: READY
    /// </summary>
    public enum StartRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState
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
    public static class StartRollingReleaseResponseRollingReleaseCurrentDeploymentReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StartRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState value)
        {
            return value switch
            {
                StartRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState.Blocked => "BLOCKED",
                StartRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState.Building => "BUILDING",
                StartRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState.Canceled => "CANCELED",
                StartRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState.Error => "ERROR",
                StartRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState.Initializing => "INITIALIZING",
                StartRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState.Queued => "QUEUED",
                StartRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StartRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BLOCKED" => StartRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState.Blocked,
                "BUILDING" => StartRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState.Building,
                "CANCELED" => StartRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState.Canceled,
                "ERROR" => StartRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState.Error,
                "INITIALIZING" => StartRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState.Initializing,
                "QUEUED" => StartRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState.Queued,
                "READY" => StartRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState.Ready,
                _ => null,
            };
        }
    }
}