
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The runtime environment for the sandbox. Determines the pre-installed language runtimes and tools available.<br/>
    /// Example: node24
    /// </summary>
    public enum UpdateSandboxesByNameRequestRuntime
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
        Node26,
        /// <summary>
        /// 
        /// </summary>
        Python313,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateSandboxesByNameRequestRuntimeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateSandboxesByNameRequestRuntime value)
        {
            return value switch
            {
                UpdateSandboxesByNameRequestRuntime.Node22 => "node22",
                UpdateSandboxesByNameRequestRuntime.Node24 => "node24",
                UpdateSandboxesByNameRequestRuntime.Node26 => "node26",
                UpdateSandboxesByNameRequestRuntime.Python313 => "python3.13",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateSandboxesByNameRequestRuntime? ToEnum(string value)
        {
            return value switch
            {
                "node22" => UpdateSandboxesByNameRequestRuntime.Node22,
                "node24" => UpdateSandboxesByNameRequestRuntime.Node24,
                "node26" => UpdateSandboxesByNameRequestRuntime.Node26,
                "python3.13" => UpdateSandboxesByNameRequestRuntime.Python313,
                _ => null,
            };
        }
    }
}