
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared9deb058651e8aec8Architecture
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
    public static class AutoSDKShared9deb058651e8aec8ArchitectureExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared9deb058651e8aec8Architecture value)
        {
            return value switch
            {
                AutoSDKShared9deb058651e8aec8Architecture.Arm64 => "arm64",
                AutoSDKShared9deb058651e8aec8Architecture.X8664 => "x86_64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared9deb058651e8aec8Architecture? ToEnum(string value)
        {
            return value switch
            {
                "arm64" => AutoSDKShared9deb058651e8aec8Architecture.Arm64,
                "x86_64" => AutoSDKShared9deb058651e8aec8Architecture.X8664,
                _ => null,
            };
        }
    }
}