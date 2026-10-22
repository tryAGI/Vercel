
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6df91f8a45eab833FilterV2Version
    {
        /// <summary>
        ///
        /// </summary>
        V2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared6df91f8a45eab833FilterV2VersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6df91f8a45eab833FilterV2Version value)
        {
            return value switch
            {
                AutoSDKShared6df91f8a45eab833FilterV2Version.V2 => "v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6df91f8a45eab833FilterV2Version? ToEnum(string value)
        {
            return value switch
            {
                "v2" => AutoSDKShared6df91f8a45eab833FilterV2Version.V2,
                _ => null,
            };
        }
    }
}