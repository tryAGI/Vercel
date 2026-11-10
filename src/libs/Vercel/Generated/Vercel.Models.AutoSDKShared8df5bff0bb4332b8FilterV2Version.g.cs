
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared8df5bff0bb4332b8FilterV2Version
    {
        /// <summary>
        ///
        /// </summary>
        V2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared8df5bff0bb4332b8FilterV2VersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8df5bff0bb4332b8FilterV2Version value)
        {
            return value switch
            {
                AutoSDKShared8df5bff0bb4332b8FilterV2Version.V2 => "v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8df5bff0bb4332b8FilterV2Version? ToEnum(string value)
        {
            return value switch
            {
                "v2" => AutoSDKShared8df5bff0bb4332b8FilterV2Version.V2,
                _ => null,
            };
        }
    }
}