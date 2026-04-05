
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectTargetsChecksState
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Registered,
        /// <summary>
        /// 
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetMicrofrontendsInGroupResponseProjectTargetsChecksStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectTargetsChecksState value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectTargetsChecksState.Completed => "completed",
                GetMicrofrontendsInGroupResponseProjectTargetsChecksState.Registered => "registered",
                GetMicrofrontendsInGroupResponseProjectTargetsChecksState.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectTargetsChecksState? ToEnum(string value)
        {
            return value switch
            {
                "completed" => GetMicrofrontendsInGroupResponseProjectTargetsChecksState.Completed,
                "registered" => GetMicrofrontendsInGroupResponseProjectTargetsChecksState.Registered,
                "running" => GetMicrofrontendsInGroupResponseProjectTargetsChecksState.Running,
                _ => null,
            };
        }
    }
}