
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectTargetsChecksState
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
    public static class GetProjectsResponseVariant3ProjectTargetsChecksStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectTargetsChecksState value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectTargetsChecksState.Completed => "completed",
                GetProjectsResponseVariant3ProjectTargetsChecksState.Registered => "registered",
                GetProjectsResponseVariant3ProjectTargetsChecksState.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectTargetsChecksState? ToEnum(string value)
        {
            return value switch
            {
                "completed" => GetProjectsResponseVariant3ProjectTargetsChecksState.Completed,
                "registered" => GetProjectsResponseVariant3ProjectTargetsChecksState.Registered,
                "running" => GetProjectsResponseVariant3ProjectTargetsChecksState.Running,
                _ => null,
            };
        }
    }
}