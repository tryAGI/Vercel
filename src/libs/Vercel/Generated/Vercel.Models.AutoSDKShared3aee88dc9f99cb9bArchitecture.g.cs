
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared3aee88dc9f99cb9bArchitecture
    {
        /// <summary>
        ///
        /// </summary>
        Arm64,
        /// <summary>
        ///
        /// </summary>
        X8664,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared3aee88dc9f99cb9bArchitectureExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared3aee88dc9f99cb9bArchitecture value)
        {
            return value switch
            {
                AutoSDKShared3aee88dc9f99cb9bArchitecture.Arm64 => "arm64",
                AutoSDKShared3aee88dc9f99cb9bArchitecture.X8664 => "x86_64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared3aee88dc9f99cb9bArchitecture? ToEnum(string value)
        {
            return value switch
            {
                "arm64" => AutoSDKShared3aee88dc9f99cb9bArchitecture.Arm64,
                "x86_64" => AutoSDKShared3aee88dc9f99cb9bArchitecture.X8664,
                _ => null,
            };
        }
    }
}