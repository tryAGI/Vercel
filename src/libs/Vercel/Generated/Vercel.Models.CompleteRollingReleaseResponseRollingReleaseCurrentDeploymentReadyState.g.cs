
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The state of the deployment depending on the process of deploying, or if it is ready or in an error state<br/>
    /// Example: READY
    /// </summary>
    public enum CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState
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
    public static class CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState value)
        {
            return value switch
            {
                CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState.Building => "BUILDING",
                CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState.Canceled => "CANCELED",
                CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState.Error => "ERROR",
                CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState.Initializing => "INITIALIZING",
                CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState.Queued => "QUEUED",
                CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BUILDING" => CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState.Building,
                "CANCELED" => CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState.Canceled,
                "ERROR" => CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState.Error,
                "INITIALIZING" => CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState.Initializing,
                "QUEUED" => CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState.Queued,
                "READY" => CompleteRollingReleaseResponseRollingReleaseCurrentDeploymentReadyState.Ready,
                _ => null,
            };
        }
    }
}