
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared5f7d6053e0f466daArchitecture
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
    public static class AutoSDKShared5f7d6053e0f466daArchitectureExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared5f7d6053e0f466daArchitecture value)
        {
            return value switch
            {
                AutoSDKShared5f7d6053e0f466daArchitecture.Arm64 => "arm64",
                AutoSDKShared5f7d6053e0f466daArchitecture.X8664 => "x86_64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared5f7d6053e0f466daArchitecture? ToEnum(string value)
        {
            return value switch
            {
                "arm64" => AutoSDKShared5f7d6053e0f466daArchitecture.Arm64,
                "x86_64" => AutoSDKShared5f7d6053e0f466daArchitecture.X8664,
                _ => null,
            };
        }
    }
}