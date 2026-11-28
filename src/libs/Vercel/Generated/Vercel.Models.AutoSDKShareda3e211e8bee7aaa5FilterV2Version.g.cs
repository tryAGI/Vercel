
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda3e211e8bee7aaa5FilterV2Version
    {
        /// <summary>
        ///
        /// </summary>
        V2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShareda3e211e8bee7aaa5FilterV2VersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda3e211e8bee7aaa5FilterV2Version value)
        {
            return value switch
            {
                AutoSDKShareda3e211e8bee7aaa5FilterV2Version.V2 => "v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda3e211e8bee7aaa5FilterV2Version? ToEnum(string value)
        {
            return value switch
            {
                "v2" => AutoSDKShareda3e211e8bee7aaa5FilterV2Version.V2,
                _ => null,
            };
        }
    }
}