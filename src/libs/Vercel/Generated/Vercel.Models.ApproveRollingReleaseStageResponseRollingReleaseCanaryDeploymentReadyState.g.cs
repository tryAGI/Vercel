
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The state of the deployment depending on the process of deploying, or if it is ready or in an error state<br/>
    /// Example: READY
    /// </summary>
    public enum ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentReadyState
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
    public static class ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentReadyState value)
        {
            return value switch
            {
                ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentReadyState.Building => "BUILDING",
                ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentReadyState.Canceled => "CANCELED",
                ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentReadyState.Error => "ERROR",
                ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentReadyState.Initializing => "INITIALIZING",
                ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentReadyState.Queued => "QUEUED",
                ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BUILDING" => ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentReadyState.Building,
                "CANCELED" => ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentReadyState.Canceled,
                "ERROR" => ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentReadyState.Error,
                "INITIALIZING" => ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentReadyState.Initializing,
                "QUEUED" => ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentReadyState.Queued,
                "READY" => ApproveRollingReleaseStageResponseRollingReleaseCanaryDeploymentReadyState.Ready,
                _ => null,
            };
        }
    }
}