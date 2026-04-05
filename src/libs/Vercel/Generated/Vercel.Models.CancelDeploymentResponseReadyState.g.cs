
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The state of the deployment depending on the process of deploying, or if it is ready or in an error state<br/>
    /// Example: READY
    /// </summary>
    public enum CancelDeploymentResponseReadyState
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
    public static class CancelDeploymentResponseReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseReadyState value)
        {
            return value switch
            {
                CancelDeploymentResponseReadyState.Building => "BUILDING",
                CancelDeploymentResponseReadyState.Canceled => "CANCELED",
                CancelDeploymentResponseReadyState.Error => "ERROR",
                CancelDeploymentResponseReadyState.Initializing => "INITIALIZING",
                CancelDeploymentResponseReadyState.Queued => "QUEUED",
                CancelDeploymentResponseReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BUILDING" => CancelDeploymentResponseReadyState.Building,
                "CANCELED" => CancelDeploymentResponseReadyState.Canceled,
                "ERROR" => CancelDeploymentResponseReadyState.Error,
                "INITIALIZING" => CancelDeploymentResponseReadyState.Initializing,
                "QUEUED" => CancelDeploymentResponseReadyState.Queued,
                "READY" => CancelDeploymentResponseReadyState.Ready,
                _ => null,
            };
        }
    }
}