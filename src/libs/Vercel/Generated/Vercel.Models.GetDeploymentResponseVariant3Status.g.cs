
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetDeploymentResponseVariant3Status
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
    public static class GetDeploymentResponseVariant3StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant3Status value)
        {
            return value switch
            {
                GetDeploymentResponseVariant3Status.Blocked => "BLOCKED",
                GetDeploymentResponseVariant3Status.Building => "BUILDING",
                GetDeploymentResponseVariant3Status.Canceled => "CANCELED",
                GetDeploymentResponseVariant3Status.Error => "ERROR",
                GetDeploymentResponseVariant3Status.Initializing => "INITIALIZING",
                GetDeploymentResponseVariant3Status.Queued => "QUEUED",
                GetDeploymentResponseVariant3Status.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant3Status? ToEnum(string value)
        {
            return value switch
            {
                "BLOCKED" => GetDeploymentResponseVariant3Status.Blocked,
                "BUILDING" => GetDeploymentResponseVariant3Status.Building,
                "CANCELED" => GetDeploymentResponseVariant3Status.Canceled,
                "ERROR" => GetDeploymentResponseVariant3Status.Error,
                "INITIALIZING" => GetDeploymentResponseVariant3Status.Initializing,
                "QUEUED" => GetDeploymentResponseVariant3Status.Queued,
                "READY" => GetDeploymentResponseVariant3Status.Ready,
                _ => null,
            };
        }
    }
}