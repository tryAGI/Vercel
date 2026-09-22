
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared9c06dfe8dd59ad6dFilterV2Version
    {
        /// <summary>
        ///
        /// </summary>
        V2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared9c06dfe8dd59ad6dFilterV2VersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared9c06dfe8dd59ad6dFilterV2Version value)
        {
            return value switch
            {
                AutoSDKShared9c06dfe8dd59ad6dFilterV2Version.V2 => "v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared9c06dfe8dd59ad6dFilterV2Version? ToEnum(string value)
        {
            return value switch
            {
                "v2" => AutoSDKShared9c06dfe8dd59ad6dFilterV2Version.V2,
                _ => null,
            };
        }
    }
}