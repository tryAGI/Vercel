
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectAliaDeploymentReadyState
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
    public static class GetProjectsResponseVariant3ProjectAliaDeploymentReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectAliaDeploymentReadyState value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectAliaDeploymentReadyState.Blocked => "BLOCKED",
                GetProjectsResponseVariant3ProjectAliaDeploymentReadyState.Building => "BUILDING",
                GetProjectsResponseVariant3ProjectAliaDeploymentReadyState.Canceled => "CANCELED",
                GetProjectsResponseVariant3ProjectAliaDeploymentReadyState.Error => "ERROR",
                GetProjectsResponseVariant3ProjectAliaDeploymentReadyState.Initializing => "INITIALIZING",
                GetProjectsResponseVariant3ProjectAliaDeploymentReadyState.Queued => "QUEUED",
                GetProjectsResponseVariant3ProjectAliaDeploymentReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectAliaDeploymentReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BLOCKED" => GetProjectsResponseVariant3ProjectAliaDeploymentReadyState.Blocked,
                "BUILDING" => GetProjectsResponseVariant3ProjectAliaDeploymentReadyState.Building,
                "CANCELED" => GetProjectsResponseVariant3ProjectAliaDeploymentReadyState.Canceled,
                "ERROR" => GetProjectsResponseVariant3ProjectAliaDeploymentReadyState.Error,
                "INITIALIZING" => GetProjectsResponseVariant3ProjectAliaDeploymentReadyState.Initializing,
                "QUEUED" => GetProjectsResponseVariant3ProjectAliaDeploymentReadyState.Queued,
                "READY" => GetProjectsResponseVariant3ProjectAliaDeploymentReadyState.Ready,
                _ => null,
            };
        }
    }
}