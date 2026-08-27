
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The runtime environment for the sandbox. Determines the pre-installed language runtimes and tools available.<br/>
    /// Default Value: node24<br/>
    /// Example: node24
    /// </summary>
    public enum CreateSandboxesV2RequestRuntime
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
    public static class CreateSandboxesV2RequestRuntimeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSandboxesV2RequestRuntime value)
        {
            return value switch
            {
                CreateSandboxesV2RequestRuntime.Node22 => "node22",
                CreateSandboxesV2RequestRuntime.Node24 => "node24",
                CreateSandboxesV2RequestRuntime.Node26 => "node26",
                CreateSandboxesV2RequestRuntime.Python313 => "python3.13",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSandboxesV2RequestRuntime? ToEnum(string value)
        {
            return value switch
            {
                "node22" => CreateSandboxesV2RequestRuntime.Node22,
                "node24" => CreateSandboxesV2RequestRuntime.Node24,
                "node26" => CreateSandboxesV2RequestRuntime.Node26,
                "python3.13" => CreateSandboxesV2RequestRuntime.Python313,
                _ => null,
            };
        }
    }
}