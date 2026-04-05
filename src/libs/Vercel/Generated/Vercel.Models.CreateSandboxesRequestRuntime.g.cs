
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The runtime environment for the sandbox. Determines the pre-installed language runtimes and tools available.<br/>
    /// Default Value: node24<br/>
    /// Example: node24
    /// </summary>
    public enum CreateSandboxesRequestRuntime
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
    public static class CreateSandboxesRequestRuntimeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSandboxesRequestRuntime value)
        {
            return value switch
            {
                CreateSandboxesRequestRuntime.Node22 => "node22",
                CreateSandboxesRequestRuntime.Node24 => "node24",
                CreateSandboxesRequestRuntime.Python313 => "python3.13",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSandboxesRequestRuntime? ToEnum(string value)
        {
            return value switch
            {
                "node22" => CreateSandboxesRequestRuntime.Node22,
                "node24" => CreateSandboxesRequestRuntime.Node24,
                "python3.13" => CreateSandboxesRequestRuntime.Python313,
                _ => null,
            };
        }
    }
}