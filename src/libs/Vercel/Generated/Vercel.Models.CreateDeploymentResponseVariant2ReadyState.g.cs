
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The state of the deployment depending on the process of deploying, or if it is ready or in an error state<br/>
    /// Example: READY
    /// </summary>
    public enum CreateDeploymentResponseVariant2ReadyState
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
    public static class CreateDeploymentResponseVariant2ReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant2ReadyState value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant2ReadyState.Blocked => "BLOCKED",
                CreateDeploymentResponseVariant2ReadyState.Building => "BUILDING",
                CreateDeploymentResponseVariant2ReadyState.Canceled => "CANCELED",
                CreateDeploymentResponseVariant2ReadyState.Error => "ERROR",
                CreateDeploymentResponseVariant2ReadyState.Initializing => "INITIALIZING",
                CreateDeploymentResponseVariant2ReadyState.Queued => "QUEUED",
                CreateDeploymentResponseVariant2ReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant2ReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BLOCKED" => CreateDeploymentResponseVariant2ReadyState.Blocked,
                "BUILDING" => CreateDeploymentResponseVariant2ReadyState.Building,
                "CANCELED" => CreateDeploymentResponseVariant2ReadyState.Canceled,
                "ERROR" => CreateDeploymentResponseVariant2ReadyState.Error,
                "INITIALIZING" => CreateDeploymentResponseVariant2ReadyState.Initializing,
                "QUEUED" => CreateDeploymentResponseVariant2ReadyState.Queued,
                "READY" => CreateDeploymentResponseVariant2ReadyState.Ready,
                _ => null,
            };
        }
    }
}