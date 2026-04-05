
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The state of the deployment depending on the process of deploying, or if it is ready or in an error state<br/>
    /// Example: READY
    /// </summary>
    public enum ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentReadyState
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
    public static class ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentReadyState value)
        {
            return value switch
            {
                ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentReadyState.Building => "BUILDING",
                ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentReadyState.Canceled => "CANCELED",
                ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentReadyState.Error => "ERROR",
                ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentReadyState.Initializing => "INITIALIZING",
                ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentReadyState.Queued => "QUEUED",
                ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BUILDING" => ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentReadyState.Building,
                "CANCELED" => ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentReadyState.Canceled,
                "ERROR" => ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentReadyState.Error,
                "INITIALIZING" => ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentReadyState.Initializing,
                "QUEUED" => ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentReadyState.Queued,
                "READY" => ApproveRollingReleaseStageResponseRollingReleaseCurrentDeploymentReadyState.Ready,
                _ => null,
            };
        }
    }
}