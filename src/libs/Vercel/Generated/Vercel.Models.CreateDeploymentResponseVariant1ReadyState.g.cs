
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The state of the deployment depending on the process of deploying, or if it is ready or in an error state<br/>
    /// Example: READY
    /// </summary>
    public enum CreateDeploymentResponseVariant1ReadyState
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
    public static class CreateDeploymentResponseVariant1ReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant1ReadyState value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant1ReadyState.Blocked => "BLOCKED",
                CreateDeploymentResponseVariant1ReadyState.Building => "BUILDING",
                CreateDeploymentResponseVariant1ReadyState.Canceled => "CANCELED",
                CreateDeploymentResponseVariant1ReadyState.Error => "ERROR",
                CreateDeploymentResponseVariant1ReadyState.Initializing => "INITIALIZING",
                CreateDeploymentResponseVariant1ReadyState.Queued => "QUEUED",
                CreateDeploymentResponseVariant1ReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant1ReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BLOCKED" => CreateDeploymentResponseVariant1ReadyState.Blocked,
                "BUILDING" => CreateDeploymentResponseVariant1ReadyState.Building,
                "CANCELED" => CreateDeploymentResponseVariant1ReadyState.Canceled,
                "ERROR" => CreateDeploymentResponseVariant1ReadyState.Error,
                "INITIALIZING" => CreateDeploymentResponseVariant1ReadyState.Initializing,
                "QUEUED" => CreateDeploymentResponseVariant1ReadyState.Queued,
                "READY" => CreateDeploymentResponseVariant1ReadyState.Ready,
                _ => null,
            };
        }
    }
}