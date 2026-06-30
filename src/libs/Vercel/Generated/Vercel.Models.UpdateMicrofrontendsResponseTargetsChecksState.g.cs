
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseTargetsChecksState
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
    public static class UpdateMicrofrontendsResponseTargetsChecksStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseTargetsChecksState value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseTargetsChecksState.Completed => "completed",
                UpdateMicrofrontendsResponseTargetsChecksState.Registered => "registered",
                UpdateMicrofrontendsResponseTargetsChecksState.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseTargetsChecksState? ToEnum(string value)
        {
            return value switch
            {
                "completed" => UpdateMicrofrontendsResponseTargetsChecksState.Completed,
                "registered" => UpdateMicrofrontendsResponseTargetsChecksState.Registered,
                "running" => UpdateMicrofrontendsResponseTargetsChecksState.Running,
                _ => null,
            };
        }
    }
}