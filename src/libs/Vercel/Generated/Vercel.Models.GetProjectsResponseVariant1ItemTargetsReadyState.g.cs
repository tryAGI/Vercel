
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectsResponseVariant1ItemTargetsReadyState
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
    public static class GetProjectsResponseVariant1ItemTargetsReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemTargetsReadyState value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemTargetsReadyState.Blocked => "BLOCKED",
                GetProjectsResponseVariant1ItemTargetsReadyState.Building => "BUILDING",
                GetProjectsResponseVariant1ItemTargetsReadyState.Canceled => "CANCELED",
                GetProjectsResponseVariant1ItemTargetsReadyState.Error => "ERROR",
                GetProjectsResponseVariant1ItemTargetsReadyState.Initializing => "INITIALIZING",
                GetProjectsResponseVariant1ItemTargetsReadyState.Queued => "QUEUED",
                GetProjectsResponseVariant1ItemTargetsReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemTargetsReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BLOCKED" => GetProjectsResponseVariant1ItemTargetsReadyState.Blocked,
                "BUILDING" => GetProjectsResponseVariant1ItemTargetsReadyState.Building,
                "CANCELED" => GetProjectsResponseVariant1ItemTargetsReadyState.Canceled,
                "ERROR" => GetProjectsResponseVariant1ItemTargetsReadyState.Error,
                "INITIALIZING" => GetProjectsResponseVariant1ItemTargetsReadyState.Initializing,
                "QUEUED" => GetProjectsResponseVariant1ItemTargetsReadyState.Queued,
                "READY" => GetProjectsResponseVariant1ItemTargetsReadyState.Ready,
                _ => null,
            };
        }
    }
}