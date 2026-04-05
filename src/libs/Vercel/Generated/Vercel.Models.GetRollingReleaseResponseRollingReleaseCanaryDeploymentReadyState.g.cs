
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The state of the deployment depending on the process of deploying, or if it is ready or in an error state<br/>
    /// Example: READY
    /// </summary>
    public enum GetRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState
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
    public static class GetRollingReleaseResponseRollingReleaseCanaryDeploymentReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState value)
        {
            return value switch
            {
                GetRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState.Building => "BUILDING",
                GetRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState.Canceled => "CANCELED",
                GetRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState.Error => "ERROR",
                GetRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState.Initializing => "INITIALIZING",
                GetRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState.Queued => "QUEUED",
                GetRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BUILDING" => GetRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState.Building,
                "CANCELED" => GetRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState.Canceled,
                "ERROR" => GetRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState.Error,
                "INITIALIZING" => GetRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState.Initializing,
                "QUEUED" => GetRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState.Queued,
                "READY" => GetRollingReleaseResponseRollingReleaseCanaryDeploymentReadyState.Ready,
                _ => null,
            };
        }
    }
}