
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseStatus
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
    public static class CreateDeploymentResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseStatus value)
        {
            return value switch
            {
                CreateDeploymentResponseStatus.Building => "BUILDING",
                CreateDeploymentResponseStatus.Canceled => "CANCELED",
                CreateDeploymentResponseStatus.Error => "ERROR",
                CreateDeploymentResponseStatus.Initializing => "INITIALIZING",
                CreateDeploymentResponseStatus.Queued => "QUEUED",
                CreateDeploymentResponseStatus.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "BUILDING" => CreateDeploymentResponseStatus.Building,
                "CANCELED" => CreateDeploymentResponseStatus.Canceled,
                "ERROR" => CreateDeploymentResponseStatus.Error,
                "INITIALIZING" => CreateDeploymentResponseStatus.Initializing,
                "QUEUED" => CreateDeploymentResponseStatus.Queued,
                "READY" => CreateDeploymentResponseStatus.Ready,
                _ => null,
            };
        }
    }
}