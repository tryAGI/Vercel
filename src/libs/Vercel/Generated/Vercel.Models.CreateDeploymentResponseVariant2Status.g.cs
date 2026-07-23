
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseVariant2Status
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
    public static class CreateDeploymentResponseVariant2StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant2Status value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant2Status.Blocked => "BLOCKED",
                CreateDeploymentResponseVariant2Status.Building => "BUILDING",
                CreateDeploymentResponseVariant2Status.Canceled => "CANCELED",
                CreateDeploymentResponseVariant2Status.Error => "ERROR",
                CreateDeploymentResponseVariant2Status.Initializing => "INITIALIZING",
                CreateDeploymentResponseVariant2Status.Queued => "QUEUED",
                CreateDeploymentResponseVariant2Status.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant2Status? ToEnum(string value)
        {
            return value switch
            {
                "BLOCKED" => CreateDeploymentResponseVariant2Status.Blocked,
                "BUILDING" => CreateDeploymentResponseVariant2Status.Building,
                "CANCELED" => CreateDeploymentResponseVariant2Status.Canceled,
                "ERROR" => CreateDeploymentResponseVariant2Status.Error,
                "INITIALIZING" => CreateDeploymentResponseVariant2Status.Initializing,
                "QUEUED" => CreateDeploymentResponseVariant2Status.Queued,
                "READY" => CreateDeploymentResponseVariant2Status.Ready,
                _ => null,
            };
        }
    }
}