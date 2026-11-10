
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda861c3cb40ec56dcDeliveryVariant4Compression
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
    public static class AutoSDKShareda861c3cb40ec56dcDeliveryVariant4CompressionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda861c3cb40ec56dcDeliveryVariant4Compression value)
        {
            return value switch
            {
                AutoSDKShareda861c3cb40ec56dcDeliveryVariant4Compression.Gzip => "gzip",
                AutoSDKShareda861c3cb40ec56dcDeliveryVariant4Compression.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda861c3cb40ec56dcDeliveryVariant4Compression? ToEnum(string value)
        {
            return value switch
            {
                "gzip" => AutoSDKShareda861c3cb40ec56dcDeliveryVariant4Compression.Gzip,
                "none" => AutoSDKShareda861c3cb40ec56dcDeliveryVariant4Compression.None,
                _ => null,
            };
        }
    }
}