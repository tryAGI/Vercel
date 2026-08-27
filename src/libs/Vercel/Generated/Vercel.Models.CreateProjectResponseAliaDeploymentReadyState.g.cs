
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateProjectResponseAliaDeploymentReadyState
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
    public static class CreateProjectResponseAliaDeploymentReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseAliaDeploymentReadyState value)
        {
            return value switch
            {
                CreateProjectResponseAliaDeploymentReadyState.Blocked => "BLOCKED",
                CreateProjectResponseAliaDeploymentReadyState.Building => "BUILDING",
                CreateProjectResponseAliaDeploymentReadyState.Canceled => "CANCELED",
                CreateProjectResponseAliaDeploymentReadyState.Error => "ERROR",
                CreateProjectResponseAliaDeploymentReadyState.Initializing => "INITIALIZING",
                CreateProjectResponseAliaDeploymentReadyState.Queued => "QUEUED",
                CreateProjectResponseAliaDeploymentReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseAliaDeploymentReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BLOCKED" => CreateProjectResponseAliaDeploymentReadyState.Blocked,
                "BUILDING" => CreateProjectResponseAliaDeploymentReadyState.Building,
                "CANCELED" => CreateProjectResponseAliaDeploymentReadyState.Canceled,
                "ERROR" => CreateProjectResponseAliaDeploymentReadyState.Error,
                "INITIALIZING" => CreateProjectResponseAliaDeploymentReadyState.Initializing,
                "QUEUED" => CreateProjectResponseAliaDeploymentReadyState.Queued,
                "READY" => CreateProjectResponseAliaDeploymentReadyState.Ready,
                _ => null,
            };
        }
    }
}