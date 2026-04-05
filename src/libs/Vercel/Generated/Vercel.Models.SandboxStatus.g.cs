
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The status of the sandbox.<br/>
    /// Example: running
    /// </summary>
    public enum SandboxStatus
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
    public static class SandboxStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxStatus value)
        {
            return value switch
            {
                SandboxStatus.Aborted => "aborted",
                SandboxStatus.Failed => "failed",
                SandboxStatus.Pending => "pending",
                SandboxStatus.Running => "running",
                SandboxStatus.Snapshotting => "snapshotting",
                SandboxStatus.Stopped => "stopped",
                SandboxStatus.Stopping => "stopping",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxStatus? ToEnum(string value)
        {
            return value switch
            {
                "aborted" => SandboxStatus.Aborted,
                "failed" => SandboxStatus.Failed,
                "pending" => SandboxStatus.Pending,
                "running" => SandboxStatus.Running,
                "snapshotting" => SandboxStatus.Snapshotting,
                "stopped" => SandboxStatus.Stopped,
                "stopping" => SandboxStatus.Stopping,
                _ => null,
            };
        }
    }
}