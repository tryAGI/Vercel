
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Why the sandbox stopped: `requested` for a stop requested through the API, `snapshot` for a stop to take a snapshot, `timeout` when the sandbox reached its timeout, `exited` when its main process exited on its own, and `error` when it failed or was stopped by the platform.<br/>
    /// Example: requested
    /// </summary>
    public enum SessionStopReason
    {
        /// <summary>
        /// `requested` for a stop requested through the API, `snapshot` for a stop to take a snapshot, `timeout` when the sandbox reached its timeout, `exited` when its main process exited on its own, and `error` when it failed or was stopped by the platform.
        /// </summary>
        Error,
        /// <summary>
        /// `requested` for a stop requested through the API, `snapshot` for a stop to take a snapshot, `timeout` when the sandbox reached its timeout, `exited` when its main process exited on its own, and `error` when it failed or was stopped by the platform.
        /// </summary>
        Exited,
        /// <summary>
        /// `requested` for a stop requested through the API, `snapshot` for a stop to take a snapshot, `timeout` when the sandbox reached its timeout, `exited` when its main process exited on its own, and `error` when it failed or was stopped by the platform.
        /// </summary>
        Requested,
        /// <summary>
        /// `requested` for a stop requested through the API, `snapshot` for a stop to take a snapshot, `timeout` when the sandbox reached its timeout, `exited` when its main process exited on its own, and `error` when it failed or was stopped by the platform.
        /// </summary>
        Snapshot,
        /// <summary>
        /// `requested` for a stop requested through the API, `snapshot` for a stop to take a snapshot, `timeout` when the sandbox reached its timeout, `exited` when its main process exited on its own, and `error` when it failed or was stopped by the platform.
        /// </summary>
        Timeout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionStopReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionStopReason value)
        {
            return value switch
            {
                SessionStopReason.Error => "error",
                SessionStopReason.Exited => "exited",
                SessionStopReason.Requested => "requested",
                SessionStopReason.Snapshot => "snapshot",
                SessionStopReason.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionStopReason? ToEnum(string value)
        {
            return value switch
            {
                "error" => SessionStopReason.Error,
                "exited" => SessionStopReason.Exited,
                "requested" => SessionStopReason.Requested,
                "snapshot" => SessionStopReason.Snapshot,
                "timeout" => SessionStopReason.Timeout,
                _ => null,
            };
        }
    }
}