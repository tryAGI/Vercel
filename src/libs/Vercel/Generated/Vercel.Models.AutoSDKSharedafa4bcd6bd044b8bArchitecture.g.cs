
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedafa4bcd6bd044b8bArchitecture
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
    public static class AutoSDKSharedafa4bcd6bd044b8bArchitectureExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedafa4bcd6bd044b8bArchitecture value)
        {
            return value switch
            {
                AutoSDKSharedafa4bcd6bd044b8bArchitecture.Arm64 => "arm64",
                AutoSDKSharedafa4bcd6bd044b8bArchitecture.X8664 => "x86_64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedafa4bcd6bd044b8bArchitecture? ToEnum(string value)
        {
            return value switch
            {
                "arm64" => AutoSDKSharedafa4bcd6bd044b8bArchitecture.Arm64,
                "x86_64" => AutoSDKSharedafa4bcd6bd044b8bArchitecture.X8664,
                _ => null,
            };
        }
    }
}