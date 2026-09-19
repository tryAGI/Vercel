
#nullable enable

namespace Vercel
{
    /// <summary>
    /// CPU architecture of the sandbox. This value does not change.
    /// </summary>
    public enum NamedSandboxArchitecture
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
    public static class NamedSandboxArchitectureExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NamedSandboxArchitecture value)
        {
            return value switch
            {
                NamedSandboxArchitecture.Amd64 => "amd64",
                NamedSandboxArchitecture.Arm64 => "arm64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NamedSandboxArchitecture? ToEnum(string value)
        {
            return value switch
            {
                "amd64" => NamedSandboxArchitecture.Amd64,
                "arm64" => NamedSandboxArchitecture.Arm64,
                _ => null,
            };
        }
    }
}