
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedfa633702cac2aa68Variant1Compression
    {
        /// <summary>
        ///
        /// </summary>
        Gzip,
        /// <summary>
        ///
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedfa633702cac2aa68Variant1CompressionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfa633702cac2aa68Variant1Compression value)
        {
            return value switch
            {
                AutoSDKSharedfa633702cac2aa68Variant1Compression.Gzip => "gzip",
                AutoSDKSharedfa633702cac2aa68Variant1Compression.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfa633702cac2aa68Variant1Compression? ToEnum(string value)
        {
            return value switch
            {
                "gzip" => AutoSDKSharedfa633702cac2aa68Variant1Compression.Gzip,
                "none" => AutoSDKSharedfa633702cac2aa68Variant1Compression.None,
                _ => null,
            };
        }
    }
}