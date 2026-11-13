
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0001bb8e789a120eFilterV2Version
    {
        /// <summary>
        ///
        /// </summary>
        V2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared0001bb8e789a120eFilterV2VersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0001bb8e789a120eFilterV2Version value)
        {
            return value switch
            {
                AutoSDKShared0001bb8e789a120eFilterV2Version.V2 => "v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0001bb8e789a120eFilterV2Version? ToEnum(string value)
        {
            return value switch
            {
                "v2" => AutoSDKShared0001bb8e789a120eFilterV2Version.V2,
                _ => null,
            };
        }
    }
}