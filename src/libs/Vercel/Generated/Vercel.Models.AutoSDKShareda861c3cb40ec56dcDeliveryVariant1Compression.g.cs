
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda861c3cb40ec56dcDeliveryVariant1Compression
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
    public static class AutoSDKShareda861c3cb40ec56dcDeliveryVariant1CompressionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda861c3cb40ec56dcDeliveryVariant1Compression value)
        {
            return value switch
            {
                AutoSDKShareda861c3cb40ec56dcDeliveryVariant1Compression.Gzip => "gzip",
                AutoSDKShareda861c3cb40ec56dcDeliveryVariant1Compression.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda861c3cb40ec56dcDeliveryVariant1Compression? ToEnum(string value)
        {
            return value switch
            {
                "gzip" => AutoSDKShareda861c3cb40ec56dcDeliveryVariant1Compression.Gzip,
                "none" => AutoSDKShareda861c3cb40ec56dcDeliveryVariant1Compression.None,
                _ => null,
            };
        }
    }
}