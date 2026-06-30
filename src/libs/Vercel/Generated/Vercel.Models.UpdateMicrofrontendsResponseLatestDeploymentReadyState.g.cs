
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseLatestDeploymentReadyState
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
    public static class UpdateMicrofrontendsResponseLatestDeploymentReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseLatestDeploymentReadyState value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseLatestDeploymentReadyState.Blocked => "BLOCKED",
                UpdateMicrofrontendsResponseLatestDeploymentReadyState.Building => "BUILDING",
                UpdateMicrofrontendsResponseLatestDeploymentReadyState.Canceled => "CANCELED",
                UpdateMicrofrontendsResponseLatestDeploymentReadyState.Error => "ERROR",
                UpdateMicrofrontendsResponseLatestDeploymentReadyState.Initializing => "INITIALIZING",
                UpdateMicrofrontendsResponseLatestDeploymentReadyState.Queued => "QUEUED",
                UpdateMicrofrontendsResponseLatestDeploymentReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseLatestDeploymentReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BLOCKED" => UpdateMicrofrontendsResponseLatestDeploymentReadyState.Blocked,
                "BUILDING" => UpdateMicrofrontendsResponseLatestDeploymentReadyState.Building,
                "CANCELED" => UpdateMicrofrontendsResponseLatestDeploymentReadyState.Canceled,
                "ERROR" => UpdateMicrofrontendsResponseLatestDeploymentReadyState.Error,
                "INITIALIZING" => UpdateMicrofrontendsResponseLatestDeploymentReadyState.Initializing,
                "QUEUED" => UpdateMicrofrontendsResponseLatestDeploymentReadyState.Queued,
                "READY" => UpdateMicrofrontendsResponseLatestDeploymentReadyState.Ready,
                _ => null,
            };
        }
    }
}