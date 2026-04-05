
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The status of the current sandbox.<br/>
    /// Example: running
    /// </summary>
    public enum NamedSandboxStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Running,
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
    public static class NamedSandboxStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NamedSandboxStatus value)
        {
            return value switch
            {
                NamedSandboxStatus.Running => "running",
                NamedSandboxStatus.Stopped => "stopped",
                NamedSandboxStatus.Stopping => "stopping",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NamedSandboxStatus? ToEnum(string value)
        {
            return value switch
            {
                "running" => NamedSandboxStatus.Running,
                "stopped" => NamedSandboxStatus.Stopped,
                "stopping" => NamedSandboxStatus.Stopping,
                _ => null,
            };
        }
    }
}