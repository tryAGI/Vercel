
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseTargetsChecksState
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
    public static class GetProjectResponseTargetsChecksStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseTargetsChecksState value)
        {
            return value switch
            {
                GetProjectResponseTargetsChecksState.Completed => "completed",
                GetProjectResponseTargetsChecksState.Registered => "registered",
                GetProjectResponseTargetsChecksState.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseTargetsChecksState? ToEnum(string value)
        {
            return value switch
            {
                "completed" => GetProjectResponseTargetsChecksState.Completed,
                "registered" => GetProjectResponseTargetsChecksState.Registered,
                "running" => GetProjectResponseTargetsChecksState.Running,
                _ => null,
            };
        }
    }
}