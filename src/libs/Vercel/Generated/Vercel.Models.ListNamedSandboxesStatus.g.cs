
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Filter named sandboxes by status. Only valid when sortBy is createdAt.
    /// </summary>
    public enum ListNamedSandboxesStatus
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
    public static class ListNamedSandboxesStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListNamedSandboxesStatus value)
        {
            return value switch
            {
                ListNamedSandboxesStatus.Running => "running",
                ListNamedSandboxesStatus.Stopped => "stopped",
                ListNamedSandboxesStatus.Stopping => "stopping",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListNamedSandboxesStatus? ToEnum(string value)
        {
            return value switch
            {
                "running" => ListNamedSandboxesStatus.Running,
                "stopped" => ListNamedSandboxesStatus.Stopped,
                "stopping" => ListNamedSandboxesStatus.Stopping,
                _ => null,
            };
        }
    }
}