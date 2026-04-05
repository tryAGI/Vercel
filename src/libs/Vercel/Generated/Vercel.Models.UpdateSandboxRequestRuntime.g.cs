
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The runtime environment for the sandbox. Determines the pre-installed language runtimes and tools available.<br/>
    /// Example: node24
    /// </summary>
    public enum UpdateSandboxRequestRuntime
    {
        /// <summary>
        /// 
        /// </summary>
        Node22,
        /// <summary>
        /// 
        /// </summary>
        Node24,
        /// <summary>
        /// 
        /// </summary>
        Python313,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateSandboxRequestRuntimeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateSandboxRequestRuntime value)
        {
            return value switch
            {
                UpdateSandboxRequestRuntime.Node22 => "node22",
                UpdateSandboxRequestRuntime.Node24 => "node24",
                UpdateSandboxRequestRuntime.Python313 => "python3.13",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateSandboxRequestRuntime? ToEnum(string value)
        {
            return value switch
            {
                "node22" => UpdateSandboxRequestRuntime.Node22,
                "node24" => UpdateSandboxRequestRuntime.Node24,
                "python3.13" => UpdateSandboxRequestRuntime.Python313,
                _ => null,
            };
        }
    }
}