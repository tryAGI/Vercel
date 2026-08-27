
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectsResponseVariant1ItemTargetsChecksState
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
    public static class GetProjectsResponseVariant1ItemTargetsChecksStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemTargetsChecksState value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemTargetsChecksState.Completed => "completed",
                GetProjectsResponseVariant1ItemTargetsChecksState.Registered => "registered",
                GetProjectsResponseVariant1ItemTargetsChecksState.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemTargetsChecksState? ToEnum(string value)
        {
            return value switch
            {
                "completed" => GetProjectsResponseVariant1ItemTargetsChecksState.Completed,
                "registered" => GetProjectsResponseVariant1ItemTargetsChecksState.Registered,
                "running" => GetProjectsResponseVariant1ItemTargetsChecksState.Running,
                _ => null,
            };
        }
    }
}