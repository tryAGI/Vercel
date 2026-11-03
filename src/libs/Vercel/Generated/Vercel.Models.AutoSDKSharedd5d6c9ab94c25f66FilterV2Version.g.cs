
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedd5d6c9ab94c25f66FilterV2Version
    {
        /// <summary>
        ///
        /// </summary>
        V2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedd5d6c9ab94c25f66FilterV2VersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd5d6c9ab94c25f66FilterV2Version value)
        {
            return value switch
            {
                AutoSDKSharedd5d6c9ab94c25f66FilterV2Version.V2 => "v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd5d6c9ab94c25f66FilterV2Version? ToEnum(string value)
        {
            return value switch
            {
                "v2" => AutoSDKSharedd5d6c9ab94c25f66FilterV2Version.V2,
                _ => null,
            };
        }
    }
}