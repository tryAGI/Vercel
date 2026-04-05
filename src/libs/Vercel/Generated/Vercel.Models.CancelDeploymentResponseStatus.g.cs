
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CancelDeploymentResponseStatus
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
    public static class CancelDeploymentResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseStatus value)
        {
            return value switch
            {
                CancelDeploymentResponseStatus.Building => "BUILDING",
                CancelDeploymentResponseStatus.Canceled => "CANCELED",
                CancelDeploymentResponseStatus.Error => "ERROR",
                CancelDeploymentResponseStatus.Initializing => "INITIALIZING",
                CancelDeploymentResponseStatus.Queued => "QUEUED",
                CancelDeploymentResponseStatus.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "BUILDING" => CancelDeploymentResponseStatus.Building,
                "CANCELED" => CancelDeploymentResponseStatus.Canceled,
                "ERROR" => CancelDeploymentResponseStatus.Error,
                "INITIALIZING" => CancelDeploymentResponseStatus.Initializing,
                "QUEUED" => CancelDeploymentResponseStatus.Queued,
                "READY" => CancelDeploymentResponseStatus.Ready,
                _ => null,
            };
        }
    }
}