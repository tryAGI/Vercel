
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Filter named sandboxes by status. Only valid when sortBy is createdAt.
    /// </summary>
    public enum GetSandboxesStatus
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
    public static class GetSandboxesStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSandboxesStatus value)
        {
            return value switch
            {
                GetSandboxesStatus.Running => "running",
                GetSandboxesStatus.Stopped => "stopped",
                GetSandboxesStatus.Stopping => "stopping",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSandboxesStatus? ToEnum(string value)
        {
            return value switch
            {
                "running" => GetSandboxesStatus.Running,
                "stopped" => GetSandboxesStatus.Stopped,
                "stopping" => GetSandboxesStatus.Stopping,
                _ => null,
            };
        }
    }
}