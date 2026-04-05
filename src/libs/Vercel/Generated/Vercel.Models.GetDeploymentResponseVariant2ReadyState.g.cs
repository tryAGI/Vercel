
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The state of the deployment depending on the process of deploying, or if it is ready or in an error state<br/>
    /// Example: READY
    /// </summary>
    public enum GetDeploymentResponseVariant2ReadyState
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
    public static class GetDeploymentResponseVariant2ReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant2ReadyState value)
        {
            return value switch
            {
                GetDeploymentResponseVariant2ReadyState.Building => "BUILDING",
                GetDeploymentResponseVariant2ReadyState.Canceled => "CANCELED",
                GetDeploymentResponseVariant2ReadyState.Error => "ERROR",
                GetDeploymentResponseVariant2ReadyState.Initializing => "INITIALIZING",
                GetDeploymentResponseVariant2ReadyState.Queued => "QUEUED",
                GetDeploymentResponseVariant2ReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant2ReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BUILDING" => GetDeploymentResponseVariant2ReadyState.Building,
                "CANCELED" => GetDeploymentResponseVariant2ReadyState.Canceled,
                "ERROR" => GetDeploymentResponseVariant2ReadyState.Error,
                "INITIALIZING" => GetDeploymentResponseVariant2ReadyState.Initializing,
                "QUEUED" => GetDeploymentResponseVariant2ReadyState.Queued,
                "READY" => GetDeploymentResponseVariant2ReadyState.Ready,
                _ => null,
            };
        }
    }
}