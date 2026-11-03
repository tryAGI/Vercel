
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared56f06376e757011bDeliveryVariant4Compression
    {
        /// <summary>
        ///
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared56f06376e757011bDeliveryVariant4CompressionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared56f06376e757011bDeliveryVariant4Compression value)
        {
            return value switch
            {
                AutoSDKShared56f06376e757011bDeliveryVariant4Compression.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared56f06376e757011bDeliveryVariant4Compression? ToEnum(string value)
        {
            return value switch
            {
                "none" => AutoSDKShared56f06376e757011bDeliveryVariant4Compression.None,
                _ => null,
            };
        }
    }
}