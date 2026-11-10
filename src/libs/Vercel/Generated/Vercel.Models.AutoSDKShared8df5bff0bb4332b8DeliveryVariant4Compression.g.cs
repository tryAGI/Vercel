
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared8df5bff0bb4332b8DeliveryVariant4Compression
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
    public static class AutoSDKShared8df5bff0bb4332b8DeliveryVariant4CompressionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8df5bff0bb4332b8DeliveryVariant4Compression value)
        {
            return value switch
            {
                AutoSDKShared8df5bff0bb4332b8DeliveryVariant4Compression.Gzip => "gzip",
                AutoSDKShared8df5bff0bb4332b8DeliveryVariant4Compression.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8df5bff0bb4332b8DeliveryVariant4Compression? ToEnum(string value)
        {
            return value switch
            {
                "gzip" => AutoSDKShared8df5bff0bb4332b8DeliveryVariant4Compression.Gzip,
                "none" => AutoSDKShared8df5bff0bb4332b8DeliveryVariant4Compression.None,
                _ => null,
            };
        }
    }
}