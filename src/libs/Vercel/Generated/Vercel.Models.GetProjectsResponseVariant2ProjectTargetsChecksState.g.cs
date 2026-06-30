
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectTargetsChecksState
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
    public static class GetProjectsResponseVariant2ProjectTargetsChecksStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectTargetsChecksState value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectTargetsChecksState.Completed => "completed",
                GetProjectsResponseVariant2ProjectTargetsChecksState.Registered => "registered",
                GetProjectsResponseVariant2ProjectTargetsChecksState.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectTargetsChecksState? ToEnum(string value)
        {
            return value switch
            {
                "completed" => GetProjectsResponseVariant2ProjectTargetsChecksState.Completed,
                "registered" => GetProjectsResponseVariant2ProjectTargetsChecksState.Registered,
                "running" => GetProjectsResponseVariant2ProjectTargetsChecksState.Running,
                _ => null,
            };
        }
    }
}