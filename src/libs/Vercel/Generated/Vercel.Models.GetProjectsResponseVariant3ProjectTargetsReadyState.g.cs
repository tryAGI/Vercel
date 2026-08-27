
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectTargetsReadyState
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
    public static class GetProjectsResponseVariant3ProjectTargetsReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectTargetsReadyState value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectTargetsReadyState.Blocked => "BLOCKED",
                GetProjectsResponseVariant3ProjectTargetsReadyState.Building => "BUILDING",
                GetProjectsResponseVariant3ProjectTargetsReadyState.Canceled => "CANCELED",
                GetProjectsResponseVariant3ProjectTargetsReadyState.Error => "ERROR",
                GetProjectsResponseVariant3ProjectTargetsReadyState.Initializing => "INITIALIZING",
                GetProjectsResponseVariant3ProjectTargetsReadyState.Queued => "QUEUED",
                GetProjectsResponseVariant3ProjectTargetsReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectTargetsReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BLOCKED" => GetProjectsResponseVariant3ProjectTargetsReadyState.Blocked,
                "BUILDING" => GetProjectsResponseVariant3ProjectTargetsReadyState.Building,
                "CANCELED" => GetProjectsResponseVariant3ProjectTargetsReadyState.Canceled,
                "ERROR" => GetProjectsResponseVariant3ProjectTargetsReadyState.Error,
                "INITIALIZING" => GetProjectsResponseVariant3ProjectTargetsReadyState.Initializing,
                "QUEUED" => GetProjectsResponseVariant3ProjectTargetsReadyState.Queued,
                "READY" => GetProjectsResponseVariant3ProjectTargetsReadyState.Ready,
                _ => null,
            };
        }
    }
}