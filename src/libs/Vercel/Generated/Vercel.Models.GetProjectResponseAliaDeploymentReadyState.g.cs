
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectResponseAliaDeploymentReadyState
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
    public static class GetProjectResponseAliaDeploymentReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseAliaDeploymentReadyState value)
        {
            return value switch
            {
                GetProjectResponseAliaDeploymentReadyState.Blocked => "BLOCKED",
                GetProjectResponseAliaDeploymentReadyState.Building => "BUILDING",
                GetProjectResponseAliaDeploymentReadyState.Canceled => "CANCELED",
                GetProjectResponseAliaDeploymentReadyState.Error => "ERROR",
                GetProjectResponseAliaDeploymentReadyState.Initializing => "INITIALIZING",
                GetProjectResponseAliaDeploymentReadyState.Queued => "QUEUED",
                GetProjectResponseAliaDeploymentReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseAliaDeploymentReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BLOCKED" => GetProjectResponseAliaDeploymentReadyState.Blocked,
                "BUILDING" => GetProjectResponseAliaDeploymentReadyState.Building,
                "CANCELED" => GetProjectResponseAliaDeploymentReadyState.Canceled,
                "ERROR" => GetProjectResponseAliaDeploymentReadyState.Error,
                "INITIALIZING" => GetProjectResponseAliaDeploymentReadyState.Initializing,
                "QUEUED" => GetProjectResponseAliaDeploymentReadyState.Queued,
                "READY" => GetProjectResponseAliaDeploymentReadyState.Ready,
                _ => null,
            };
        }
    }
}