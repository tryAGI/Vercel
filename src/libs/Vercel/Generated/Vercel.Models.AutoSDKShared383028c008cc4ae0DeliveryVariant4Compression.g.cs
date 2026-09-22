
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared383028c008cc4ae0DeliveryVariant4Compression
    {
        /// <summary>
        ///
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared383028c008cc4ae0DeliveryVariant4CompressionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared383028c008cc4ae0DeliveryVariant4Compression value)
        {
            return value switch
            {
                AutoSDKShared383028c008cc4ae0DeliveryVariant4Compression.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared383028c008cc4ae0DeliveryVariant4Compression? ToEnum(string value)
        {
            return value switch
            {
                "none" => AutoSDKShared383028c008cc4ae0DeliveryVariant4Compression.None,
                _ => null,
            };
        }
    }
}