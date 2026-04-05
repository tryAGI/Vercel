
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectTargetsReadyState
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
    public static class GetMicrofrontendsInGroupResponseProjectTargetsReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectTargetsReadyState value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectTargetsReadyState.Building => "BUILDING",
                GetMicrofrontendsInGroupResponseProjectTargetsReadyState.Canceled => "CANCELED",
                GetMicrofrontendsInGroupResponseProjectTargetsReadyState.Error => "ERROR",
                GetMicrofrontendsInGroupResponseProjectTargetsReadyState.Initializing => "INITIALIZING",
                GetMicrofrontendsInGroupResponseProjectTargetsReadyState.Queued => "QUEUED",
                GetMicrofrontendsInGroupResponseProjectTargetsReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectTargetsReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BUILDING" => GetMicrofrontendsInGroupResponseProjectTargetsReadyState.Building,
                "CANCELED" => GetMicrofrontendsInGroupResponseProjectTargetsReadyState.Canceled,
                "ERROR" => GetMicrofrontendsInGroupResponseProjectTargetsReadyState.Error,
                "INITIALIZING" => GetMicrofrontendsInGroupResponseProjectTargetsReadyState.Initializing,
                "QUEUED" => GetMicrofrontendsInGroupResponseProjectTargetsReadyState.Queued,
                "READY" => GetMicrofrontendsInGroupResponseProjectTargetsReadyState.Ready,
                _ => null,
            };
        }
    }
}