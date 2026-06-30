
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseTargetsReadyState
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
    public static class UpdateMicrofrontendsResponseTargetsReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseTargetsReadyState value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseTargetsReadyState.Blocked => "BLOCKED",
                UpdateMicrofrontendsResponseTargetsReadyState.Building => "BUILDING",
                UpdateMicrofrontendsResponseTargetsReadyState.Canceled => "CANCELED",
                UpdateMicrofrontendsResponseTargetsReadyState.Error => "ERROR",
                UpdateMicrofrontendsResponseTargetsReadyState.Initializing => "INITIALIZING",
                UpdateMicrofrontendsResponseTargetsReadyState.Queued => "QUEUED",
                UpdateMicrofrontendsResponseTargetsReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseTargetsReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BLOCKED" => UpdateMicrofrontendsResponseTargetsReadyState.Blocked,
                "BUILDING" => UpdateMicrofrontendsResponseTargetsReadyState.Building,
                "CANCELED" => UpdateMicrofrontendsResponseTargetsReadyState.Canceled,
                "ERROR" => UpdateMicrofrontendsResponseTargetsReadyState.Error,
                "INITIALIZING" => UpdateMicrofrontendsResponseTargetsReadyState.Initializing,
                "QUEUED" => UpdateMicrofrontendsResponseTargetsReadyState.Queued,
                "READY" => UpdateMicrofrontendsResponseTargetsReadyState.Ready,
                _ => null,
            };
        }
    }
}