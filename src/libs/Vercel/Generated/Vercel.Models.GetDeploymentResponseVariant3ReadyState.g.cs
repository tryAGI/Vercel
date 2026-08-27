
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The state of the deployment depending on the process of deploying, or if it is ready or in an error state<br/>
    /// Example: READY
    /// </summary>
    public enum GetDeploymentResponseVariant3ReadyState
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
    public static class GetDeploymentResponseVariant3ReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant3ReadyState value)
        {
            return value switch
            {
                GetDeploymentResponseVariant3ReadyState.Blocked => "BLOCKED",
                GetDeploymentResponseVariant3ReadyState.Building => "BUILDING",
                GetDeploymentResponseVariant3ReadyState.Canceled => "CANCELED",
                GetDeploymentResponseVariant3ReadyState.Error => "ERROR",
                GetDeploymentResponseVariant3ReadyState.Initializing => "INITIALIZING",
                GetDeploymentResponseVariant3ReadyState.Queued => "QUEUED",
                GetDeploymentResponseVariant3ReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant3ReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BLOCKED" => GetDeploymentResponseVariant3ReadyState.Blocked,
                "BUILDING" => GetDeploymentResponseVariant3ReadyState.Building,
                "CANCELED" => GetDeploymentResponseVariant3ReadyState.Canceled,
                "ERROR" => GetDeploymentResponseVariant3ReadyState.Error,
                "INITIALIZING" => GetDeploymentResponseVariant3ReadyState.Initializing,
                "QUEUED" => GetDeploymentResponseVariant3ReadyState.Queued,
                "READY" => GetDeploymentResponseVariant3ReadyState.Ready,
                _ => null,
            };
        }
    }
}