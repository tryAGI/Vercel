
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateProjectResponseTargetsReadyState
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
    public static class CreateProjectResponseTargetsReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseTargetsReadyState value)
        {
            return value switch
            {
                CreateProjectResponseTargetsReadyState.Blocked => "BLOCKED",
                CreateProjectResponseTargetsReadyState.Building => "BUILDING",
                CreateProjectResponseTargetsReadyState.Canceled => "CANCELED",
                CreateProjectResponseTargetsReadyState.Error => "ERROR",
                CreateProjectResponseTargetsReadyState.Initializing => "INITIALIZING",
                CreateProjectResponseTargetsReadyState.Queued => "QUEUED",
                CreateProjectResponseTargetsReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseTargetsReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BLOCKED" => CreateProjectResponseTargetsReadyState.Blocked,
                "BUILDING" => CreateProjectResponseTargetsReadyState.Building,
                "CANCELED" => CreateProjectResponseTargetsReadyState.Canceled,
                "ERROR" => CreateProjectResponseTargetsReadyState.Error,
                "INITIALIZING" => CreateProjectResponseTargetsReadyState.Initializing,
                "QUEUED" => CreateProjectResponseTargetsReadyState.Queued,
                "READY" => CreateProjectResponseTargetsReadyState.Ready,
                _ => null,
            };
        }
    }
}