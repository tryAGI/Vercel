
#nullable enable

namespace Vercel
{
    /// <summary>
    /// CPU architecture of the sandbox.
    /// </summary>
    public enum SessionArchitecture
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
    public static class SessionArchitectureExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionArchitecture value)
        {
            return value switch
            {
                SessionArchitecture.Amd64 => "amd64",
                SessionArchitecture.Arm64 => "arm64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionArchitecture? ToEnum(string value)
        {
            return value switch
            {
                "amd64" => SessionArchitecture.Amd64,
                "arm64" => SessionArchitecture.Arm64,
                _ => null,
            };
        }
    }
}