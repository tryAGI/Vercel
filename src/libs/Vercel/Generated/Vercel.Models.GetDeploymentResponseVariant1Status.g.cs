
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant1Status
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
    public static class GetDeploymentResponseVariant1StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant1Status value)
        {
            return value switch
            {
                GetDeploymentResponseVariant1Status.Building => "BUILDING",
                GetDeploymentResponseVariant1Status.Canceled => "CANCELED",
                GetDeploymentResponseVariant1Status.Error => "ERROR",
                GetDeploymentResponseVariant1Status.Initializing => "INITIALIZING",
                GetDeploymentResponseVariant1Status.Queued => "QUEUED",
                GetDeploymentResponseVariant1Status.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant1Status? ToEnum(string value)
        {
            return value switch
            {
                "BUILDING" => GetDeploymentResponseVariant1Status.Building,
                "CANCELED" => GetDeploymentResponseVariant1Status.Canceled,
                "ERROR" => GetDeploymentResponseVariant1Status.Error,
                "INITIALIZING" => GetDeploymentResponseVariant1Status.Initializing,
                "QUEUED" => GetDeploymentResponseVariant1Status.Queued,
                "READY" => GetDeploymentResponseVariant1Status.Ready,
                _ => null,
            };
        }
    }
}