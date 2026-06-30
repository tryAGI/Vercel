
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseTargetsReadyState
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
    public static class UpdateProjectResponseTargetsReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseTargetsReadyState value)
        {
            return value switch
            {
                UpdateProjectResponseTargetsReadyState.Blocked => "BLOCKED",
                UpdateProjectResponseTargetsReadyState.Building => "BUILDING",
                UpdateProjectResponseTargetsReadyState.Canceled => "CANCELED",
                UpdateProjectResponseTargetsReadyState.Error => "ERROR",
                UpdateProjectResponseTargetsReadyState.Initializing => "INITIALIZING",
                UpdateProjectResponseTargetsReadyState.Queued => "QUEUED",
                UpdateProjectResponseTargetsReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseTargetsReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BLOCKED" => UpdateProjectResponseTargetsReadyState.Blocked,
                "BUILDING" => UpdateProjectResponseTargetsReadyState.Building,
                "CANCELED" => UpdateProjectResponseTargetsReadyState.Canceled,
                "ERROR" => UpdateProjectResponseTargetsReadyState.Error,
                "INITIALIZING" => UpdateProjectResponseTargetsReadyState.Initializing,
                "QUEUED" => UpdateProjectResponseTargetsReadyState.Queued,
                "READY" => UpdateProjectResponseTargetsReadyState.Ready,
                _ => null,
            };
        }
    }
}