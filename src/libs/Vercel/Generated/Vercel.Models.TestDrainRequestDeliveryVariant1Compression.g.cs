
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum TestDrainRequestDeliveryVariant1Compression
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
    public static class TestDrainRequestDeliveryVariant1CompressionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestDrainRequestDeliveryVariant1Compression value)
        {
            return value switch
            {
                TestDrainRequestDeliveryVariant1Compression.Gzip => "gzip",
                TestDrainRequestDeliveryVariant1Compression.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestDrainRequestDeliveryVariant1Compression? ToEnum(string value)
        {
            return value switch
            {
                "gzip" => TestDrainRequestDeliveryVariant1Compression.Gzip,
                "none" => TestDrainRequestDeliveryVariant1Compression.None,
                _ => null,
            };
        }
    }
}