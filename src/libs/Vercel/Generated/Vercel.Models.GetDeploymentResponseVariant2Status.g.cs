
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant2Status
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
    public static class GetDeploymentResponseVariant2StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant2Status value)
        {
            return value switch
            {
                GetDeploymentResponseVariant2Status.Building => "BUILDING",
                GetDeploymentResponseVariant2Status.Canceled => "CANCELED",
                GetDeploymentResponseVariant2Status.Error => "ERROR",
                GetDeploymentResponseVariant2Status.Initializing => "INITIALIZING",
                GetDeploymentResponseVariant2Status.Queued => "QUEUED",
                GetDeploymentResponseVariant2Status.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant2Status? ToEnum(string value)
        {
            return value switch
            {
                "BUILDING" => GetDeploymentResponseVariant2Status.Building,
                "CANCELED" => GetDeploymentResponseVariant2Status.Canceled,
                "ERROR" => GetDeploymentResponseVariant2Status.Error,
                "INITIALIZING" => GetDeploymentResponseVariant2Status.Initializing,
                "QUEUED" => GetDeploymentResponseVariant2Status.Queued,
                "READY" => GetDeploymentResponseVariant2Status.Ready,
                _ => null,
            };
        }
    }
}