
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectTargetsReadyState
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
    public static class GetProjectsResponseVariant2ProjectTargetsReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectTargetsReadyState value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectTargetsReadyState.Blocked => "BLOCKED",
                GetProjectsResponseVariant2ProjectTargetsReadyState.Building => "BUILDING",
                GetProjectsResponseVariant2ProjectTargetsReadyState.Canceled => "CANCELED",
                GetProjectsResponseVariant2ProjectTargetsReadyState.Error => "ERROR",
                GetProjectsResponseVariant2ProjectTargetsReadyState.Initializing => "INITIALIZING",
                GetProjectsResponseVariant2ProjectTargetsReadyState.Queued => "QUEUED",
                GetProjectsResponseVariant2ProjectTargetsReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectTargetsReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BLOCKED" => GetProjectsResponseVariant2ProjectTargetsReadyState.Blocked,
                "BUILDING" => GetProjectsResponseVariant2ProjectTargetsReadyState.Building,
                "CANCELED" => GetProjectsResponseVariant2ProjectTargetsReadyState.Canceled,
                "ERROR" => GetProjectsResponseVariant2ProjectTargetsReadyState.Error,
                "INITIALIZING" => GetProjectsResponseVariant2ProjectTargetsReadyState.Initializing,
                "QUEUED" => GetProjectsResponseVariant2ProjectTargetsReadyState.Queued,
                "READY" => GetProjectsResponseVariant2ProjectTargetsReadyState.Ready,
                _ => null,
            };
        }
    }
}