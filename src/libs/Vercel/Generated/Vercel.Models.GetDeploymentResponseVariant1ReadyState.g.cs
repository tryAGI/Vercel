
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The state of the deployment depending on the process of deploying, or if it is ready or in an error state<br/>
    /// Example: READY
    /// </summary>
    public enum GetDeploymentResponseVariant1ReadyState
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
    public static class GetDeploymentResponseVariant1ReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant1ReadyState value)
        {
            return value switch
            {
                GetDeploymentResponseVariant1ReadyState.Building => "BUILDING",
                GetDeploymentResponseVariant1ReadyState.Canceled => "CANCELED",
                GetDeploymentResponseVariant1ReadyState.Error => "ERROR",
                GetDeploymentResponseVariant1ReadyState.Initializing => "INITIALIZING",
                GetDeploymentResponseVariant1ReadyState.Queued => "QUEUED",
                GetDeploymentResponseVariant1ReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant1ReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BUILDING" => GetDeploymentResponseVariant1ReadyState.Building,
                "CANCELED" => GetDeploymentResponseVariant1ReadyState.Canceled,
                "ERROR" => GetDeploymentResponseVariant1ReadyState.Error,
                "INITIALIZING" => GetDeploymentResponseVariant1ReadyState.Initializing,
                "QUEUED" => GetDeploymentResponseVariant1ReadyState.Queued,
                "READY" => GetDeploymentResponseVariant1ReadyState.Ready,
                _ => null,
            };
        }
    }
}