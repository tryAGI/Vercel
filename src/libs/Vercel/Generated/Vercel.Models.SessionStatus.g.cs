
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The status of the sandbox.<br/>
    /// Example: running
    /// </summary>
    public enum SessionStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Aborted,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Running,
        /// <summary>
        /// 
        /// </summary>
        Snapshotting,
        /// <summary>
        /// 
        /// </summary>
        Stopped,
        /// <summary>
        /// 
        /// </summary>
        Stopping,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionStatus value)
        {
            return value switch
            {
                SessionStatus.Aborted => "aborted",
                SessionStatus.Failed => "failed",
                SessionStatus.Pending => "pending",
                SessionStatus.Running => "running",
                SessionStatus.Snapshotting => "snapshotting",
                SessionStatus.Stopped => "stopped",
                SessionStatus.Stopping => "stopping",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionStatus? ToEnum(string value)
        {
            return value switch
            {
                "aborted" => SessionStatus.Aborted,
                "failed" => SessionStatus.Failed,
                "pending" => SessionStatus.Pending,
                "running" => SessionStatus.Running,
                "snapshotting" => SessionStatus.Snapshotting,
                "stopped" => SessionStatus.Stopped,
                "stopping" => SessionStatus.Stopping,
                _ => null,
            };
        }
    }
}