
#nullable enable

namespace Vercel
{
    /// <summary>
    /// CPU architecture. Inherits a snapshot or single image manifest when omitted. Image indexes default to amd64. Must match the source. ARM64 creation requires API v3 or v4 without runtime and team access.<br/>
    /// Example: arm64
    /// </summary>
    public enum CreateSandboxesV2RequestArchitecture
    {
        /// <summary>
        ///
        /// </summary>
        Amd64,
        /// <summary>
        ///
        /// </summary>
        Arm64,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSandboxesV2RequestArchitectureExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSandboxesV2RequestArchitecture value)
        {
            return value switch
            {
                CreateSandboxesV2RequestArchitecture.Amd64 => "amd64",
                CreateSandboxesV2RequestArchitecture.Arm64 => "arm64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSandboxesV2RequestArchitecture? ToEnum(string value)
        {
            return value switch
            {
                "amd64" => CreateSandboxesV2RequestArchitecture.Amd64,
                "arm64" => CreateSandboxesV2RequestArchitecture.Arm64,
                _ => null,
            };
        }
    }
}