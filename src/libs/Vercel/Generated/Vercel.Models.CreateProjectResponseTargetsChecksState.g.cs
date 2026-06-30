
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseTargetsChecksState
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
    public static class CreateProjectResponseTargetsChecksStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseTargetsChecksState value)
        {
            return value switch
            {
                CreateProjectResponseTargetsChecksState.Completed => "completed",
                CreateProjectResponseTargetsChecksState.Registered => "registered",
                CreateProjectResponseTargetsChecksState.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseTargetsChecksState? ToEnum(string value)
        {
            return value switch
            {
                "completed" => CreateProjectResponseTargetsChecksState.Completed,
                "registered" => CreateProjectResponseTargetsChecksState.Registered,
                "running" => CreateProjectResponseTargetsChecksState.Running,
                _ => null,
            };
        }
    }
}