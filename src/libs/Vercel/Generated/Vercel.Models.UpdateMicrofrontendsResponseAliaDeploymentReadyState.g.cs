
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateMicrofrontendsResponseAliaDeploymentReadyState
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
    public static class UpdateMicrofrontendsResponseAliaDeploymentReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseAliaDeploymentReadyState value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseAliaDeploymentReadyState.Blocked => "BLOCKED",
                UpdateMicrofrontendsResponseAliaDeploymentReadyState.Building => "BUILDING",
                UpdateMicrofrontendsResponseAliaDeploymentReadyState.Canceled => "CANCELED",
                UpdateMicrofrontendsResponseAliaDeploymentReadyState.Error => "ERROR",
                UpdateMicrofrontendsResponseAliaDeploymentReadyState.Initializing => "INITIALIZING",
                UpdateMicrofrontendsResponseAliaDeploymentReadyState.Queued => "QUEUED",
                UpdateMicrofrontendsResponseAliaDeploymentReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseAliaDeploymentReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BLOCKED" => UpdateMicrofrontendsResponseAliaDeploymentReadyState.Blocked,
                "BUILDING" => UpdateMicrofrontendsResponseAliaDeploymentReadyState.Building,
                "CANCELED" => UpdateMicrofrontendsResponseAliaDeploymentReadyState.Canceled,
                "ERROR" => UpdateMicrofrontendsResponseAliaDeploymentReadyState.Error,
                "INITIALIZING" => UpdateMicrofrontendsResponseAliaDeploymentReadyState.Initializing,
                "QUEUED" => UpdateMicrofrontendsResponseAliaDeploymentReadyState.Queued,
                "READY" => UpdateMicrofrontendsResponseAliaDeploymentReadyState.Ready,
                _ => null,
            };
        }
    }
}