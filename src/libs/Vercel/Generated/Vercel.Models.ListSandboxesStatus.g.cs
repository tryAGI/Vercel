
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Filter named sandboxes by status. Only valid when sortBy is createdAt.
    /// </summary>
    public enum ListSandboxesStatus
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
    public static class ListSandboxesStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListSandboxesStatus value)
        {
            return value switch
            {
                ListSandboxesStatus.Running => "running",
                ListSandboxesStatus.Stopped => "stopped",
                ListSandboxesStatus.Stopping => "stopping",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListSandboxesStatus? ToEnum(string value)
        {
            return value switch
            {
                "running" => ListSandboxesStatus.Running,
                "stopped" => ListSandboxesStatus.Stopped,
                "stopping" => ListSandboxesStatus.Stopping,
                _ => null,
            };
        }
    }
}