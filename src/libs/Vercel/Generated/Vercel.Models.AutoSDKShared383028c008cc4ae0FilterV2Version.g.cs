
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared383028c008cc4ae0FilterV2Version
    {
        /// <summary>
        ///
        /// </summary>
        V2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared383028c008cc4ae0FilterV2VersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared383028c008cc4ae0FilterV2Version value)
        {
            return value switch
            {
                AutoSDKShared383028c008cc4ae0FilterV2Version.V2 => "v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared383028c008cc4ae0FilterV2Version? ToEnum(string value)
        {
            return value switch
            {
                "v2" => AutoSDKShared383028c008cc4ae0FilterV2Version.V2,
                _ => null,
            };
        }
    }
}