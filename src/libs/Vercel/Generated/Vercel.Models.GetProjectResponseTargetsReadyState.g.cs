
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseTargetsReadyState
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
    public static class GetProjectResponseTargetsReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseTargetsReadyState value)
        {
            return value switch
            {
                GetProjectResponseTargetsReadyState.Blocked => "BLOCKED",
                GetProjectResponseTargetsReadyState.Building => "BUILDING",
                GetProjectResponseTargetsReadyState.Canceled => "CANCELED",
                GetProjectResponseTargetsReadyState.Error => "ERROR",
                GetProjectResponseTargetsReadyState.Initializing => "INITIALIZING",
                GetProjectResponseTargetsReadyState.Queued => "QUEUED",
                GetProjectResponseTargetsReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseTargetsReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BLOCKED" => GetProjectResponseTargetsReadyState.Blocked,
                "BUILDING" => GetProjectResponseTargetsReadyState.Building,
                "CANCELED" => GetProjectResponseTargetsReadyState.Canceled,
                "ERROR" => GetProjectResponseTargetsReadyState.Error,
                "INITIALIZING" => GetProjectResponseTargetsReadyState.Initializing,
                "QUEUED" => GetProjectResponseTargetsReadyState.Queued,
                "READY" => GetProjectResponseTargetsReadyState.Ready,
                _ => null,
            };
        }
    }
}