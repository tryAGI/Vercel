
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The state of the deployment depending on the process of deploying, or if it is ready or in an error state<br/>
    /// Example: READY
    /// </summary>
    public enum CreateDeploymentResponseReadyState
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
    public static class CreateDeploymentResponseReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseReadyState value)
        {
            return value switch
            {
                CreateDeploymentResponseReadyState.Building => "BUILDING",
                CreateDeploymentResponseReadyState.Canceled => "CANCELED",
                CreateDeploymentResponseReadyState.Error => "ERROR",
                CreateDeploymentResponseReadyState.Initializing => "INITIALIZING",
                CreateDeploymentResponseReadyState.Queued => "QUEUED",
                CreateDeploymentResponseReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BUILDING" => CreateDeploymentResponseReadyState.Building,
                "CANCELED" => CreateDeploymentResponseReadyState.Canceled,
                "ERROR" => CreateDeploymentResponseReadyState.Error,
                "INITIALIZING" => CreateDeploymentResponseReadyState.Initializing,
                "QUEUED" => CreateDeploymentResponseReadyState.Queued,
                "READY" => CreateDeploymentResponseReadyState.Ready,
                _ => null,
            };
        }
    }
}